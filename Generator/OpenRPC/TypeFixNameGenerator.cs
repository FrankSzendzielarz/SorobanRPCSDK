using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generator.OpenRPC
{
    public class TypeFixNameGenerator : ITypeNameGenerator
    {
        private readonly ITypeNameGenerator _baseGenerator;

        // Static collection to track all generated types
        public static HashSet<string> GeneratedTypeNames { get; } = new HashSet<string>();

        public TypeFixNameGenerator(ITypeNameGenerator baseGenerator)
        {
            _baseGenerator = baseGenerator;
        }

        public string Generate(JsonSchema schema, string? typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            if (typeNameHint != null)
            {
                typeNameHint = Regex.Replace(typeNameHint, @"\[.*?\]", "");
            }

            string typeName = _baseGenerator.Generate(schema, typeNameHint, reservedTypeNames);

            // Add the type name to our collection
            if (!string.IsNullOrEmpty(typeName))
            {
                GeneratedTypeNames.Add(typeName);
            }

            return typeName;
        }

        // Add a method to reset the type tracking (for multiple generator runs)
        public static void ResetTypeTracking()
        {
            GeneratedTypeNames.Clear();
        }
    }
}
