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
        private readonly bool _verbose;

        public GrpcAotGenerator(Assembly targetAssembly, string outputPath, string serviceNamespace = "Stellar.RPC.AOT", bool verbose = false)
        {
            _targetAssembly = targetAssembly;
            _outputPath = outputPath;
            _namespace = serviceNamespace;
            _verbose = verbose;
        }

        public void GenerateAotGrpcServices()
        {
            // Find all service contracts in the assembly
            var serviceContracts = FindAllServiceContracts();

            Console.WriteLine($"Found {serviceContracts.Count} service contracts");

            // Find all proto contract types
            var protoContractTypes = FindAllProtoContracts();

            // Special handling for SCSpecTypeDef nested types
            var nestedTypes = FindNestedTypes();

            // Add nested types to the list of types to process
            foreach (var type in nestedTypes)
            {
                if (!protoContractTypes.Contains(type))
                {
                    protoContractTypes.Add(type);
                    Console.WriteLine($"Added nested type to generation list: {type.DeclaringType.Name}.{type.Name}");
                }
            }

            Console.WriteLine($"Total of {protoContractTypes.Count} types to process");

            // Generate service adapters for each service contract
            foreach (var serviceContract in serviceContracts)
            {
                GenerateServiceAdapter(serviceContract);
            }

            // Generate marshallers for all proto contract types
            foreach (var type in protoContractTypes)
            {
                GenerateTypeMarshaller(type);
            }

            // Generate registration extensions
            GenerateRegistrationExtensions(serviceContracts, protoContractTypes);
        }

        private List<Type> FindAllServiceContracts()
        {
            var contracts = new List<Type>();

            // Direct approach - look for ServiceContract attribute
            var withAttribute = _targetAssembly.GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any())
                .ToList();
            contracts.AddRange(withAttribute);

            // Also look for types that implement interface with ServiceContract
            var implementingServiceContract = _targetAssembly.GetTypes()
                .Where(type => !type.IsInterface && !type.IsAbstract)
                .Where(type => type.GetInterfaces().Any(i => i.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any()))
                .ToList();
            contracts.AddRange(implementingServiceContract);

            // Look for types with "RPC" or "Service" in the name as a fallback
            //var byNamingConvention = _targetAssembly.GetTypes()
            //    .Where(type => (type.Name.Contains("RPC") || type.Name.Contains("Service") ||
            //                  type.Name.EndsWith("Client")) &&
            //                  !type.IsAbstract &&
            //                  type.IsPublic)
            //    .Where(type => !contracts.Contains(type))
            //    .ToList();

            //// Check if they have methods that look like service operations
            //var potentialServices = byNamingConvention
            //    .Where(type => HasPotentialServiceMethods(type))
            //    .ToList();

            //contracts.AddRange(potentialServices);

            // Remove duplicates while preserving order
            return contracts.Distinct().ToList();
        }

        private bool HasPotentialServiceMethods(Type type)
        {
            return type.GetMethods()
                .Any(m => m.IsPublic &&
                         !m.IsStatic &&
                         !m.IsSpecialName && // Exclude property accessors
                         m.GetParameters().Length > 0 && // Has at least one parameter
                         m.ReturnType != typeof(void) && // Returns something
                         (m.ReturnType.IsGenericType || m.ReturnType.IsClass)); // Returns a complex type
        }

        private List<Type> FindAllProtoContracts()
        {
            // Find all types with ProtoContract attribute
            var withAttribute = _targetAssembly.GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(ProtoContractAttribute), true).Any())
                .ToList();

            // Also look for types with naming patterns suggesting they're proto contracts
            //var byNamingConvention = _targetAssembly.GetTypes()
            //    .Where(type => type.Name.EndsWith("Request") ||
            //                  type.Name.EndsWith("Response") ||
            //                  type.Name.EndsWith("Params") ||
            //                  type.Name.EndsWith("Result") ||
            //                  type.Name.Contains("_ProtoWrapper"))
            //    .Where(type => !withAttribute.Contains(type) && !type.IsAbstract && type.IsPublic)
            //    .ToList();

            // Combine and remove duplicates
            return withAttribute.Distinct().ToList();
        }

        // Update the service adapter generation to properly handle nested types in method descriptors

        // Update GenerateServiceAdapter to use dot notation consistently

        private void GenerateServiceAdapter(Type serviceContract)
        {
            // Find all public instance methods that could be service operations
            var operations = serviceContract.GetMethods()
                .Where(m => m.IsPublic && !m.IsStatic && !m.IsSpecialName) // Public instance methods, excluding property accessors
                .Where(m => m.GetParameters().Length > 0) // Must have at least one parameter (request)
                .Where(m => m.ReturnType != typeof(void)) // Must return something
                .ToList();

            if (!operations.Any())
            {
                Console.WriteLine($"Warning: No suitable operations found for {serviceContract.FullName}");
                return;
            }

            Console.WriteLine($"Generating service adapter for {serviceContract.FullName} with {operations.Count} operations");

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
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System.Buffers;");
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
                if (methodName == "Equals") continue;
                var requestType = operation.GetParameters().FirstOrDefault()?.ParameterType;
                var responseType = operation.ReturnType.IsGenericType ?
                    operation.ReturnType.GetGenericArguments()[0] :
                    operation.ReturnType;

                if (requestType == null || responseType == null)
                {
                    Console.WriteLine($"  Warning: Skipping method {methodName} - cannot determine request or response type");
                    continue;
                }

                // Get proper type names with dot notation
                string requestTypeName = GetTypeNameWithDotSeparators(requestType);
                string responseTypeName = GetTypeNameWithDotSeparators(responseType);

                // Get marshaller class and property names
                string requestMarshallerClass = GetCleanClassName(requestType) + "GrpcMarshaller";
                string responseMarshallerClass = GetCleanClassName(responseType) + "GrpcMarshaller";

                sb.AppendLine($"        /// <summary>Method descriptor for {methodName}</summary>");
                sb.AppendLine($"        public static readonly Method<{requestTypeName}, {responseTypeName}> {methodName}Method =");
                sb.AppendLine($"            new Method<{requestTypeName}, {responseTypeName}>(");
                sb.AppendLine("                MethodType.Unary,");
                sb.AppendLine($"                ServiceName,");
                sb.AppendLine($"                \"{methodName}\",");
                sb.AppendLine($"                {requestMarshallerClass}.{requestType.Name}Marshaller,");
                sb.AppendLine($"                {responseMarshallerClass}.{responseType.Name}Marshaller);");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine();

            // Generate marshaller class
            sb.AppendLine($"    /// <summary>Custom marshallers for {serviceName} types</summary>");
            sb.AppendLine($"    public static class {serviceImplName}GrpcMarshaller");
            sb.AppendLine("    {");

            // Get all unique types used in the service
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

            // Static constructor to configure types
            sb.AppendLine("        // Static constructor to configure types");
            sb.AppendLine($"        static {serviceImplName}GrpcMarshaller()");
            sb.AppendLine("        {");
            sb.AppendLine("            ConfigureTypes();");
            sb.AppendLine("        }");
            sb.AppendLine();

            // ConfigureTypes method
            sb.AppendLine("        /// <summary>Configure type serialization</summary>");
            sb.AppendLine("        public static void ConfigureTypes()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Get runtime type model");
            sb.AppendLine("            var model = RuntimeTypeModel.Default;");
            sb.AppendLine();
            sb.AppendLine("            // Ensure types are configured for AOT compatibility");

            foreach (var type in allTypes)
            {
                // Use dot notation for typeof expressions - this is critical!
                string typeNameWithDots = GetTypeNameWithDotSeparators(type);

                sb.AppendLine($"            if (!model.IsDefined(typeof({typeNameWithDots})))");
                sb.AppendLine("            {");
                sb.AppendLine($"                model.Add(typeof({typeNameWithDots}), true);");
                sb.AppendLine("            }");
            }

            sb.AppendLine();
            sb.AppendLine("            // Pre-compile serializers for AOT compatibility");
            sb.AppendLine("            model.CompileInPlace();");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Generate marshaller properties for all types
            foreach (var type in allTypes)
            {
                string typeNameWithDots = GetTypeNameWithDotSeparators(type);

                sb.AppendLine($"        /// <summary>Marshaller for {type.Name}</summary>");
                sb.AppendLine($"        public static readonly Marshaller<{typeNameWithDots}> {type.Name}Marshaller = Marshallers.Create<{typeNameWithDots}>(");
                sb.AppendLine("            (message, serializationContext) =>");
                sb.AppendLine("            {");
                sb.AppendLine("                try");
                sb.AppendLine("                {");
                sb.AppendLine("                    var ms = new MemoryStream();");
                sb.AppendLine("                    Serializer.Serialize(ms, message);");
                sb.AppendLine("                    var buffer = ms.ToArray();");
                sb.AppendLine("                    serializationContext.Complete(buffer);");
                sb.AppendLine("                }");
                sb.AppendLine("                catch (Exception ex)");
                sb.AppendLine("                {");
                sb.AppendLine("                    throw new RpcException(new Status(StatusCode.Internal, $\"Serialization error: {ex.Message}\"));");
                sb.AppendLine("                }");
                sb.AppendLine("            },");
                sb.AppendLine("            (deserializationContext) =>");
                sb.AppendLine("            {");
                sb.AppendLine("                try");
                sb.AppendLine("                {");
                sb.AppendLine("                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();");
                sb.AppendLine("                    using (var ms = new MemoryStream(buffer))");
                sb.AppendLine("                    {");
                sb.AppendLine($"                        return Serializer.Deserialize<{typeNameWithDots}>(ms);");
                sb.AppendLine("                    }");
                sb.AppendLine("                }");
                sb.AppendLine("                catch (Exception ex)");
                sb.AppendLine("                {");
                sb.AppendLine("                    throw new RpcException(new Status(StatusCode.Internal, $\"Deserialization error: {ex.Message}\"));");
                sb.AppendLine("                }");
                sb.AppendLine("            });");
                sb.AppendLine();
            }

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

                string requestTypeWithDots = GetTypeNameWithDotSeparators(requestType);
                string responseTypeWithDots = GetTypeNameWithDotSeparators(responseType);

                var isAsync = operation.ReturnType.IsGenericType &&
                                (operation.ReturnType.GetGenericTypeDefinition() == typeof(Task<>) ||
                                operation.ReturnType.GetGenericTypeDefinition() == typeof(ValueTask<>));

                sb.AppendLine($"        /// <summary>Handler for {methodName} method</summary>");
                sb.AppendLine($"        public async Task<{responseTypeWithDots}> {methodName}({requestTypeWithDots} request, ServerCallContext context)");
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
            try
            {
                File.WriteAllText(Path.Combine(_outputPath, fileName), sb.ToString());
                Console.WriteLine($"  Generated {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error writing {fileName}: {ex.Message}");
            }
        }

        private void PreserveProtobufAttributes(Type type, StringBuilder sb)
        {
            // Get runtime type model
            sb.AppendLine("            var model = RuntimeTypeModel.Default;");
            sb.AppendLine();

            string typeNameWithDots = GetTypeNameWithDotSeparators(type);

            sb.AppendLine($"            // Configure {typeNameWithDots}");
            sb.AppendLine($"            if (!model.IsDefined(typeof({typeNameWithDots})))");
            sb.AppendLine("            {");

            // Add the type to the model
            sb.AppendLine($"                var metaType = model.Add(typeof({typeNameWithDots}), true);");

            // Get all properties with ProtoMember attributes
            var protoMemberProps = type.GetProperties()
                .Where(p => p.GetCustomAttributes(typeof(ProtoMemberAttribute), true).Any())
                .ToList();

            if (protoMemberProps.Any())
            {
                sb.AppendLine();
                sb.AppendLine("                // Add all properties with their original ProtoMember numbers");

                foreach (var prop in protoMemberProps)
                {
                    // Get the ProtoMember attribute to extract the tag number
                    var protoMemberAttr = prop.GetCustomAttributes(typeof(ProtoMemberAttribute), true)
                        .Cast<ProtoMemberAttribute>()
                        .FirstOrDefault();

                    if (protoMemberAttr != null)
                    {
                        var tagNumber = protoMemberAttr.Tag;
                        sb.AppendLine($"                metaType.Add({tagNumber}, \"{prop.Name}\");");
                    }
                }
            }

            // Add all ProtoInclude attributes
            var protoIncludes = type.GetCustomAttributes(typeof(ProtoIncludeAttribute), true)
                .Cast<ProtoIncludeAttribute>()
                .ToList();

            if (protoIncludes.Any())
            {
                sb.AppendLine();
                sb.AppendLine("                // Add all ProtoInclude references with their original tag numbers");

                foreach (var include in protoIncludes)
                {
                    var tagNumber = include.Tag;
                    var subType = include.KnownType;
                    string subTypeNameWithDots = GetTypeNameWithDotSeparators(subType);

                    sb.AppendLine($"                metaType.AddSubType({tagNumber}, typeof({subTypeNameWithDots}));");
                }
            }

            sb.AppendLine("            }");
        }


        private string GetTypeNameWithDotSeparators(Type type)
        {
            if (!type.IsNested)
            {
                return type.FullName;
            }

            // Start with the namespace
            var result = type.Namespace + ".";

            // Build the list of types from outermost to innermost
            var parts = new List<string>();
            var currentType = type;

            while (currentType != null)
            {
                if (currentType.IsNested)
                {
                    // Add this nested type to our parts list
                    parts.Add(currentType.Name);
                    // Move to the declaring type
                    currentType = currentType.DeclaringType;
                }
                else
                {
                    // This is the outermost type - add it and break
                    parts.Add(currentType.Name);
                    break;
                }
            }

            // Reverse the parts to get outermost first
            parts.Reverse();

            // Join with dots and return
            return result + string.Join(".", parts);
        }


        // Get full type name with dot notation for nested types
        private string GetFullTypeNameWithDots(Type type)
        {
            if (!type.IsNested)
            {
                // For non-nested types, just return the full name
                return type.FullName;
            }

            // For nested types, we need to build the full path
            var parts = new List<string>();
            var currentType = type;

            // Add the type and all its declaring types to the list
            while (currentType != null)
            {
                parts.Add(currentType.Name);
                currentType = currentType.DeclaringType;
            }

            // Reverse the list to get the correct order from outer to inner
            parts.Reverse();

            // Combine with the namespace
            return $"{type.Namespace}.{string.Join(".", parts)}";
        }

        // Get typeof expression with dot notation
        private string GetTypeofExpressionWithDots(Type type)
        {
            if (!type.IsNested)
            {
                // For non-nested types, use the standard typeof expression
                return $"typeof({type.FullName})";
            }

            // For nested types, we need to use the + notation for typeof
            // because C# doesn't allow nested type access through typeof with dot notation
            var currentType = type;
            var declaringTypes = new Stack<string>();

            // Build the hierarchy in reverse
            while (currentType.IsNested)
            {
                declaringTypes.Push(currentType.Name);
                currentType = currentType.DeclaringType;
            }

            // Start with the outermost type's full name
            var typeExpression = currentType.FullName;

            // Add each nested level with + notation
            while (declaringTypes.Count > 0)
            {
                typeExpression += "+" + declaringTypes.Pop();
            }

            return $"typeof({typeExpression})";
        }

      



        // Fix the GenerateTypeMarshaller method to use DOT notation consistently everywhere
        private void GenerateTypeMarshaller(Type type)
        {
            // Skip if this is a service
            if (type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any())
                return;

            // Get the clean type name for the marshaller class
            var marshallerClassName = GetCleanClassName(type);
            var fileName = $"{marshallerClassName}GrpcMarshaller.cs";

            Console.WriteLine($"Generating marshaller for {type.FullName}");

            var sb = new StringBuilder();

            // Add file header
            sb.AppendLine("// Generated code - do not modify directly");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System.Buffers;");
            sb.AppendLine("using Grpc.Core;");
            sb.AppendLine("using ProtoBuf;");
            sb.AppendLine("using ProtoBuf.Meta;");

            // Add the namespace of the type
            if (!string.IsNullOrEmpty(type.Namespace))
            {
                sb.AppendLine($"using {type.Namespace};");
            }

            sb.AppendLine();
            sb.AppendLine($"namespace {_namespace}");
            sb.AppendLine("{");

            // Generate marshaller class
            sb.AppendLine($"    /// <summary>Custom marshaller for {type.FullName}</summary>");
            sb.AppendLine($"    public static class {marshallerClassName}GrpcMarshaller");
            sb.AppendLine("    {");

            // Static constructor
            sb.AppendLine("        // Static constructor to configure type");
            sb.AppendLine($"        static {marshallerClassName}GrpcMarshaller()");
            sb.AppendLine("        {");
            sb.AppendLine("            ConfigureTypes();");
            sb.AppendLine("        }");
            sb.AppendLine();

            // ConfigureTypes method
            sb.AppendLine("        /// <summary>Configure type serialization</summary>");
            sb.AppendLine("        public static void ConfigureTypes()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Get runtime type model");
            sb.AppendLine();

            // Get the type name with dot notation for C# code
            string typeNameForCode = GetTypeNameWithDotSeparators(type);

            
            PreserveProtobufAttributes(type, sb);

            sb.AppendLine("            // Pre-compile serializer for AOT compatibility");
            sb.AppendLine("            model.CompileInPlace();");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Marshaller property - use dot notation
            sb.AppendLine($"        /// <summary>Marshaller for {type.Name}</summary>");
            sb.AppendLine($"        public static readonly Marshaller<{typeNameForCode}> {type.Name}Marshaller = Marshallers.Create<{typeNameForCode}>(");
            sb.AppendLine("            (message, serializationContext) =>");
            sb.AppendLine("            {");
            sb.AppendLine("                try");
            sb.AppendLine("                {");
            sb.AppendLine("                    var ms = new MemoryStream();");
            sb.AppendLine("                    Serializer.Serialize(ms, message);");
            sb.AppendLine("                    var buffer = ms.ToArray();");
            sb.AppendLine("                    serializationContext.Complete(buffer);");
            sb.AppendLine("                }");
            sb.AppendLine("                catch (Exception ex)");
            sb.AppendLine("                {");
            sb.AppendLine("                    throw new RpcException(new Status(StatusCode.Internal, $\"Serialization error: {ex.Message}\"));");
            sb.AppendLine("                }");
            sb.AppendLine("            },");
            sb.AppendLine("            (deserializationContext) =>");
            sb.AppendLine("            {");
            sb.AppendLine("                try");
            sb.AppendLine("                {");
            sb.AppendLine("                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();");
            sb.AppendLine("                    using (var ms = new MemoryStream(buffer))");
            sb.AppendLine("                    {");
            sb.AppendLine($"                        return Serializer.Deserialize<{typeNameForCode}>(ms);");
            sb.AppendLine("                    }");
            sb.AppendLine("                }");
            sb.AppendLine("                catch (Exception ex)");
            sb.AppendLine("                {");
            sb.AppendLine("                    throw new RpcException(new Status(StatusCode.Internal, $\"Deserialization error: {ex.Message}\"));");
            sb.AppendLine("                }");
            sb.AppendLine("            });");
            sb.AppendLine();

            sb.AppendLine("    }");
            sb.AppendLine("}");

            // Write file
            try
            {
                File.WriteAllText(Path.Combine(_outputPath, fileName), sb.ToString());
                Console.WriteLine($"  Generated {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error writing {fileName}: {ex.Message}");
            }
        }

        private List<Type> FindNestedTypes()
        {
            var result = new List<Type>();

            // Look for SCSpecTypeDef class
            var scSpecTypeDefClass = _targetAssembly.GetTypes()
                .FirstOrDefault(t => t.Name == "SCSpecTypeDef");

            if (scSpecTypeDefClass != null)
            {
                Console.WriteLine($"Found SCSpecTypeDef class: {scSpecTypeDefClass.FullName}");

                // Get all its nested types
                var nestedTypes = scSpecTypeDefClass.GetNestedTypes();
                result.AddRange(nestedTypes);

                Console.WriteLine($"Found {nestedTypes.Length} nested types within SCSpecTypeDef");
                foreach (var type in nestedTypes)
                {
                    Console.WriteLine($"  - {type.Name}");
                }
            }
            else
            {
                Console.WriteLine("Could not find SCSpecTypeDef class!");
            }

            return result;
        }

        // Update the registration method to correctly handle nested types
        private void GenerateRegistrationExtensions(List<Type> serviceContracts, List<Type> protoContractTypes)
        {
            var sb = new StringBuilder();

            // Add file header
            sb.AppendLine("// Generated code - do not modify directly");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System.Buffers;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Threading;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Grpc.Core;");
            sb.AppendLine("using Microsoft.AspNetCore.Builder;");
            sb.AppendLine("using Microsoft.AspNetCore.Http;");
            sb.AppendLine("using Microsoft.AspNetCore.Routing;");
            sb.AppendLine("using Microsoft.Extensions.DependencyInjection;");
            sb.AppendLine("using Microsoft.Extensions.Logging;");
            sb.AppendLine("using ProtoBuf;");

            // Add namespaces for all service contracts
            var namespaces = serviceContracts
                .Select(t => t.Namespace)
                .Union(protoContractTypes.Select(t => t.Namespace))
                .Where(ns => !string.IsNullOrEmpty(ns))
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
                    // Only try to register implementation if the interface starts with I
                    sb.AppendLine($"            services.AddScoped<{serviceName}, {serviceImplName}>();");
                }
                else
                {
                    // Just register the concrete type
                    sb.AppendLine($"            services.AddScoped<{serviceName}>();");
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

            // First the service-specific marshallers
            foreach (var serviceContract in serviceContracts)
            {
                var serviceName = serviceContract.Name;
                var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;

                sb.AppendLine($"            {serviceImplName}GrpcMarshaller.ConfigureTypes();");
            }

            // Then the type-specific marshallers
            foreach (var type in protoContractTypes)
            {
                // Skip if this is a service, a primitive type, or a type already handled
                if (type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any() ||
                    type.IsPrimitive)
                    continue;

                string marshallerClassName;

                // Handle nested types specially
                if (type.IsNested)
                {
                    // For SCSpecTypeDef+ScSpecTypeBytes, use SCSpecTypeDefScSpecTypeBytesGrpcMarshaller
                    marshallerClassName = $"{GetCleanClassName(type)}GrpcMarshaller";
                }
                else
                {
                    // For regular types
                    marshallerClassName = $"{type.Name}GrpcMarshaller";
                }

                sb.AppendLine($"            {marshallerClassName}.ConfigureTypes();");
            }

            sb.AppendLine();


            foreach (var serviceContract in serviceContracts)
            {
                var serviceName = serviceContract.Name;
                var serviceImplName = serviceName.StartsWith("I") ? serviceName.Substring(1) : serviceName;

                var operations = serviceContract.GetMethods()
                    .Where(m => m.IsPublic && !m.IsStatic && !m.IsSpecialName)
                    .Where(m => m.GetParameters().Length > 0)
                    .Where(m => m.ReturnType != typeof(void))
                    .ToList();

                if (!operations.Any())
                    continue;

                sb.AppendLine($"            // Map {serviceName} methods");
                foreach (var operation in operations)
                {
                    var methodName = operation.Name;
                    var requestType = operation.GetParameters().FirstOrDefault()?.ParameterType;
                    var responseType = operation.ReturnType.IsGenericType ?
                        operation.ReturnType.GetGenericArguments()[0] :
                        operation.ReturnType;

                    if (requestType == null || responseType == null)
                        continue;

                    string requestTypeFullName = GetFullTypeNameWithDots(requestType);
                    string responseTypeFullName = GetFullTypeNameWithDots(responseType);

        
                    sb.AppendLine($"            endpoints.MapPost(\"/{serviceImplName}/{methodName}\", async context =>");
                    sb.AppendLine("            {");
                    sb.AppendLine($"                var service = context.RequestServices.GetRequiredService<{serviceImplName}GrpcService>();");
                    sb.AppendLine("                var serverCallContext = CreateServerCallContext(context);");
                    sb.AppendLine("                try");
                    sb.AppendLine("                {");
                    sb.AppendLine("                    // Read and deserialize request");
                    sb.AppendLine("                    using var ms = new MemoryStream();");
                    sb.AppendLine("                    await context.Request.Body.CopyToAsync(ms);");
                    sb.AppendLine("                    ms.Position = 0;");
                    sb.AppendLine($"                    var request = Serializer.Deserialize<{requestTypeFullName}>(ms);");
                    sb.AppendLine();
                    sb.AppendLine("                    // Call service method");
                    sb.AppendLine($"                    var response = await service.{methodName}(request, serverCallContext);");
                    sb.AppendLine();
                    sb.AppendLine("                    // Serialize and send response");
                    sb.AppendLine("                    context.Response.ContentType = \"application/grpc\";");
                    sb.AppendLine("                    context.Response.Headers.Add(\"grpc-status\", \"0\");");
                    sb.AppendLine("                    using var responseMs = new MemoryStream();");
                    sb.AppendLine("                    Serializer.Serialize(responseMs, response);");
                    sb.AppendLine("                    responseMs.Position = 0;");
                    sb.AppendLine("                    await responseMs.CopyToAsync(context.Response.Body);");
                    sb.AppendLine("                }");
                    sb.AppendLine("                catch (Exception ex)");
                    sb.AppendLine("                {");
                    sb.AppendLine("                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;");
                    sb.AppendLine("                    context.Response.Headers.Add(\"grpc-status\", \"2\");");
                    sb.AppendLine("                    context.Response.Headers.Add(\"grpc-message\", ex.Message);");
                    sb.AppendLine($"                    var logger = context.RequestServices.GetService<ILogger<{serviceImplName}GrpcService>>();");
                    sb.AppendLine($"                    logger?.LogError(ex, \"Error in {serviceImplName}/{methodName}\");");
                    sb.AppendLine("                }");
                    sb.AppendLine("            });");
                }
                sb.AppendLine();
            }

            sb.AppendLine("            return endpoints;");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Helper methods for request/response handling
            sb.AppendLine("        private static async Task<byte[]> ReadRequestBodyAsync(HttpRequest request)");
            sb.AppendLine("        {");
            sb.AppendLine("            using (var ms = new MemoryStream())");
            sb.AppendLine("            {");
            sb.AppendLine("                await request.Body.CopyToAsync(ms);");
            sb.AppendLine("                return ms.ToArray();");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("        private static object DeserializeRequest(byte[] requestBytes, Type requestType)");
            sb.AppendLine("        {");
            sb.AppendLine("            using (var ms = new MemoryStream(requestBytes))");
            sb.AppendLine("            {");
            sb.AppendLine("                return typeof(Serializer).GetMethod(\"Deserialize\", new[] { typeof(Stream) })");
            sb.AppendLine("                    .MakeGenericMethod(requestType)");
            sb.AppendLine("                    .Invoke(null, new object[] { ms });");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("        private static byte[] SerializeResponse(object response)");
            sb.AppendLine("        {");
            sb.AppendLine("            using (var ms = new MemoryStream())");
            sb.AppendLine("            {");
            sb.AppendLine("                typeof(Serializer).GetMethod(\"Serialize\", new[] { typeof(Stream), response.GetType() })");
            sb.AppendLine("                    .Invoke(null, new object[] { ms, response });");
            sb.AppendLine("                return ms.ToArray();");
            sb.AppendLine("            }");
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

            sb.AppendLine("        #endregion");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            // Write file
            try
            {
                File.WriteAllText(Path.Combine(_outputPath, "GrpcServiceExtensions.cs"), sb.ToString());
                Console.WriteLine($"  Generated GrpcServiceExtensions.cs");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error writing GrpcServiceExtensions.cs: {ex.Message}");
            }
        }
        // Helper method to get clean class name (without special characters)
        private string GetCleanClassName(Type type)
        {
            if (!type.IsNested)
            {
                return type.Name;
            }

            // For nested types, include all declaring types
            return BuildNestedTypeNameForClass(type);
        }

        // Helper method to build a type name with all declaring types
        private string BuildNestedTypeNameForClass(Type type)
        {
            if (!type.IsNested)
            {
                return type.Name;
            }

            return BuildNestedTypeNameForClass(type.DeclaringType) + type.Name;
        }

     
    }
}