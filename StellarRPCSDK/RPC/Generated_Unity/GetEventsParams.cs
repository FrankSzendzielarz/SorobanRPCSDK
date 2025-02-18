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
        [Newtonsoft.Json.JsonProperty("startLedger", Required = Newtonsoft.Json.Required.Always)]
        public long StartLedger { get; set; }

        /// <summary>
        /// List of filters for the returned events. Events matching any of the filters are included. To match a filter, an event must match both a contractId and a topic. Maximum 5 filters are allowed per request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

        /// <summary>
        /// Pagination in stellar-rpc is similar to pagination in Horizon. See [Pagination](https://developers.stellar.org/docs/data/rpc/api-reference/pagination).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pagination", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Pagination { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static GetEventsParams FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetEventsParams>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}