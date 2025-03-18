# Working with Nested Structures in Soroban

This tutorial demonstrates how to work with nested structures when interacting with Soroban smart contracts. You'll learn how to create, organize, and pass complex nested data structures to Soroban contracts.

## Prerequisites

- A project with the Stellar RPC SDK installed
- A funded Stellar account
- A deployed Soroban contract that accepts nested structures
- Basic understanding of Soroban contract data types

## Understanding Soroban Contract Structures

Soroban contracts can define and work with complex data structures. In Rust contracts, these are typically defined as structs. When calling contract functions that expect struct parameters, you need to represent these structures using Soroban's Contract Data (SC) types - typically as `SCMap` objects.

## Initializing the Client

First, set up the RPC client and specify the network:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Initialize the client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);

// Set the network context
Network.UseTestNetwork();
```

## Setting Up Account and Contract Information

Define your account and the contract you want to interact with:

```csharp
// User account that will invoke the contract
MuxedAccount.KeyTypeEd25519 userAccount = MuxedAccount.FromSecretSeed(
    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");

// Contract ID that accepts nested structures
string contractId = "CDO5UFNRHPMCLFN6NXFPMS22HTQFZQACUZP6S25QUTFIGDFP4HLD3YVN";
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
        ## Simulating and Executing the Transaction

Use the standard simulation and execution pattern for Soroban transactions:

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
```

## Understanding Soroban Structure Representation

When working with Soroban structures, there are several important points to remember:

### 1. Map Keys Must Be Alphabetically Ordered

Soroban contracts expect map keys to be in alphabetical order. Failing to maintain this order will result in contract invocation errors.

```csharp
// CORRECT: Keys in alphabetical order (flat, numba, word)
var nestedTestReqMap = new SCVal.ScvMap()
{
    map = new SCMap(new SCMapEntry[]
    {
        new SCMapEntry()
        {
            key = new SCVal.ScvSymbol() { sym = new SCSymbol("flat") },
            val = flatTestReqMap
        },
        new SCMapEntry()
        {
            key = new SCVal.ScvSymbol() { sym = new SCSymbol("numba") },
            val = new SCVal.ScvU32() { u32 = 100 }
        },
        new SCMapEntry()
        {
            key = new SCVal.ScvSymbol() { sym = new SCSymbol("word") },
            val = new SCVal.ScvString() { str = new SCString("world") }
        }
    })
};
```

### 2. Keys are Case-Sensitive

The key names must exactly match what the contract expects, including case sensitivity.

### 3. Types Must Match Exactly

The Rust types in the contract must be matched with the correct SCVal types:

| Rust Type | SCVal Type     | C# Implementation                                   |
|-----------|----------------|-----------------------------------------------------|
| `u32`     | `ScvU32`       | `new SCVal.ScvU32() { u32 = 42 }`                  |
| `i32`     | `ScvI32`       | `new SCVal.ScvI32() { i32 = -42 }`                 |
| `u64`     | `ScvU64`       | `new SCVal.ScvU64() { u64 = 42 }`                  |
| `i64`     | `ScvI64`       | `new SCVal.ScvI64() { i64 = -42 }`                 |
| `String`  | `ScvString`    | `new SCVal.ScvString() { str = new SCString("text") }` |
| `Vec<T>`  | `ScvVec`       | `new SCVal.ScvVec() { vec = [element1, element2] }` |
| `Struct`  | `ScvMap`       | Map of field names to values                        |
| `Option<T>` | `ScvVoid`/value | Use `ScvVoid` for None, or the value type for Some  |

## Handling Complex Nested Structures

For deeply nested structures, you may want to create helper methods:

```csharp
SCVal CreateStructField(string name, string value)
{
    return new SCMapEntry()
    {
        key = new SCVal.ScvSymbol() { sym = new SCSymbol(name) },
        val = new SCVal.ScvString() { str = new SCString(value) }
    };
}

SCVal CreateStructField(string name, uint value)
{
    return new SCMapEntry()
    {
        key = new SCVal.ScvSymbol() { sym = new SCSymbol(name) },
        val = new SCVal.ScvU32() { u32 = value }
    };
}

SCVal CreateStructField(string name, SCVal value)
{
    return new SCMapEntry()
    {
        key = new SCVal.ScvSymbol() { sym = new SCSymbol(name) },
        val = value
    };
}
```

## Processing Result Structures

When a contract returns a complex structure, you'll need to process it:

```csharp
void ProcessResultStructure(SCVal resultValue)
{
    if (resultValue is SCVal.ScvMap resultMap)
    {
        Console.WriteLine("Contract returned a structure with fields:");
        
        foreach (var entry in resultMap.map)
        {
            if (entry.key is SCVal.ScvSymbol keySymbol)
            {
                string fieldName = keySymbol.sym;
                Console.WriteLine($"Field: {fieldName}");
                
                // Process the value based on its type
                ProcessFieldValue(fieldName, entry.val);
            }
        }
    }
}

void ProcessFieldValue(string fieldName, SCVal fieldValue)
{
    switch (fieldValue)
    {
        case SCVal.ScvString stringValue:
            Console.WriteLine($"  {fieldName}: {stringValue.str} (String)");
            break;
            
        case SCVal.ScvU32 u32Value:
            Console.WriteLine($"  {fieldName}: {u32Value.u32} (U32)");
            break;
            
        case SCVal.ScvI32 i32Value:
            Console.WriteLine($"  {fieldName}: {i32Value.i32} (I32)");
            break;
            
        case SCVal.ScvMap mapValue:
            Console.WriteLine($"  {fieldName}: Nested structure with {mapValue.map.Length} fields");
            // Recursively process nested structures
            foreach (var entry in mapValue.map)
            {
                if (entry.key is SCVal.ScvSymbol keySymbol)
                {
                    string nestedFieldName = $"{fieldName}.{keySymbol.sym}";
                    ProcessFieldValue(nestedFieldName, entry.val);
                }
            }
            break;
            
        // Handle other types as needed
        default:
            Console.WriteLine($"  {fieldName}: {fieldValue.GetType().Name}");
            break;
    }
}
```

## Best Practices

1. **Validate Contract Interface**: Before writing code, understand the exact structure of the contract's parameters. Many errors come from mismatched structures.

2. **Maintain Alphabetical Order**: Always ensure map keys are in alphabetical order.

3. **Type Safety**: Match Rust types exactly with the corresponding SCVal types.

4. **Error Handling**: Implement robust error handling, especially for contract-specific errors related to structure validation.

5. **Debugging**: Use simulation to debug structure issues before execution. The simulation result will often provide helpful error messages.

## Next Steps

Now that you can work with nested structures in Soroban contracts, you can:

- [Explore Soroban Authorizations](soroban-authorization.md)
- [Monitor Contract Events](events-monitoring.md)
- [Develop Your Own Complex Soroban Contracts](https://soroban.stellar.org/docs)

```

## Complete Example

Here's a complete example that demonstrates invoking a contract function with nested structures:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NestedStructsExample
{
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
                string contractId = "CDO5UFNRHPMCLFN6NXFPMS22HTQFZQACUZP6S25QUTFIGDFP4HLD3YVN";
                
                Console.WriteLine("Creating nested structures for contract invocation...");
                
                // Create the nested structures
                SCVal nestedStructs = CreateNestedStructures();
                
                // Get account information for the sequence number
                AccountEntry accountEntry = await GetAccountInfo(client, userAccount);
                
                // Create the contract invocation operation
                Operation nestedStructsInvocation = CreateNestedStructsInvocation(
                    userAccount,
                    contractId,
                    nestedStructs
                );
                
                // Create the transaction
                Transaction transaction = CreateNestedStructsTransaction(
                    userAccount,
                    accountEntry.seqNum,
                    nestedStructsInvocation
                );
                
                // Simulate the transaction
                Console.WriteLine("Simulating transaction...");
                SimulateTransactionResult simulationResult = await SimulateTransaction(
                    client,
                    transaction
                );
                
                // Execute the transaction
                Console.WriteLine("Executing transaction...");
                GetTransactionResult transactionResult = await AssembleAndExecuteTransaction(
                    client,
                    transaction,
                    simulationResult,
                    userAccount
                );
                
                Console.WriteLine("Transaction completed successfully!");
                Console.WriteLine($"Transaction hash: {transactionResult.Hash}");
                
                // Access and process the result if needed
                if (transactionResult.TransactionResultMeta is TransactionMeta.case_3 meta3)
                {
                    SCVal returnValue = meta3.v3.sorobanMeta.returnValue;
                    Console.WriteLine($"Contract returned: {returnValue.GetType().Name}");
                    
                    // Process the return value based on its type
                    // ...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        // Include all the other methods defined earlier
    }
}
```
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
    
    // Submit the transaction
    SendTransactionResult sendResult = await client.SendTransactionAsync(
        new SendTransactionParams()
        {
            Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
        });
    
    if (sendResult.Status != SendTransactionResult_Status.PENDING)
    {
        throw new Exception($"Transaction submission failed: {sendResult.ErrorResult?.result}");
    }
    
    // Check transaction status
    return await CheckTransactionStatus(client, sendResult);
}

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

## Creating Nested Structures

Let's assume we have a contract with nested structures in Rust like this:

```rust
// In the Soroban contract
#[derive(Clone, Debug, Eq, PartialEq, serde::Serialize, serde::Deserialize)]
#[contracttype]
pub struct FlatTestReq {
    pub number: u32,
    pub word: String,
}

#[derive(Clone, Debug, Eq, PartialEq, serde::Serialize, serde::Deserialize)]
#[contracttype]
pub struct NestedTestReq {
    pub flat: FlatTestReq,
    pub numba: u32,
    pub word: String,
}
```

Here's how to create these nested structures in C#:

```csharp
// Create nested structures for Soroban contract invocation
SCVal CreateNestedStructures()
{
    // First, create the nested FlatTestReq struct as an SCMap
    var flatTestReqMap = new SCVal.ScvMap()
    {
        map = new SCMap(new SCMapEntry[]
        {
            new SCMapEntry()
            {
                key = new SCVal.ScvSymbol() { sym = new SCSymbol("number") },
                val = new SCVal.ScvU32() { u32 = 42 }
            },
            new SCMapEntry()
            {
                key = new SCVal.ScvSymbol() { sym = new SCSymbol("word") },
                val = new SCVal.ScvString() { str = new SCString("hello") }
            }
        })
    };

    // Then, create the parent NestedTestReq struct as an SCMap
    var nestedTestReqMap = new SCVal.ScvMap()
    {
        map = new SCMap(new SCMapEntry[]
        {
            /*
             * IMPORTANT: Map keys must be in alphabetical order
             */
            new SCMapEntry()
            {
                key = new SCVal.ScvSymbol() { sym = new SCSymbol("flat") },
                val = flatTestReqMap  // Using the nested struct we created above
            },
            new SCMapEntry()
            {
                key = new SCVal.ScvSymbol() { sym = new SCSymbol("numba") },
                val = new SCVal.ScvU32() { u32 = 100 }
            },
            new SCMapEntry()
            {
                key = new SCVal.ScvSymbol() { sym = new SCSymbol("word") },
                val = new SCVal.ScvString() { str = new SCString("world") }
            }
        })
    };

    return nestedTestReqMap;
}
```

## Creating a Contract Invocation with Nested Structures

Create an operation to invoke a contract function with the nested structures:

```csharp
Operation CreateNestedStructsInvocation(
    MuxedAccount.KeyTypeEd25519 sourceAccount, 
    string contractId, 
    SCVal nestedStructure)
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
                        functionName = new SCSymbol("nested_param_test"),
                        args = [nestedStructure]
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
Transaction CreateNestedStructsTransaction(
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
        operations = [operation]
    };
    
    return transaction;
}