﻿using Microsoft.AspNetCore.Builder;
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
            try
            {
                _serverThread = new Thread(() =>
                {
                    var builder = WebApplication.CreateBuilder(new WebApplicationOptions
                    {
                        ApplicationName = "StellarRPCSDK_Native",  // Explicit name
                        EnvironmentName = "Production"  // Explicit environment
                    });

                    builder.Logging.SetMinimumLevel(LogLevel.Debug);
                    builder.Logging.AddConsole();
                    //DI for the Stellar Service
                    builder.Services.AddHttpClient<StellarRPCClient>(client =>
                    {
                        client.BaseAddress = new Uri(Network.Url);
                    });
                    // Add gRPC service. Should be fully AOT compat according to MS docs.
                    builder.Services.AddGrpc(options =>
                    {
                        options.EnableDetailedErrors = true;
                    });

                    builder.Services.AddSingleton<StellarRPCClient>();
                    builder.Services.AddSingleton<MuxedAccount_ProtoWrapper>();
                    builder.Services.AddSingleton<Transaction_ProtoWrapper>();
                    builder.Services.AddSingleton<Network_ProtoWrapper>();
                    builder.Services.AddSingleton<SimulateTransactionResult_ProtoWrapper>();
                    builder.Services.AddSingleton<XdrProtoService>();

                    // Platform-specific IPC configuration
#if WINDOWS
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
                    //_app.MapGrpcService<StellarRPCClient>();
                    //_app.MapGrpcService<MuxedAccount_ProtoWrapper>();
                    //_app.MapGrpcService<Transaction_ProtoWrapper>();
                    //_app.MapGrpcService<Network_ProtoWrapper>();
                    //_app.MapGrpcService<SimulateTransactionResult_ProtoWrapper>();
                    //_app.MapGrpcService<XdrProtoService>();

                    _app.Lifetime.ApplicationStarted.Register(() => { Console.WriteLine("Stellar SDK ready"); _serverReady.Set(); });
                    _app.Run();



                });

                _serverThread.IsBackground = true;
                _serverThread.Start();

                Console.WriteLine("Waiting for Stellar SDK");
                _serverReady.Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Server startup failed: {ex.Message}");
                _serverReady.Set(); // Prevent calling thread from waiting indefinitely
            }
        }

        

        [UnmanagedCallersOnly(EntryPoint = "StopServer")]
        public static void StopServer()
        {
            _app?.StopAsync().GetAwaiter().GetResult();
            _app?.Lifetime.StopApplication();
            _serverReady.Reset();
        }
        [UnmanagedCallersOnly(EntryPoint = "CleanupServer")]
        public static void CleanupServer()
        {
            _serverReady.Dispose();
            _app = null;
            _serverThread = null;
        }

    }

   
}
