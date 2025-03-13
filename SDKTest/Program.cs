using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System.Security.Cryptography;
using System.Text.Json;

namespace SDKTest
{
    internal class Program
    {
        static Transaction invokeContractTransaction;
        static SimulateTransactionResult simulationResult;
        static async Task Main(string[] args)
        {

            /****************************************
             *                                      *
             *        XDR Serialisation Tests       *
             *                                      * 
             ****************************************/
            TextWriter originalConsole = Console.Out;
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
                writer.Close();
                Console.SetOut(originalConsole);

            }

            /****************************************
             *                                      *
             *        Soroban RPC Use Cases         *
             *                                      * 
             ****************************************/
            string demoContractId = "CARVNC27XT7FUE6EGISSPYAUIY6X4TJPZLDZDMMBHRMUDBL7VHT45UZT"; // See SorobanExample project in the solution
            string nestedStructContractId = "CDO5UFNRHPMCLFN6NXFPMS22HTQFZQACUZP6S25QUTFIGDFP4HLD3YVN";
            string sorobanAuthContractId = "CALYAREJBDZNQCWDDUL26O6WKQFUUDOOQPP7SKXKHM6REXEBLCX6ZFLK";

            // Initialise a connection to the RPC Client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(httpClient);


            StellarRPCClient sorobanClient = new StellarRPCClient(httpClientFactory);  // USE HTTPCLIENT DIRECTLY ON PREVIOUS SDK VERSION. CURRENTLY IN DEV.

            // Use a test account that has already been pre-funded
            MuxedAccount.KeyTypeEd25519 testAccount = MuxedAccount.FromSecretSeed("SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
            AccountID testAccountId = new AccountID(testAccount.XdrPublicKey);

            // Create a recipient test account for a payment transaction that has already been pre-funded
            MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromSecretSeed("SATD6DG6F25FZX2GIQU74GZVECOKXRYSM74ACULTR7NGSEJI7ILDBW6H");
            AccountID recipientAccountId = recipientAccount.XdrPublicKey;

            // Use cases
            var lastLedger = await ServerHealthCheckUseCase(sorobanClient);
            AccountEntry accountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            await CreateAndSimulateNestedStructSorobanInvocationUseCase(sorobanClient, testAccount, accountEntry, nestedStructContractId);
            AccountEntry accountEntryRecipient = await GetAccountLedgerEntryUseCase(sorobanClient, recipientAccountId);
            await GetEventsAboutAContractUseCase(sorobanClient, lastLedger);
            await GetFeeStatsUseCase(sorobanClient);
            await GetLatestLedgerUseCase(sorobanClient, lastLedger);
            await GetNetworkUseCase(sorobanClient);
            await GetTransactions(sorobanClient, lastLedger);
            await GetServerVersionInfo(sorobanClient);
            accountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            SendTransactionResult result = await SignAndSendAPaymentTransactionUseCase(sorobanClient, testAccount, recipientAccount, accountEntry);
            await GetTransactionAndWaitForStatusUseCase(sorobanClient, result);
            await VerifyBalanceChangeUseCase(sorobanClient, testAccountId, recipientAccountId, accountEntry, accountEntryRecipient);
            Network.UseTestNetwork();
            AccountEntry newAccountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            long val1 = 33;
            long val2 = 11;
            await CreateAndSimulateSorobanInvocationUseCase(sorobanClient, testAccount, newAccountEntry, demoContractId, val1, val2);
            GetTransactionResult finalResult = await AssembleSorobanInvocationAndExecuteUseCase(sorobanClient, testAccount, invokeContractTransaction, simulationResult);
            AccessSorobanInvocationResultUseCase(val1, val2, finalResult);

            await CreateAndSimulateSorobanAuthInvocationUseCase(sorobanClient, testAccount, newAccountEntry, recipientAccount, testAccount, sorobanAuthContractId);
            GetTransactionResult finalResultWithAuth = await AssembleSorobanInvocationAndExecuteUseCaseWithAuthorisation(sorobanClient, testAccount, recipientAccount, invokeContractTransaction, simulationResult);
            
            
         


        }

        private static void AccessSorobanInvocationResultUseCase(long val1, long val2, GetTransactionResult finalResult)
        {
            long divisionResult = ((finalResult.TransactionResultMeta as TransactionMeta.case_3).v3.sorobanMeta.returnValue as SCVal.ScvI64).i64;
            Console.WriteLine($"Soroban says that {val1} divided by {val2} is {divisionResult}");
        }

     

        private static async Task<GetTransactionResult> AssembleSorobanInvocationAndExecuteUseCaseWithAuthorisation(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 testAccount, MuxedAccount.KeyTypeEd25519 authorisingAccount, Transaction invokeContractTransaction, SimulateTransactionResult simulationResult)
        {
            //Get authorisations to sign and then sign them
            List<HashIDPreimage.EnvelopeTypeSorobanAuthorization> authorisationsToSign = simulationResult.GetAuthorisationsRequired();
            if (authorisationsToSign!=null && authorisationsToSign.Count==1) //test scenario expects one authorisation from the payer
            {
                byte[] payloadToSign = Util.Hash(Convert.FromBase64String(HashIDPreimageXdr.EncodeToBase64(authorisationsToSign[0])));
                byte[] sorobanAuthSig = authorisingAccount.Sign(payloadToSign);
                simulationResult.AddAuthorisationSignature(0,authorisingAccount.PublicKey,sorobanAuthSig);
            }
         
            //Apply the simulation results to the transaction
            Transaction assembledTransaction = simulationResult.ApplyTo(invokeContractTransaction);

            //Sign and send
            var signature = assembledTransaction.Sign(testAccount);
            TransactionEnvelope sendEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = assembledTransaction,
                    signatures = [signature]
                }
            };
            SendTransactionResult res = await sorobanClient.SendTransactionAsync(new SendTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(sendEnvelope)
            });

            var finalResult = await GetTransactionAndWaitForStatusUseCase(sorobanClient, res);
            return finalResult;
        }


        private static async Task<GetTransactionResult> AssembleSorobanInvocationAndExecuteUseCase(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 testAccount, Transaction invokeContractTransaction, SimulateTransactionResult simulationResult)
        {
            Transaction assembledTransaction = simulationResult.ApplyTo(invokeContractTransaction);
            var signature = assembledTransaction.Sign(testAccount);
            TransactionEnvelope sendEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = assembledTransaction,
                    signatures = [signature]
                }
            };
            SendTransactionResult res = await sorobanClient.SendTransactionAsync(new SendTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(sendEnvelope)
            });

            var finalResult = await GetTransactionAndWaitForStatusUseCase(sorobanClient, res);
            return finalResult;
        }

        private static async Task CreateAndSimulateNestedStructSorobanInvocationUseCase(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 testAccount, AccountEntry newAccountEntry, string demoContractId)
        {
            // First, create the nested FlatTestReq struct as an SCMap
            var flatTestReqMap = new SCVal.ScvMap()
            {
                map = new SCMap(new SCMapEntry[]
                {
                    new SCMapEntry()
                    {
                        key = new SCVal.ScvSymbol() { sym = new SCSymbol("number") },
                        val = new SCVal.ScvU32() { u32 = 42 }  // Example value
                    },
                    new SCMapEntry()
                    {
                        key = new SCVal.ScvSymbol() { sym = new SCSymbol("word") },
                        val = new SCVal.ScvString() { str = new SCString("hello") }  // Example value
                    }
                })
            };

            // Then, create the parent NestedTestReq struct as an SCMap
            var nestedTestReqMap = new SCVal.ScvMap()
            {
                map = new SCMap(new SCMapEntry[]
                {
                   /*
                    *  MUST BE IN ALPHA ORDER
                    */
                    new SCMapEntry()
                    {
                        key = new SCVal.ScvSymbol() { sym = new SCSymbol("flat") },
                        val = flatTestReqMap  // Using the nested struct we created above
                    },
                      new SCMapEntry()
                    {
                        key = new SCVal.ScvSymbol() { sym = new SCSymbol("numba") },
                        val = new SCVal.ScvU32() { u32 = 100 }  // Example value
                    },
                    new SCMapEntry()
                    {
                        key = new SCVal.ScvSymbol() { sym = new SCSymbol("word") },
                        val = new SCVal.ScvString() { str = new SCString("world") }  // Example value
                    },

                })
            };

            // Create a soroban contract invocation
            Operation nestedParamTestInvocation = new Operation()
            {
                sourceAccount = testAccount,
                body = new Operation.bodyUnion.InvokeHostFunction()
                {
                    invokeHostFunctionOp = new InvokeHostFunctionOp()
                    {
                        auth = [], // No authorization needed
                        hostFunction = new HostFunction.HostFunctionTypeInvokeContract()
                        {
                            invokeContract = new InvokeContractArgs()
                            {
                                contractAddress = new SCAddress.ScAddressTypeContract()
                                {
                                    contractId = new Hash(StrKey.DecodeContractId(demoContractId))
                                },
                                functionName = new SCSymbol("nested_param_test"),
                                args = [nestedTestReqMap]  // Pass the constructed map as the argument
                            }
                        }
                    }
                }
            };

            invokeContractTransaction = new Transaction()
            {
                sourceAccount = testAccount,
                fee = 100,
                memo = new Memo.MemoNone(),
                seqNum = newAccountEntry.seqNum.Increment(),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations =
                [
                    nestedParamTestInvocation
                ]
            };

            // Simulate a Soroban contract invocation
            TransactionEnvelope simulateEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = invokeContractTransaction,
                    signatures = []
                }
            };
            simulationResult = await sorobanClient.SimulateTransactionAsync(new SimulateTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(simulateEnvelope)
            });
        }


        private static async Task CreateAndSimulateSorobanAuthInvocationUseCase(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 sourceAccount, AccountEntry sourceAccountEntry, MuxedAccount.KeyTypeEd25519 payerAccount, MuxedAccount.KeyTypeEd25519 recipientAccount, string contractId)
        {
            // Create a soroban contract invocation
            Operation payOperation = new Operation()
            {
                sourceAccount = sourceAccount,
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
                                    contractId = new Hash(StrKey.DecodeContractId(contractId))
                                },
                                functionName = new SCSymbol("pay"),
                                args =
                                [
                                    new SCVal.ScvAddress()
                                    {
                                        address= new SCAddress.ScAddressTypeAccount()
                                        {
                                            accountId = new AccountID(payerAccount.XdrPublicKey)
                                        }
                                    },
                                     new SCVal.ScvAddress()
                                    {
                                        address= new SCAddress.ScAddressTypeAccount()
                                        {
                                            accountId = new AccountID(recipientAccount.XdrPublicKey)
                                        }
                                    },
                                    new SCVal.ScvI128(){   i128= new Int128Parts(){ lo=100,hi=0 } }
                                ]
                            }
                        }
                    }
                }
            };

            invokeContractTransaction = new Transaction()
            {
                sourceAccount = sourceAccount,
                fee = 100,
                memo = new Memo.MemoNone(),
                seqNum = sourceAccountEntry.seqNum.Increment(),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations =
                [
                    payOperation
                ]
            };

            // Simulate a Soroban contract invocation
            TransactionEnvelope simulateEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = invokeContractTransaction,
                    signatures = []
                }
            };
            simulationResult = await sorobanClient.SimulateTransactionAsync(new SimulateTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(simulateEnvelope)
            });
        }

        private static async Task CreateAndSimulateSorobanInvocationUseCase(StellarRPCClient sorobanClient, MuxedAccount.KeyTypeEd25519 testAccount, AccountEntry newAccountEntry, string demoContractId, long val1, long val2)
        {
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

            invokeContractTransaction = new Transaction()
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
            TransactionEnvelope simulateEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = invokeContractTransaction,
                    signatures = []
                }
            };
            simulationResult = await sorobanClient.SimulateTransactionAsync(new SimulateTransactionParams()
            {
                Transaction = TransactionEnvelopeXdr.EncodeToBase64(simulateEnvelope)
            });
        }

        private static async Task VerifyBalanceChangeUseCase(StellarRPCClient sorobanClient, AccountID testAccountId, AccountID recipientAccountId, AccountEntry accountEntry, AccountEntry accountEntryRecipient)
        {
            AccountEntry accountEntryNew = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            AccountEntry accountEntryRecipientNew = await GetAccountLedgerEntryUseCase(sorobanClient, recipientAccountId);
            Assert.MustBe(accountEntry.balance - accountEntryNew.balance == 100 + 17, "Balance reduction is incorrect");
            Assert.MustBe(accountEntryRecipientNew.balance - accountEntryRecipient.balance == 17, "Balance increase is incorrect");
        }

        private static async Task<GetTransactionResult> GetTransactionAndWaitForStatusUseCase(StellarRPCClient sorobanClient, SendTransactionResult result)
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
                    case GetTransactionResult_Status.NOT_FOUND:
                        attempts--;
                        Assert.MustBe(attempts >= 0, "Could not find transaction.");
                        await Task.Delay(500);
                        break;
                    case GetTransactionResult_Status.FAILED:
                        Assert.MustBe(false, "Transaction failed");
                        break;
                    case GetTransactionResult_Status.SUCCESS:
                        return completion;
                        
                }
            }
            return null;
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

            // Wrap it in an envelope to send to Stellar
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
            Assert.MustBe(result.Status == SendTransactionResult_Status.PENDING,$"Transaction failed {result?.ErrorResult?.result}");
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
  
    public class SimpleHttpClientFactory : IHttpClientFactory
    {
        private readonly HttpClient _httpClient;

        public SimpleHttpClientFactory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient CreateClient(string name)
        {
            return _httpClient;
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
