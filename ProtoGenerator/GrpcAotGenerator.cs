using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using ProtoBuf;
using ProtoBuf.Meta;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Stellar.RPC.Tools
{
    public class GrpcAotGenerator
    {
        private readonly Assembly _targetAssembly;
        private readonly string _outputPath;
        private readonly string _namespace;

        public GrpcAotGenerator(Assembly targetAssembly, string outputPath, string serviceNamespace = "Stellar.RPC.AOT")
        {
            _targetAssembly = targetAssembly;
            _outputPath = outputPath;
            _namespace = serviceNamespace;
        }

        public void GenerateAotGrpcServices()
        {
            var serviceContracts = _targetAssembly.GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any())
                .ToList();

            foreach (var serviceContract in serviceContracts)
            {
                GenerateServiceAdapter(serviceContract);
            }

            // Generate registration extensions
            GenerateRegistrationExtensions(serviceContracts);
        }

        private void GenerateServiceAdapter(Type serviceContract)
        {
            var operations = serviceContract.GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(OperationContractAttribute), true).Any())
                .ToList();

            if (!operations.Any())
                return;

            var sb = new StringBuilder();
            var serviceName = serviceContract.Name;
            
            // Remove 'I' prefix for implementation class name if it exists
            var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;
            var fileName = $"{serviceImplName}GrpcService.cs";

            // Add file header
            sb.AppendLine("// Generated code - do not modify directly");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Grpc.Core;");
            sb.AppendLine("using Microsoft.Extensions.DependencyInjection;");
            sb.AppendLine("using Microsoft.Extensions.Logging;");
            sb.AppendLine("using ProtoBuf;");
            sb.AppendLine("using ProtoBuf.Meta;");
            sb.AppendLine($"using {serviceContract.Namespace};");
            sb.AppendLine();
            sb.AppendLine($"namespace {_namespace}");
            sb.AppendLine("{");

            // Generate service descriptor class
            sb.AppendLine($"    /// <summary>gRPC service descriptor for {serviceName}</summary>");
            sb.AppendLine($"    public static class {serviceImplName}GrpcDescriptor");
            sb.AppendLine("    {");
            sb.AppendLine($"        public const string ServiceName = \"{serviceContract.Namespace}.{serviceImplName}\";");
            sb.AppendLine();

            // Define method descriptors for each operation
            foreach (var operation in operations)
            {
                var methodName = operation.Name;
                var requestType = operation.GetParameters().FirstOrDefault()?.ParameterType;
                var responseType = operation.ReturnType.IsGenericType ? 
                    operation.ReturnType.GetGenericArguments()[0] : 
                    operation.ReturnType;

                if (requestType == null || responseType == null)
                    continue;

                sb.AppendLine($"        /// <summary>Method descriptor for {methodName}</summary>");
                sb.AppendLine($"        public static readonly Method<{requestType.FullName}, {responseType.FullName}> {methodName}Method =");
                sb.AppendLine($"            new Method<{requestType.FullName}, {responseType.FullName}>(");
                sb.AppendLine("                MethodType.Unary,");
                sb.AppendLine($"                ServiceName,");
                sb.AppendLine($"                \"{methodName}\",");
                sb.AppendLine($"                {serviceImplName}GrpcMarshaller.{requestType.Name}Marshaller,");
                sb.AppendLine($"                {serviceImplName}GrpcMarshaller.{responseType.Name}Marshaller);");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine();

            // Generate marshaller class
            sb.AppendLine($"    /// <summary>Custom marshallers for {serviceName} types</summary>");
            sb.AppendLine($"    public static class {serviceImplName}GrpcMarshaller");
            sb.AppendLine("    {");
            sb.AppendLine("        // Configure protobuf-net serialization for all types");
            sb.AppendLine("        static {serviceImplName}GrpcMarshaller()");
            sb.AppendLine("        {");
            sb.AppendLine("            ConfigureTypes();");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("        /// <summary>Configure protobuf serialization for all types</summary>");
            sb.AppendLine("        public static void ConfigureTypes()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Preregister all types with RuntimeTypeModel");
            sb.AppendLine("            var model = RuntimeTypeModel.Default;");
            sb.AppendLine();

            // Generate type configurations for request and response types
            var allTypes = new HashSet<Type>();
            foreach (var operation in operations)
            {
                var requestType = operation.GetParameters().FirstOrDefault()?.ParameterType;
                var responseType = operation.ReturnType.IsGenericType ? 
                    operation.ReturnType.GetGenericArguments()[0] : 
                    operation.ReturnType;

                if (requestType != null) allTypes.Add(requestType);
                if (responseType != null) allTypes.Add(responseType);
            }

            // Generate marshaller properties for all types
            foreach (var type in allTypes)
            {
                sb.AppendLine($"            // Marshaller for {type.Name}");
                sb.AppendLine($"            public static readonly Marshaller<{type.FullName}> {type.Name}Marshaller = Marshallers.Create<{type.FullName}>(");
                sb.AppendLine("                (obj, ctx) =>");
                sb.AppendLine("                {");
                sb.AppendLine("                    try");
                sb.AppendLine("                    {");
                sb.AppendLine("                        using (var ms = new System.IO.MemoryStream())");
                sb.AppendLine("                        {");
                sb.AppendLine("                            Serializer.Serialize(ms, obj);");
                sb.AppendLine("                            ctx.Complete(ms.ToArray());");
                sb.AppendLine("                        }");
                sb.AppendLine("                    }");
                sb.AppendLine("                    catch (Exception ex)");
                sb.AppendLine("                    {");
                sb.AppendLine("                        throw new RpcException(new Status(StatusCode.Internal, $\"Failed to serialize: {ex.Message}\"));");
                sb.AppendLine("                    }");
                sb.AppendLine("                },");
                sb.AppendLine("                (ctx) =>");
                sb.AppendLine("                {");
                sb.AppendLine("                    try");
                sb.AppendLine("                    {");
                sb.AppendLine("                        var bytes = ctx.PayloadAsReadOnlySequence().ToArray();");
                sb.AppendLine("                        using (var ms = new System.IO.MemoryStream(bytes))");
                sb.AppendLine("                        {");
                sb.AppendLine($"                            return Serializer.Deserialize<{type.FullName}>(ms);");
                sb.AppendLine("                        }");
                sb.AppendLine("                    }");
                sb.AppendLine("                    catch (Exception ex)");
                sb.AppendLine("                    {");
                sb.AppendLine("                        throw new RpcException(new Status(StatusCode.Internal, $\"Failed to deserialize: {ex.Message}\"));");
                sb.AppendLine("                    }");
                sb.AppendLine("                });");
                sb.AppendLine();
            }

            sb.AppendLine("            // Pre-compile serializers for AOT compatibility");
            sb.AppendLine("            model.CompileInPlace();");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Generate service implementation
            sb.AppendLine($"    /// <summary>gRPC service implementation for {serviceName}</summary>");
            sb.AppendLine($"    public class {serviceImplName}GrpcService");
            sb.AppendLine("    {");
            sb.AppendLine($"        private readonly {serviceName} _service;");
            sb.AppendLine("        private readonly ILogger _logger;");
            sb.AppendLine();
            sb.AppendLine($"        public {serviceImplName}GrpcService({serviceName} service, ILogger<{serviceImplName}GrpcService> logger)");
            sb.AppendLine("        {");
            sb.AppendLine("            _service = service;");
            sb.AppendLine("            _logger = logger;");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Generate handler methods for each operation
            foreach (var operation in operations)
            {
                var methodName = operation.Name;
                var requestType = operation.GetParameters().FirstOrDefault()?.ParameterType;
                var responseType = operation.ReturnType.IsGenericType ? 
                    operation.ReturnType.GetGenericArguments()[0] : 
                    operation.ReturnType;

                if (requestType == null || responseType == null)
                    continue;

                var isAsync = operation.ReturnType.IsGenericType && 
                             (operation.ReturnType.GetGenericTypeDefinition() == typeof(Task<>) ||
                              operation.ReturnType.GetGenericTypeDefinition() == typeof(ValueTask<>));

                sb.AppendLine($"        /// <summary>Handler for {methodName} method</summary>");
                sb.AppendLine($"        public async Task<{responseType.FullName}> {methodName}({requestType.FullName} request, ServerCallContext context)");
                sb.AppendLine("        {");
                sb.AppendLine("            try");
                sb.AppendLine("            {");
                sb.AppendLine($"                _logger.LogInformation(\"Processing {methodName} request\");");
                
                if (isAsync)
                {
                    sb.AppendLine($"                return await _service.{methodName}(request);");
                }
                else
                {
                    sb.AppendLine($"                return _service.{methodName}(request);");
                }
                
                sb.AppendLine("            }");
                sb.AppendLine("            catch (Exception ex)");
                sb.AppendLine("            {");
                sb.AppendLine($"                _logger.LogError(ex, \"Error in {methodName}\");");
                sb.AppendLine("                throw new RpcException(new Status(StatusCode.Internal, ex.Message));");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            // Write file
            File.WriteAllText(Path.Combine(_outputPath, fileName), sb.ToString());
        }

        private void GenerateRegistrationExtensions(List<Type> serviceContracts)
        {
            var sb = new StringBuilder();
            
            // Add file header
            sb.AppendLine("// Generated code - do not modify directly");
            sb.AppendLine("using System;");
            sb.AppendLine("using Grpc.Core;");
            sb.AppendLine("using Microsoft.AspNetCore.Builder;");
            sb.AppendLine("using Microsoft.AspNetCore.Routing;");
            sb.AppendLine("using Microsoft.Extensions.DependencyInjection;");
            
            // Add namespaces for all service contracts
            var namespaces = serviceContracts
                .Select(t => t.Namespace)
                .Distinct()
                .OrderBy(n => n);
                
            foreach (var ns in namespaces)
            {
                sb.AppendLine($"using {ns};");
            }
            
            sb.AppendLine();
            sb.AppendLine($"namespace {_namespace}");
            sb.AppendLine("{");
            sb.AppendLine("    /// <summary>Extension methods for registering AOT-compatible gRPC services</summary>");
            sb.AppendLine("    public static class GrpcServiceExtensions");
            sb.AppendLine("    {");
            
            // Service registration method
            sb.AppendLine("        /// <summary>Add all AOT-compatible gRPC services to the DI container</summary>");
            sb.AppendLine("        public static IServiceCollection AddAotGrpcServices(this IServiceCollection services)");
            sb.AppendLine("        {");
            
            // Add base gRPC services
            sb.AppendLine("            // Add base gRPC infrastructure");
            sb.AppendLine("            services.AddGrpc(options =>");
            sb.AppendLine("            {");
            sb.AppendLine("                options.EnableDetailedErrors = true;");
            sb.AppendLine("                options.MaxReceiveMessageSize = 16 * 1024 * 1024; // 16 MB");
            sb.AppendLine("                options.MaxSendMessageSize = 16 * 1024 * 1024; // 16 MB");
            sb.AppendLine("            });");
            sb.AppendLine();
            
            // Register each service implementation
            foreach (var serviceContract in serviceContracts)
            {
                var serviceName = serviceContract.Name;
                var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;
                
                sb.AppendLine($"            // Register {serviceName} and its gRPC adapter");
                if (serviceName.StartsWith("I"))
                {
                    sb.AppendLine($"            services.AddScoped<{serviceName}, {serviceImplName}>();");
                }
                sb.AppendLine($"            services.AddScoped<{serviceImplName}GrpcService>();");
            }
            
            sb.AppendLine();
            sb.AppendLine("            return services;");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Endpoint mapping method
            sb.AppendLine("        /// <summary>Map all AOT-compatible gRPC services to endpoints</summary>");
            sb.AppendLine("        public static IEndpointRouteBuilder MapAotGrpcServices(this IEndpointRouteBuilder endpoints)");
            sb.AppendLine("        {");
            
            // Configure each service marshaller
            sb.AppendLine("            // Ensure all marshallers are configured");
            foreach (var serviceContract in serviceContracts)
            {
                var serviceName = serviceContract.Name;
                var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;
                
                sb.AppendLine($"            {serviceImplName}GrpcMarshaller.ConfigureTypes();");
            }
            sb.AppendLine();
            
            // Map each service method
            foreach (var serviceContract in serviceContracts)
            {
                var serviceName = serviceContract.Name;
                var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;
                var operations = serviceContract.GetMethods()
                    .Where(m => m.GetCustomAttributes(typeof(OperationContractAttribute), true).Any())
                    .ToList();
                
                sb.AppendLine($"            // Map {serviceName} methods");
                foreach (var operation in operations)
                {
                    var methodName = operation.Name;
                    sb.AppendLine($"            endpoints.MapGrpcMethod<{serviceImplName}GrpcService>({serviceImplName}GrpcDescriptor.{methodName}Method);");
                }
                sb.AppendLine();
            }
            
            sb.AppendLine("            return endpoints;");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Helper method to map individual gRPC methods
            sb.AppendLine("        /// <summary>Map a gRPC method to an endpoint</summary>");
            sb.AppendLine("        private static IEndpointRouteBuilder MapGrpcMethod<TService>(");
            sb.AppendLine("            this IEndpointRouteBuilder endpoints,");
            sb.AppendLine("            Method method)");
            sb.AppendLine("            where TService : class");
            sb.AppendLine("        {");
            sb.AppendLine("            var methodName = method.Name;");
            sb.AppendLine("            var serviceName = method.ServiceName;");
            sb.AppendLine();
            sb.AppendLine("            // Create the route template");
            sb.AppendLine("            var pattern = $\"/grpc/{serviceName}/{methodName}\";");
            sb.AppendLine();
            sb.AppendLine("            // Map POST endpoint for unary calls");
            sb.AppendLine("            endpoints.MapPost(pattern, async context =>");
            sb.AppendLine("            {");
            sb.AppendLine("                var service = context.RequestServices.GetRequiredService<TService>();");
            sb.AppendLine("                var serviceType = typeof(TService);");
            sb.AppendLine();
            sb.AppendLine("                // Find the matching handler method");
            sb.AppendLine("                var handler = serviceType.GetMethod(methodName);");
            sb.AppendLine("                if (handler == null)");
            sb.AppendLine("                {");
            sb.AppendLine("                    context.Response.StatusCode = 404;");
            sb.AppendLine("                    await context.Response.WriteAsync($\"Method {methodName} not found on service {serviceName}\");");
            sb.AppendLine("                    return;");
            sb.AppendLine("                }");
            sb.AppendLine();
            sb.AppendLine("                try");
            sb.AppendLine("                {");
            sb.AppendLine("                    // Create ServerCallContext");
            sb.AppendLine("                    var serverCallContext = CreateServerCallContext(context);");
            sb.AppendLine();
            sb.AppendLine("                    // Get the marshaller for the request type");
            sb.AppendLine("                    var requestMarshaller = method.GetType().GetField(\"RequestMarshaller\")?.GetValue(method) as Marshaller;");
            sb.AppendLine("                    if (requestMarshaller == null)");
            sb.AppendLine("                    {");
            sb.AppendLine("                        throw new InvalidOperationException(\"Could not get request marshaller\");");
            sb.AppendLine("                    }");
            sb.AppendLine();
            sb.AppendLine("                    // Deserialize the request");
            sb.AppendLine("                    var deserializeDelegate = requestMarshaller.GetType().GetProperty(\"ContextualDeserializer\")?.GetValue(requestMarshaller) as Func<DeserializationContext, object>;");
            sb.AppendLine("                    if (deserializeDelegate == null)");
            sb.AppendLine("                    {");
            sb.AppendLine("                        throw new InvalidOperationException(\"Could not get deserializer\");");
            sb.AppendLine("                    }");
            sb.AppendLine();
            sb.AppendLine("                    // Create deserialization context from request body");
            sb.AppendLine("                    var deserializationContext = new GrpcDeserializationContext(context.Request.Body);");
            sb.AppendLine("                    var request = deserializeDelegate(deserializationContext);");
            sb.AppendLine();
            sb.AppendLine("                    // Invoke the handler method");
            sb.AppendLine("                    var response = await (Task<object>)handler.Invoke(service, new[] { request, serverCallContext });");
            sb.AppendLine();
            sb.AppendLine("                    // Get the marshaller for the response type");
            sb.AppendLine("                    var responseMarshaller = method.GetType().GetField(\"ResponseMarshaller\")?.GetValue(method) as Marshaller;");
            sb.AppendLine("                    if (responseMarshaller == null)");
            sb.AppendLine("                    {");
            sb.AppendLine("                        throw new InvalidOperationException(\"Could not get response marshaller\");");
            sb.AppendLine("                    }");
            sb.AppendLine();
            sb.AppendLine("                    // Serialize the response");
            sb.AppendLine("                    var serializeDelegate = responseMarshaller.GetType().GetProperty(\"ContextualSerializer\")?.GetValue(responseMarshaller) as Action<object, SerializationContext>;");
            sb.AppendLine("                    if (serializeDelegate == null)");
            sb.AppendLine("                    {");
            sb.AppendLine("                        throw new InvalidOperationException(\"Could not get serializer\");");
            sb.AppendLine("                    }");
            sb.AppendLine();
            sb.AppendLine("                    // Set response content type");
            sb.AppendLine("                    context.Response.ContentType = \"application/grpc\";");
            sb.AppendLine();
            sb.AppendLine("                    // Create serialization context");
            sb.AppendLine("                    var serializationContext = new GrpcSerializationContext(context.Response.Body);");
            sb.AppendLine("                    serializeDelegate(response, serializationContext);");
            sb.AppendLine();
            sb.AppendLine("                    // Complete serialization");
            sb.AppendLine("                    await serializationContext.CompleteAsync();");
            sb.AppendLine("                }");
            sb.AppendLine("                catch (Exception ex)");
            sb.AppendLine("                {");
            sb.AppendLine("                    context.Response.StatusCode = 500;");
            sb.AppendLine("                    await context.Response.WriteAsync(ex.Message);");
            sb.AppendLine("                }");
            sb.AppendLine("            });");
            sb.AppendLine();
            sb.AppendLine("            return endpoints;");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Helper method to create ServerCallContext
            sb.AppendLine("        private static ServerCallContext CreateServerCallContext(HttpContext httpContext)");
            sb.AppendLine("        {");
            sb.AppendLine("            // Create simple ServerCallContext implementation");
            sb.AppendLine("            return new GrpcServerCallContext(httpContext);");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Add custom context implementations
            sb.AppendLine("        #region Custom gRPC Context Implementations");
            sb.AppendLine();
            
            // Custom ServerCallContext
            sb.AppendLine("        private class GrpcServerCallContext : ServerCallContext");
            sb.AppendLine("        {");
            sb.AppendLine("            private readonly HttpContext _httpContext;");
            sb.AppendLine();
            sb.AppendLine("            public GrpcServerCallContext(HttpContext httpContext)");
            sb.AppendLine("            {");
            sb.AppendLine("                _httpContext = httpContext;");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            protected override string MethodCore => _httpContext.Request.Path;");
            sb.AppendLine("            protected override string HostCore => _httpContext.Request.Host.Value;");
            sb.AppendLine("            protected override string PeerCore => _httpContext.Connection.RemoteIpAddress?.ToString() ?? \"unknown\";");
            sb.AppendLine("            protected override DateTime DeadlineCore => DateTime.MaxValue;");
            sb.AppendLine("            protected override Metadata RequestHeadersCore => new Metadata();");
            sb.AppendLine("            protected override CancellationToken CancellationTokenCore => _httpContext.RequestAborted;");
            sb.AppendLine("            protected override Metadata ResponseTrailersCore => new Metadata();");
            sb.AppendLine("            protected override Status StatusCore { get; set; } = Status.DefaultSuccess;");
            sb.AppendLine("            protected override WriteOptions WriteOptionsCore { get; set; } = new WriteOptions();");
            sb.AppendLine();
            sb.AppendLine("            protected override AuthContext AuthContextCore => throw new NotImplementedException();");
            sb.AppendLine();
            sb.AppendLine("            protected override ContextPropagationToken CreatePropagationTokenCore(ContextPropagationOptions options)");
            sb.AppendLine("            {");
            sb.AppendLine("                throw new NotImplementedException();");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            protected override Task WriteResponseHeadersAsyncCore(Metadata responseHeaders)");
            sb.AppendLine("            {");
            sb.AppendLine("                return Task.CompletedTask;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Custom DeserializationContext
            sb.AppendLine("        private class GrpcDeserializationContext : DeserializationContext");
            sb.AppendLine("        {");
            sb.AppendLine("            private readonly Stream _stream;");
            sb.AppendLine();
            sb.AppendLine("            public GrpcDeserializationContext(Stream stream)");
            sb.AppendLine("            {");
            sb.AppendLine("                _stream = stream;");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override int PayloadLength => -1; // Unknown length");
            sb.AppendLine();
            sb.AppendLine("            public override byte[] PayloadAsNewBuffer()");
            sb.AppendLine("            {");
            sb.AppendLine("                using var ms = new MemoryStream();");
            sb.AppendLine("                _stream.CopyTo(ms);");
            sb.AppendLine("                return ms.ToArray();");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override ReadOnlySequence<byte> PayloadAsReadOnlySequence()");
            sb.AppendLine("            {");
            sb.AppendLine("                return new ReadOnlySequence<byte>(PayloadAsNewBuffer());");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            // Custom SerializationContext
            sb.AppendLine("        private class GrpcSerializationContext : SerializationContext");
            sb.AppendLine("        {");
            sb.AppendLine("            private readonly Stream _stream;");
            sb.AppendLine();
            sb.AppendLine("            public GrpcSerializationContext(Stream stream)");
            sb.AppendLine("            {");
            sb.AppendLine("                _stream = stream;");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override void Complete(byte[] payload)");
            sb.AppendLine("            {");
            sb.AppendLine("                _stream.Write(payload, 0, payload.Length);");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override Task CompleteAsync(byte[] payload)");
            sb.AppendLine("            {");
            sb.AppendLine("                return _stream.WriteAsync(payload, 0, payload.Length).AsTask();");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public async Task CompleteAsync()");
            sb.AppendLine("            {");
            sb.AppendLine("                await _stream.FlushAsync();");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override IBufferWriter<byte> GetBufferWriter()");
            sb.AppendLine("            {");
            sb.AppendLine("                throw new NotImplementedException(\"Buffer writer not supported\");");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override void SetPayloadLength(int payloadLength)");
            sb.AppendLine("            {");
            sb.AppendLine("                // No-op, not needed for direct stream writing");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine("            public override void Complete()");
            sb.AppendLine("            {");
            sb.AppendLine("                _stream.Flush();");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
            
            sb.AppendLine("        #endregion");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            
            // Write file
            File.WriteAllText(Path.Combine(_outputPath, "GrpcServiceExtensions.cs"), sb.ToString());
        }
    }
}
