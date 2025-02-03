//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetHealthResult
    {
        /// <summary>
        /// "healthy"
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Most recent known ledger sequence
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedger")]
        public double LatestLedger { get; set; }

        /// <summary>
        /// Oldest ledger sequence kept in history
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("oldestLedger")]
        public double OldestLedger { get; set; }

        /// <summary>
        /// Maximum retention window configured. A full window state can be determined via: ledgerRetentionWindow = latestLedger - oldestLedger + 1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledgerRetentionWindow")]
        public double LedgerRetentionWindow { get; set; }



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
        public static GetHealthResult FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetHealthResult>(data, options);

        }

    }
}