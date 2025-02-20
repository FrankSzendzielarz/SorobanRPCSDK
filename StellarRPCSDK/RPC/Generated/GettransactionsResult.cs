//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetTransactionsResult
    {

        [System.Text.Json.Serialization.JsonPropertyName("transactions")]
        [ProtoBuf.ProtoMember(1)] public System.Collections.Generic.ICollection<Transactions>  Transactions { get; set; }

        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedger")]
        [ProtoBuf.ProtoMember(2)] public long  LatestLedger { get; set; }

        /// <summary>
        /// The unix timestamp of the close time of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedgerCloseTimestamp")]
        [ProtoBuf.ProtoMember(3)] public long  LatestLedgerCloseTimestamp { get; set; }

        /// <summary>
        /// The sequence number of the oldest ledger ingested by Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("oldestLedger")]
        [ProtoBuf.ProtoMember(4)] public long  OldestLedger { get; set; }

        /// <summary>
        /// The unix timestamp of the close time of the oldest ledger ingested by Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("oldestLedgerCloseTimestamp")]
        [ProtoBuf.ProtoMember(5)] public long  OldestLedgerCloseTimestamp { get; set; }



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
        public static GetTransactionsResult FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetTransactionsResult>(data, options);

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class Transactions
    {
        /// <summary>
        /// Indicates whether the transaction was successful or not.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [ProtoBuf.ProtoMember(1)] public string  Status { get; set; }

        /// <summary>
        /// The 1-based index of the transaction among all transactions included in the ledger.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("applicationOrder")]
        [ProtoBuf.ProtoMember(2)] public long  ApplicationOrder { get; set; }

        /// <summary>
        /// Indicates whether the transaction was fee bumped.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("feeBump")]
        [ProtoBuf.ProtoMember(3)] public bool  FeeBump { get; set; }

        /// <summary>
        /// A base64 encoded string of the raw TransactionEnvelope XDR struct for this transaction.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("envelopeXdr")]
        [ProtoBuf.ProtoMember(4)] public string  EnvelopeXdr { get; set; }

        /// <summary>
        /// A base64 encoded string of the raw TransactionResult XDR struct for this transaction.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("resultXdr")]
        [ProtoBuf.ProtoMember(5)] public string  ResultXdr { get; set; }

        /// <summary>
        /// A base64 encoded string of the raw TransactionMeta XDR struct for this transaction.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("resultMetaXdr")]
        [ProtoBuf.ProtoMember(6)] public string  ResultMetaXdr { get; set; }

        /// <summary>
        /// (optional) A base64 encoded slice of xdr.DiagnosticEvent. This is only present if the `ENABLE_SOROBAN_DIAGNOSTIC_EVENTS` has been enabled in the stellar-core config.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("diagnosticEventsXdr")]
        [ProtoBuf.ProtoMember(7)] public System.Collections.Generic.ICollection<string>  DiagnosticEventsXdr { get; set; }

        /// <summary>
        /// The sequence number of the ledger which included the transaction.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledger")]
        [ProtoBuf.ProtoMember(8)] public long  Ledger { get; set; }

        /// <summary>
        /// The unix timestamp of when the transaction was included in the ledger.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [ProtoBuf.ProtoMember(9)] public long  CreatedAt { get; set; }



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
        public static Transactions FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<Transactions>(data, options);

        }

    }
}