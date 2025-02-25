using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Stellar.RPC;

namespace Stellar.RPC
{
/// <summary>
/// Stellar-RPC allows you to communicate directly with Soroban via a JSON RPC interface.
/// </summary>
public partial class StellarRPCClient
{
    private readonly HttpClient _httpClient;
    private static readonly StellarRPCJsonContext _jsonContext = StellarRPCJsonContext.Default;

    public StellarRPCClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Clients can request a filtered list of events emitted by a given ledger range.
    /// Stellar-RPC will support querying within a maximum 7 days of recent ledgers.
    /// Note, this could be used by the client to only prompt a refresh when there is a new ledger with relevant events. It should also be used by backend Dapp components to &quot;ingest&quot; events into their own database for querying and serving.
    /// If making multiple requests, clients should deduplicate any events received, based on the event&apos;s unique id field. This prevents double-processing in the case of duplicate events being received.
    /// By default soroban-rpc retains the most recent 24 hours of events.
    /// </summary>
    public async Task<GetEventsResult> GetEventsAsync(GetEventsParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getEvents",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetEventsResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetEventsResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Statistics for charged inclusion fees. The inclusion fee statistics are calculated from the inclusion fees that were paid for the transactions to be included onto the ledger. For Soroban transactions and Stellar transactions, they each have their own inclusion fees and own surge pricing. Inclusion fees are used to prevent spam and prioritize transactions during network traffic surge.
    /// </summary>
    public async Task<GetFeeStatsResult> GetFeeStatsAsync()
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getFeeStats",
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetFeeStatsResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetFeeStatsResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// General node health check.
    /// </summary>
    public async Task<GetHealthResult> GetHealthAsync()
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getHealth",
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetHealthResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetHealthResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// For finding out the current latest known ledger of this node. This is a subset of the ledger info from Horizon.
    /// </summary>
    public async Task<GetLatestLedgerResult> GetLatestLedgerAsync()
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getLatestLedger",
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetLatestLedgerResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetLatestLedgerResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// For reading the current value of ledger entries directly.
    /// This method enables the retrieval of various ledger states, such as accounts, trustlines, offers, data, claimable balances, and liquidity pools. It also provides direct access to inspect a contract&apos;s current state, its code, or any other ledger entry. This serves as a primary method to access your contract data which may not be available via events or `simulateTransaction`.
    /// To fetch contract wasm byte-code, use the ContractCode ledger entry key.
    /// </summary>
    public async Task<GetLedgerEntriesResult> GetLedgerEntriesAsync(GetLedgerEntriesParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getLedgerEntries",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetLedgerEntriesResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetLedgerEntriesResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// General information about the currently configured network. This response will contain all the information needed to successfully submit transactions to the network this node serves.
    /// </summary>
    public async Task<GetNetworkResult> GetNetworkAsync()
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getNetwork",
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetNetworkResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetNetworkResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// The getTransaction method provides details about the specified transaction. Clients are expected to periodically query this method to ascertain when a transaction has been successfully recorded on the blockchain. The stellar-rpc system maintains a restricted history of recently processed transactions, with the default retention window set at 1440 ledgers, approximately equivalent to a 2-hour timeframe. For private stellar-rpc instances, it is possible to modify the retention window value by adjusting the transaction-retention-window configuration setting. For comprehensive debugging needs that extend beyond the 2-hour timeframe, it is advisable to retrieve transaction information from Horizon, as it provides a lasting and persistent record.
    /// </summary>
    public async Task<GetTransactionResult> GetTransactionAsync(GetTransactionParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getTransaction",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetTransactionResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetTransactionResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// The `getTransactions` method return a detailed list of transactions starting from the user specified starting point that you can paginate as long as the pages fall within the history retention of their corresponding RPC provider.
    /// </summary>
    public async Task<GetTransactionsResult> GetTransactionsAsync(GetTransactionsParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getTransactions",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetTransactionsResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetTransactionsResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Version information about the RPC and Captive core. RPC manages its own, pared-down version of Stellar Core optimized for its own subset of needs. we&apos;ll refer to this as a &quot;Captive Core&quot; instance.
    /// </summary>
    public async Task<GetVersionInfoResult> GetVersionInfoAsync()
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getVersionInfo",
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<GetVersionInfoResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<GetVersionInfoResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Submit a real transaction to the Stellar network. This is the only way to make changes on-chain.
    /// Unlike Horizon, this does not wait for transaction completion. It simply validates and enqueues the transaction. Clients should call `getTransaction` to learn about transaction success/failure.
    /// This supports all transactions, not only smart contract-related transactions.
    /// </summary>
    public async Task<SendTransactionResult> SendTransactionAsync(SendTransactionParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "sendTransaction",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<SendTransactionResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<SendTransactionResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Submit a trial contract invocation to simulate how it would be executed by the network. This endpoint calculates the effective transaction data, required authorizations, and minimal resource fee. It provides a way to test and analyze the potential outcomes of a transaction without actually submitting it to the network.
    /// </summary>
    public async Task<SimulateTransactionResult> SimulateTransactionAsync(SimulateTransactionParams parameters)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "simulateTransaction",
            Params = parameters,
            Id = 1
        };

        var requestJson = JsonSerializer.Serialize(request, _jsonContext.JsonRpcRequest);
        var response = await _httpClient.PostAsync("", 
            new StringContent(
                requestJson,
                Encoding.UTF8,
                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json")));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var jsonTypeInfo = _jsonContext.GetTypeInfo(typeof(JsonRpcResponse<SimulateTransactionResult>));
        var rpcResponse = JsonSerializer.Deserialize(content, jsonTypeInfo) as JsonRpcResponse<SimulateTransactionResult>;

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

}
}
