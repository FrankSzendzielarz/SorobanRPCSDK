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

// Initialize the client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);

// Set the network context (important for transaction signing)
Network.UseTestNetwork();
```

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
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            StellarRPCClient client = new StellarRPCClient(httpClient);
            
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
        
        static Transaction CreateContractTransaction(
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
        
        static async Task<SimulateTransactionResult> SimulateTransaction(
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
        
        static async Task<GetTransactionResult> AssembleAndExecuteTransaction(
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
        
        static SCVal AccessInvocationResult(GetTransactionResult transactionResult)
        {
            // Extract the result from the transaction metadata
            var meta = transactionResult.TransactionResultMeta as TransactionMeta.case_3;
            
            if (meta != null)
            {
                return meta.v3.sorobanMeta.returnValue;
            }
            
            throw new Exception("Cannot access invocation result");
        }
    }