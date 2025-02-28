//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetEventsResult
    {
        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latestLedger")]
        [ProtoBuf.ProtoMember(1)] public long  LatestLedger { get; set; }


        [System.Text.Json.Serialization.JsonPropertyName("events")]
        [ProtoBuf.ProtoMember(2)] public System.Collections.Generic.List<Events>  Events { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class Events
    {
        /// <summary>
        /// The type of event emission.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        [ProtoBuf.ProtoMember(1)] public Events_Type  Type { get; set; }

        /// <summary>
        /// Sequence number of the ledger in which this event was emitted.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledger")]
        [ProtoBuf.ProtoMember(2)] public long  Ledger { get; set; }

        /// <summary>
        /// [ISO-8601](https://www.iso.org/iso-8601-date-and-time-format.html) timestamp of the ledger closing time
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ledgerClosedAt")]
        [ProtoBuf.ProtoMember(3)] public string  LedgerClosedAt { get; set; }

        /// <summary>
        /// StrKey representation of the contract address that emitted this event.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contractId")]
        [ProtoBuf.ProtoMember(4)] public string  ContractId { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// <br/>
        /// <br/>- The event's unique id field is based on a [`toid` from Horizon](https://github.com/stellar/go/blob/master/toid/main.go) as used in Horizon's /effects endpoint.
        /// <br/>
        /// <br/>- https://github.com/stellar/go/blob/master/services/horizon/internal/db2/history/effect.go#L58
        /// <br/>
        /// <br/>- Specifically, it is a string containing:
        /// <br/>
        /// <br/>- bigint(32 bit ledger sequence + 20 bit txn number + 12 bit operation) + `&lt;hyphen&gt;` + number for the event within the operation.
        /// <br/>
        /// <br/>- For example: `1234-1`
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [ProtoBuf.ProtoMember(5)] public string  Id { get; set; }

        /// <summary>
        /// Duplicate of `id` field, but in the standard place for pagination tokens.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pagingToken")]
        [ProtoBuf.ProtoMember(6)] public string  PagingToken { get; set; }

        /// <summary>
        /// If true the event was emitted during a successful contract call.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("inSuccessfulContractCall")]
        [ProtoBuf.ProtoMember(7)] public bool  InSuccessfulContractCall { get; set; }

        /// <summary>
        /// List containing the topic this event was emitted with.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("topic")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(4)]
        [ProtoBuf.ProtoMember(8)] public System.Collections.Generic.List<string>  Topic { get; set; }

        /// <summary>
        /// The emitted body value of the event (serialized in a base64 string).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [ProtoBuf.ProtoMember(9)] public string  Value { get; set; }

        /// <summary>
        /// The transaction which triggered this event.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("txHash")]
        [System.ComponentModel.DataAnnotations.StringLength(64, MinimumLength = 64)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[a-f\d]{64}$")]
        [ProtoBuf.ProtoMember(10)] public string  TxHash { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public enum Events_Type
    {

        [System.Runtime.Serialization.EnumMember(Value = @"contract")]
        Contract = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"diagnostic")]
        Diagnostic = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"system")]
        System = 2,


    }
}