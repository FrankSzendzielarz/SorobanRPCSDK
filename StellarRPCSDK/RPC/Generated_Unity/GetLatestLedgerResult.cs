//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [ProtoBuf.ProtoContract] public partial class GetLatestLedgerResult
    {
        /// <summary>
        /// Hash identifier of the latest ledger (as a hex-encoded string) known to Stellar RPC at the time it handled the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(64, MinimumLength = 64)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[a-f\d]{64}$")]
        [ProtoBuf.ProtoMember(1)] public string  Id { get; set; }

        /// <summary>
        /// Stellar Core protocol version associated with the latest ledger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("protocolVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [ProtoBuf.ProtoMember(2)] public long  ProtocolVersion { get; set; }

        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequence", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [ProtoBuf.ProtoMember(3)] public long  Sequence { get; set; }



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
        public static GetLatestLedgerResult FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetLatestLedgerResult>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}