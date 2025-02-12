using NJsonSchema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Generator.OpenRPC
{
    // OpenRPC specific models
    public class OpenRpcSpec
    {
        [JsonPropertyName("openrpc")]
        public string OpenRpc { get; set; } = "";

        [JsonPropertyName("info")]
        public InfoObject Info { get; set; } = new();

        [JsonPropertyName("methods")]
        public List<RpcMethod> Methods { get; set; } = new();
    }

    public class InfoObject
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("version")]
        public string Version { get; set; } = "";
    }

    public class RpcMethod
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("params")]
        public List<RpcParameter>? Params { get; set; }

        [JsonPropertyName("result")]
        public RpcResult? Result { get; set; }
    }

    public class RpcParameter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("required")]
        public bool Required { get; set; }

        [JsonPropertyName("schema")]
        public RpcParameterSchema Schema { get; set; } = new();
    }

    public class RpcParameterSchema
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("items")]
        public RpcParameterSchema? Items { get; set; }

        public JsonSchema ToJsonSchema()
        {
            var schema = new JsonSchema
            {
                Type = Enum.Parse<JsonObjectType>(Type, true),
                Description = Description
            };

            if (Items != null && Type.Equals("array", StringComparison.OrdinalIgnoreCase))
            {
                schema.Item = Items.ToJsonSchema();
            }

            return schema;
        }
    }

    public class RpcResult
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("schema")]
        public JsonElement Schema { get; set; }
    }
}