//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetLatestLedgerResult
    {
        /// <summary>
        /// Hash identifier of the latest ledger (as a hex-encoded string) known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.StringLength(64, MinimumLength = 64)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[a-f\d]{64}$")]
        public string Id { get; set; }

        /// <summary>
        /// Stellar Core protocol version associated with the latest ledger.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
        public long ProtocolVersion { get; set; }

        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sequence")]
        public long Sequence { get; set; }



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
        public static GetLatestLedgerResult FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetLatestLedgerResult>(data, options);

        }

    }
}