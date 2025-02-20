//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetHealthResult
    {
        /// <summary>
        /// "healthy"
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [ProtoBuf.ProtoMember(1)] public string  Status { get; set; }

        /// <summary>
        /// Most recent known ledger sequence
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedger")]
        [ProtoBuf.ProtoMember(2)] public long  LatestLedger { get; set; }

        /// <summary>
        /// Oldest ledger sequence kept in history
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("oldestLedger")]
        [ProtoBuf.ProtoMember(3)] public long  OldestLedger { get; set; }

        /// <summary>
        /// Maximum retention window configured. A full window state can be determined via: ledgerRetentionWindow = latestLedger - oldestLedger + 1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledgerRetentionWindow")]
        [ProtoBuf.ProtoMember(4)] public long  LedgerRetentionWindow { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}