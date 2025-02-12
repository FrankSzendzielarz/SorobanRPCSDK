using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System.Text;

namespace Generator.OpenRPC
{
    public class CSharpOpenRPCGenerator
    {
        private readonly OpenRpcSpec _spec;
        private readonly string _outputDir;
        private readonly CSharpGeneratorSettings _settings;
        private readonly bool _isUnityBuild;

        public CSharpOpenRPCGenerator(OpenRpcSpec spec, string outputDir, bool isUnityBuild = false)
        {
            _spec = spec;
            _outputDir = outputDir;
            _isUnityBuild = isUnityBuild;

            _settings = new CSharpGeneratorSettings
            {
                ClassStyle = CSharpClassStyle.Poco,
          //      GenerateDataAnnotations = true,
                GenerateJsonMethods = true,
                Namespace = "Stellar.RPC",
                JsonLibrary = isUnityBuild ? CSharpJsonLibrary.NewtonsoftJson : CSharpJsonLibrary.SystemTextJson,
                ArrayType = "System.Collections.Generic.ICollection",
                ArrayBaseType = "System.Collections.Generic.ICollection<{0}>",
                NumberType = "long",
                 
                
                 
            };
        }

        public async Task GenerateAsync()
        {
            foreach (var method in _spec.Methods)
            {
                await GenerateMethodModelsAsync(method);
            }

            await GenerateClientClassAsync();
        }

        private async Task GenerateMethodModelsAsync(RpcMethod method)
        {
            if (method.Params?.Any() == true)
            {
                var paramSchema = new JsonSchema
                {
                    Type = JsonObjectType.Object,
                    Description = $"Parameters for {method.Name} method"
                };

                foreach (var param in method.Params)
                {
                    var schemaFromParam = param.Schema.ToJsonSchema();
                    var propSchema = new JsonSchemaProperty
                    {
                        Type = schemaFromParam.Type,
                        Description = param.Description,
                        Item = schemaFromParam.Item
                    };

                    if (schemaFromParam.Type == JsonObjectType.Object && schemaFromParam.Properties != null)
                    {
                        propSchema.Type = JsonObjectType.Object;
                        foreach (var property in schemaFromParam.Properties)
                        {
                            propSchema.Properties.Add(property.Key, property.Value);
                        }
                    }

                    paramSchema.Properties[$"{param.Name.ToCamelCase()}"] = propSchema;

                    if (param.Required)
                    {
                        paramSchema.RequiredProperties.Add(param.Name);
                    }
                }

                var generator = new CSharpGenerator(paramSchema, _settings);
                var code = generator.GenerateFile($"{method.Name.ToPascalCase()}Params");
                await File.WriteAllTextAsync(Path.Combine(_outputDir, $"{method.Name.ToPascalCase()}Params.cs"), code);
            }

            if (method.Result?.Schema != null)
            {
                var resultSchema = await JsonSchema.FromJsonAsync(method.Result.Schema.GetRawText());
                var generator = new CSharpGenerator(resultSchema, _settings);
                var code = generator.GenerateFile($"{method.Name.ToPascalCase()}Result");
                await File.WriteAllTextAsync(Path.Combine(_outputDir, $"{method.Name.ToPascalCase()}Result.cs"), code);
            }
        }

        private async Task GenerateClientClassAsync()
        {
            var sb = new StringBuilder();

            // Add appropriate using statements based on JSON library
            if (_isUnityBuild)
            {
                sb.AppendLine("using Newtonsoft.Json;");
                sb.AppendLine("using Newtonsoft.Json.Serialization;");
            }
            else
            {
                sb.AppendLine("using System.Text.Json;");
                sb.AppendLine("using System.Text.Json.Serialization;");
            }

            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Net.Http;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Stellar.RPC;");
            sb.AppendLine();
            sb.AppendLine("namespace Stellar.RPC");
            sb.AppendLine("{");

            if (!string.IsNullOrEmpty(_spec.Info.Description))
            {
                sb.AppendLine(FormatXmlComment(_spec.Info.Description, 0));
            }

            sb.AppendLine($"public partial class {_spec.Info.Title.Replace(" ", "")}Client");
            sb.AppendLine("{");
            sb.AppendLine("    private readonly HttpClient _httpClient;");

            if (_isUnityBuild)
            {
                sb.AppendLine("    private readonly JsonSerializerSettings _jsonSettings;");
                sb.AppendLine();
                sb.AppendLine($"    public {_spec.Info.Title.Replace(" ", "")}Client(HttpClient httpClient)");
                sb.AppendLine("    {");
                sb.AppendLine("        _httpClient = httpClient;");
                sb.AppendLine("        _jsonSettings = new JsonSerializerSettings");
                sb.AppendLine("        {");
                sb.AppendLine("            ContractResolver = new CamelCasePropertyNamesContractResolver(),");
                sb.AppendLine("            NullValueHandling = NullValueHandling.Ignore");
                sb.AppendLine("        };");
                sb.AppendLine("    }");
            }
            else
            {
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
            }

            sb.AppendLine();

            foreach (var method in _spec.Methods)
            {
                await GenerateMethodAsync(sb, method);
            }

            sb.AppendLine("}");
            sb.AppendLine("}");

            await File.WriteAllTextAsync(
                Path.Combine(_outputDir, $"{_spec.Info.Title.Replace(" ", "")}Client.cs"),
                sb.ToString());
        }

        private async Task GenerateMethodAsync(StringBuilder sb, RpcMethod method)
        {
            var methodName = method.Name.ToPascalCase();
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
            sb.AppendLine($"            Method = \"{method.Name.ToCamelCase()}\",");
            sb.AppendLine("            Params = parameters,");
            sb.AppendLine("            Id = 1");
            sb.AppendLine("        };");
            sb.AppendLine();

            if (_isUnityBuild)
            {
                sb.AppendLine("        var requestJson = JsonConvert.SerializeObject(request, _jsonSettings);");
            }
            else
            {
                sb.AppendLine("        var requestJson = JsonSerializer.Serialize(request, _jsonOptions);");
            }

            sb.AppendLine($"        var response = await _httpClient.PostAsync(\"\", ");
            sb.AppendLine("            new StringContent(");
            sb.AppendLine("                requestJson,");
            sb.AppendLine("                Encoding.UTF8,");
            sb.AppendLine("                \"application/json\"));");
            sb.AppendLine();
            sb.AppendLine("        response.EnsureSuccessStatusCode();");
            sb.AppendLine("        var content = await response.Content.ReadAsStringAsync();");

            if (_isUnityBuild)
            {
                sb.AppendLine($"        var rpcResponse = JsonConvert.DeserializeObject<JsonRpcResponse<{resultType}>>(content, _jsonSettings);");
            }
            else
            {
                sb.AppendLine($"        var rpcResponse = JsonSerializer.Deserialize<JsonRpcResponse<{resultType}>>(content, _jsonOptions);");
            }

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

        private string FormatXmlComment(string description, int indentationLevel = 1)
        {
            if (string.IsNullOrEmpty(description))
                return string.Empty;

            var sb = new StringBuilder();
            var indent = new string(' ', indentationLevel * 4);

            var lines = description.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            sb.AppendLine($"{indent}/// <summary>");
            foreach (var line in lines)
            {
                var escapedLine = line.Trim()
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("\"", "&quot;")
                    .Replace("'", "&apos;");

                if (!string.IsNullOrWhiteSpace(escapedLine))
                {
                    sb.AppendLine($"{indent}/// {escapedLine}");
                }
            }
            sb.AppendLine($"{indent}/// </summary>");

            return sb.ToString().TrimEnd();
        }
    }
}