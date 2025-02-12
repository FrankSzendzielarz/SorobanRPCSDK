//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Parameters for getLedgerEntries method
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class GetLedgerEntriesParams
    {
        /// <summary>
        /// Array containing the keys of the ledger entries you wish to retrieve. (an array of serialized base64 strings)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keys", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> Keys { get; set; } = new System.Collections.ObjectModel.Collection<string>();



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
        public static GetLedgerEntriesParams FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetLedgerEntriesParams>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}