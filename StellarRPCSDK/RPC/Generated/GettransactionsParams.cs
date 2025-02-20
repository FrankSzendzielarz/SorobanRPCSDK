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

        [System.Text.Json.Serialization.JsonPropertyName("startLedger")]
        [ProtoBuf.ProtoMember(1)] public long  StartLedger { get; set; }


        [System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [ProtoBuf.ProtoMember(2)] public Pagination  Pagination { get; set; }



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
        public static GetTransactionsParams FromJson(string data)
        {

            var options = new System.Text.Json.JsonSerializerOptions();

            return System.Text.Json.JsonSerializer.Deserialize<GetTransactionsParams>(data, options);

        }

    }

    
}