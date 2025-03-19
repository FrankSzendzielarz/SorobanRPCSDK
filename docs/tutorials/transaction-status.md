# Checking Transaction Status

This tutorial demonstrates how to check the status of transactions using the Stellar RPC SDK. You'll learn how to verify if a transaction succeeded, extract results, and handle different status conditions.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Basic understanding of Stellar transactions
- Familiarity with the SDK setup (see [Quick Start Guide](../getting-started/quickstart.md))

## Initializing the Client

Set up the RPC client:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Net.Http;
using System.Threading.Tasks;

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

// Initialize the client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);
```

> **Note:** For more details on client initialization, see the [Quick Start Guide](../getting-started/quickstart.md).

## Getting Transaction Status

Once you have submitted a transaction and received a transaction hash, you can check its status:

```csharp
async Task<GetTransactionResult> CheckTransactionStatus(StellarRPCClient client, string transactionHash)
{
    var transactionParams = new GetTransactionParams()
    {
        Hash = transactionHash
    };
    
    return await client.GetTransactionAsync(transactionParams);
}
```

## Understanding Transaction Status Values

The `GetTransactionResult` object includes a `Status` field with one of these values:

- **`GetTransactionResult_Status.SUCCESS`**: The transaction was processed successfully
- **`GetTransactionResult_Status.FAILED`**: The transaction failed during processing
- **`GetTransactionResult_Status.NOT_FOUND`**: The transaction has not been processed yet or does not exist

## Waiting for Transaction Completion

Since transactions are not processed instantly, you'll often need to poll for status:

```csharp
async Task<GetTransactionResult> WaitForTransactionCompletion(
    StellarRPCClient client, 
    string transactionHash, 
    int maxAttempts = 10, 
    int delayMs = 1000)
{
    int attempts = 0;
    
    while (attempts < maxAttempts)
    {
        var transaction = await client.GetTransactionAsync(new GetTransactionParams()
        {
            Hash = transactionHash
        });
        
        switch (transaction.Status)
        {
            case GetTransactionResult_Status.SUCCESS:
                return transaction;
                
            case GetTransactionResult_Status.FAILED:
                throw new Exception($"Transaction failed: {transaction.ResultXdr}");
                
            case GetTransactionResult_Status.NOT_FOUND:
                // Transaction not processed yet, wait and retry
                attempts++;
                await Task.Delay(delayMs);
                break;
        }
    }
    
    throw new Exception("Transaction verification timed out");
}
```

## Extracting Transaction Results

For successful transactions, you can extract additional information:

### Payment Transaction Results

```csharp
void ProcessPaymentResult(GetTransactionResult result)
{
    if (result.Status == GetTransactionResult_Status.SUCCESS)
    {
        Console.WriteLine($"Transaction successful!");
        Console.WriteLine($"Fee charged: {result.FeeMeta?.FeeCharged ?? 0} stroops");
        Console.WriteLine($"Ledger: {result.Ledger}");
    }
}
```

### Soroban Contract Results

For Soroban contract transactions, you can extract the return value:

```csharp
SCVal GetSorobanReturnValue(GetTransactionResult result)
{
    if (result.Status == GetTransactionResult_Status.SUCCESS && 
        result.TransactionResultMeta is TransactionMeta.case_3 metaV3)
    {
        return metaV3.v3.sorobanMeta.returnValue;
    }
    
    throw new Exception("Cannot extract Soroban return value");
}
```

## Complete Example

Here's a complete example that submits a transaction and checks its status:

```csharp
async Task SubmitAndVerifyTransaction(
    StellarRPCClient client, 
    TransactionEnvelope transactionEnvelope)
{
    try
    {
        // Encode the transaction envelope
        string encodedEnvelope = TransactionEnvelopeXdr.EncodeToBase64(transactionEnvelope);
        
        // Submit the transaction
        var sendResult = await client.SendTransactionAsync(new SendTransactionParams()
        {
            Transaction = encodedEnvelope
        });
        
        if (sendResult.Status == SendTransactionResult_Status.ERROR)
        {
            Console.WriteLine($"Transaction submission failed: {sendResult.ErrorResult?.result}");
            return;
        }
        
        Console.WriteLine($"Transaction submitted successfully: {sendResult.Hash}");
        
        // Wait for the transaction to complete
        var finalResult = await WaitForTransactionCompletion(client, sendResult.Hash);
        
        // Process the result
        Console.WriteLine($"Transaction completed successfully in ledger {finalResult.Ledger}");
        
        // If this was a Soroban transaction, we could extract the return value
        if (finalResult.TransactionResultMeta is TransactionMeta.case_3 metaV3)
        {
            SCVal returnValue = metaV3.v3.sorobanMeta.returnValue;
            Console.WriteLine($"Soroban return value type: {returnValue.GetType().Name}");
            
            // Process the return value based on its type
            if (returnValue is SCVal.ScvI64 i64Value)
            {
                Console.WriteLine($"Integer result: {i64Value.i64}");
            }
            // Handle other types as needed
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
```

## Getting Multiple Transactions

To retrieve multiple transactions for a range of ledgers:

```csharp
async Task GetRecentTransactions(StellarRPCClient client, long startLedger, int limit = 10)
{
    var transactionsParams = new GetTransactionsParams()
    {
        StartLedger = startLedger,
        Limit = limit,
        IncludeFailed = true  // Set to false to include only successful transactions
    };
    
    var transactionsResult = await client.GetTransactionsAsync(transactionsParams);
    
    Console.WriteLine($"Found {transactionsResult.Transactions.Count} transactions:");
    
    foreach (var tx in transactionsResult.Transactions)
    {
        Console.WriteLine($"Hash: {tx.Hash}");
        Console.WriteLine($"Ledger: {tx.Ledger}");
        Console.WriteLine($"Status: {(tx.Successful ? "Success" : "Failed")}");
        Console.WriteLine();
    }
}
```

## Error Handling and Best Practices

1. **Implement Timeouts**: Always set a maximum number of attempts when waiting for transactions.

2. **Handle Network Issues**: Be prepared for network disruptions during transaction verification.

3. **Check for Failed Transactions**: Always check the transaction status before processing results.

4. **Transaction Hash Storage**: Store transaction hashes for important operations to verify them later.

5. **Logging**: Log transaction details for auditing and debugging purposes.

## Next Steps

For more detailed information and examples, check these related tutorials:

- [Creating and Sending Payments](payment-transaction.md)
- [Invoking Soroban Contracts](soroban-invocation.md)
- [Working with Soroban Authorizations](soroban-authorization.md)