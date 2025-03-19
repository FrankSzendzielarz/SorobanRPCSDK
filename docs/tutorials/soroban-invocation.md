# Invoking Soroban Smart Contracts

This tutorial demonstrates how to invoke Soroban smart contracts using the Stellar RPC SDK. You'll learn how to create, simulate, and execute a contract invocation transaction.

## Prerequisites

- A project with the Stellar RPC SDK installed
- A funded Stellar account
- A deployed Soroban contract ID
- Basic understanding of Stellar transactions and Soroban

## Initializing the Client

First, set up the RPC client and specify the network:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

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

// Set the network context (important for transaction signing)
Network.UseTestNetwork();
```

> **Note:** The `SimpleHttpClientFactory` implementation shown here is a convenience for example code and simple console applications. In production applications, you should use a proper dependency injection system to provide an implementation of `IHttpClientFactory`.

## Setting Up Account and Contract Information

Define your account and the contract you want to interact with:

```csharp
// User account that will invoke the contract
MuxedAccount.KeyTypeEd25519 userAccount = MuxedAccount.FromSecretSeed(
    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");

// Contract ID of the deployed Soroban contract
string contractId = "CARVNC27XT7FUE6EGISSPYAUIY6X4TJPZLDZDMMBHRMUDBL7VHT45UZT";
```

## Getting Account Information

Before creating a transaction, you need the user's current sequence number:

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

## Creating a Contract Invocation

Create an operation to invoke a contract function with parameters:

```csharp
Operation CreateContractInvocation(
    MuxedAccount.KeyTypeEd25519 sourceAccount, 
    string contractId, 
    string functionName, 
    params SCVal[] arguments)
{
    // Create the contract invocation
    Operation operation = new Operation()
    {
        sourceAccount = sourceAccount,
        body = new Operation.bodyUnion.InvokeHostFunction()
        {
            invokeHostFunctionOp = new InvokeHostFunctionOp()
            {
                auth = [], // No authorization needed for this example
                hostFunction = new HostFunction.HostFunctionTypeInvokeContract()
                {
                    invokeContract = new InvokeContractArgs()
                    {
                        contractAddress = new SCAddress.ScAddressTypeContract()
                        {
                            contractId = new Hash(StrKey.DecodeContractId(contractId))
                        },
                        functionName = new SCSymbol(functionName),
                        args = arguments
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
Transaction CreateContractTransaction(
    MuxedAccount.KeyTypeEd25519 sourceAccount,
    SequenceNumber sequenceNumber,
    Operation operation)
{
    Transaction transaction = new Transaction()
    {
        sourceAccount = sourceAccount,
        fee = 100, // Base fee
        memo = new Memo.MemoNone(),
        seqNum = sequenceNumber.Increment(), // Increment the sequence number
        cond = new Preconditions.PrecondNone(),
        ext = new Transaction.extUnion.case_0(),
        operations =
        [
            operation
        ]
    };
    
    return transaction;
}
```

## Simulating the Transaction

Before executing a contract invocation, simulate it to get the proper transaction setup:

```csharp
async Task<SimulateTransactionResult> SimulateTransaction(
    StellarRPCClient client,
    Transaction transaction)
{
    // Create an envelope without signatures for simulation
    TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
    {
        v1 = new TransactionV1Envelope()
        {
            tx = transaction,
            signatures = [] // No signatures needed for simulation
        }
    };
    
    // Encode the envelope
    string encodedEnvelope = TransactionEnvelopeXdr.EncodeToBase64(envelope);
    
    // Simulate the transaction
    SimulateTransactionResult simulationResult = await client.SimulateTransactionAsync(
        new SimulateTransactionParams()
        {
            Transaction = encodedEnvelope
        });
    
    return simulationResult;
}
```

## Assembling and Executing the Transaction

Apply the simulation results to the transaction, sign it, and submit it:

```csharp
async Task<GetTransactionResult> AssembleAndExecuteTransaction(
    StellarRPCClient client,
    Transaction transaction,
    SimulateTransactionResult simulationResult,
    MuxedAccount.KeyTypeEd25519 signerAccount)
{
    // Apply simulation results to the transaction
    Transaction assembledTransaction = simulationResult.ApplyTo(transaction);
    
    // Sign the transaction
    var signature = assembledTransaction.Sign(signerAccount);
    
    // Create the transaction envelope with signature
    TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
    {
        v1 = new TransactionV1Envelope()
        {
            tx = assembledTransaction,
            signatures = [signature]
        }
    };
    
    // Encode the envelope
    string encodedEnvelope = TransactionEnvelopeXdr.EncodeToBase64(envelope);
    
    // Submit the transaction
    SendTransactionResult sendResult = await client.SendTransactionAsync(
        new SendTransactionParams()
        {
            Transaction = encodedEnvelope
        });
    
    if (sendResult.Status != SendTransactionResult_Status.PENDING)
    {
        throw new Exception($"Transaction submission failed: {sendResult.ErrorResult?.result}");
    }
    
    // Check transaction status
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

## Accessing the Invocation Result

Extract and process the contract invocation result:

```csharp
SCVal AccessInvocationResult(GetTransactionResult transactionResult)
{
    // Extract the result from the transaction metadata
    var meta = transactionResult.TransactionResultMeta as TransactionMeta.case_3;
    
    if (meta != null)
    {
        return meta.v3.sorobanMeta.returnValue;
    }
    
    throw new Exception("Cannot access invocation result");
}
```

## Complete Example: Division Function

Here's a complete example that invokes a contract's division function:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContractInvocationExample
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
                // Set up user account
                MuxedAccount.KeyTypeEd25519 userAccount = MuxedAccount.FromSecretSeed(
                    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
                
                // Contract ID to invoke
                string contractId = "CARVNC27XT7FUE6EGISSPYAUIY6X4TJPZLDZDMMBHRMUDBL7VHT45UZT";
                
                // Define the parameters for the division function
                long dividend = 33;
                long divisor = 11;
                
                Console.WriteLine($"Invoking division function with parameters: {dividend} / {divisor}");
                
                // Get account information for the sequence number
                AccountEntry accountEntry = await GetAccountInfo(client, userAccount);
                
                // Create the contract invocation operation
                Operation invokeDivisionOp = CreateContractInvocation(
                    userAccount,
                    contractId,
                    "divide_two_numbers",
                    new SCVal.ScvI64() { i64 = dividend },
                    new SCVal.ScvI64() { i64 = divisor }
                );
                
                // Create the transaction
                Transaction invokeTransaction = CreateContractTransaction(
                    userAccount,
                    accountEntry.seqNum,
                    invokeDivisionOp
                );
                
                // Simulate the transaction
                Console.WriteLine("Simulating transaction...");
                SimulateTransactionResult simulationResult = await SimulateTransaction(
                    client,
                    invokeTransaction
                );
                
                // Execute the transaction
                Console.WriteLine("Executing transaction...");
                GetTransactionResult transactionResult = await AssembleAndExecuteTransaction(
                    client,
                    invokeTransaction,
                    simulationResult,
                    userAccount
                );
                
                // Access and display the result
                SCVal result = AccessInvocationResult(transactionResult);
                
                if (result is SCVal.ScvI64 scvI64)
                {
                    Console.WriteLine($"Contract result: {dividend} / {divisor} = {scvI64.i64}");
                }
                else
                {
                    Console.WriteLine($"Unexpected result type: {result.GetType().Name}");
                }
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
        
        static Operation CreateContractInvocation(
            MuxedAccount.KeyTypeEd25519 sourceAccount, 
            string contractId, 
            string functionName, 
            params SCVal[] arguments)
        {
            Operation operation = new Operation()
            {
                sourceAccount = sourceAccount,
                body = new Operation.bodyUnion.InvokeHostFunction()
                {
                    invokeHostFunctionOp = new InvokeHostFunctionOp()
                    {
                        auth = [],
                        hostFunction = new HostFunction.HostFunctionTypeInvokeContract()
                        {
                            invokeContract = new InvokeContractArgs()
                            {
                                contractAddress = new SCAddress.ScAddressTypeContract()
                                {
                                    contractId = new Hash(StrKey.DecodeContractId(contractId))
                                },
                                functionName = new SCSymbol(functionName),
                                args = arguments
                            }
                        }
                    }
                }
            };
            
            return operation;
        }
        
        static Transaction CreateContractTransaction(
            MuxedAccount.KeyTypeEd25519 sourceAccount,
            SequenceNumber sequenceNumber,
            Operation operation)
        {
            Transaction transaction = new Transaction()
            {
                sourceAccount = sourceAccount,
                fee = 100,
                memo = new Memo.MemoNone(),
                seqNum = sequenceNumber.Increment(),
                cond = new Preconditions.PrecondNone(),
                ext = new Transaction.extUnion.case_0(),
                operations = [operation]
            };
            
            return transaction;
        }
        
        static async Task<SimulateTransactionResult> SimulateTransaction(
            StellarRPCClient client,
            Transaction transaction)
        {
            TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = transaction,
                    signatures = []
                }
            };
            
            string encodedEnvelope = TransactionEnvelopeXdr.EncodeToBase64(envelope);
            
            SimulateTransactionResult simulationResult = await client.SimulateTransactionAsync(
                new SimulateTransactionParams()
                {
                    Transaction = encodedEnvelope
                });
            
            return simulationResult;
        }
        
        static async Task<GetTransactionResult> AssembleAndExecuteTransaction(
            StellarRPCClient client,
            Transaction transaction,
            SimulateTransactionResult simulationResult,
            MuxedAccount.KeyTypeEd25519 signerAccount)
        {
            Transaction assembledTransaction = simulationResult.ApplyTo(transaction);
            
            var signature = assembledTransaction.Sign(signerAccount);
            
            TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
            {
                v1 = new TransactionV1Envelope()
                {
                    tx = assembledTransaction,
                    signatures = [signature]
                }
            };
            
            SendTransactionResult sendResult = await client.SendTransactionAsync(
                new SendTransactionParams()
                {
                    Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
                });
            
            if (sendResult.Status != SendTransactionResult_Status.PENDING)
            {
                throw new Exception($"Transaction submission failed: {sendResult.ErrorResult?.result}");
            }
            
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
                        attempts++;
                        await Task.Delay(1000);
                        break;
                }
            }
            
            throw new Exception("Transaction timed out");
        }
        
        static SCVal AccessInvocationResult(GetTransactionResult transactionResult)
        {
            var meta = transactionResult.TransactionResultMeta as TransactionMeta.case_3;
            
            if (meta != null)
            {
                return meta.v3.sorobanMeta.returnValue;
            }
            
            throw new Exception("Cannot access invocation result");
        }
    }
}
```

## Understanding Soroban Contract Invocation

Soroban contract invocation in the Stellar RPC SDK involves several steps:

1. **Creating an Invocation Operation**: Define which contract and function to call with what parameters
2. **Transaction Creation**: Embed the invocation operation in a transaction
3. **Simulation**: Run a simulation to get the proper resource setup
4. **Execution**: Sign and submit the transaction with the simulation results
5. **Result Processing**: Extract and process the return value from the transaction metadata

## Working with Different Parameter Types

Soroban contracts can accept various parameter types. Here's how to create different SCVal types:

```csharp
// Integer
SCVal intValue = new SCVal.ScvI64() { i64 = 42 };

// Unsigned integer
SCVal uintValue = new SCVal.ScvU64() { u64 = 42 };

// Boolean
SCVal boolValue = new SCVal.ScvBool() { b = true };

// String
SCVal stringValue = new SCVal.ScvString() { str = new SCString("Hello, Soroban!") };

// Binary data
SCVal binaryValue = new SCVal.ScvBytes() { bytes = Encoding.UTF8.GetBytes("Binary data") };

// Symbol (for function names, etc.)
SCVal symbolValue = new SCVal.ScvSymbol() { sym = new SCSymbol("symbol_name") };

// Address (account)
SCVal accountAddressValue = new SCVal.ScvAddress() 
{ 
    address = new SCAddress.ScAddressTypeAccount() 
    { 
        accountId = new AccountID(MuxedAccount.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T").XdrPublicKey) 
    } 
};

// Address (contract)
SCVal contractAddressValue = new SCVal.ScvAddress() 
{ 
    address = new SCAddress.ScAddressTypeContract() 
    { 
        contractId = new Hash(StrKey.DecodeContractId("CARVNC27XT7FUE6EGISSPYAUIY6X4TJPZLDZDMMBHRMUDBL7VHT45UZT")) 
    } 
};
```

## Processing Return Values

Different contracts return different types. Here's how to handle various return value types:

```csharp
void ProcessReturnValue(SCVal returnValue)
{
    switch (returnValue)
    {
        case SCVal.ScvBool scvBool:
            Console.WriteLine($"Boolean result: {scvBool.b}");
            break;
            
        case SCVal.ScvI64 scvI64:
            Console.WriteLine($"Integer result: {scvI64.i64}");
            break;
            
        case SCVal.ScvU64 scvU64:
            Console.WriteLine($"Unsigned integer result: {scvU64.u64}");
            break;
            
        case SCVal.ScvString scvString:
            Console.WriteLine($"String result: {scvString.str}");
            break;
            
        case SCVal.ScvBytes scvBytes:
            string hexString = BitConverter.ToString(scvBytes.bytes).Replace("-", "");
            Console.WriteLine($"Binary result: {hexString}");
            break;
            
        case SCVal.ScvVec scvVec:
            Console.WriteLine($"Vector result with {scvVec.vec.Length} elements");
            // Process each element in the vector
            break;
            
        case SCVal.ScvMap scvMap:
            Console.WriteLine($"Map result with {scvMap.map.Length} entries");
            // Process each key-value pair in the map
            break;
            
        default:
            Console.WriteLine($"Unhandled result type: {returnValue.GetType().Name}");
            break;
    }
}
```

## Error Handling

Contract invocations can fail for several reasons. Here are common errors and how to handle them:

1. **Contract Execution Errors**: Check the simulation result for potential execution errors before submitting the transaction.

2. **Resource Exhausted**: If the transaction exceeds the allowed resources, try adjusting the resource limits in the transaction.

3. **Authorization Errors**: If the contract requires authorization from multiple accounts, ensure all required signatures are included.

4. **Contract Not Found**: Verify the contract ID exists on the network you're connecting to.

```csharp
try
{
    SimulateTransactionResult simulationResult = await SimulateTransaction(client, transaction);
    
    // Check if simulation succeeded
    if (simulationResult.Error != null)
    {
        Console.WriteLine($"Simulation failed: {simulationResult.Error}");
        return;
    }
    
    // Continue with transaction execution
}
catch (Exception ex)
{
    Console.WriteLine($"Error during contract invocation: {ex.Message}");
}
```

## Best Practices

1. **Always Simulate First**: Always simulate transactions before executing them to catch errors early and set up proper resources.

2. **Proper Error Handling**: Implement robust error handling, especially for contract-specific errors.

3. **Resource Management**: Be aware of the resource requirements for your contract invocations, especially for contracts that involve significant computation or storage.

4. **Security Considerations**: For contracts that require authorization from multiple accounts, ensure proper signature collection and validation.

5. **Testing Strategy**: Test contract invocations in a testnet environment before moving to mainnet.

## Next Steps

Now that you can invoke Soroban contracts, you can:

- [Learn About Monitoring Contract Events](events-monitoring.md)
- [Explore More Complex Contract Interactions](transaction-status.md)
- [Develop Your Own Soroban Contracts](https://soroban.stellar.org/docs)