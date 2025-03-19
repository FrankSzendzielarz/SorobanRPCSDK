# Working with Ledger Entries

This tutorial demonstrates how to retrieve and work with different types of ledger entries using the Stellar RPC SDK.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Basic familiarity with the SDK (see [Quick Start Guide](../getting-started/quickstart.md))

## Overview

The Stellar network maintains a ledger containing different types of entries, including:

- **Account Entries**: Information about Stellar accounts
- **Trustline Entries**: Asset trustlines established by accounts
- **Offer Entries**: Asset offers on the decentralized exchange
- **Data Entries**: Arbitrary data stored by accounts
- **Soroban Entries**: Soroban smart contract data

## Initializing the Client

Set up the RPC client:

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

> **Note:** For more details on client initialization, see the [Quick Start Guide](../getting-started/quickstart.md).

## Creating Ledger Keys

To retrieve ledger entries, you first need to create the appropriate ledger key:

### Account Ledger Key

```csharp
// Create an account ledger key
LedgerKey CreateAccountLedgerKey(string accountId)
{
    AccountID account = new AccountID(MuxedAccount.FromAccountId(accountId).XdrPublicKey);
    
    return new LedgerKey.Account()
    {
        account = new LedgerKey.accountStruct()
        {
            accountID = account
        }
    };
}
```

### Trustline Ledger Key

```csharp
// Create a trustline ledger key
LedgerKey CreateTrustlineLedgerKey(string accountId, string assetCode, string assetIssuer)
{
    AccountID account = new AccountID(MuxedAccount.FromAccountId(accountId).XdrPublicKey);
    AccountID issuer = new AccountID(MuxedAccount.FromAccountId(assetIssuer).XdrPublicKey);
    
    Asset asset;
    if (assetCode.Length <= 4)
    {
        asset = new Asset.AssetTypeCreditAlphanum4()
        {
            alphaNum4 = new AssetCode4()
            {
                assetCode = Util.PadRight(assetCode, 4),
                issuer = issuer
            }
        };
    }
    else
    {
        asset = new Asset.AssetTypeCreditAlphanum12()
        {
            alphaNum12 = new AssetCode12()
            {
                assetCode = Util.PadRight(assetCode, 12),
                issuer = issuer
            }
        };
    }
    
    return new LedgerKey.Trustline()
    {
        trustLine = new LedgerKey.trustLineStruct()
        {
            accountID = account,
            asset = asset
        }
    };
}
```

### Data Entry Ledger Key

```csharp
// Create a data entry ledger key
LedgerKey CreateDataEntryLedgerKey(string accountId, string dataName)
{
    AccountID account = new AccountID(MuxedAccount.FromAccountId(accountId).XdrPublicKey);
    
    return new LedgerKey.Data()
    {
        data = new LedgerKey.dataStruct()
        {
            accountID = account,
            dataName = Encoding.UTF8.GetBytes(dataName)
        }
    };
}
```

## Retrieving Ledger Entries

Once you have created the appropriate ledger key, you can retrieve the entry:

```csharp
async Task<T> GetLedgerEntry<T>(StellarRPCClient client, LedgerKey key) where T : class
{
    // Encode the ledger key to base64
    string encodedKey = LedgerKeyXdr.EncodeToBase64(key);
    
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
        // Extract the entry data
        return response.Entries[0].LedgerEntryData as T;
    }
    
    throw new Exception("Ledger entry not found");
}
```

## Complete Example: Retrieving Account and Trustline Information

Here's a simple example that retrieves both account and trustline information:

```csharp
async Task ShowAccountAndTrustlineInfo(StellarRPCClient client, string accountId, string assetCode, string assetIssuer)
{
    try
    {
        // Get account information
        LedgerKey accountKey = CreateAccountLedgerKey(accountId);
        var accountData = await GetLedgerEntry<LedgerEntry.dataUnion.Account>(client, accountKey);
        
        if (accountData != null)
        {
            Console.WriteLine($"Account Balance: {accountData.account.balance} stroops");
            Console.WriteLine($"Sequence Number: {accountData.account.seqNum}");
        }
        
        // Get trustline information
        LedgerKey trustlineKey = CreateTrustlineLedgerKey(accountId, assetCode, assetIssuer);
        var trustlineData = await GetLedgerEntry<LedgerEntry.dataUnion.Trustline>(client, trustlineKey);
        
        if (trustlineData != null)
        {
            Console.WriteLine($"Trustline Balance: {trustlineData.trustLine.balance}");
            Console.WriteLine($"Trustline Limit: {trustlineData.trustLine.limit}");
        }
    }
    catch (Exception ex) when (ex.Message.Contains("not found"))
    {
        Console.WriteLine("Account or trustline not found");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
```

## Retrieving Multiple Ledger Entries

You can retrieve multiple ledger entries in a single request:

```csharp
async Task<List<LedgerEntry>> GetMultipleLedgerEntries(StellarRPCClient client, List<LedgerKey> keys)
{
    // Encode all ledger keys to base64
    var encodedKeys = keys.Select(key => LedgerKeyXdr.EncodeToBase64(key)).ToList();
    
    // Create the request parameters
    var request = new GetLedgerEntriesParams()
    {
        Keys = encodedKeys
    };
    
    // Call the API
    var response = await client.GetLedgerEntriesAsync(request);
    
    // Return all entries
    return response.Entries;
}
```

## Best Practices

1. **Handle Missing Entries**: Always handle the case where a ledger entry may not exist.

2. **Type Checking**: Verify the type of returned ledger entries before casting.

3. **Batch Retrieval**: When retrieving multiple related entries, batch them into a single request.

4. **Error Handling**: Implement proper error handling for network issues and other failures.

## Next Steps

Now that you know how to work with ledger entries, you can:

- [Create and Send Payments](payment-transaction.md)
- [Work with Soroban Smart Contracts](soroban-invocation.md)
- [Check Transaction Status](transaction-status.md)

For more complete examples, refer to the more comprehensive tutorials linked above.