using Stellar;
using Stellar.RPC;
using Stellar.XDR;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace SDKTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            /****************************************
             *                                      *
             *        XDR Serialisation Tests       *
             *                                      * 
             ****************************************/
            StreamWriter writer = new StreamWriter("xdr.txt");
            try
            {
                Console.SetOut(writer);
                var runner = new XdrTestRunner();
                await runner.RunAllTests();
            }
            finally
            {
                Console.SetOut(Console.Out);
                writer.Close();
            }

            /****************************************
             *                                      *
             *        Soroban RPC Use Cases         *
             *                                      * 
             ****************************************/

            // Initialise a connection to the RPC Client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            StellarRPCClient sorobanClient = new StellarRPCClient(httpClient);

            // Use a test account that has already been pre-funded
            KeyPair keyPair = KeyPair.FromAccountId("GA3RQ7FWMT6INHS2R4KEKWENPYQOPLRNPYDAJFFRY5AUSD2GP6VG3OPY");
            PublicKey.PublicKeyTypeEd25519 testAccountPubKey = new PublicKey.PublicKeyTypeEd25519()
            {
                ed25519 = keyPair.PublicKey
            };
            AccountID testAccountId = testAccountPubKey;

            // Use cases
            await ServerHealthCheckUseCase(sorobanClient);
            await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);

        }

        private static async Task GetAccountLedgerEntryUseCase(StellarRPCClient sorobanClient, AccountID testAccountId)
        {
            LedgerKey myAccount = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = testAccountId
                }
            };
            var encodedAccount = LedgerKeyXdr.EncodeToBase64(myAccount);
            var accountLedgerEntriesArgument = new GetLedgerEntriesParams()
            {
                Keys = [encodedAccount]
            };
            var ledgerEntriesAccount = await sorobanClient.GetLedgerEntriesAsync(accountLedgerEntriesArgument);
            var test = ledgerEntriesAccount.Entries.First().LedgerEntryData as LedgerEntry.dataUnion.Account;
        }

        private static async Task ServerHealthCheckUseCase(StellarRPCClient sorobanClient)
        {
            var healthResult = await sorobanClient.GetHealthAsync();
            Assert.MustBe(healthResult != null,"HealthResult was null.");
        }
    }

    public static class Assert
    {
        public static void MustBe(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException($"Assertion failed: {message}");
            }
        }
    }

}
