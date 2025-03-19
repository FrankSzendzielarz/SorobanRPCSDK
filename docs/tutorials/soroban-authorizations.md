# Soroban Authorizations

This tutorial demonstrates how to work with Soroban authorizations using the Stellar RPC SDK. You'll learn how to create, simulate, sign, and execute transactions that require authorization from multiple accounts.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Multiple funded Stellar accounts
- A deployed Soroban contract that requires authorization
- Basic understanding of Stellar transactions and Soroban

## Understanding Soroban Authorizations

Soroban contracts can require authorization from specific accounts to perform certain operations. For example, a payment contract might require authorization from the account that's sending funds. The authorization process in Soroban involves:

1. Creating a contract invocation
2. Simulating the transaction to determine which authorizations are needed
3. Signing the authorization payloads with the required accounts
4. Adding the signatures to the transaction
5. Submitting the completed transaction

## Initializing the Client

First, set up the RPC client and specify the network:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

// A simple HTTP client factory for console applications
// Note: In real applications, you would typically use dependency injection
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

// Initialize the client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);

// Set the network context
Network.UseTestNetwork();
```

> **Note:** The `SimpleHttpClientFactory` implementation shown here is a convenience for example code and simple console applications. In production applications, you should use a proper dependency injection system to provide an implementation of `IHttpClientFactory`.

## Setting Up Account and Contract Information

Define the accounts and contract for the authorization example:

```csharp
// Source account that will submit the transaction
MuxedAccount.KeyTypeEd25519 sourceAccount = MuxedAccount.FromSecretSeed(
    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");

// Account that will provide authorization (e.g., the payer)
MuxedAccount.KeyTypeEd25519 authorizingAccount = MuxedAccount.FromSecretSeed(
    "SATD6DG6F25FZX2GIQU74GZVECOKXRYSM74ACULTR7NGSEJI7ILDBW6H");

// Recipient account for the payment
MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId(
    "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");

// Contract ID of the payment contract
string contractId = "CALYAREJBDZNQCWDDUL26O6WKQFUUDOOQPP7SKXKHM6REXEBLCX6ZFLK";
```

## Getting Account Information

Retrieve the account information to get the current sequence number:

```csharp
async Task<AccountEntry> GetAccountInfo(StellarRPCClient client, MuxedAccount.KeyTypeEd25519 account)
{
    AccountID accountId = new AccountID(account.XdrPublicKey);
    
    LedgerKey accountKey = new LedgerKey.Account()
    {
        account = new LedgerKey.accountStruct()
        {
            accountID = accountId
        }
    };
    
    var request = new GetLedgerEntriesParams()
    {
        Keys = [LedgerKeyXdr.EncodeToBase64(accountKey)]
    };
    
    var response = await client.GetLedgerEntriesAsync(request);
    
    if (response.Entries.Count > 0)
    {
        var accountData = response.Entries[0].LedgerEntryData as LedgerEntry.dataUnion.Account;
        if (accountData != null)
        {
            return accountData.account;
        }
    }
    
    throw new Exception("Account not found");
}
```

## Creating a Contract Invocation with Potential Authorization

Create an operation to invoke a contract function that will require authorization:

```csharp
Operation CreatePaymentOperation(
    MuxedAccount.KeyTypeEd25519 sourceAccount, 
    MuxedAccount.KeyTypeEd25519 payerAccount,
    MuxedAccount.KeyTypeEd25519 recipientAccount,
    string contractId)
{
    // Create the contract invocation
    Operation operation = new Operation()
    {
        sourceAccount = sourceAccount,
        body = new Operation.bodyUnion.InvokeHostFunction()
        {
            invokeHostFunctionOp = new InvokeHostFunctionOp()
            {
                auth = [], // Authorization will be added later after simulation
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
                            // Payer account (requires authorization)
                            new SCVal.ScvAddress()
                            {
                                address = new SCAddress.ScAddressTypeAccount()
                                {
                                    accountId = new AccountID(payerAccount.XdrPublicKey)
                                }
                            },
                            // Recipient account
                            new SCVal.ScvAddress()
                            {
                                address = new SCAddress.ScAddressTypeAccount()
                                {
                                    accountId = new AccountID(recipientAccount.XdrPublicKey)
                                }
                            },
                            // Amount (e.g., 100 units)
                            new SCVal.ScvI128()
                            {
                                i128 = new Int128Parts()
                                {
                                    lo = 100,
                                    hi = 0
                                }
                            }
                        ]
                    }
                }
            }
        }
    };
    
    return operation;
}
```

## Creating the Transaction

Create a transaction with the contract invocation operation:

```csharp
async Task<Transaction> CreateAuthorizationTransaction(
    StellarRPCClient client,
    MuxedAccount.KeyTypeEd25519 sourceAccount,
    MuxedAccount.KeyTypeEd25519 payerAccount,
    MuxedAccount.KeyTypeEd25519 recipientAccount,
    string contractId)
{
    // Get the current account information for the sequence number
    AccountEntry accountEntry = await GetAccountInfo(client, sourceAccount);
    
    // Create the payment operation
    Operation payOperation = CreatePaymentOperation(
        sourceAccount,
        payerAccount,
        recipientAccount,
        contractId
    );
    
    // Create the transaction
    Transaction transaction = new Transaction()
    {
        sourceAccount = sourceAccount,
        fee = 100, // Base fee
        memo = new Memo.MemoNone(),
        seqNum = accountEntry.seqNum.Increment(),
        cond = new Preconditions.PrecondNone(),
        ext = new Transaction.extUnion.case_0(),
        operations = [payOperation]
    };
    
    return transaction;
}
```

## Simulating the Transaction to Get Authorization Requirements

Simulate the transaction to determine which authorizations are needed:

```csharp
async Task<SimulateTransactionResult> SimulateAuthorizationTransaction(
    StellarRPCClient client,
    Transaction transaction)
{
    // Create an envelope without signatures for simulation
    TransactionEnvelope simulateEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
    {
        v1 = new TransactionV1Envelope()
        {
            tx = transaction,
            signatures = [] // No signatures needed for simulation
        }
    };
    
    // Simulate the transaction
    SimulateTransactionResult simulationResult = await client.SimulateTransactionAsync(
        new SimulateTransactionParams()
        {
            Transaction = TransactionEnvelopeXdr.EncodeToBase64(simulateEnvelope)
        });
    
    return simulationResult;
}
```

## Adding Authorization Signatures

Process the simulation results and add the required authorization signatures:

```csharp
async Task<GetTransactionResult> AssembleAndExecuteAuthorizationTransaction(
    StellarRPCClient client,
    MuxedAccount.KeyTypeEd25519 sourceAccount,
    MuxedAccount.KeyTypeEd25519 authorizingAccount,
    Transaction transaction,
    SimulateTransactionResult simulationResult)
{
    // Get authorizations to sign
    List<HashIDPreimage.EnvelopeTypeSorobanAuthorization> authorisationsToSign = 
        simulationResult.GetAuthorisationsRequired();
    
    // Process each required authorization
    if (authorisationsToSign != null && authorisationsToSign.Count > 0)
    {
        for (int i = 0; i < authorisationsToSign.Count; i++)
        {
            // Create the payload hash to sign
            byte[] payloadToSign = Util.Hash(
                Convert.FromBase64String(
                    HashIDPreimageXdr.EncodeToBase64(authorisationsToSign[i])
                )
            );
            
            // Sign the payload with the authorizing account
            byte[] authSignature = authorizingAccount.Sign(payloadToSign);
            
            // Add the signature to the simulation result
            simulationResult.AddAuthorisationSignature(
                i,
                authorizingAccount.PublicKey,
                authSignature
            );
        }
    }
    
    // Apply the simulation results with authorizations to the transaction
    Transaction assembledTransaction = simulationResult.ApplyTo(transaction);
    
    // Sign the transaction with the source account
    var signature = assembledTransaction.Sign(sourceAccount);
    
    // Create the transaction envelope with the signature
    TransactionEnvelope sendEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
    {
        v1 = new TransactionV1Envelope()
        {
            tx = assembledTransaction,
            signatures = [signature]
        }
    };
    
    // Submit the transaction
    SendTransactionResult sendResult = await client.SendTransactionAsync(
        new SendTransactionParams()
        {
            Transaction = TransactionEnvelopeXdr.EncodeToBase64(sendEnvelope)
        });
    
    if (sendResult.Status != SendTransactionResult_Status.PENDING)
    {
        throw new Exception($"Transaction submission failed: {sendResult.ErrorResult?.result}");
    }
    
    // Check and return the transaction status
    return await CheckTransactionStatus(client, sendResult);
}
```

## Checking Transaction Status

Wait for the transaction to be processed:

```csharp
async Task<GetTransactionResult> CheckTransactionStatus(
    StellarRPCClient client,
    SendTransactionResult sendResult)
{
    int maxAttempts = 10;
    int attempts = 0;
    
    while (attempts < maxAttempts)
    {
        var transaction = await client.GetTransactionAsync(
            new GetTransactionParams()
            {
                Hash = sendResult.Hash
            });
        
        switch (transaction.Status)
        {
            case GetTransactionResult_Status.SUCCESS:
                return transaction;
                
            case GetTransactionResult_Status.FAILED:
                throw new Exception("Transaction failed");
                
            case GetTransactionResult_Status.NOT_FOUND:
                // Transaction not processed yet, wait and retry
                attempts++;
                await Task.Delay(1000); // Wait 1 second before checking again
                break;
        }
    }
    
    throw new Exception("Transaction timed out");
}
```

## Complete Example

Here's a complete example that demonstrates invoking a contract function with authorization:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SorobanAuthorizationExample
{
    // A simple HTTP client factory for console applications
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

    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(httpClient);
            StellarRPCClient client = new StellarRPCClient(httpClientFactory);
            
            // Set the network context
            Network.UseTestNetwork();
            
            try
            {
                // Set up accounts
                MuxedAccount.KeyTypeEd25519 sourceAccount = MuxedAccount.FromSecretSeed(
                    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
                
                MuxedAccount.KeyTypeEd25519 authorizingAccount = MuxedAccount.FromSecretSeed(
                    "SATD6DG6F25FZX2GIQU74GZVECOKXRYSM74ACULTR7NGSEJI7ILDBW6H");
                
                MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId(
                    "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
                
                // Contract ID
                string contractId = "CALYAREJBDZNQCWDDUL26O6WKQFUUDOOQPP7SKXKHM6REXEBLCX6ZFLK";
                
                Console.WriteLine("Creating authorized payment transaction...");
                
                // Create the transaction
                Transaction transaction = await CreateAuthorizationTransaction(
                    client,
                    sourceAccount,
                    authorizingAccount,
                    recipientAccount,
                    contractId
                );
                
                // Simulate the transaction
                Console.WriteLine("Simulating transaction to get authorization requirements...");
                SimulateTransactionResult simulationResult = 
                    await SimulateAuthorizationTransaction(client, transaction);
                
                // Get the number of required authorizations
                List<HashIDPreimage.EnvelopeTypeSorobanAuthorization> authorizations = 
                    simulationResult.GetAuthorisationsRequired();
                
                Console.WriteLine($"Transaction requires {authorizations?.Count ?? 0} authorizations");
                
                // Execute the transaction with authorizations
                Console.WriteLine("Adding authorization signatures and executing transaction...");
                GetTransactionResult result = await AssembleAndExecuteAuthorizationTransaction(
                    client,
                    sourceAccount,
                    authorizingAccount,
                    transaction,
                    simulationResult
                );
                
                Console.WriteLine("Transaction completed successfully!");
                Console.WriteLine($"Transaction hash: {result.Hash}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        // Include all the other methods defined earlier
        static async Task<AccountEntry> GetAccountInfo(StellarRPCClient client, MuxedAccount.KeyTypeEd25519 account)
        {
            AccountID accountId = new AccountID(account.XdrPublicKey);
            
            LedgerKey accountKey = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = accountId
                }
            };
            
            var request = new GetLedgerEntriesParams()
            {
                Keys = [LedgerKeyXdr.EncodeToBase64(accountKey)]
            };
            
            var response = await client.GetLedgerEntriesAsync(request);
            
            if (response.Entries.Count > 0)
            {
                var accountData = response.Entries[0].LedgerEntryData as LedgerEntry.dataUnion.Account;
                if (accountData != null)
                {
                    return accountData.account;
                }
            }
            
            throw new Exception("Account not found");
        }
        
        static Operation CreatePaymentOperation(
            MuxedAccount.KeyTypeEd25519 sourceAccount, 
            MuxedAccount.KeyTypeEd25519 payerAccount,
            MuxedAccount.KeyTypeEd25519 recipientAccount,
            string contractId)
        {
            // Create the contract invocation
            Operation operation = new Operation()
            {
                sourceAccount = sourceAccount,
                body = new Operation.bodyUnion.InvokeHostFunction()
                {
                    invokeHostFunctionOp = new InvokeHostFunctionOp()
                    {
                        auth = [], // Authorization will be added later after simulation
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
                                    // Payer account (requires authorization)
                                    new SCVal.ScvAddress()
                                    {
                                        address = new SCAddress.ScAddressTypeAccount()
                                        {
                                            accountId = new AccountID(payerAccount.XdrPublicKey)
                                        }
                                    },
                                    // Recipient account
                                    new SCVal.ScvAddress()
                                    {
                                        address = new SCAddress.ScAddressTypeAccount()
                                        {
                                            accountId = new AccountID(recipientAccount.XdrPublicKey)
                                        }
                                    },
                                    // Amount (e.g., 100 units)
                                    new SCVal.ScvI128()
                                    {
                                        i128 = new Int128Parts()
                                        {
                                            lo = 100,
                                            hi = 0
                                        }
                                    }
                                ]
                            }
                        }
                    }
                }
            };
            
            return operation;
        }
        
        static async Task<Transaction> CreateAuthorizationTransaction(
            StellarRPCClient client,
            MuxedAccount.KeyTypeEd25519 sourceAccount,
            MuxedAccount.KeyTypeEd25519 payerAccount,
            MuxedAccount.KeyTypeEd25519 recipientAccount,
            string contractId)
        {
            // Get the current account information for the sequence number
            AccountEntry accountEntry = await GetAccountInfo(client, sourceAccount);
            
            // Create the payment operation
            Operation payOperation = CreatePaymentOperation(
                sourceAccount,
                payerAccount,
                recipientAccount,
                contractId
            );
            
            // Create the transaction
            Transaction transaction = new Transaction()
            {
                sourceAccount = sourceAccount,
                fee = 100, // Base fee
                memo = new Memo.MemoNone(),
                seqNum = accountEntry.seqNum.Increment(),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations = [payOperation]
            };
            
            return transaction;
        }
        
        static async Task<SimulateTransactionResult> SimulateAuthorizationTransaction(
            StellarRPCClient client,
            Transaction transaction)
        {
            // Create an envelope without signatures for simulation
            TransactionEnvelope simulateEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = transaction,
                    signatures = [] // No signatures needed for simulation
                }
            };
            
            // Simulate the transaction
            SimulateTransactionResult simulationResult = await client.SimulateTransactionAsync(
                new SimulateTransactionParams()
                {
                    Transaction = TransactionEnvelopeXdr.EncodeToBase64(simulateEnvelope)
                });
            
            return simulationResult;
        }
        
        static async Task<GetTransactionResult> AssembleAndExecuteAuthorizationTransaction(
            StellarRPCClient client,
            MuxedAccount.KeyTypeEd25519 sourceAccount,
            MuxedAccount.KeyTypeEd25519 authorizingAccount,
            Transaction transaction,
            SimulateTransactionResult simulationResult)
        {
            // Get authorizations to sign
            List<HashIDPreimage.EnvelopeTypeSorobanAuthorization> authorisationsToSign = 
                simulationResult.GetAuthorisationsRequired();
            
            // Process each required authorization
            if (authorisationsToSign != null && authorisationsToSign.Count > 0)
            {
                for (int i = 0; i < authorisationsToSign.Count; i++)
                {
                    // Create the payload hash to sign
                    byte[] payloadToSign = Util.Hash(
                        Convert.FromBase64String(
                            HashIDPreimageXdr.EncodeToBase64(authorisationsToSign[i])
                        )
                    );
                    
                    // Sign the payload with the authorizing account
                    byte[] authSignature = authorizingAccount.Sign(payloadToSign);
                    
                    // Add the signature to the simulation result
                    simulationResult.AddAuthorisationSignature(
                        i,
                        authorizingAccount.PublicKey,
                        authSignature
                    );
                }
            }
            
            // Apply the simulation results with authorizations to the transaction
            Transaction assembledTransaction = simulationResult.ApplyTo(transaction);
            
            // Sign the transaction with the source account
            var signature = assembledTransaction.Sign(sourceAccount);
            
            // Create the transaction envelope with the signature
            TransactionEnvelope sendEnvelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = assembledTransaction,
                    signatures = [signature]
                }
            };
            
            // Submit the transaction
            SendTransactionResult sendResult = await client.SendTransactionAsync(
                new SendTransactionParams()
                {
                    Transaction = TransactionEnvelopeXdr.EncodeToBase64(sendEnvelope)
                });
            
            if (sendResult.Status != SendTransactionResult_Status.PENDING)
            {
                throw new Exception($"Transaction submission failed: {sendResult.ErrorResult?.result}");
            }
            
            // Check and return the transaction status
            return await CheckTransactionStatus(client, sendResult);
        }
        
        static async Task<GetTransactionResult> CheckTransactionStatus(
            StellarRPCClient client,
            SendTransactionResult sendResult)
        {
            int maxAttempts = 10;
            int attempts = 0;
            
            while (attempts < maxAttempts)
            {
                var transaction = await client.GetTransactionAsync(
                    new GetTransactionParams()
                    {
                        Hash = sendResult.Hash
                    });
                
                switch (transaction.Status)
                {
                    case GetTransactionResult_Status.SUCCESS:
                        return transaction;
                        
                    case GetTransactionResult_Status.FAILED:
                        throw new Exception("Transaction failed");
                        
                    case GetTransactionResult_Status.NOT_FOUND:
                        // Transaction not processed yet, wait and retry
                        attempts++;
                        await Task.Delay(1000); // Wait 1 second before checking again
                        break;
                }
            }
            
            throw new Exception("Transaction timed out");
        }
    }
}
```

## Understanding Soroban Authorization Format

Soroban authorizations use a specific format encoded in XDR:

1. **HashIDPreimage.EnvelopeTypeSorobanAuthorization**: The authorization envelope that contains:
   - **networkID**: Hash of the network passphrase
   - **nonce**: A unique number to prevent replay attacks
   - **signatureExpirationLedger**: The ledger number after which the signature expires
   - **invocation**: The authorized invocation details

2. Each authorization requires:
   - Creating the payload hash from the XDR-encoded authorization envelope
   - Signing the hash with the authorizing account's secret key
   - Adding the signature and public key to the transaction

## Best Practices for Authorization

1. **Security**: Keep authorization secret seeds secure and never expose them in client applications.

2. **Expiration Ledgers**: Be aware of the signature expiration ledger and ensure transactions are submitted in time.

3. **Multiple Authorizations**: Some contract functions might require authorization from multiple accounts. Process each one separately.

4. **Error Handling**: Implement robust error handling for authorization failures.

5. **Testing**: Test authorization flows thoroughly in the testnet before moving to mainnet.

## Next Steps

Now that you understand Soroban authorizations, you can:

- [Explore More Complex Contract Interactions](soroban-invocation.md)
- [Learn About Monitoring Contract Events](events-monitoring.md)
- [Develop Advanced Multi-Signature Contract Solutions](https://soroban.stellar.org/docs)