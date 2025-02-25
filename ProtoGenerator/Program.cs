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
                string outputPath = args.Length > 0 ? args[0] : "./";

                var generator = new ProtoBuf.Grpc.Reflection.SchemaGenerator();

                var options = new SchemaGenerationOptions
                {
                    Syntax = ProtoSyntax.Proto3,
                    Package = "stellar.rpc.v1",
                };
      
                foreach (var schema in GetServiceContractTypes())
                {
                    options.Package = schema.Key;
                    var proto = generator.GetSchema(schema.Value.ToArray());
                    proto= FixEnumZeroValues(proto);
                    File.WriteAllText(Path.Combine(outputPath,schema.Key+".proto"), proto);
                }  

                Console.WriteLine($"Generated proto schema at: {outputPath}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
                return 1;
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
        public static  Dictionary<string, List<Type>> GetServiceContractTypes()
        {
            // Load the assembly
            Assembly assembly = Assembly.GetAssembly(typeof(StellarRPCClient));

            // Find all types decorated with ServiceContract attribute
            var contractsDictionary = assembly.GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(ServiceContractAttribute), true).Any())
                .GroupBy(type => type.Namespace)
                .ToDictionary(
                    group => group.Key??"",
                    group => group.ToList()
                );

            return contractsDictionary;
        }
    }
}