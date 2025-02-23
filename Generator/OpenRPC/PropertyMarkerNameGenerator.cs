using NJsonSchema;
using NJsonSchema.CodeGeneration;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.OpenRPC
{
    public class PropertyMarkerNameGenerator : IPropertyNameGenerator
    {
        private readonly CSharpPropertyNameGenerator _baseGenerator = new CSharpPropertyNameGenerator();
        private readonly Dictionary<JsonSchema, int> _typeCounters = new Dictionary<JsonSchema, int>();

        public string Generate(JsonSchemaProperty property)
        {
            // Get the parent type name (the class/type this property belongs to)
            //var parentTypeName = property.ParentSchema?.Title ?? "Unknown";

            // Initialize or get the counter for this type
            if (!_typeCounters.ContainsKey(property.ParentSchema))
            {
                _typeCounters[property.ParentSchema] = 1;
            }

            var memberNumber = _typeCounters[property.ParentSchema]++;
            var propertyName = _baseGenerator.Generate(property);
            if (!IsNestedCollection(property))
            {
                return $"[ProtoBuf.ProtoMember({memberNumber})] {propertyName}";
            }
            else
            {
                return $"{propertyName}";
            }

        }
        private bool IsNestedCollection(JsonSchemaProperty property)
        {
            return property.Type == JsonObjectType.Array &&
                   property.Item?.Type == JsonObjectType.Array;
        }

    }
}
