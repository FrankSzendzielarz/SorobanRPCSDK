# Server Health Check Tutorial

This tutorial demonstrates how to perform basic server health checks with the Stellar RPC SDK. Server health checks are a good first step to ensure your connection to the Stellar network is functioning correctly.

## Prerequisites

- A project with the Stellar RPC SDK installed
- Basic understanding of C# and async/await

## Setting Up the RPC Client

First, you need to initialize the `StellarRPCClient`:

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

// Create an HTTP client with the base address set to a Stellar RPC server
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");

// Create an HTTP client factory
var httpClientFactory = new SimpleHttpClientFactory(httpClient);

// Initialize the Stellar RPC client
StellarRPCClient sorobanClient = new StellarRPCClient(httpClientFactory);
```

> **Note:** The `SimpleHttpClientFactory` implementation shown here is a convenience for example code and simple console applications. In production applications, you should use a proper dependency injection system to provide an implementation of `IHttpClientFactory`.
```

## Checking Server Health

The `GetHealthAsync` method provides information about the server's health and the latest ledger:

```csharp
async Task CheckServerHealth(StellarRPCClient client)
{
    try
    {
        var healthResult = await client.GetHealthAsync();
        
        Console.WriteLine("Server Health Check:");
        Console.WriteLine($"- Status: Healthy");
        Console.WriteLine($"- Latest Ledger: {healthResult.LatestLedger}");
        
        // You can use the latest ledger sequence number in subsequent operations
        long latestLedger = healthResult.LatestLedger;
        
        return latestLedger;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Health check failed: {ex.Message}");
        throw;
    }
}
```

## Getting Server Version Information

The `GetVersionInfoAsync` method provides information about the server version:

```csharp
async Task CheckServerVersion(StellarRPCClient client)
{
    try
    {
        var versionInfoResult = await client.GetVersionInfoAsync();
        
        Console.WriteLine("Server Version Information:");
        Console.WriteLine($"- Protocol Version: {versionInfoResult.Protocol_version}");
        
        // Verify that the server is running a protocol version that your application supports
        if (versionInfoResult.Protocol_version < 21)
        {
            Console.WriteLine("Warning: Server is running an older protocol version");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Version check failed: {ex.Message}");
        throw;
    }
}
```

## Getting Network Information

You can also check which Stellar network you're connected to:

```csharp
async Task CheckNetworkInformation(StellarRPCClient client)
{
    try
    {
        var networkResult = await client.GetNetworkAsync();
        
        Console.WriteLine("Network Information:");
        Console.WriteLine($"- Network Passphrase: {networkResult.Passphrase}");
        
        // Verify that you're connected to the expected network
        if (networkResult.Passphrase == "Test SDF Network ; September 2015")
        {
            Console.WriteLine("Connected to the Stellar Testnet");
        }
        else if (networkResult.Passphrase == "Public Global Stellar Network ; September 2015")
        {
            Console.WriteLine("Connected to the Stellar Mainnet");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Network check failed: {ex.Message}");
        throw;
    }
}
```

## Complete Example

Here's a complete example that performs all three checks:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServerHealthCheckExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the client
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(httpClient);
            StellarRPCClient sorobanClient = new StellarRPCClient(httpClientFactory);
            
            try
            {
                // Check server health
                long latestLedger = await CheckServerHealth(sorobanClient);
                
                // Check server version
                await CheckServerVersion(sorobanClient);
                
                // Check network information
                await CheckNetworkInformation(sorobanClient);
                
                Console.WriteLine("\nAll checks completed successfully!");
                Console.WriteLine($"Ready to process operations through ledger {latestLedger}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during server checks: {ex.Message}");
            }
        }
        
        static async Task<long> CheckServerHealth(StellarRPCClient client)
        {
            var healthResult = await client.GetHealthAsync();
            
            Console.WriteLine("Server Health Check:");
            Console.WriteLine($"- Status: Healthy");
            Console.WriteLine($"- Latest Ledger: {healthResult.LatestLedger}");
            
            return healthResult.LatestLedger;
        }
        
        static async Task CheckServerVersion(StellarRPCClient client)
        {
            var versionInfoResult = await client.GetVersionInfoAsync();
            
            Console.WriteLine("\nServer Version Information:");
            Console.WriteLine($"- Protocol Version: {versionInfoResult.Protocol_version}");
            
            if (versionInfoResult.Protocol_version < 21)
            {
                Console.WriteLine("Warning: Server is running an older protocol version");
            }
        }
        
        static async Task CheckNetworkInformation(StellarRPCClient client)
        {
            var networkResult = await client.GetNetworkAsync();
            
            Console.WriteLine("\nNetwork Information:");
            Console.WriteLine($"- Network Passphrase: {networkResult.Passphrase}");
            
            if (networkResult.Passphrase == "Test SDF Network ; September 2015")
            {
                Console.WriteLine("Connected to the Stellar Testnet");
            }
            else if (networkResult.Passphrase == "Public Global Stellar Network ; September 2015")
            {
                Console.WriteLine("Connected to the Stellar Mainnet");
            }
        }
    }
}
```

## Error Handling

When working with network requests, it's important to implement proper error handling:

```csharp
try
{
    var healthResult = await client.GetHealthAsync();
    Console.WriteLine($"Server is healthy, latest ledger: {healthResult.LatestLedger}");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Network error: {ex.Message}");
    // Handle network connectivity issues
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
    // Handle other exceptions
}
```

## Best Practices

1. **Implement Retries**: Network operations can fail temporarily. Consider implementing retry logic with exponential backoff.

2. **Health Check Before Operations**: Perform health checks before critical operations to ensure the network is available.

3. **Monitor Latest Ledger**: Use the latest ledger information to set appropriate timeouts and preconditions for transactions.

4. **Timeout Configuration**: Set appropriate timeouts on your HTTP client:

   ```csharp
   httpClient.Timeout = TimeSpan.FromSeconds(30);
   ```

## Next Steps

Now that you can verify connectivity to the Stellar network, you can:

- [Retrieve Account Information](account-info.md)
- [Create and Send Payments](payment-transaction.md)
- [Monitor Ledger Events](events-monitoring.md)