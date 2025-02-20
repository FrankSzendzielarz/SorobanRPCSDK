using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Reflection;
using ProtoBuf.Meta;

namespace Stellar.RPC.Tools
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                string outputPath = args.Length > 0 ? args[0] : "./stellar-rpc.proto";


                //var model = RuntimeTypeModel.Create();
                //var sdkAssembly = typeof(SimulateTransactionResult).Assembly;

                //var types = sdkAssembly.GetTypes()
                //    .Where(type => (type.Namespace == "Stellar.RPC" || type.Namespace == "Stellar")
                //        && !type.Name.Contains("JsonRpcResponse"))
                //    .ToList();

                //// Process all non-union types first
                //foreach (var type in types.Where(t => !t.IsAbstract))
                //{
                //    Console.WriteLine($"Processing type: {type.FullName}");
                //    var metaType = model.Add(type, false);

                //    if (type.IsNested)
                //    {
                //        metaType.Name = type.FullName.Replace("+", ".");
                //    }

                //    // Get all properties for this type
                //    var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                //        .Where(p => p.DeclaringType == type && p.Name != "Discriminator");

                //    int fieldNumber = 1;
                //    foreach (var prop in properties)
                //    {
                //        if (prop.GetCustomAttribute<NonSerializedAttribute>() != null ||
                //            prop.PropertyType == typeof(object) ||
                //            prop.PropertyType.IsPointer ||
                //            prop.PropertyType.IsByRef)
                //        {
                //            Console.WriteLine($"Skipping property {type.FullName}.{prop.Name}");
                //            continue;
                //        }

                //        try
                //        {
                //            Console.WriteLine($"Adding property {prop.Name} to {type.FullName}");
                //            var field = metaType.Add(fieldNumber, prop.Name);

                //            if (prop.PropertyType.IsEnum)
                //            {
                //                model.Add(prop.PropertyType, false);
                //            }
                //            else if (prop.PropertyType.IsGenericType)
                //            {
                //                Type genericTypeDef = prop.PropertyType.GetGenericTypeDefinition();
                //                if (genericTypeDef == typeof(List<>) ||
                //                    genericTypeDef == typeof(IList<>) ||
                //                    genericTypeDef == typeof(ICollection<>) ||
                //                    genericTypeDef == typeof(IEnumerable<>))
                //                {
                //                    field.IsGroup = true;
                //                }
                //            }

                //            fieldNumber++;
                //        }
                //        catch (Exception ex)
                //        {
                //            Console.WriteLine($"Warning: Failed to add property {prop.Name} to {type.FullName}: {ex.Message}");
                //        }
                //    }
                //}

                //// Handle union types (abstract base classes with Discriminator)
                //foreach (var abstractType in types.Where(t => t.IsAbstract))
                //{
                //    var discriminatorProp = abstractType.GetProperty("Discriminator");
                //    if (discriminatorProp != null)
                //    {
                //        Console.WriteLine($"Processing union type: {abstractType.FullName}");

                //        var metaType = model.Add(abstractType, false);
                //        if (abstractType.IsNested)
                //        {
                //            metaType.Name = abstractType.FullName.Replace("+", ".");
                //        }

                //        var unionCases = abstractType.GetNestedTypes()
                //            .Where(t => t.IsClass && !t.IsAbstract)
                //            .ToList();

                //        foreach (var caseType in unionCases)
                //        {
                //            Console.WriteLine($"Processing union case: {caseType.Name}");

                //            var caseMetaType = model.Add(caseType, false);

                //            var properties = caseType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                //                .Where(p => p.Name != "Discriminator" && p.DeclaringType == caseType);

                //            int fieldNumber = 1;
                //            foreach (var prop in properties)
                //            {
                //                try
                //                {
                //                    Console.WriteLine($"Adding property {prop.Name} to {caseType.Name}");
                //                    var field = caseMetaType.Add(fieldNumber++, prop.Name);

                //                    if (prop.PropertyType.IsEnum)
                //                    {
                //                        model.Add(prop.PropertyType, false);
                //                    }
                //                    else if (prop.PropertyType.IsGenericType)
                //                    {
                //                        Type genericTypeDef = prop.PropertyType.GetGenericTypeDefinition();
                //                        if (genericTypeDef == typeof(List<>) ||
                //                            genericTypeDef == typeof(IList<>) ||
                //                            genericTypeDef == typeof(ICollection<>) ||
                //                            genericTypeDef == typeof(IEnumerable<>))
                //                        {
                //                            field.IsGroup = true;
                //                        }
                //                    }
                //                }
                //                catch (Exception ex)
                //                {
                //                    Console.WriteLine($"Warning: Failed to add property {prop.Name} to {caseType.Name}: {ex.Message}");
                //                }
                //            }
                //        }
                //    }
                //}

                var generator = new ProtoBuf.Grpc.Reflection.SchemaGenerator();

                var options = new SchemaGenerationOptions
                {
                    Syntax = ProtoSyntax.Proto3,
                    Package = "stellar.rpc.v1",
                     
                };


                string schema = generator.GetSchema<StellarRPCClient>();
               // string schema2 = generator.GetSchema<MuxedAccount>();
                //var schema = model.GetSchema(options);
                File.WriteAllText(outputPath, schema);
                Console.WriteLine($"Generated proto schema at: {outputPath}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
                return 1;
            }
        }
    }
}