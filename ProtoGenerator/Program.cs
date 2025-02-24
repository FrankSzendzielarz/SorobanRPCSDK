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

    /*
     * 1. DONE Fix the problems with the Stellar RPC Client codegen producing an object for empty parameters, this should fix the missing methods in the Protobuf service. Also fix the nested collections thing.

2. DONE Modify XDR gen to also add protobuf fields

3. DONE Extract interfaces from all manual partials and make them ServiceContract 

4. DONE Change all the methods on the Manual Partial so they don't return byte[] but meaningful types (eg PrivateKey) so that protobuf-net doesn't have to work with native types

5. DONE Modify protogen to scan the assembly for service contracts and do it automatically.

6. Test the  builder.Services.AddCodeFirstGrpc(); is working in the Native AOT project. We don't need to manually register any services. 

The above should make everything automatic wrt to protobuf
    */



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