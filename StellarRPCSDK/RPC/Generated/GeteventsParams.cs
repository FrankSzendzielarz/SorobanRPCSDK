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
        [ProtoBuf.ProtoMember(2)] public System.Collections.Generic.ICollection<Filters>  Filters { get; set; }


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
        [ProtoBuf.ProtoMember(2)] public System.Collections.Generic.ICollection<string>  ContractIds { get; set; }

        /// <summary>
        /// List of topic filters. If omitted, query for all events. If multiple filters are specified, events will be included if they match any of the filters. Maximum 5 filters are allowed per request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("topics")]
        [System.ComponentModel.DataAnnotations.MaxLength(5)]
        public System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<string>> Topics { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

  
}