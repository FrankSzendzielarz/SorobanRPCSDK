# Retrieving Account Information

This tutorial demonstrates how to retrieve account information using the Stellar RPC SDK. You'll learn how to get an account's balance, sequence number, and other properties.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Basic understanding of C# and async/await
- A Stellar account ID to query (see [Setting Up Stellar Accounts](../getting-started/accounts-setup.md))

## Initializing the Client

First, set up the RPC client:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Initialize the client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);
```

## Getting Account Information

To get account information, you'll need to:

1. Create an `AccountID` object from the account's public key
2. Create a `LedgerKey` for the account
3. Call `GetLedgerEntriesAsync` with the encoded ledger key

Here's how to retrieve account information:

```csharp
async Task<AccountEntry> GetAccountInfo(StellarRPCClient client, string accountIdStr)
{
    // Convert string account ID to AccountID object
    AccountID accountId = new AccountID(MuxedAccount.FromAccountId(accountIdStr).XdrPublicKey);
    
    // Create a ledger key for the account
    LedgerKey accountKey = new LedgerKey.Account()
    {
        account = new LedgerKey.accountStruct()
        {
            accountID = accountId
        }
    };
    
    // Encode the ledger key to base64
    string encodedKey = LedgerKeyXdr.EncodeToBase64(accountKey);
    
    // Create the request parameters
    var request = new GetLedgerEntriesParams()
    {
        Keys = [encodedKey]
    };
    
    // Call the API
    var response = await client.GetLedgerEntriesAsync(request);
    
    // Process the response
    if (response.Entries.Count > 0)
    {
        // Extract the account data from the response
        var accountData = response.Entries[0].LedgerEntryData as LedgerEntry.dataUnion.Account;
        
        if (accountData != null)
        {
            return accountData.account;
        }
    }
    
    throw new Exception("Account not found or not activated");
}
```

## Displaying Account Information

Once you have the account data, you can display its properties:

```csharp
void DisplayAccountInfo(AccountEntry account)
{
    Console.WriteLine("Account Information:");
    Console.WriteLine($"- Balance: {account.balance} stroops ({(double)account.balance / 10000000:F7} XLM)");
    Console.WriteLine($"- Sequence Number: {account.seqNum}");
    Console.WriteLine($"- Number of Subentries: {account.numSubEntries}");
    
    // Display flags
    Console.WriteLine("- Flags:");
    Console.WriteLine($"  - Auth Required: {(account.flags & 1) != 0}");
    Console.WriteLine($"  - Auth Revocable: {(account.flags & 2) != 0}");
    Console.WriteLine($"  - Auth Immutable: {(account.flags & 4) != 0}");
    
    // Display thresholds
    Console.WriteLine("- Thresholds:");
    Console.WriteLine($"  - Low: {account.thresholds.lowThreshold}");
    Console.WriteLine($"  - Medium: {account.thresholds.medThreshold}");
    Console.WriteLine($"  - High: {account.thresholds.highThreshold}");
}
```

## Complete Example

Here's a complete example that retrieves and displays account information:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AccountInfoExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            StellarRPCClient client = new StellarRPCClient(httpClient);
            
            // Example account ID
            string accountId = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T";
            
            try
            {
                // Get account information
                AccountEntry account = await GetAccountInfo(client, accountId);
                
                // Display account information
                DisplayAccountInfo(account);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        static async Task<AccountEntry> GetAccountInfo(StellarRPCClient client, string accountIdStr)
        {
            // Convert string account ID to AccountID object
            AccountID accountId = new AccountID(MuxedAccount.FromAccountId(accountIdStr).XdrPublicKey);
            
            // Create a ledger key for the account
            LedgerKey accountKey = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = accountId
                }
            };
            
            // Encode the ledger key to base64
            string encodedKey = LedgerKeyXdr.EncodeToBase64(accountKey);
            
            // Create the request parameters
            var request = new GetLedgerEntriesParams()
            {
                Keys = [encodedKey]
            };
            
            // Call the API
            var response = await client.GetLedgerEntriesAsync(request);
            
            // Process the response
            if (response.Entries.Count > 0)
            {
                // Extract the account data from the response
                var accountData = response.Entries[0].LedgerEntryData as LedgerEntry.dataUnion.Account;
                
                if (accountData != null)
                {
                    return accountData.account;
                }
            }
            
            throw new Exception("Account not found or not activated");
        }
        
        static void DisplayAccountInfo(AccountEntry account)
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine($"- Balance: {account.balance} stroops ({(double)account.balance / 10000000:F7} XLM)");
            Console.WriteLine($"- Sequence Number: {account.seqNum}");
            Console.WriteLine($"- Number of Subentries: {account.numSubEntries}");
            
            // Display flags
            Console.WriteLine("- Flags:");
            Console.WriteLine($"  - Auth Required: {(account.flags & 1) != 0}");
            Console.WriteLine($"  - Auth Revocable: {(account.flags & 2) != 0}");
            Console.WriteLine($"  - Auth Immutable: {(account.flags & 4) != 0}");
            
            // Display thresholds
            Console.WriteLine("- Thresholds:");
            Console.WriteLine($"  - Low: {account.thresholds.lowThreshold}");
            Console.WriteLine($"  - Medium: {account.thresholds.medThreshold}");
            Console.WriteLine($"  - High: {account.thresholds.highThreshold}");
        }
    }