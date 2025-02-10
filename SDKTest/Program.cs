using Stellar;
using Stellar.RPC;
using Stellar.XDR;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text.Json;

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
                // Tests round trip serialisation for all XDR objects.
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
            PublicKey.PublicKeyTypeEd25519 testAccountPubKey = keyPair.XdrPublicKey;
            AccountID testAccountId = testAccountPubKey;

            // Use cases
            var lastLedger = await ServerHealthCheckUseCase(sorobanClient);
            await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            await GetEventsAboutAContractUseCase(sorobanClient, lastLedger);
            await GetFeeStatsUseCase(sorobanClient);
            await GetLatestLedgerUseCase(sorobanClient, lastLedger);
            await GetNetworkUseCase(sorobanClient);
            await GetTransactions(sorobanClient, lastLedger);
            await GetServerVersionInfo(sorobanClient);

            // Simulate a transaction.

            // Make a payment from A to B, get transaction using hash
            
            // Get a recipient account (pre funded test account)
            KeyPair recepientKeyPair = KeyPair.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
            PublicKey.PublicKeyTypeEd25519 recipientPubKey = new PublicKey.PublicKeyTypeEd25519()
            {
                ed25519 = keyPair.PublicKey
            };
            AccountID recipientAccountId = testAccountPubKey;
            // Create a payment transaction from testAccountId to recipientAccountId



            // Deploy a contract, compile a contract

            // Execute a contract,
            // add utility for Authorising the Operation (signing)
            // add utility for Assemble Transaction - does the modification of the footprint etc


        }

        private static async Task GetServerVersionInfo(StellarRPCClient sorobanClient)
        {
            var versionInfoResult = await sorobanClient.GetVersionInfoAsync();
            Assert.MustBe(versionInfoResult != null && versionInfoResult.Protocol_version > 21, "Get version info failed");
        }

        private static async Task GetTransactions(StellarRPCClient sorobanClient, long lastLedger)
        {
            GetTransactionsParams getTransactionsArguments = new GetTransactionsParams()
            {
                StartLedger = lastLedger - 100
            };

            var getTransactionsResult = await sorobanClient.GetTransactionsAsync(getTransactionsArguments);
            Assert.MustBe(getTransactionsResult != null && getTransactionsResult.Transactions.Count > 0, "Get transactions failed.");
        }

        private static async Task GetNetworkUseCase(StellarRPCClient sorobanClient)
        {
            var getNetworkResult = await sorobanClient.GetNetworkAsync();
            Assert.MustBe(getNetworkResult?.Passphrase == "Test SDF Network ; September 2015", "Get network result failed.");
        }

        private static async Task GetLatestLedgerUseCase(StellarRPCClient sorobanClient, long lastLedger)
        {
            var latestLedgerResult = await sorobanClient.GetLatestLedgerAsync();
            Assert.MustBe(latestLedgerResult != null && lastLedger <= latestLedgerResult.Sequence, "Latest ledger failed.");
        }

        private static async Task GetFeeStatsUseCase(StellarRPCClient sorobanClient)
        {
            //Example taken from stellar-rpc-openrpc.json
            var feeStats = await sorobanClient.GetFeeStatsAsync();
            Assert.MustBe(feeStats != null,"Feestats failed to retrieve.");
        }

        private static async Task GetEventsAboutAContractUseCase(StellarRPCClient sorobanClient, long lastLedger)
        {
            //Example taken from stellar-rpc-openrpc.json
            string exampleJson = @$"{{
                  ""startLedger"": {lastLedger - 10000},
                  ""filters"": [
                    {{
                      ""type"": ""contract"",
                      ""contractIds"": [
                        ""CDLZFC3SYJYDZT7K67VZ75HPJVIEUVNIXF47ZG2FB2RMQQVU2HHGCYSC""
                      ],
                      ""topics"": [
                        [
                          ""AAAADwAAAAh0cmFuc2Zlcg=="",
                          ""*"",
                          ""*"",
                          ""*""
                        ]
                      ]
                    }}
                  ],
                  ""pagination"": {{
                    ""limit"": 2
                  }}
                }}";
            GetEventsParams getEventsParams = JsonSerializer.Deserialize<GetEventsParams>(exampleJson);
            var getEventsResult = await sorobanClient.GetEventsAsync(getEventsParams);
            Assert.MustBe(getEventsResult != null, "Get events failed.");
        }

        private static async Task<long> GetAccountLedgerEntryUseCase(StellarRPCClient sorobanClient, AccountID testAccountId)
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
            Assert.MustBe(test != null && test.account.balance > 0, "Account data retrieval failed.");
            return test.account.balance;
        }

        private static async Task<long> ServerHealthCheckUseCase(StellarRPCClient sorobanClient)
        {
            var healthResult = await sorobanClient.GetHealthAsync();
            Assert.MustBe(healthResult != null,"HealthResult was null.");
            return healthResult.LatestLedger;
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
