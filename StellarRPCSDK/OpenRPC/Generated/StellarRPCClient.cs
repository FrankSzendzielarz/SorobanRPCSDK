using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Threading.Tasks;
using Stellar.RPC;

/// <summary>
/// Stellar-RPC allows you to communicate directly with Soroban via a JSON RPC interface.
/// </summary>
public class StellarRPCClient
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public StellarRPCClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    /// <summary>
    /// Clients can request a filtered list of events emitted by a given ledger range.
    /// Stellar-RPC will support querying within a maximum 7 days of recent ledgers.
    /// Note, this could be used by the client to only prompt a refresh when there is a new ledger with relevant events. It should also be used by backend Dapp components to &quot;ingest&quot; events into their own database for querying and serving.
    /// If making multiple requests, clients should deduplicate any events received, based on the event&apos;s unique id field. This prevents double-processing in the case of duplicate events being received.
    /// By default soroban-rpc retains the most recent 24 hours of events.
    /// </summary>
    public async Task<GeteventsResult> GeteventsAsync(GeteventsParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getEvents",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GeteventsResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Statistics for charged inclusion fees. The inclusion fee statistics are calculated from the inclusion fees that were paid for the transactions to be included onto the ledger. For Soroban transactions and Stellar transactions, they each have their own inclusion fees and own surge pricing. Inclusion fees are used to prevent spam and prioritize transactions during network traffic surge.
    /// </summary>
    public async Task<GetfeestatsResult> GetfeestatsAsync(object parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getFeeStats",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GetfeestatsResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// General node health check.
    /// </summary>
    public async Task<GethealthResult> GethealthAsync(object parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getHealth",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GethealthResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// For finding out the current latest known ledger of this node. This is a subset of the ledger info from Horizon.
    /// </summary>
    public async Task<GetlatestledgerResult> GetlatestledgerAsync(object parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getLatestLedger",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GetlatestledgerResult>>(content, _jsonOptions);

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
    public async Task<GetledgerentriesResult> GetledgerentriesAsync(GetledgerentriesParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getLedgerEntries",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GetledgerentriesResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// General information about the currently configured network. This response will contain all the information needed to successfully submit transactions to the network this node serves.
    /// </summary>
    public async Task<GetnetworkResult> GetnetworkAsync(object parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getNetwork",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GetnetworkResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// The getTransaction method provides details about the specified transaction. Clients are expected to periodically query this method to ascertain when a transaction has been successfully recorded on the blockchain. The stellar-rpc system maintains a restricted history of recently processed transactions, with the default retention window set at 1440 ledgers, approximately equivalent to a 2-hour timeframe. For private stellar-rpc instances, it is possible to modify the retention window value by adjusting the transaction-retention-window configuration setting. For comprehensive debugging needs that extend beyond the 2-hour timeframe, it is advisable to retrieve transaction information from Horizon, as it provides a lasting and persistent record.
    /// </summary>
    public async Task<GettransactionResult> GettransactionAsync(GettransactionParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getTransaction",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GettransactionResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// The `getTransactions` method return a detailed list of transactions starting from the user specified starting point that you can paginate as long as the pages fall within the history retention of their corresponding RPC provider.
    /// </summary>
    public async Task<GettransactionsResult> GettransactionsAsync(GettransactionsParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getTransactions",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GettransactionsResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Version information about the RPC and Captive core. RPC manages its own, pared-down version of Stellar Core optimized for its own subset of needs. we&apos;ll refer to this as a &quot;Captive Core&quot; instance.
    /// </summary>
    public async Task<GetversioninfoResult> GetversioninfoAsync(object parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "getVersionInfo",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<GetversioninfoResult>>(content, _jsonOptions);

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
    public async Task<SendtransactionResult> SendtransactionAsync(SendtransactionParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "sendTransaction",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<SendtransactionResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

    /// <summary>
    /// Submit a trial contract invocation to simulate how it would be executed by the network. This endpoint calculates the effective transaction data, required authorizations, and minimal resource fee. It provides a way to test and analyze the potential outcomes of a transaction without actually submitting it to the network.
    /// </summary>
    public async Task<SimulatetransactionResult> SimulatetransactionAsync(SimulatetransactionParams parameters = null)
    {
        var request = new JsonRpcRequest
        {
            JsonRpc = "2.0",
            Method = "simulateTransaction",
            Params = parameters,
            Id = 1
        };

        var response = await _httpClient.PostAsync("", 
            new StringContent(
                JsonSerializer.Serialize(request, _jsonOptions),
                Encoding.UTF8,
                "application/json"));

        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<SimulatetransactionResult>>(content, _jsonOptions);

        if (rpcResponse.Error != null)
        {
            throw new JsonRpcException(rpcResponse.Error);
        }

        return rpcResponse.Result;
    }

}
