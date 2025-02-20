//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetFeeStatsResult
    {
        /// <summary>
        /// Inclusion fee distribution statistics for Soroban transactions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sorobanInclusionFee")]
        [ProtoBuf.ProtoMember(1)] public SorobanInclusionFee  SorobanInclusionFee { get; set; }

        /// <summary>
        /// Fee distribution statistics for Stellar (i.e. non-Soroban) transactions. Statistics are normalized per operation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("inclusionFee")]
        [ProtoBuf.ProtoMember(2)] public InclusionFee  InclusionFee { get; set; }

        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedger")]
        [ProtoBuf.ProtoMember(3)] public long  LatestLedger { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Serialize(this, options);

        }
        public static GetFeeStatsResult FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetFeeStatsResult>(data, options);

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class SorobanInclusionFee
    {
        /// <summary>
        /// Maximum fee
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("max")]
        [ProtoBuf.ProtoMember(1)] public string  Max { get; set; }

        /// <summary>
        /// Minimum fee
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("min")]
        [ProtoBuf.ProtoMember(2)] public string  Min { get; set; }

        /// <summary>
        /// Fee value which occurs the most often
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        [ProtoBuf.ProtoMember(3)] public string  Mode { get; set; }

        /// <summary>
        /// 10th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p10")]
        [ProtoBuf.ProtoMember(4)] public string  P10 { get; set; }

        /// <summary>
        /// 20th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p20")]
        [ProtoBuf.ProtoMember(5)] public string  P20 { get; set; }

        /// <summary>
        /// 30th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p30")]
        [ProtoBuf.ProtoMember(6)] public string  P30 { get; set; }

        /// <summary>
        /// 40th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p40")]
        [ProtoBuf.ProtoMember(7)] public string  P40 { get; set; }

        /// <summary>
        /// 50th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p50")]
        [ProtoBuf.ProtoMember(8)] public string  P50 { get; set; }

        /// <summary>
        /// 60th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p60")]
        [ProtoBuf.ProtoMember(9)] public string  P60 { get; set; }

        /// <summary>
        /// 70th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p70")]
        [ProtoBuf.ProtoMember(10)] public string  P70 { get; set; }

        /// <summary>
        /// 80th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p80")]
        [ProtoBuf.ProtoMember(11)] public string  P80 { get; set; }

        /// <summary>
        /// 90th nearest-rank fee percentile.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p90")]
        [ProtoBuf.ProtoMember(12)] public string  P90 { get; set; }

        /// <summary>
        /// 95th nearest-rank fee percentile.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p95")]
        [ProtoBuf.ProtoMember(13)] public string  P95 { get; set; }

        /// <summary>
        /// 99th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p99")]
        [ProtoBuf.ProtoMember(14)] public string  P99 { get; set; }

        /// <summary>
        /// How many transactions are part of the distribution
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("transactionCount")]
        [ProtoBuf.ProtoMember(15)] public string  TransactionCount { get; set; }

        /// <summary>
        /// How many consecutive ledgers form the distribution
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledgerCount")]
        [ProtoBuf.ProtoMember(16)] public long  LedgerCount { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Serialize(this, options);

        }
        public static SorobanInclusionFee FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<SorobanInclusionFee>(data, options);

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class InclusionFee
    {
        /// <summary>
        /// Maximum fee
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("max")]
        [ProtoBuf.ProtoMember(1)] public string  Max { get; set; }

        /// <summary>
        /// Minimum fee
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("min")]
        [ProtoBuf.ProtoMember(2)] public string  Min { get; set; }

        /// <summary>
        /// Fee value which occurs the most often
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        [ProtoBuf.ProtoMember(3)] public string  Mode { get; set; }

        /// <summary>
        /// 10th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p10")]
        [ProtoBuf.ProtoMember(4)] public string  P10 { get; set; }

        /// <summary>
        /// 20th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p20")]
        [ProtoBuf.ProtoMember(5)] public string  P20 { get; set; }

        /// <summary>
        /// 30th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p30")]
        [ProtoBuf.ProtoMember(6)] public string  P30 { get; set; }

        /// <summary>
        /// 40th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p40")]
        [ProtoBuf.ProtoMember(7)] public string  P40 { get; set; }

        /// <summary>
        /// 50th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p50")]
        [ProtoBuf.ProtoMember(8)] public string  P50 { get; set; }

        /// <summary>
        /// 60th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p60")]
        [ProtoBuf.ProtoMember(9)] public string  P60 { get; set; }

        /// <summary>
        /// 70th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p70")]
        [ProtoBuf.ProtoMember(10)] public string  P70 { get; set; }

        /// <summary>
        /// 80th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p80")]
        [ProtoBuf.ProtoMember(11)] public string  P80 { get; set; }

        /// <summary>
        /// 90th nearest-rank fee percentile.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p90")]
        [ProtoBuf.ProtoMember(12)] public string  P90 { get; set; }

        /// <summary>
        /// 95th nearest-rank fee percentile.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p95")]
        [ProtoBuf.ProtoMember(13)] public string  P95 { get; set; }

        /// <summary>
        /// 99th nearest-rank fee percentile
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("p99")]
        [ProtoBuf.ProtoMember(14)] public string  P99 { get; set; }

        /// <summary>
        /// How many transactions are part of the distribution
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("transactionCount")]
        [ProtoBuf.ProtoMember(15)] public string  TransactionCount { get; set; }

        /// <summary>
        /// How many consecutive ledgers form the distribution
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledgerCount")]
        [ProtoBuf.ProtoMember(16)] public long  LedgerCount { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Serialize(this, options);

        }
        public static InclusionFee FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<InclusionFee>(data, options);

        }

    }
}