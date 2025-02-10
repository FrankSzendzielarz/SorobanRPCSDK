using System;
using System.Text.Json.Serialization;

namespace Stellar.RPC
{
    public class JsonRpcRequest
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        [JsonPropertyName("method")]
        public string Method { get; set; } = "";

        [JsonPropertyName("params")]
        public object Params { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class JsonRpcResponse<T>
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; } = "";

        [JsonPropertyName("result")]
        public T Result { get; set; }

        [JsonPropertyName("error")]
        public JsonRpcError Error { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class JsonRpcError
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class JsonRpcException : Exception
    {
        public int Code { get; }
        public object Data { get; }

        public JsonRpcException(JsonRpcError error)
            : base(error.Message)
        {
            Code = error.Code;
            Data = error.Data;
        }
    }
}