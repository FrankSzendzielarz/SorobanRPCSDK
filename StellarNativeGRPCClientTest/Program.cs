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
            var muxed_client = channel.CreateGrpcService<IMuxedAccount_ProtoWrapper>();
      

            network_client.UseTestNetwork();
            network_client.SetUrl(new Network_ProtoWrapper.SetUrlParam() { Url = "https://soroban-testnet.stellar.org" });
            var health= await stellar_client.GetHealthAsync();
            MuxedAccount.KeyTypeEd25519 account = 
                muxed_client.FromAccountId(
                    new MuxedAccount_ProtoWrapper.StringParam() 
                    { 
                        Value = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T" 
                    } 
            );
            var pk = muxed_client.GetPublicKey(account);
            
            LedgerKey myAccount = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = new AccountID()
                    {
                        InnerValue = new PublicKey.PublicKeyTypeEd25519()
                        {
                            ed25519 = new uint256()
                            {
                                InnerValue = pk.Value
                            }
                        }
                    }
                }
            };

            //TODO - AND NOW we need every object to be serialisable.

            var ledgerEntries = stellar_client.GetLedgerEntriesAsync(new GetLedgerEntriesParams()
            {
                 Keys = new List<string>() {  }
            });

            Console.WriteLine($"{health.Status}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }

  
}
