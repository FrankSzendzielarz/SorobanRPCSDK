//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Parameters for getTransactions method
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetTransactionsParams
    {
        /// <summary>
        /// Sequence number of the ledger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startLedger", Required = Newtonsoft.Json.Required.Always)]
        [ProtoBuf.ProtoMember(1)] public long  StartLedger { get; set; }

        [Newtonsoft.Json.JsonProperty("pagination", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [ProtoBuf.ProtoMember(2)] public Pagination  Pagination { get; set; }



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
        public static GetTransactionsParams FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetTransactionsParams>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class Pagination
    {
        /// <summary>
        /// A unique identifier (specifically, a [TOID](https://github.com/stellar/stellar-protocol/blob/master/ecosystem/sep-0035.md#specification)) that points to a specific location in a collection of responses and is pulled from the `paging_token` value of a record. When a cursor is provided, RPC will _not_ include the element whose ID matches the cursor in the response: only elements which appear _after_ the cursor will be included.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [ProtoBuf.ProtoMember(1)] public string  Cursor { get; set; }

        /// <summary>
        /// The maximum number of records returned. For getTransactions, this ranges from 1 to 200 and defaults to 50.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [ProtoBuf.ProtoMember(2)] public long  Limit { get; set; }



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
        public static Pagination FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Pagination>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}