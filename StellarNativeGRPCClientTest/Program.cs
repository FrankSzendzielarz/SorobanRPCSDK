using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc.Client;
using Stellar;
using Stellar.RPC;
using System.Dynamic;
using System.Reflection;
using static Grpc.Core.Interceptors.Interceptor;

namespace StellarNativeGRPCClientTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7133");
                

            channel.Intercept(new ClientLoggingInterceptor());



            // Channel may be to proxy server or may be an in-process channel to the SDK, which
            // is a binary available on all platforms for library loading directly into the process:
            var network_client = channel.CreateGrpcService<INetwork_ProtoWrapper>();
            var stellar_client = channel.CreateGrpcService<IStellarRPCClient>();
            var muxed_client = channel.CreateGrpcService<IMuxedAccount_ProtoWrapper>();
            var xdr_client = channel.CreateGrpcService<IXdrProtoService>();

            network_client.UseTestNetwork();
            network_client.SetUrl(new Network_ProtoWrapper.SetUrlParam() { Url = "https://soroban-testnet.stellar.org" });
            
            // Get Stellar RPC server health using Protobuf gRPC
            var health= await stellar_client.GetHealthAsync();
            Console.WriteLine($"{health.Status}");

            // Generate Muxed Account using Protobuf [in-process] SDK
            MuxedAccount.KeyTypeEd25519 account = 
                muxed_client.FromAccountId(
                    new StringWrapper() 
                    { 
                        Value = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T" 
                    } 
            );

            // Obtain a Public Key using the MuxedAccount interface with Protobuf gRPC
            var pk = muxed_client.GetPublicKey(account);
            
            // Local object construction - Protobuf .proto file will be made public
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

            // protobuf gRPC [in-process] SDK exposes interface allowing XDR [de]serialisation of all Stellar objects
            // These are code generated as part of the build process and require no manual maintenance:
            var ledgerKeyEncodedResponse = xdr_client.EncodeLedgerKey(new LedgerKeyEncodeRequest() {  Value = myAccount });
            
            // gRPC [in-process] SDK call to ask RPC server for ledger entries for an account
            var ledgerEntries = await stellar_client.GetLedgerEntriesAsync(new GetLedgerEntriesParams()
            {
                 Keys = new List<string>() { ledgerKeyEncodedResponse.EncodedValue}
            });
            var test = ledgerEntries.Entries.First().LedgerEntryData as LedgerEntry.dataUnion.Account;
            Console.WriteLine($"Account balance: {test.account.balance.InnerValue}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }

    public class ClientLoggingInterceptor : Interceptor
    {
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var call = continuation(request, context);
            var responseTask = new AsyncUnaryCall<TResponse>(
                HandleResponse(call.ResponseAsync),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose);
            return responseTask;
        }

        private async Task<TResponse> HandleResponse<TResponse>(Task<TResponse> responseTask)
        {
            var response = await responseTask;
            LogMessage("Client Received", response);
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
                        Console.WriteLine(
                            $"{type} {prop.Name} Length: {bytes.Length}, Bytes: {BitConverter.ToString(bytes)}");
                    }
                }
            }
        }
    }

}
