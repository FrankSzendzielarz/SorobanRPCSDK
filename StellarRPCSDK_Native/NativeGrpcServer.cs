using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using ProtoBuf.Grpc.Server;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Stellar.RPC.Native
{
    public static class NativeGrpcServer
    {

        private static WebApplication? _app;
        private static Thread? _serverThread;
        private static readonly ManualResetEventSlim _serverReady = new ManualResetEventSlim(false);

        // C entry point to start the server

        [UnmanagedCallersOnly(EntryPoint = "StartServer")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public static void StartServer()
        {
            _serverThread = new Thread(() =>
            {
                var builder = WebApplication.CreateBuilder(new WebApplicationOptions
                {
                    ApplicationName = "StellarRPCSDK_Native",  // Explicit name
                    EnvironmentName = "Production"  // Explicit environment
                });

                //builder.Logging.SetMinimumLevel(LogLevel.Trace); 
                //builder.Logging.AddConsole(options =>
                //{
                //    options.FormatterName = "Simple";
                //});

                builder.Services.AddGrpc(options =>
                {
                    options.EnableDetailedErrors = true;
                });

                // Platform-specific IPC configuration
#if WINDOWS
                // Windows: Named pipes via HttpSys


                builder.WebHost.ConfigureKestrel(options =>
                {
                    options.ListenNamedPipe("MyServicePipe", listenOptions =>
                    {
                        listenOptions.Protocols = HttpProtocols.Http2;
                    });
                });


#else

                // Linux/macOS: Unix domain sockets
                builder.WebHost.ConfigureKestrel(options =>
                {
                    options.ListenUnixSocket("/tmp/MyService.sock", listenOptions =>
                    {
                        listenOptions.Protocols = HttpProtocols.Http2;
                    });
                });
#endif

                builder.Services.AddCodeFirstGrpc();
                _app = builder.Build();
                _app.MapGrpcService<StellarRPCClient>();
                _app.MapGrpcService<MuxedAccount_ProtoWrapper>();
                _app.MapGrpcService<Transaction_ProtoWrapper>();
                _app.MapGrpcService<Network_ProtoWrapper>();
                _app.MapGrpcService<SimulateTransactionResult_ProtoWrapper>();
                _app.MapGrpcService<XdrProtoService>();

                _app.Lifetime.ApplicationStarted.Register(() => { Console.WriteLine("Stellar SDK ready"); _serverReady.Set(); });
                _app.Run();
            });

            _serverThread.IsBackground = true;
            _serverThread.Start();

            Console.WriteLine("Waiting for Stellar SDK");
            _serverReady.Wait();

        }


    }
}
