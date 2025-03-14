using System.Text.Json.Serialization;

namespace Stellar.RPC
{
    /// <summary>
    /// JSON source generator context for the Stellar RPC API.
    /// This class provides AOT-compatible serialization for System.Text.Json.
    /// </summary>
    [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonSerializable(typeof(JsonRpcRequest))]
    [JsonSerializable(typeof(JsonRpcError))]
    [JsonSerializable(typeof(GetEventsParams))]
    [JsonSerializable(typeof(JsonRpcResponse<GetEventsParams>))]
    [JsonSerializable(typeof(Filters))]
    [JsonSerializable(typeof(JsonRpcResponse<Filters>))]
    [JsonSerializable(typeof(Pagination))]
    [JsonSerializable(typeof(JsonRpcResponse<Pagination>))]
    [JsonSerializable(typeof(GetEventsResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetEventsResult>))]
    [JsonSerializable(typeof(Events))]
    [JsonSerializable(typeof(JsonRpcResponse<Events>))]
    [JsonSerializable(typeof(Events_Type))]
    [JsonSerializable(typeof(JsonRpcResponse<Events_Type>))]
    [JsonSerializable(typeof(GetFeeStatsResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetFeeStatsResult>))]
    [JsonSerializable(typeof(SorobanInclusionFee))]
    [JsonSerializable(typeof(JsonRpcResponse<SorobanInclusionFee>))]
    [JsonSerializable(typeof(InclusionFee))]
    [JsonSerializable(typeof(JsonRpcResponse<InclusionFee>))]
    [JsonSerializable(typeof(GetHealthResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetHealthResult>))]
    [JsonSerializable(typeof(GetLatestLedgerResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetLatestLedgerResult>))]
    [JsonSerializable(typeof(GetLedgerEntriesParams))]
    [JsonSerializable(typeof(JsonRpcResponse<GetLedgerEntriesParams>))]
    [JsonSerializable(typeof(GetLedgerEntriesResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetLedgerEntriesResult>))]
    [JsonSerializable(typeof(Entries))]
    [JsonSerializable(typeof(JsonRpcResponse<Entries>))]
    [JsonSerializable(typeof(GetNetworkResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetNetworkResult>))]
    [JsonSerializable(typeof(GetTransactionParams))]
    [JsonSerializable(typeof(JsonRpcResponse<GetTransactionParams>))]
    [JsonSerializable(typeof(GetTransactionResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetTransactionResult>))]
    [JsonSerializable(typeof(GetTransactionResult_Status))]
    [JsonSerializable(typeof(JsonRpcResponse<GetTransactionResult_Status>))]
    [JsonSerializable(typeof(GetTransactionsParams))]
    [JsonSerializable(typeof(JsonRpcResponse<GetTransactionsParams>))]
    [JsonSerializable(typeof(GetTransactionsResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetTransactionsResult>))]
    [JsonSerializable(typeof(Transactions))]
    [JsonSerializable(typeof(JsonRpcResponse<Transactions>))]
    [JsonSerializable(typeof(GetVersionInfoResult))]
    [JsonSerializable(typeof(JsonRpcResponse<GetVersionInfoResult>))]
    [JsonSerializable(typeof(SendTransactionParams))]
    [JsonSerializable(typeof(JsonRpcResponse<SendTransactionParams>))]
    [JsonSerializable(typeof(SendTransactionResult))]
    [JsonSerializable(typeof(JsonRpcResponse<SendTransactionResult>))]
    [JsonSerializable(typeof(SendTransactionResult_Status))]
    [JsonSerializable(typeof(JsonRpcResponse<SendTransactionResult_Status>))]
    [JsonSerializable(typeof(SimulateTransactionParams))]
    [JsonSerializable(typeof(JsonRpcResponse<SimulateTransactionParams>))]
    [JsonSerializable(typeof(ResourceConfigResourceConfig))]
    [JsonSerializable(typeof(JsonRpcResponse<ResourceConfigResourceConfig>))]
    [JsonSerializable(typeof(SimulateTransactionResult))]
    [JsonSerializable(typeof(JsonRpcResponse<SimulateTransactionResult>))]
    [JsonSerializable(typeof(Cost))]
    [JsonSerializable(typeof(JsonRpcResponse<Cost>))]
    [JsonSerializable(typeof(Results))]
    [JsonSerializable(typeof(JsonRpcResponse<Results>))]
    [JsonSerializable(typeof(RestorePreamble))]
    [JsonSerializable(typeof(JsonRpcResponse<RestorePreamble>))]
    [JsonSerializable(typeof(StateChanges))]
    [JsonSerializable(typeof(JsonRpcResponse<StateChanges>))]
    [JsonSerializable(typeof(StateChanges_Type))]
    [JsonSerializable(typeof(JsonRpcResponse<StateChanges_Type>))]
    public partial class StellarRPCJsonContext : JsonSerializerContext
    {
    }
}
