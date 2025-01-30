using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Generator.OpenRPC
{
    public class CSharpOpenRPCGenerator
    {
        private readonly OpenRpcSpec _spec;
        private readonly string _outputDir;
        private readonly CSharpGeneratorSettings _settings;

        public CSharpOpenRPCGenerator(OpenRpcSpec spec, string outputDir)
        {
            _spec = spec;
            _outputDir = outputDir;
            _settings = new CSharpGeneratorSettings
            {
                ClassStyle = CSharpClassStyle.Poco,
                GenerateDataAnnotations = true,
                GenerateJsonMethods = true,
                Namespace = "Stellar.RPC",
                JsonLibrary = CSharpJsonLibrary.SystemTextJson,
                
            
            };
        }

        public async Task GenerateAsync()
        {
            // Generate model classes for parameters and results
            foreach (var method in _spec.Methods)
            {
                await GenerateMethodModelsAsync(method);
            }

            // Generate client class
            await GenerateClientClassAsync();
        }

        private async Task GenerateMethodModelsAsync(RpcMethod method)
        {
            if (method.Params?.Any() == true)
            {
                // Create a schema for the parameters
                var paramSchema = new JsonSchema
                {
                    Type = JsonObjectType.Object,
                    Description = $"Parameters for {method.Name} method"
                };

                foreach (var param in method.Params)
                {
                    // Create a JsonSchemaProperty instead of JsonSchema
                    var propSchema = new JsonSchemaProperty(); 
           

                    // Parse the schema from the parameter
                    var schemaFromParam = await JsonSchema.FromJsonAsync(
                        param.Schema.GetRawText());

                    // Copy properties from the parsed schema to our property
                    propSchema.Type = schemaFromParam.Type;
                    propSchema.Description = param.Description;
                    propSchema.Pattern = schemaFromParam.Pattern;
                    propSchema.Minimum = schemaFromParam.Minimum;
                    propSchema.Maximum = schemaFromParam.Maximum;

                    // Handle items for arrays
                    if (schemaFromParam.Type == JsonObjectType.Array && schemaFromParam.Items != null)
                    {
                        propSchema.Type = JsonObjectType.Array;
                        // Take the first schema from the Items collection
                        propSchema.Item = schemaFromParam.Items.FirstOrDefault();
                    }

                    // Handle properties for objects
                    if (schemaFromParam.Type == JsonObjectType.Object && schemaFromParam.Properties != null)
                    {
                        propSchema.Type = JsonObjectType.Object;
                      
                        foreach (var property in schemaFromParam.Properties)
                        {
                            propSchema.Properties.Add(property.Key, property.Value);
                        }
                    }

                    paramSchema.Properties[$"{ToPascalCase(method.Name)}{ToPascalCase(param.Name)}"] = propSchema;

                    if (param.Required)
                    {
                        paramSchema.RequiredProperties.Add(param.Name);
                    }
                }

                var generator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator(paramSchema, _settings);
                var paramClassName = $"{ToPascalCase(method.Name)}Params";
                var code = generator.GenerateFile(paramClassName);
                await File.WriteAllTextAsync(Path.Combine(_outputDir, $"{paramClassName}.cs"), code);
            }

            if (method.Result?.Schema != null)
            {
                var resultSchema = await JsonSchema.FromJsonAsync(
                    method.Result.Schema.GetRawText());

                var generator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator(resultSchema, _settings);
                var resultClassName = $"{ToPascalCase(method.Name)}Result";
                var code = generator.GenerateFile(resultClassName);
                await File.WriteAllTextAsync(Path.Combine(_outputDir, $"{resultClassName}.cs"), code);
            }
        }
        private async Task GenerateClientClassAsync()
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Text.Json;");
            sb.AppendLine("using System.Text.Json.Serialization;");
            sb.AppendLine("using System.Net.Http;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Stellar.RPC;"); 
            sb.AppendLine();

            if (!string.IsNullOrEmpty(_spec.Info.Description))
            {
                sb.AppendLine(FormatXmlComment(_spec.Info.Description,0));
            }

            sb.AppendLine($"public class {_spec.Info.Title.Replace(" ", "")}Client");
            sb.AppendLine("{");
            sb.AppendLine("    private readonly HttpClient _httpClient;");
            sb.AppendLine("    private readonly JsonSerializerOptions _jsonOptions;");
            sb.AppendLine();
            sb.AppendLine($"    public {_spec.Info.Title.Replace(" ", "")}Client(HttpClient httpClient)");
            sb.AppendLine("    {");
            sb.AppendLine("        _httpClient = httpClient;");
            sb.AppendLine("        _jsonOptions = new JsonSerializerOptions");
            sb.AppendLine("        {");
            sb.AppendLine("            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,");
            sb.AppendLine("            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull");
            sb.AppendLine("        };");
            sb.AppendLine("    }");
            sb.AppendLine();

            foreach (var method in _spec.Methods)
            {
                await GenerateMethodAsync(sb, method);
            }

            sb.AppendLine("}");

            await File.WriteAllTextAsync(
                Path.Combine(_outputDir, $"{_spec.Info.Title.Replace(" ", "")}Client.cs"),
                sb.ToString());
        }

        private string FormatXmlComment(string description, int indentationLevel = 1)
        {
            if (string.IsNullOrEmpty(description))
                return string.Empty;

            var sb = new StringBuilder();
            var indent = new string(' ', indentationLevel * 4);

            // Split by line breaks and handle both \n and \r\n
            var lines = description.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            sb.AppendLine($"{indent}/// <summary>");
            foreach (var line in lines)
            {
                // Escape XML special characters and trim any trailing whitespace
                var escapedLine = line.Trim()
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("\"", "&quot;")
                    .Replace("'", "&apos;");

                // Skip empty lines in XML comments as they can cause issues
                if (!string.IsNullOrWhiteSpace(escapedLine))
                {
                    sb.AppendLine($"{indent}/// {escapedLine}");
                }
            }
            sb.AppendLine($"{indent}/// </summary>");

            return sb.ToString().TrimEnd();
        }

        private async Task GenerateMethodAsync(StringBuilder sb, RpcMethod method)
        {
            var methodName = ToPascalCase(method.Name);
            var paramType = method.Params?.Any() == true ? $"{methodName}Params" : "object";
            var resultType = $"{methodName}Result";

            if (!string.IsNullOrEmpty(method.Description))
            {
                sb.AppendLine(FormatXmlComment(method.Description));
            }

            sb.AppendLine($"    public async Task<{resultType}> {methodName}Async({paramType} parameters = null)");
            sb.AppendLine("    {");
            sb.AppendLine("        var request = new JsonRpcRequest");
            sb.AppendLine("        {");
            sb.AppendLine("            JsonRpc = \"2.0\",");
            sb.AppendLine($"            Method = \"{method.Name}\",");
            sb.AppendLine("            Params = parameters,");
            sb.AppendLine("            Id = 1");
            sb.AppendLine("        };");
            sb.AppendLine();
            sb.AppendLine("        var response = await _httpClient.PostAsync(\"\", ");
            sb.AppendLine("            new StringContent(");
            sb.AppendLine("                JsonSerializer.Serialize(request, _jsonOptions),");
            sb.AppendLine("                Encoding.UTF8,");
            sb.AppendLine("                \"application/json\"));");
            sb.AppendLine();
            sb.AppendLine("        response.EnsureSuccessStatusCode();");
            sb.AppendLine("        var content = await response.Content.ReadAsStringAsync();");
            sb.AppendLine($"        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<{resultType}>>(content, _jsonOptions);");
            sb.AppendLine();
            sb.AppendLine("        if (rpcResponse.Error != null)");
            sb.AppendLine("        {");
            sb.AppendLine("            throw new JsonRpcException(rpcResponse.Error);");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine("        return rpcResponse.Result;");
            sb.AppendLine("    }");
            sb.AppendLine();
        }

        private string ToPascalCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var words = input.Split(new[] { '_', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower());

            return string.Concat(words);
        }
    }

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
        public JsonElement Schema { get; set; }
    }

    public class RpcResult
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("schema")]
        public JsonElement Schema { get; set; }
    }

    // JSON-RPC communication models
    public class JsonRpcRequest
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        [JsonPropertyName("method")]
        public string Method { get; set; } = "";

        [JsonPropertyName("params")]
        public object? Params { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class JsonRpcResponse<T>
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; } = "";

        [JsonPropertyName("result")]
        public T? Result { get; set; }

        [JsonPropertyName("error")]
        public JsonRpcError? Error { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class JsonRpcError
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";
    }

    public class JsonRpcException : Exception
    {
        public int Code { get; }

        public JsonRpcException(JsonRpcError error)
            : base(error.Message)
        {
            Code = error.Code;
        }
    }
}
