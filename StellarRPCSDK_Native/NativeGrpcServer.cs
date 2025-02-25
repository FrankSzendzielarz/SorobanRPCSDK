using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc.Server;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

                //builder.Logging.SetMinimumLevel(LogLevel.Debug);
                //builder.Logging.ClearProviders(); // Clear default providers
                //builder.Logging.AddConsole();
                //// Add a custom logger to capture logs
                //var logCollector = new LogCollector();
                //builder.Logging.AddProvider(logCollector);

                // Create a queue to store logs
                var logQueue = new ConcurrentQueue<string>();

                // Register the custom logger provider
                builder.Logging.ClearProviders();
                builder.Logging.AddConsole();
                builder.Logging.AddProvider(new InMemoryLoggerProvider(logQueue));
                builder.Logging.SetMinimumLevel(LogLevel.Debug);

                builder.Services.AddHttpClient<StellarRPCClient>(client =>
                {
                    client.BaseAddress = new Uri(Network.Url);

                });

                builder.Services.AddCodeFirstGrpc(options =>
                {
                    options.EnableDetailedErrors = true;
                });


                // Platform-specific IPC configuration
#if WINDOWS
                // Windows: Named pipes via HttpSys

                foreach (var log in logQueue)
                {
                    Console.WriteLine(log);
                }
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

       
                _app = builder.Build();
                _app.MapGrpcService<StellarRPCClient>();
                _app.MapGrpcService<MuxedAccount_ProtoWrapper>();
                _app.MapGrpcService<Transaction_ProtoWrapper>();
                _app.MapGrpcService<Network_ProtoWrapper>();
                _app.MapGrpcService<SimulateTransactionResult_ProtoWrapper>();
                _app.MapGrpcService<XdrProtoService>();

                _app.Lifetime.ApplicationStarted.Register(() => { Console.WriteLine("Stellar SDK ready"); _serverReady.Set(); });
                _app.Run();
                foreach (var log in logQueue)
                {
                    Console.WriteLine(log);
                }


            });

            _serverThread.IsBackground = true;
            _serverThread.Start();

            Console.WriteLine("Waiting for Stellar SDK");
            _serverReady.Wait();

        }


    }

    public class InMemoryLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly ConcurrentQueue<string> _logs;

        public InMemoryLogger(string categoryName, ConcurrentQueue<string> logs)
        {
            _categoryName = categoryName;
            _logs = logs;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var message = $"[{logLevel}] {_categoryName}: {formatter(state, exception)}";
            if (exception != null)
            {
                message += $"\nException: {exception}";
            }
            _logs.Enqueue(message);
        }
    }

    public class InMemoryLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentQueue<string> _logs;

        public InMemoryLoggerProvider(ConcurrentQueue<string> logs)
        {
            _logs = logs;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new InMemoryLogger(categoryName, _logs);
        }

        public void Dispose() { }
    }
}
