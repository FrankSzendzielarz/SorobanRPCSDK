#if UNITY || TIZEN
using Newtonsoft.Json;
#else
using System.Text.Json.Serialization;
#endif
using System;

namespace Stellar.RPC
{
    public class JsonRpcRequest
    {
#if UNITY || TIZEN
        [JsonProperty("jsonrpc")]
#else
        [JsonPropertyName("jsonrpc")]
#endif
        public string JsonRpc { get; set; } = "2.0";

#if UNITY || TIZEN
        [JsonProperty("method")]
#else
        [JsonPropertyName("method")]
#endif
        public string Method { get; set; } = "";

#if UNITY || TIZEN
        [JsonProperty("params")]
#else
        [JsonPropertyName("params")]
#endif
        public object Params { get; set; }

#if UNITY || TIZEN
        [JsonProperty("id")]
#else
        [JsonPropertyName("id")]
#endif
        public int Id { get; set; }
    }

    public class JsonRpcResponse<T>
    {
#if UNITY || TIZEN
        [JsonProperty("jsonrpc")]
#else
        [JsonPropertyName("jsonrpc")]
#endif
        public string JsonRpc { get; set; } = "";

#if UNITY || TIZEN
        [JsonProperty("result")]
#else
        [JsonPropertyName("result")]
#endif
        public T Result { get; set; }

#if UNITY || TIZEN
        [JsonProperty("error")]
#else
        [JsonPropertyName("error")]
#endif
        public JsonRpcError Error { get; set; }

#if UNITY || TIZEN
        [JsonProperty("id")]
#else
        [JsonPropertyName("id")]
#endif
        public int Id { get; set; }
    }

    public class JsonRpcError
    {
#if UNITY || TIZEN
        [JsonProperty("code")]
#else
        [JsonPropertyName("code")]
#endif
        public int Code { get; set; }

#if UNITY || TIZEN
        [JsonProperty("message")]
#else
        [JsonPropertyName("message")]
#endif
        public string Message { get; set; } = "";

#if UNITY || TIZEN
        [JsonProperty("data")]
#else
        [JsonPropertyName("data")]
#endif
        public object Data { get; set; }
    }

    public class JsonRpcException : Exception
    {
        public int Code { get; }
        public  object ErrorData { get; }

        public JsonRpcException(JsonRpcError error)
            : base(error.Message)
        {
            Code = error.Code;
            ErrorData = error.Data;
        }
    }
}