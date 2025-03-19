# StellarRPCClient API Reference

The `StellarRPCClient` class is the main entry point for interacting with the Stellar network through the RPC API. It provides methods for all supported Soroban RPC operations.

## Constructor

### StellarRPCClient(IHttpClientFactory httpClientFactory)

Creates a new instance of the Stellar RPC client with the specified `IHttpClientFactory`.

**Parameters:**
- `httpClientFactory`: An `IHttpClientFactory` implementation that can create HttpClient instances configured with the Stellar RPC server URL.

**Example with Dependency Injection (recommended for production applications):**
```csharp
// In Startup.cs or Program.cs for ASP.NET Core
builder.Services.AddHttpClient("StellarClient", client =>
{
    client.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
});

builder.Services.AddScoped<StellarRPCClient>(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    return new StellarRPCClient(httpClientFactory);
});
```

**Example for simple console applications:**
```csharp
// Simple implementation of IHttpClientFactory for console applications
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

// Create an HTTP client
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");

// Create a simple HTTP client factory
var httpClientFactory = new SimpleHttpClientFactory(httpClient);

// Initialize the StellarRPCClient with the factory
StellarRPCClient client = new StellarRPCClient(httpClientFactory);
```

> **Note:** The `SimpleHttpClientFactory` implementation is provided as a convenience for example code and simple applications. For production applications, it's recommended to use a proper dependency injection system.

## Health and Network Methods

### GetHealthAsync()

Gets the health status of the RPC server.

**Returns:** A `Task<HealthResult>` containing the status and latest ledger number.

**Example:**
```csharp
var healthResult = await client.GetHealthAsync();
Console.WriteLine($"Latest ledger: {healthResult.LatestLedger}");
```

### GetNetworkAsync()

Gets information about the current Stellar network.

**Returns:** A `Task<GetNetworkResult>` containing network information like passphrase.

**Example:**
```csharp
var networkResult = await client.GetNetworkAsync();
Console.WriteLine($"Network passphrase: {networkResult.Passphrase}");
```

### GetVersionInfoAsync()

Gets version information for the RPC server.

**Returns:** A `Task<GetVersionInfoResult>` containing protocol version information.

**Example:**
```csharp
var versionInfo = await client.GetVersionInfoAsync();
Console.WriteLine($"Protocol version: {versionInfo.Protocol_version}");
```

## Ledger Methods

### GetLatestLedgerAsync()

Gets information about the latest ledger.

**Returns:** A `Task<GetLatestLedgerResult>` containing details about the latest ledger.

**Example:**
```csharp
var latestLedger = await client.GetLatestLedgerAsync();
Console.WriteLine($"Latest ledger sequence: {latestLedger.Sequence}");
Console.WriteLine($"Protocol version: {latestLedger.ProtocolVersion}");
```

### GetLedgerEntriesAsync(GetLedgerEntriesParams parameters)

Gets ledger entries by their keys.

**Parameters:**
- `parameters`: A `GetLedgerEntriesParams` object containing:
  - `Keys`: An array of base64-encoded ledger keys

**Returns:** A `Task<GetLedgerEntriesResult>` containing the requested ledger entries.

**Example:**
```csharp
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
```

## Transaction Methods

### SendTransactionAsync(SendTransactionParams parameters)

Submits a transaction to the network.

**Parameters:**
- `parameters`: A `SendTransactionParams` object containing:
  - `Transaction`: A base64-encoded transaction envelope XDR

**Returns:** A `Task<SendTransactionResult>` containing the transaction hash and status.

**Example:**
```csharp
var result = await client.SendTransactionAsync(new SendTransactionParams()
{
    Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
});

Console.WriteLine($"Transaction hash: {result.Hash}");
Console.WriteLine($"Status: {result.Status}");
```

### GetTransactionAsync(GetTransactionParams parameters)

Gets information about a transaction by its hash.

**Parameters:**
- `parameters`: A `GetTransactionParams` object containing:
  - `Hash`: The transaction hash

**Returns:** A `Task<GetTransactionResult>` containing the transaction details.

**Example:**
```csharp
var transaction = await client.GetTransactionAsync(new GetTransactionParams()
{
    Hash = "abcdef1234567890abcdef1234567890abcdef1234567890abcdef1234567890"
});

Console.WriteLine($"Status: {transaction.Status}");
```

### GetTransactionsAsync(GetTransactionsParams parameters)

Gets a list of transactions in a specific ledger range.

**Parameters:**
- `parameters`: A `GetTransactionsParams` object containing:
  - `StartLedger`: The starting ledger sequence (optional)
  - `EndLedger`: The ending ledger sequence (optional)
  - `Cursor`: Pagination cursor (optional)
  - `Limit`: Maximum number of records to return (optional)
  - `IncludeFailed`: Whether to include failed transactions (optional)

**Returns:** A `Task<GetTransactionsResult>` containing the list of transactions.

**Example:**
```csharp
var transactions = await client.GetTransactionsAsync(new GetTransactionsParams()
{
    StartLedger = 123456,
    Limit = 10,
    IncludeFailed = true
});

foreach (var tx in transactions.Transactions)
{
    Console.WriteLine($"Transaction: {tx.Hash}");
}
```

### SimulateTransactionAsync(SimulateTransactionParams parameters)

Simulates executing a transaction without committing it to the ledger.

**Parameters:**
- `parameters`: A `SimulateTransactionParams` object containing:
  - `Transaction`: A base64-encoded transaction envelope XDR

**Returns:** A `Task<SimulateTransactionResult>` containing simulation results.

**Example:**
```csharp
var simulationResult = await client.SimulateTransactionAsync(new SimulateTransactionParams()
{
    Transaction = TransactionEnvelopeXdr.EncodeToBase64(envelope)
});

// Apply simulation results to the transaction
Transaction assembledTransaction = simulationResult.ApplyTo(transaction);
```

## Event Methods

### GetEventsAsync(GetEventsParams parameters)

Gets events matching specified filters.

**Parameters:**
- `parameters`: A `GetEventsParams` object containing:
  - `StartLedger`: The starting ledger sequence
  - `EndLedger`: The ending ledger sequence (optional)
  - `Filters`: An array of event filters
  - `Pagination`: Pagination parameters (optional)

**Returns:** A `Task<GetEventsResult>` containing the filtered events.

**Example:**
```csharp
var eventsParams = new GetEventsParams()
{
    StartLedger = 123456,
    Filters = [
        new EventFilter()
        {
            Type = "contract",
            ContractIds = ["CDLZFC3SYJYDZT7K67VZ75HPJVIEUVNIXF47ZG2FB2RMQQVU2HHGCYSC"],
            Topics = [
                ["AAAADwAAAAh0cmFuc2Zlcg==", "*", "*", "*"]
            ]
        }
    ],
    Pagination = new Pagination()
    {
        Limit = 10
    }
};

var events = await client.GetEventsAsync(eventsParams);

foreach (var evt in events.Events)
{
    Console.WriteLine($"Event Type: {evt.Type}");
    Console.WriteLine($"Ledger: {evt.Ledger}");
}
```

## Fee Methods

### GetFeeStatsAsync()

Gets statistics about recent transaction fees.

**Returns:** A `Task<GetFeeStatsResult>` containing fee statistics.

**Example:**
```csharp
var feeStats = await client.GetFeeStatsAsync();
Console.WriteLine($"Max fee: {feeStats.MaxFee}");
Console.WriteLine($"Fee percentiles: {string.Join(", ", feeStats.FeeCharged?.Percentiles ?? Array.Empty<long>())}");
```

## Error Handling

Most methods can throw exceptions for:

1. Network issues (`HttpRequestException`)
2. Invalid parameters
3. Server-side errors

Example error handling pattern:

```csharp
try
{
    var result = await client.GetHealthAsync();
    // Process result
}
catch (HttpRequestException ex)
{
    // Handle network errors
    Console.WriteLine($"Network error: {ex.Message}");
}
catch (Exception ex)
{
    // Handle other errors
    Console.WriteLine($"Error: {ex.Message}");
}
```

## Thread Safety

The `StellarRPCClient` is thread-safe for concurrent operations, as it relies on the thread safety of the underlying `HttpClient`.

## Best Practices

1. **Reuse the client**: Create a single instance of `StellarRPCClient` and reuse it throughout your application.

2. **Configure timeouts**: Set appropriate timeouts on the `HttpClient` for your use case.

3. **Handle rate limits**: Implement exponential backoff for retries if you encounter rate limiting.

4. **Dispose properly**: If your application creates the `HttpClient`, ensure it's properly disposed when no longer needed.

## Example Client Configuration

Example with custom timeout and headers:

```csharp
var handler = new HttpClientHandler();
var httpClient = new HttpClient(handler)
{
    BaseAddress = new Uri("https://soroban-testnet.stellar.org"),
    Timeout = TimeSpan.FromSeconds(30)
};

// Add any custom headers if needed
httpClient.DefaultRequestHeaders.Add("X-Client-Name", "YourAppName");
httpClient.DefaultRequestHeaders.Add("X-Client-Version", "1.0.0");

var httpClientFactory = new SimpleHttpClientFactory(httpClient);
var client = new StellarRPCClient(httpClientFactory);
```