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
```

> **Note:** The `SimpleHttpClientFactory` implementation shown here is a convenience for example code and simple console applications. In production applications, you should use a proper dependency injection system to provide an implementation of `IHttpClientFactory`.

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
}
```

## Working with Account Signers

If you need to access the account's signers, you can extend the `DisplayAccountInfo` method:

```csharp
void DisplaySigners(AccountEntry account)
{
    Console.WriteLine("- Signers:");
    
    foreach (var signer in account.signers)
    {
        string signerType = "Unknown";
        string signerValue = "Unknown";
        
        if (signer.key is SignerKey.SignerKeyTypeEd25519)
        {
            var ed25519Key = (SignerKey.SignerKeyTypeEd25519)signer.key;
            signerType = "Ed25519 Public Key";
            signerValue = StrKey.EncodeAccountId(new AccountID(new PublicKey.PublicKeyTypeEd25519() 
            { 
                ed25519 = ed25519Key.ed25519
            }));
        }
        else if (signer.key is SignerKey.SignerKeyTypePreAuthTx)
        {
            signerType = "Pre-authorized Transaction Hash";
            // Format hash if needed
        }
        else if (signer.key is SignerKey.SignerKeyTypeHashX)
        {
            signerType = "SHA-256 Hash";
            // Format hash if needed
        }
        
        Console.WriteLine($"  - Type: {signerType}");
        Console.WriteLine($"    Value: {signerValue}");
        Console.WriteLine($"    Weight: {signer.weight}");
    }
}
```

## Checking if an Account Exists

Before retrieving account details, you may want to check if an account exists:

```csharp
async Task<bool> AccountExists(StellarRPCClient client, string accountIdStr)
{
    try
    {
        await GetAccountInfo(client, accountIdStr);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}
```

## Error Handling

When working with account information, be prepared to handle these common errors:

1. **Account Not Found**: The account hasn't been created or funded yet
2. **Invalid Account ID**: The provided account ID string is not valid
3. **Network Errors**: Connection issues with the Stellar network

```csharp
try
{
    AccountEntry account = await GetAccountInfo(client, accountId);
    DisplayAccountInfo(account);
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid account ID format. Make sure you're using a valid Stellar account ID.");
}
catch (Exception ex) when (ex.Message.Contains("not found"))
{
    Console.WriteLine("Account not found or not activated. The account may need to be funded first.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error retrieving account information: {ex.Message}");
}
```

## Best Practices

1. **Cache Account Information**: To reduce network calls, consider caching account information for a short period.

2. **Check Sequence Numbers**: Before submitting transactions, always get the latest sequence number from the network.

3. **Handle Different Account States**: Be prepared to handle accounts in different states (new, funded, merged).

4. **Balance Formatting**: When displaying balances, remember that Stellar uses "stroops" (1 XLM = 10,000,000 stroops).

## Next Steps

Now that you can retrieve account information, you can:

- [Create and Send Payments](payment-transaction.md)
- [Work with Ledger Entries](ledger-entries.md)
- [Monitor Account Events](events-monitoring.md)