//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Parameters for getEvents method
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetEventsParams
    {
        /// <summary>
        /// Ledger sequence number to start fetching responses from (inclusive). This method will return an error if `startLedger` is less than the oldest ledger stored in this node, or greater than the latest ledger seen by this node. If a cursor is included in the request, `startLedger` must be omitted.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("startLedger")]
        public double StartLedger { get; set; }

        /// <summary>
        /// List of filters for the returned events. Events matching any of the filters are included. To match a filter, an event must match both a contractId and a topic. Maximum 5 filters are allowed per request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

        /// <summary>
        /// Pagination in stellar-rpc is similar to pagination in Horizon. See [Pagination](https://developers.stellar.org/docs/data/rpc/api-reference/pagination).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public object Pagination { get; set; }



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
        public static GetEventsParams FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetEventsParams>(data, options);

        }

    }
}