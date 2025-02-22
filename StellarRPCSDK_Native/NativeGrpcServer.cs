using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.HttpSys; // Windows only
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using NativeTests;
using System;
using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc.Server;

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
                builder.Services.AddScoped<TestService>();
                builder.Services.AddCodeFirstGrpc();
                _app = builder.Build();
                _app.MapGrpcService<TestService>();

         

                _app.Lifetime.ApplicationStarted.Register(() => { Console.WriteLine("Stellar SDK ready"); _serverReady.Set(); });
                _app.Run();
            });

            _serverThread.IsBackground = true;
            _serverThread.Start();

            Console.WriteLine("Waiting for Stellar SDK");
            _serverReady.Wait();
     
        }

        // Example gRPC service
        private class TestService : MyService.MyServiceBase
        {
            private readonly ILogger<TestService> _logger;

            public TestService(ILogger<TestService> logger)
            {
                _logger = logger;
            }
            public override Task<AddResponse> AddNumbers(AddRequest request, ServerCallContext context)
            {
                _logger.LogInformation("AddNumbers called with A: {A}, B: {B}", request.A, request.B);

                try
                {
                    var result = request.A + request.B;
                    _logger.LogInformation("AddNumbers result: {Result}", result);
                    return Task.FromResult(new AddResponse { Result = result });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in AddNumbers");
                    throw;
                }
            }
        }
    }
}
