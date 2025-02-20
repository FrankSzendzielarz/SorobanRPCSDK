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
        ITypeNameGenerator _baseGenerator;
        public TypeFixNameGenerator(ITypeNameGenerator baseGenerator)
        {
            _baseGenerator=baseGenerator;
        }
        public string Generate(JsonSchema schema, string? typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            if (typeNameHint != null)
            {
                typeNameHint = Regex.Replace(typeNameHint, @"\[.*?\]", "");
            }
            string baseName= _baseGenerator.Generate(schema, typeNameHint, reservedTypeNames);
            return baseName;
        }
    }
}
