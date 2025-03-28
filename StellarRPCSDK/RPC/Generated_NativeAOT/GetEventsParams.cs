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
    [ProtoBuf.ProtoContract] public partial class GetEventsParams
    {
        /// <summary>
        /// Sequence number of the ledger.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("startLedger")]
        [ProtoBuf.ProtoMember(1)] public long  StartLedger { get; set; }


        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        [ProtoBuf.ProtoMember(2)] public System.Collections.Generic.List<Filters>  Filters { get; set; }


        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [ProtoBuf.ProtoMember(3)] public Pagination  Pagination { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class Filters
    {
        /// <summary>
        /// A comma separated list of event types (system, contract, or diagnostic) used to filter events. If omitted, all event types are included.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [ProtoBuf.ProtoMember(1)] public string  Type { get; set; }

        /// <summary>
        /// List of contract IDs to query for events. If omitted, return events for all contracts. Maximum 5 contract IDs are allowed per request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contractIds")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        [ProtoBuf.ProtoMember(2)] public System.Collections.Generic.List<string>  ContractIds { get; set; }

        /// <summary>
        /// List of topic filters. If omitted, query for all events. If multiple filters are specified, events will be included if they match any of the filters. Maximum 5 filters are allowed per request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("topics")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> Topics { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class Pagination
    {
        /// <summary>
        /// A unique identifier (specifically, a [TOID](https://github.com/stellar/stellar-protocol/blob/master/ecosystem/sep-0035.md#specification)) that points to a specific location in a collection of responses and is pulled from the `paging_token` value of a record. When a cursor is provided, RPC will _not_ include the element whose ID matches the cursor in the response: only elements which appear _after_ the cursor will be included.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        [ProtoBuf.ProtoMember(1)] public string  Cursor { get; set; }

        /// <summary>
        /// The maximum number of records returned. The limit for getEvents can range from 1 to 10000 - an upper limit that is hardcoded in Stellar-RPC for performance reasons. If this argument isn't designated, it defaults to 100.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        [ProtoBuf.ProtoMember(2)] public long  Limit { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}