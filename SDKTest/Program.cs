using Stellar;
using Stellar.RPC;
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
            MuxedAccount.KeyTypeEd25519 testAccount = MuxedAccount.FromSecretSeed("SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
            AccountID testAccountId = new AccountID(testAccount.XdrPublicKey);

            // Use cases
            var lastLedger = await ServerHealthCheckUseCase(sorobanClient);
            AccountEntry accountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            await GetEventsAboutAContractUseCase(sorobanClient, lastLedger);
            await GetFeeStatsUseCase(sorobanClient);
            await GetLatestLedgerUseCase(sorobanClient, lastLedger);
            await GetNetworkUseCase(sorobanClient);
            await GetTransactions(sorobanClient, lastLedger);
            await GetServerVersionInfo(sorobanClient);

            //For transaction processing we need to set the Network
            Network.UseTestNetwork();



            // Get a recipient account (pre funded test account)
            MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
            AccountID recipientAccountId = recipientAccount.XdrPublicKey;
            
            // Increment the sender's sequence number
            int64 currentSequenceNumber = accountEntry.seqNum;
            currentSequenceNumber++;

            // Create a payment transaction from testAccountId to recipientAccountId
            Transaction payment = new Transaction()
            {
                sourceAccount = testAccount,
                fee = 100,
                memo = new Memo.MemoNone(),
                seqNum = new SequenceNumber(currentSequenceNumber),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations =
                        [
                            new Operation()
                            {
                                sourceAccount=testAccount,
                                body = new Operation.bodyUnion.Payment()
                                {
                                    paymentOp = new PaymentOp()
                                    {
                                        amount= 17,
                                        destination = recipientAccount,
                                        asset = new Asset.AssetTypeNative()
                                    }
                                }
                            }
                        ]
            };
            // Sign it with the sender account
            var signature = payment.Sign(testAccount);

            // Wrap it an envelope to send to Stellar
            TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = payment,
                    signatures = [signature]
                }
            };

            SendTransactionResult result = await sorobanClient.SendTransactionAsync(new SendTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
            });


            // Simulate a Soroban transaction


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
            Assert.MustBe(feeStats != null, "Feestats failed to retrieve.");
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

        private static async Task<AccountEntry> GetAccountLedgerEntryUseCase(StellarRPCClient sorobanClient, AccountID testAccountId)
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
            return test.account;
        }

        private static async Task<long> ServerHealthCheckUseCase(StellarRPCClient sorobanClient)
        {
            var healthResult = await sorobanClient.GetHealthAsync();
            Assert.MustBe(healthResult != null, "HealthResult was null.");
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
