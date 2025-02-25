using Grpc.Core.Interceptors;
using Grpc.Core;
using ProtoBuf.Grpc.Configuration;
using ProtoBuf.Grpc.Server;
using Stellar;
using Stellar.RPC;
using System.ServiceModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;
using System.Text.Json;

namespace StellarNativeGRPCServerTest
{
  
    public class Program
    { 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
       

            // Configure Kestrel to use HTTPS
            builder.WebHost.ConfigureKestrel(serverOptions =>
            {
                serverOptions.ListenAnyIP(5001, listenOptions =>
                {
                    listenOptions.UseHttps();
                });
            });

            builder.Services.AddLogging(logging =>
            {
                logging.AddConsole();
            });
            builder.Services.AddHttpClient<StellarRPCClient>(client =>
            {
                client.BaseAddress = new Uri(Network.Url);
             
            });

            var dummy = typeof(StellarRPCClient);
            Debugger.Launch();
            builder.Services.AddCodeFirstGrpc(options =>
            {
                options.Interceptors.Add<MessageLoggingInterceptor>();
            });

            // var binder = ServiceBinder.Default;
            //var serviceTypes = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(a => a.GetTypes()) 
            //    .Where(t => binder.IsServiceContract(t, out var name));
            //foreach (var contractType in serviceTypes)
            //{
            //    Console.WriteLine($"Found service contract: {contractType.Name}");

            //    // We can also check the operations
            //    var methods = contractType.GetMethods();
            //    foreach (var method in methods)
            //    {
            //        if (binder.IsOperationContract(method, out var operationName))
            //        {
            //            Console.WriteLine($" - Operation: {operationName}");
            //        }
            //    }
            //}

            var app = builder.Build();
             
            app.MapGrpcService<StellarRPCClient>();
            app.MapGrpcService<MuxedAccount_ProtoWrapper>();
            app.MapGrpcService<Transaction_ProtoWrapper>();
            app.MapGrpcService<Network_ProtoWrapper>();
            app.MapGrpcService<SimulateTransactionResult_ProtoWrapper>();
            app.MapGrpcService<XdrProtoService>();

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");


              

            app.Run();
        }
    }

    public class MessageLoggingInterceptor : Interceptor
    {
        private readonly ILogger<MessageLoggingInterceptor> _logger;

        public MessageLoggingInterceptor(ILogger<MessageLoggingInterceptor> logger)
        {
            _logger = logger;
        }

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
            TRequest request,
            ServerCallContext context,
            UnaryServerMethod<TRequest, TResponse> continuation)
        {
            // Log request
            LogMessage("Request", request);

            var response = await continuation(request, context);

            // Log response
            LogMessage("Response", response);

            return response;
        }

        private void LogMessage<T>(string type, T message)
        {
            if (message == null) return;

            var properties = message.GetType().GetProperties();
            foreach (var prop in properties)
            {
                if (prop.PropertyType == typeof(byte[]))
                {
                    var bytes = prop.GetValue(message) as byte[];
                    if (bytes != null)
                    {
                        _logger.LogInformation(
                            "{Type} {PropertyName} Length: {Length}, Bytes: {Bytes}",
                            type,
                            prop.Name,
                            bytes.Length,
                            BitConverter.ToString(bytes)
                        );
                    }
                }
            }
        }
    }
}
