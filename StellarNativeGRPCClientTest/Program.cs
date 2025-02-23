using Grpc.Core;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using Stellar;
using Stellar.RPC;
using System.Dynamic;
using System.Reflection;

namespace StellarNativeGRPCClientTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7133");


            var network_client = channel.CreateGrpcService<INetwork_ProtoWrapper>();
            var stellar_client = channel.CreateGrpcService<IStellarRPCClient>();
      

            network_client.UseTestNetwork();
            network_client.SetUrl(new Network_ProtoWrapper.SetUrlParam() { Url = "https://soroban-testnet.stellar.org" });
            var health= await stellar_client.GetHealthAsync();

            Console.WriteLine($"{health.Status}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }

  
}
