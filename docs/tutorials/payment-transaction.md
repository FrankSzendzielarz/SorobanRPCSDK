# Creating and Sending Payment Transactions

This tutorial demonstrates how to create, sign, and submit a payment transaction using the Stellar RPC SDK. You'll learn how to transfer XLM from one account to another.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Two Stellar accounts (a sender with funds and a recipient)
- The secret key for the sender account
- Basic understanding of Stellar transactions

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
Network.UseTestNetwork(); // Use Network.UseMainNetwork() for mainnet
```

## Setting Up the Accounts

Define the sender and recipient accounts:

```csharp
// Sender account (you need the secret key)
MuxedAccount.KeyTypeEd25519 senderAccount = MuxedAccount.FromSecretSeed("SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
AccountID senderAccountId = new AccountID(senderAccount.XdrPublicKey);

// Recipient account (public key only)
MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
```

## Getting Account Information

Before creating a transaction, you need the sender's current sequence number:

```csharp
async Task<AccountEntry> GetAccountInfo(StellarRPCClient client, AccountID accountId)
{
    // Create a ledger key for the account
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

## Creating a Payment Transaction

Now, create a payment transaction using the sender's sequence number:

```csharp
Transaction CreatePaymentTransaction(
    MuxedAccount.KeyTypeEd25519 senderAccount, 
    MuxedAccount.KeyTypeEd25519 recipientAccount, 
    SequenceNumber currentSequenceNumber,
    long amount) // Amount in stroops (1 XLM = 10,000,000 stroops)
{
    // Increment the sequence number for the new transaction
    SequenceNumber nextSequenceNumber = new SequenceNumber(currentSequenceNumber.InnerValue + 1);
    
    // Create a payment operation
    Operation paymentOperation = new Operation()
    {
        sourceAccount = senderAccount, // Optional: use sender as the operation source
        body = new Operation.bodyUnion.Payment()
        {
            paymentOp = new PaymentOp()
            {
                amount = amount, // Amount in stroops
                destination = recipientAccount,
                asset = new Asset.AssetTypeNative() // XLM
            }
        }
    };
    
    // Create the transaction
    Transaction transaction = new Transaction()
    {
        sourceAccount = senderAccount,
        fee = 100, // Base fee (100 stroops per operation)
        memo = new Memo.MemoNone(), // No memo
        seqNum = nextSequenceNumber,
        cond = new Preconditions.PrecondNone(), // No preconditions
        ext = new Transaction.extUnion.case_0(),
        operations = [paymentOperation]
    };
    
    return transaction;
}
```

## Signing and Submitting the Transaction

Sign the transaction with the sender's secret key and submit it:

```csharp
async Task<SendTransactionResult> SignAndSubmitTransaction(
    StellarRPCClient client, 
    Transaction transaction, 
    MuxedAccount.KeyTypeEd25519 signerAccount)
{
    // Sign the transaction
    var signature = transaction.Sign(signerAccount);
    
    // Create the transaction envelope
    TransactionEnvelope envelope = new TransactionEnvelope.EnvelopeTypeTx()
    {
        v1 = new TransactionV1Envelope()
        {
            tx = transaction,
            signatures = [signature]
        }
    };
    
    // Encode the envelope to base64
    string encodedEnvelope = TransactionEnvelopeXdr.EncodeToBase64(envelope);
    
    // Submit the transaction
    SendTransactionResult result = await client.SendTransactionAsync(new SendTransactionParams()
    {
        Transaction = encodedEnvelope
    });
    
    // Check the result
    if (result.Status == SendTransactionResult_Status.ERROR)
    {
        throw new Exception($"Transaction failed: {result.ErrorResult?.result}");
    }
    
    return result;
}
```

## Checking Transaction Status

After submitting a transaction, you should check its status:

```csharp
async Task<GetTransactionResult> CheckTransactionStatus(
    StellarRPCClient client, 
    SendTransactionResult sendResult)
{
    int maxAttempts = 10;
    int attempts = 0;
    
    while (attempts < maxAttempts)
    {
        var transaction = await client.GetTransactionAsync(new GetTransactionParams()
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
                await Task.Delay(500); // Wait 500ms before checking again
                break;
        }
    }
    
    throw new Exception("Transaction timed out");
}
```

## Verifying the Balance Change

After a successful payment, you can verify the balance change:

```csharp
async Task VerifyBalanceChange(
    StellarRPCClient client, 
    AccountID senderAccountId, 
    AccountID recipientAccountId, 
    long originalSenderBalance, 
    long originalRecipientBalance, 
    long paymentAmount)
{
    AccountEntry newSenderAccount = await GetAccountInfo(client, senderAccountId);
    AccountEntry newRecipientAccount = await GetAccountInfo(client, recipientAccountId);
    
    // Verify sender's balance decreased by paymentAmount + fee
    long expectedSenderDecrease = paymentAmount + 100; // payment + fee
    if (originalSenderBalance - newSenderAccount.balance != expectedSenderDecrease)
    {
        Console.WriteLine("Warning: Sender balance change doesn't match expected amount");
    }
    
    // Verify recipient's balance increased by paymentAmount
    if (newRecipientAccount.balance - originalRecipientBalance != paymentAmount)
    {
        Console.WriteLine("Warning: Recipient balance change doesn't match expected amount");
    }
    
    Console.WriteLine("Balance changes verified successfully");
}
```

## Complete Example

Here's a complete example that sends a payment and verifies the result:

```csharp
using Stellar;
using Stellar.RPC;
using Stellar.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaymentExample
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
                // Set up accounts
                MuxedAccount.KeyTypeEd25519 senderAccount = MuxedAccount.FromSecretSeed(
                    "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");
                AccountID senderAccountId = new AccountID(senderAccount.XdrPublicKey);
                
                MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId(
                    "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
                AccountID recipientAccountId = new AccountID(recipientAccount.XdrPublicKey);
                
                // Get current account information
                Console.WriteLine("Getting account information...");
                AccountEntry senderAccountEntry = await GetAccountInfo(client, senderAccountId);
                AccountEntry recipientAccountEntry = await GetAccountInfo(client, recipientAccountId);
                
                // Display initial balances
                Console.WriteLine($"Sender initial balance: {senderAccountEntry.balance} stroops");
                Console.WriteLine($"Recipient initial balance: {recipientAccountEntry.balance} stroops");
                
                // Set the payment amount (1 XLM = 10,000,000 stroops)
                long paymentAmount = 500000; // 0.05 XLM
                Console.WriteLine($"Sending {paymentAmount} stroops ({(double)paymentAmount / 10000000:F7} XLM)");
                
                // Create payment transaction
                Transaction paymentTransaction = CreatePaymentTransaction(
                    senderAccount, 
                    recipientAccount, 
                    senderAccountEntry.seqNum, 
                    paymentAmount);
                
                // Sign and submit the transaction
                Console.WriteLine("Submitting transaction...");
                SendTransactionResult sendResult = await SignAndSubmitTransaction(
                    client, 
                    paymentTransaction, 
                    senderAccount);
                
                Console.WriteLine($"Transaction submitted: {sendResult.Hash}");
                
                // Check transaction status
                Console.WriteLine("Checking transaction status...");
                GetTransactionResult transactionResult = await CheckTransactionStatus(client, sendResult);
                
                Console.WriteLine("Transaction successful!");
                
                // Verify balance changes
                Console.WriteLine("Verifying balance changes...");
                await VerifyBalanceChange(
                    client, 
                    senderAccountId, 
                    recipientAccountId, 
                    senderAccountEntry.balance, 
                    recipientAccountEntry.balance, 
                    paymentAmount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        // ... Include all the methods defined earlier ...
    }
}
```

## Best Practices

1. **Set the Correct Network**: Always make sure to set the correct network context (`Network.UseTestNetwork()` or `Network.UseMainNetwork()`) before signing transactions.

2. **Fee Strategy**: Consider the network congestion when setting fees. You may want to use a higher fee during high-congestion periods.

3. **Sequence Number Handling**: Always get the latest sequence number from the network before creating a transaction.

4. **Error Handling**: Implement robust error handling, especially for sequence number errors, which might occur if multiple transactions are submitted in quick succession.

5. **Timeouts**: Set appropriate timeouts for transaction status checks, especially on the testnet where transaction processing might be slower.

## Common Errors and Solutions

1. **Bad Sequence Error**: If you get a bad sequence error, fetch the latest sequence number and try again.

2. **Insufficient Balance**: Ensure the sender has enough XLM to cover both the payment amount and the transaction fee.

3. **Transaction Already Submitted**: If you accidentally submit the same transaction twice, you'll get an error. Generate a new transaction with a new sequence number.

## Next Steps

Now that you can send payment transactions, you can:

- [Invoke Soroban Smart Contracts](soroban-invocation.md)
- [Monitor Account Events](events-monitoring.md)
- [Learn About More Complex Transaction Types](transaction-status.md)