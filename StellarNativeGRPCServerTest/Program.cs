using ProtoBuf.Grpc.Configuration;
using ProtoBuf.Grpc.Server;
using Stellar;
using Stellar.RPC;
using System.ServiceModel;

namespace StellarNativeGRPCServerTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHttpClient<StellarRPCClient>(client =>
            {
                client.BaseAddress = new Uri(Network.Url);
             
            });

            var dummy = typeof(StellarRPCClient);
            builder.Services.AddCodeFirstGrpc();

            var binder = ServiceBinder.Default;
            var serviceTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => binder.IsServiceContract(t, out var name));

            foreach (var contractType in serviceTypes)
            {
                Console.WriteLine($"Found service contract: {contractType.Name}");

                // We can also check the operations
                var methods = contractType.GetMethods();
                foreach (var method in methods)
                {
                    if (binder.IsOperationContract(method, out var operationName))
                    {
                        Console.WriteLine($" - Operation: {operationName}");
                    }
                }
            }

            var app = builder.Build();

            app.MapGrpcService<StellarRPCClient>();
            app.MapGrpcService<MuxedAccount_ProtoWrapper>();
            app.MapGrpcService<Transaction_ProtoWrapper>();
            app.MapGrpcService<Network_ProtoWrapper>();
            app.MapGrpcService<SimulateTransactionResult_ProtoWrapper>();

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");





            app.Run();
        }
    }
}
