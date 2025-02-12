//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Stellar.RPC
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SimulateTransactionResult
    {
        /// <summary>
        /// The sequence number of the latest ledger known to Stellar RPC at the time it handled the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latestLedger", Required = Newtonsoft.Json.Required.Always)]
        public long LatestLedger { get; set; }

        /// <summary>
        /// (optional) Stringified number - Recommended minimum resource fee to add when submitting the transaction. This fee is to be added on top of the [Stellar network fee](https://developers.stellar.org/docs/learn/fundamentals/fees-resource-limits-metering#inclusion-fee). Not present in case of error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minResourceFee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinResourceFee { get; set; }

        /// <summary>
        /// (optional) - The cost object is legacy, inaccurate, and will be deprecated in future RPC releases. Please decode transactionData XDR to retrieve the correct resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Cost Cost { get; set; }

        /// <summary>
        /// (optional) - This array will only have one element: the result for the Host Function invocation. Only present on successful simulation (i.e. no error) of `InvokeHostFunction` operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("results", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Results> Results { get; set; }

        /// <summary>
        /// (optional) Serialized base64 string - The recommended Soroban Transaction Data to use when submitting the simulated transaction. This data contains the refundable fee and resource usage information such as the ledger footprint and IO access data (serialized in a base64 string). Not present in case of error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactionData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionData { get; set; }

        /// <summary>
        /// (optional) Array of serialized base64 strings - Array of the events emitted during the contract invocation. The events are ordered by their emission time. (an array of serialized base64 strings). Only present when simulating of `InvokeHostFunction` operations, note that it can be present on error, providing extra context about what failed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("events", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Events { get; set; }

        /// <summary>
        /// (optional) - It can only be present on successful simulation (i.e. no error) of `InvokeHostFunction` operations. If present, it indicates that the simulation detected archived ledger entries which need to be restored before the submission of the `InvokeHostFunction` operation. The `minResourceFee` and `transactionData` fields should be used to submit a transaction containing a `RestoreFootprint` operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restorePreamble", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RestorePreamble RestorePreamble { get; set; }

        /// <summary>
        /// (optional) - On successful simulation of `InvokeHostFunction` operations, this field will be an array of `LedgerEntry`s before and after simulation occurred. Note that _at least_ one of `before` or `after` will be present: `before` and no `after` indicates a deletion event, the inverse is a creation event, and both present indicates an update event. Or just check the `type`.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stateChanges", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StateChanges> StateChanges { get; set; }

        /// <summary>
        /// (optional) - This field will include details about why the invoke host function call failed. Only present if the transaction simulation failed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Error { get; set; }



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
        public static SimulateTransactionResult FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SimulateTransactionResult>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Cost
    {
        /// <summary>
        /// Stringified number - Total cpu instructions consumed by this transaction
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpuInsns", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CpuInsns { get; set; }

        /// <summary>
        /// Stringified number - Total memory bytes allocated by this transaction
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memBytes", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MemBytes { get; set; }



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
        public static Cost FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Cost>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Results
    {
        /// <summary>
        /// Serialized base64 string - return value of the Host Function call.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xdr", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Xdr { get; set; }

        /// <summary>
        /// Array of serialized base64 strings - Per-address authorizations recorded when simulating this Host Function call.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> Auth { get; set; } = new System.Collections.ObjectModel.Collection<string>();



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
        public static Results FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Results>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RestorePreamble
    {
        /// <summary>
        /// Stringified number - Recommended minimum resource fee to add when submitting the `RestoreFootprint` operation. This fee is to be added on top of the [Stellar network fee](https://developers.stellar.org/docs/learn/fundamentals/fees-resource-limits-metering#inclusion-fee).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minResourceFee", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MinResourceFee { get; set; }

        /// <summary>
        /// Serialized base64 string - The recommended Soroban Transaction Data to use when submitting the `RestoreFootprint` operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactionData", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TransactionData { get; set; }



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
        public static RestorePreamble FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<RestorePreamble>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class StateChanges
    {
        /// <summary>
        /// Indicates if the entry was created (1), updated (2), or deleted (3)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public StateChangesType Type { get; set; }

        /// <summary>
        /// Base64 - the `LedgerKey` for this delta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Key { get; set; }

        /// <summary>
        /// Base64, if present - `LedgerEntry` state prior to simulation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("before", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Before { get; set; }

        /// <summary>
        /// Base64, if present - `LedgerEntry` state after simulation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after", Required = Newtonsoft.Json.Required.AllowNull)]
        public string After { get; set; }



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
        public static StateChanges FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<StateChanges>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum StateChangesType
    {

        _1 = 1,


        _2 = 2,


        _3 = 3,


    }
}