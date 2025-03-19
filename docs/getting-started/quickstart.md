# Quick Start Guide

This guide will help you create a simple console application that connects to the Stellar Testnet, checks the server health, and retrieves account information.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher
- A basic understanding of C# and asynchronous programming
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional)

## Create a New Console Project

First, create a new console application:

```bash
dotnet new console -n StellarRpcSdkDemo
cd StellarRpcSdkDemo
```

## Install the Stellar RPC SDK

Add the SDK package to your project:

```bash
dotnet add package StellarRPCSDK
```

## Basic Application Structure

Replace the contents of `Program.cs` with the following code:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Threading.Tasks;

namespace StellarRpcSdkDemo
{
    internal class Program
    {

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



        static async Task Main(string[] args)
        {
            // Initialize the client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(httpClient);
            StellarRPCClient client = new StellarRPCClient(httpClientFactory);

            try
            {
                // Check server health
                var healthResult = await client.GetHealthAsync();
                Console.WriteLine($"Server is healthy. Latest ledger: {healthResult.LatestLedger}");

                // Get network information
                var networkResult = await client.GetNetworkAsync();
                Console.WriteLine($"Connected to network: {networkResult.Passphrase}");

                // Get an account address from the command line
                Console.Write("Enter a Stellar account ID (or press Enter to use a sample account): ");
                string accountId = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(accountId))
                {
                    accountId = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T";
                    Console.WriteLine($"Using sample account: {accountId}");
                }

                // Get account information
                AccountID account = new AccountID(MuxedAccount.FromAccountId(accountId).XdrPublicKey);
                
                LedgerKey accountKey = new LedgerKey.Account()
                {
                    account = new LedgerKey.accountStruct()
                    {
                        accountID = account
                    }
                };

                var entriesRequest = new GetLedgerEntriesParams()
                {
                    Keys = [LedgerKeyXdr.EncodeToBase64(accountKey)]
                };
                
                var entriesResult = await client.GetLedgerEntriesAsync(entriesRequest);
                
                if (entriesResult.Entries.Count > 0)
                {
                    var accountData = entriesResult.Entries[0].LedgerEntryData as LedgerEntry.dataUnion.Account;
                    
                    if (accountData != null)
                    {
                        Console.WriteLine($"Account Balance: {accountData.account.balance} stroops");
                        Console.WriteLine($"Sequence Number: {accountData.account.seqNum}");
                    }
                }
                else
                {
                    Console.WriteLine("Account not found or not activated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
```

## Run the Application

Build and run your application:

```bash
dotnet run
```

The application will:

1. Connect to the Stellar Testnet
2. Verify the server health
3. Display network information
4. Prompt for a Stellar account ID (or use a sample one)
5. Display account information (balance and sequence number)

## Next Steps

Now that you have a basic application working, you can explore more advanced features:

- [Setting Up Stellar Accounts](accounts-setup.md)
- [Creating and Sending Payments](../tutorials/payment-transaction.md)
- [Invoking Soroban Contracts](../tutorials/soroban-invocation.md)

For a more comprehensive example, check out the [SDKTest project](https://github.com/yourusername/stellar-rpcsdk/tree/main/SDKTest) in the SDK repository.