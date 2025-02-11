using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
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

            // Create a recipient test account for a payment transaction that has already been pre-funded
            MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
            AccountID recipientAccountId = recipientAccount.XdrPublicKey;

            // Use cases
            var lastLedger = await ServerHealthCheckUseCase(sorobanClient);
            AccountEntry accountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            AccountEntry accountEntryRecipient = await GetAccountLedgerEntryUseCase(sorobanClient, recipientAccountId);
            await GetEventsAboutAContractUseCase(sorobanClient, lastLedger);
            await GetFeeStatsUseCase(sorobanClient);
            await GetLatestLedgerUseCase(sorobanClient, lastLedger);
            await GetNetworkUseCase(sorobanClient);
            await GetTransactions(sorobanClient, lastLedger);
            await GetServerVersionInfo(sorobanClient);
            SendTransactionResult result = await SignAndSendAPaymentTransactionUseCase(sorobanClient, testAccount, recipientAccount, accountEntry);
            await GetTransactionAndWaitForStatusUseCase(sorobanClient, result);
            await VerifyBalanceChangeUseCase(sorobanClient, testAccountId, recipientAccountId, accountEntry, accountEntryRecipient);

            string demoContractId = "CARVNC27XT7FUE6EGISSPYAUIY6X4TJPZLDZDMMBHRMUDBL7VHT45UZT";


            
            long val1 = 33;
            long val2 = 11;
            long expected = 3;

            
            AccountEntry newAccountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);

            // Create a soroban contract invocation

            Operation divideTwoNumberInvocation = new Operation()
            {
                sourceAccount = testAccount,
                body = new Operation.bodyUnion.InvokeHostFunction()
                {
                    invokeHostFunctionOp = new InvokeHostFunctionOp()
                    {
                        auth = [], //no authorisation needed in this scenario
                        hostFunction = new HostFunction.HostFunctionTypeInvokeContract()
                        {
                            invokeContract = new InvokeContractArgs()
                            {
                                contractAddress = new SCAddress.ScAddressTypeContract()
                                {
                                    contractId = new Hash(StrKey.DecodeContractId(demoContractId))
                                },
                                functionName = new SCSymbol("divide_two_numbers"),
                                args =
                                [
                                    new SCVal.ScvI64(){  i64=val1 }  ,
                                    new SCVal.ScvI64(){  i64=val2 }
                                ]
                            }
                        }
                    }
                }
            };

            Transaction invokeContractTransaction = new Transaction()
            {
                sourceAccount = testAccount,
                fee = 100,
                memo = new Memo.MemoNone(),
                seqNum = newAccountEntry.seqNum.Increment(),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations =
                [
                    divideTwoNumberInvocation
                ]
            };

            // Simulate a Soroban contract invocation
            TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = invokeContractTransaction,
                    signatures = []
                }
            };
            var simulationResult = await sorobanClient.SimulateTransactionAsync(new SimulateTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
            });

            // Execute a contract

            // Execute a contract demonstrating the auth required on a passed in account by signing the operation from 
            // 2nd account.

            // add utility for Authorising the Operation (signing)
            // add utility for Assemble Transaction - does the modification of the footprint etc


        }

        private static async Task VerifyBalanceChangeUseCase(StellarRPCClient sorobanClient, AccountID testAccountId, AccountID recipientAccountId, AccountEntry accountEntry, AccountEntry accountEntryRecipient)
        {
            AccountEntry accountEntryNew = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            AccountEntry accountEntryRecipientNew = await GetAccountLedgerEntryUseCase(sorobanClient, recipientAccountId);
            Assert.MustBe(accountEntry.balance - accountEntryNew.balance == 100 + 17, "Balance reduction is incorrect");
            Assert.MustBe(accountEntryRecipientNew.balance - accountEntryRecipient.balance == 17, "Balance increase is incorrect");
        }

        private static async Task GetTransactionAndWaitForStatusUseCase(StellarRPCClient sorobanClient, SendTransactionResult result)
        {
            bool complete = false;
            int attempts = 10;
            while (!complete)
            {
                var completion = await sorobanClient.GetTransactionAsync(new GetTransactionParams()
                {
                    Hash = result.Hash
                });
                switch (completion.Status)
                {
                    case GetTransactionResultStatus.NOT_FOUND:
                        attempts--;
                        Assert.MustBe(attempts >= 0, "Could not find transaction.");
                        await Task.Delay(500);
                        break;
                    case GetTransactionResultStatus.FAILED:
                        Assert.MustBe(false, "Transaction failed");
                        break;
                    case GetTransactionResultStatus.SUCCESS:
                        complete = true;
                        break;
                }
            }
        }

        private static async Task<SendTransactionResult> SignAndSendAPaymentTransactionUseCase(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 testAccount, MuxedAccount.KeyTypeEd25519 recipientAccount,  AccountEntry accountEntry)
        {
            //For transaction processing we need to set the Network
            Network.UseTestNetwork();

          

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
            Assert.MustBe(result.Status == SendTransactionResultStatus.PENDING,$"Transaction failed {result?.ErrorResult?.result}");
            return result;
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
