using ProtoBuf.Grpc.Configuration;
using ProtoBuf.Grpc.Server;
using Stellar.RPC;
using System.ServiceModel;

namespace StellarNativeGRPCServerTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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


        

          

            app.Run();
        }
    }
}
