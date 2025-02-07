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
            var lastLedger = await ServerHealthCheckUseCase(sorobanClient);
            await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            await GetEventsAboutAContractUseCase(sorobanClient, lastLedger);
            await GetFeeStatsUseCase(sorobanClient);
            await GetLatestLedgerUseCase(sorobanClient, lastLedger);
            await GetNetworkUseCase(sorobanClient);

            GetTransactionsParams getTransactionsArguments = new GetTransactionsParams()
            {
                StartLedger = lastLedger - 100
            };

            var getTransactionsResult = await sorobanClient.GetTransactionsAsync(getTransactionsArguments);


            //TODO BUG WITH TRANSACTION ENVELOPE XDR
            // AAAAAgAAAABraisBXNgRPYfB16c3fe+AGAH6D/XrJTZJy4wMfKBEYAAehIAAACHFAAShuQAAAAEAAAAAAAAAAAAAAABnphUxAAAAAQAAAAhwc3BiOjY4MQAAAAIAAAABAAAAAIqW61Q3kZPdQ6gTYFSQ20kTCiKkY6KcEWxC1eCkhkzFAAAAAQAAAADjfej7Kt6ZZTe3zxwql+kdH4kwVHjgkfOYEaeLqGoIRgAAAAJBVFVTRAAAAAAAAAAAAAAAZ8rWY3iaDnWNtfpvLpNaCEbKdDjrd2gQODOuKpmj1vMAAAAAADh1IAAAAAEAAAAAipbrVDeRk91DqBNgVJDbSRMKIqRjopwRbELV4KSGTMUAAAABAAAAAON96Psq3pllN7fPHCqX6R0fiTBUeOCR85gRp4uoaghGAAAAAkFUVUFIAAAAAAAAAAAAAABnytZjeJoOdY21+m8uk1oIRsp0OOt3aBA4M64qmaPW8wAAAAAGjneAAAAAAAAAAAJ8oERgAAAAQBQJ7q0nrYaKsdlvkepxVpbrpwmX3/UJL6cHdEfQjeUcaPtDQ7xCUvRK8ISdjwnRmd8IMXqV2Svo6/5BJXKJCQSkhkzFAAAAQHY0/ecQ3GKRFVHAMeLINaRAUKVc8pAC7j96YRL/7dVspq2WNbzlU88Mm5tpAo4QwrQV29q0zgkiqk2oeyXrZwM=
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
