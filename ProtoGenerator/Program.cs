using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Reflection;
using ProtoBuf.Meta;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace Stellar.RPC.Tools
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length == 0 || args[0] == "--help" || args[0] == "-h")
                {
                    Console.WriteLine("Usage: ProtoGenerator [options]");
                    Console.WriteLine();
                    Console.WriteLine("Options:");
                    Console.WriteLine("  --proto <path>       Generate .proto files to specified directory (default: ./proto)");
                    Console.WriteLine("  --grpc-aot <path>    Generate AOT-compatible gRPC code to specified directory (default: ./GrpcAot)");
                    Console.WriteLine("  --namespace <ns>     Namespace for generated gRPC code (default: Stellar.RPC.AOT)");
                    Console.WriteLine("  --help, -h           Show this help message");
                    return 0;
                }

                string protoOutputPath = "./proto";
                string grpcAotOutputPath = null;
                string serviceNamespace = "Stellar.RPC.AOT";

                // Parse command line arguments
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "--proto" && i + 1 < args.Length)
                    {
                        protoOutputPath = args[++i];
                    }
                    else if (args[i] == "--grpc-aot" && i + 1 < args.Length)
                    {
                        grpcAotOutputPath = args[++i];
                    }
                    else if (args[i] == "--namespace" && i + 1 < args.Length)
                    {
                        serviceNamespace = args[++i];
                    }
                }

                // Get the assembly containing the service contracts
                Assembly assembly = Assembly.GetAssembly(typeof(StellarRPCClient));

                // Create output directories if they don't exist
                Directory.CreateDirectory(protoOutputPath);
                if (grpcAotOutputPath != null)
                {
                    Directory.CreateDirectory(grpcAotOutputPath);
                }

                // Generate .proto files
                Console.WriteLine("Generating .proto files...");
                GenerateProtoFiles(assembly, protoOutputPath);

                // Generate gRPC AOT code if requested
                if (grpcAotOutputPath != null)
                {
                    Console.WriteLine("Generating AOT-compatible gRPC code...");
                    var generator = new GrpcAotGenerator(assembly, grpcAotOutputPath, serviceNamespace);
                    generator.GenerateAotGrpcServices();
                }

                Console.WriteLine("Done!");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
                return 1;
            }
        }

        private static void GenerateProtoFiles(Assembly assembly, string outputPath)
        {
            var generator = new ProtoBuf.Grpc.Reflection.SchemaGenerator();

            var options = new SchemaGenerationOptions
            {
                Syntax = ProtoSyntax.Proto3,
                Package = "stellar.rpc.v1",
            };

            foreach (var schema in GetServiceContractTypes(assembly))
            {
                options.Package = schema.Key;
                var proto = generator.GetSchema(schema.Value.ToArray());
                proto = FixEnumZeroValues(proto);
                string filePath = Path.Combine(outputPath, schema.Key + ".proto");
                File.WriteAllText(filePath, proto);
                Console.WriteLine($"  Generated: {filePath}");
            }
        }

        public static string FixEnumZeroValues(string protoContent)
        {
            // This pattern matches:
            // 1. enum name capture group
            // 2. opening brace and whitespace
            // 3. ZERO = 0 line capture group
            var pattern = @"enum\s+(\w+)\s*\{[\r\n\s]*?(ZERO\s*=\s*0\s*;[^\r\n]*(?:\r?\n|\r))";

            return Regex.Replace(protoContent, pattern, (Match m) =>
            {
                var enumName = m.Groups[1].Value;
                var zeroLine = m.Groups[2].Value;

                // Replace "ZERO" with "{EnumName} _ZERO"
                var fixedZeroLine = zeroLine.Replace("ZERO", $"{enumName}_ZERO");

                return $"enum {enumName} {{{Environment.NewLine}   {fixedZeroLine}";
            });
        }

        public static Dictionary<string, List<Type>> GetServiceContractTypes(Assembly assembly)
        {
            // Find all types decorated with ServiceContract attribute
            var contractsDictionary = assembly.GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any())
                .GroupBy(type => type.Namespace)
                .ToDictionary(
                    group => group.Key ?? "",
                    group => group.ToList()
                );

            return contractsDictionary;
        }
    }
}