# Setting Up Stellar Accounts

This guide explains how to create and fund Stellar accounts for testing and development purposes.

## Understanding Stellar Accounts

In Stellar:

- Each account is identified by a public key (account ID)
- Each public key has a corresponding private key (secret seed)
- Accounts must be funded with XLM (the native asset) to exist on the network
- The minimum account balance is 1 XLM plus reserves for ledger entries

## Creating Test Accounts

### Method 1: Using the SDK to Generate Keys

You can create new key pairs directly in your code:

```csharp
using Stellar;

// Generate a random key pair
MuxedAccount.KeyTypeEd25519 keyPair = MuxedAccount.KeyTypeEd25519.Random();

// Get the public key (account ID)
string accountId = keyPair.GetAccountId();
Console.WriteLine($"Account ID: {accountId}");

// Get the private key (secret seed)
string secretSeed = keyPair.GetSecretSeed();
Console.WriteLine($"Secret Seed: {secretSeed}");

// IMPORTANT: In a real application, never log or display the secret seed
```

### Method 2: Using the Stellar Laboratory

You can also use the [Stellar Laboratory](https://laboratory.stellar.org/#account-creator) to create accounts:

1. Visit the [Account Creator](https://laboratory.stellar.org/#account-creator)
2. Click "Generate keypair"
3. Save both the public key and secret key securely

## Funding Test Accounts

### On Testnet

For the Testnet, you have several options to fund your accounts:

#### Option 1: Friendbot (recommended for development)

The Stellar Testnet has a service called Friendbot that will fund new accounts:

```csharp
using System.Net.Http;
using System.Threading.Tasks;

// Fund a new account using Friendbot
async Task FundTestnetAccount(string accountId)
{
    using var httpClient = new HttpClient();
    string url = $"https://friendbot.stellar.org/?addr={accountId}";
    var response = await httpClient.GetAsync(url);
    response.EnsureSuccessStatusCode();
    Console.WriteLine("Account funded successfully!");
}

// Usage
await FundTestnetAccount("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
```

#### Option 2: Using the Stellar Laboratory

1. Go to the [Stellar Laboratory](https://laboratory.stellar.org/)
2. Switch to "Testnet" in the network dropdown
3. Navigate to "Create Account"
4. Enter your account ID
5. Submit the transaction

### On Mainnet

For the Mainnet:

1. You need to get XLM from an exchange or another user
2. Transfer the XLM to your new account ID
3. The first transaction to a new account must include the minimum balance (1 XLM)

## Loading Existing Accounts

To use an existing account in your application:

```csharp
using Stellar;

// Load an account from a secret seed
MuxedAccount.KeyTypeEd25519 existingAccount = MuxedAccount.FromSecretSeed("SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");

// Create an AccountID for use in API calls
AccountID accountId = new AccountID(existingAccount.XdrPublicKey);

// IMPORTANT: Only store secret seeds in secure configuration
```

## Sample Test Accounts

For convenience, the SDK test examples use these pre-funded accounts:

```csharp
// Test account with funds
MuxedAccount.KeyTypeEd25519 testAccount = MuxedAccount.FromSecretSeed("SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH");

// Recipient test account
MuxedAccount.KeyTypeEd25519 recipientAccount = MuxedAccount.FromAccountId("GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T");
```

> **Note:** These accounts are for demonstration purposes only. In a production application, you should create and securely manage your own accounts.

## Best Practices for Account Management

1. **Never hardcode secret seeds** in production applications
2. **Store secret seeds securely** using proper secret management
3. **Generate different accounts** for different environments (development, testing, production)
4. **Implement key rotation** for long-lived applications
5. **Use multi-signature** for high-value accounts

## Next Steps

Once you have accounts set up, you can:

- [Create and Send Payments](../tutorials/payment-transaction.md)
- [Invoke Soroban Contracts](../tutorials/soroban-invocation.md)
- [Monitor Account Events](../tutorials/events-monitoring.md)