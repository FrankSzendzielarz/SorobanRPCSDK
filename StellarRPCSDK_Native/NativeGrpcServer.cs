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

namespace Stellar.RPC.Native
{
    public static class NativeGrpcServer
    {
        private static WebApplication? _app;
        private static Thread? _serverThread;

        // C entry point to start the server

        [UnmanagedCallersOnly(EntryPoint = "StartServer")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public static void StartServer()
        {
            _serverThread = new Thread(() =>
            {
                var builder = WebApplication.CreateBuilder();
                builder.Services.AddGrpc();

                // Platform-specific IPC configuration
#if WINDOWS
                // Windows: Named pipes via HttpSys

                builder.WebHost.UseHttpSys(options =>
                {
                    options.UrlPrefixes.Add("http://pipe:/MyServicePipe");
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

                _app = builder.Build();
                _app.MapGrpcService<TestService>();
                _app.Run();
            });

            _serverThread.IsBackground = true;
            _serverThread.Start();
        }

        // Example gRPC service
        private class TestService : MyService.MyServiceBase
        {
            public override Task<AddResponse> AddNumbers(AddRequest request, ServerCallContext context)
                => Task.FromResult(new AddResponse { Result = request.A + request.B });
        }
    }
}
