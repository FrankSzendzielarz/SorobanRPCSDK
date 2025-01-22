using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;
using System.Text;

namespace Generator.CodeGenVisitors;

public class CSharpCodeGenVisitor : StellarXdrBaseVisitor<object>
{
    private class TypeContext
    {
        public string? Namespace { get; set; }
        public Stack<string> TypeStack { get; } = new();
        public string CurrentPath => string.Join(".", TypeStack.Reverse());
        public string CurrentNamespace => Namespace ?? "StellarGenerated";
    }

    private readonly string _outputDir;
    private readonly TypeContext _context = new();

    public CSharpCodeGenVisitor(string outputDir)
    {
        _outputDir = outputDir;
    }

    public override object VisitNamespaceDefinition([NotNull] StellarXdrParser.NamespaceDefinitionContext context)
    {
        _context.Namespace = context.identifier().GetText();
        return base.VisitNamespaceDefinition(context);
    }

    public override object VisitEnumDefinition([NotNull] StellarXdrParser.EnumDefinitionContext context)
    {
        var enumName = context.identifier().GetText();
        _context.TypeStack.Push(enumName);

        try
        {
            GenerateEnum(context);
        }
        finally
        {
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitStructDefinition([NotNull] StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        _context.TypeStack.Push(structName);

        try
        {
            GenerateStruct(context);
        }
        finally
        {
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitUnionDefinition([NotNull] StellarXdrParser.UnionDefinitionContext context)
    {
        var unionName = context.identifier().GetText();
        _context.TypeStack.Push(unionName);

        try
        {
            GenerateUnion(context);
        }
        finally
        {
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitTypedefDefinition([NotNull] StellarXdrParser.TypedefDefinitionContext context)
    {
        var typedefName = context.declaration().identifier().GetText();
        _context.TypeStack.Push(typedefName);

        try
        {
            GenerateTypedef(context);
        }
        finally
        {
            _context.TypeStack.Pop();
        }

        return null;
    }

    private void GenerateEnum(StellarXdrParser.EnumDefinitionContext context)
    {
        var enumName = context.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{enumName}.cs");

        // Start with file header
        code.AppendLine("// Generated code - do not modify");
        code.AppendLine();
        code.AppendLine($"namespace {_context.CurrentNamespace}");
        code.AppendLine("{");

        // Generate enum
        code.AppendLine($"    public enum {enumName}");
        code.AppendLine("    {");

        // Add enum values
        var enumMembers = context.enumBody().enumMember();
        foreach (var member in enumMembers)
        {
            var name = member.identifier(0).GetText(); // First identifier is the enum member name
            string value;

            if (member.constant() != null)
            {
                value = member.constant().GetText();
            }
            else if (member.identifier().Length > 1)
            {
                // If there's a second identifier, it's referencing another enum value
                value = member.identifier(1).GetText();
            }
            else
            {
                value = "0";
            }

            code.AppendLine($"        {name} = {value},");
        }

        code.AppendLine("    }");
        code.AppendLine();

        // Generate static helper class for XDR serialization
        code.AppendLine($"    public static class {enumName}Xdr");
        code.AppendLine("    {");

        // Add Encode method
        code.AppendLine($"        public static void Encode(XdrDataOutputStream stream, {enumName} value)");
        code.AppendLine("        {");
        code.AppendLine("            stream.WriteInt((int)value);");
        code.AppendLine("        }");
        code.AppendLine();

        // Add Decode method
        code.AppendLine($"        public static {enumName} Decode(XdrDataInputStream stream)");
        code.AppendLine("        {");
        code.AppendLine("            int value = stream.ReadInt();");
        code.AppendLine("            switch (value)");
        code.AppendLine("            {");

        foreach (var member in enumMembers)
        {
            var name = member.identifier(0).GetText();
            string value;

            if (member.constant() != null)
            {
                value = member.constant().GetText();
            }
            else if (member.identifier().Length > 1)
            {
                value = member.identifier(1).GetText();
            }
            else
            {
                value = "0";
            }

            code.AppendLine($"                case {value}: return {enumName}.{name};");
        }

        code.AppendLine("                default:");
        code.AppendLine("                    throw new Exception(\"Unknown enum value: \" + value);");
        code.AppendLine("            }");
        code.AppendLine("        }");

        // Close classes and namespace
        code.AppendLine("    }");
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private void GenerateTypedef(StellarXdrParser.TypedefDefinitionContext context)
    {
        var declaration = context.declaration();
        var typedefName = declaration.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{typedefName}.cs");

        // Start with file header
        code.AppendLine("// Generated code - do not modify");
        code.AppendLine();
        code.AppendLine($"namespace {_context.CurrentNamespace}");
        code.AppendLine("{");

        code.AppendLine($"    public class {typedefName}");
        code.AppendLine("    {");

        var typeSpecifier = declaration.typeSpecifier();
        var baseType = GetCSharpType(typeSpecifier);

        if (declaration.arraySizeSpec() != null)
        {
            // Array types
            code.AppendLine($"        public {baseType}[] InnerValue {{ get; set; }} = default({baseType}[]);");
        }
        else
        {
            // Simple types
            code.AppendLine($"        public {baseType} InnerValue {{ get; set; }} = default({baseType});");
        }

        code.AppendLine();
        code.AppendLine($"        public {typedefName}() {{ }}");
        code.AppendLine();

        // Constructor
        if (declaration.arraySizeSpec() != null)
        {
            code.AppendLine($"        public {typedefName}({baseType}[] value)");
        }
        else
        {
            code.AppendLine($"        public {typedefName}({baseType} value)");
        }
        code.AppendLine("        {");
        code.AppendLine("            InnerValue = value;");
        code.AppendLine("        }");

        // Close main class
        code.AppendLine("    }");
        code.AppendLine();

        // Generate XDR helper class
        code.AppendLine($"    public static class {typedefName}Xdr");
        code.AppendLine("    {");
        code.AppendLine($"        public static void Encode(XdrDataOutputStream stream, {typedefName} value)");
        code.AppendLine("        {");
        if (declaration.arraySizeSpec() != null)
        {
            var arraySpec = declaration.arraySizeSpec();
            if (arraySpec.value() != null)
            {
                // Fixed size array
                var size = arraySpec.value().GetText();
                code.AppendLine($"            if (value.InnerValue.Length != {size})");
                code.AppendLine($"                throw new Exception($\"Fixed array size must be {size}\");");
            }
            else
            {
                // Variable size array
                code.AppendLine("            stream.WriteInt(value.InnerValue.Length);");
            }
            code.AppendLine("            foreach(var item in value.InnerValue)");
            code.AppendLine("            {");
            code.AppendLine($"                {GetEncodeStatement(typeSpecifier, "item")};");
            code.AppendLine("            }");
        }
        else
        {
            code.AppendLine($"            {GetEncodeStatement(typeSpecifier, "value.InnerValue")};");
        }
        code.AppendLine("        }");
        code.AppendLine();

        code.AppendLine($"        public static {typedefName} Decode(XdrDataInputStream stream)");
        code.AppendLine("        {");
        code.AppendLine($"            var value = new {typedefName}();");
        if (declaration.arraySizeSpec() != null)
        {
            var arraySpec = declaration.arraySizeSpec();
            code.AppendLine("            int length;");
            if (arraySpec.value() != null)
            {
                // Fixed size array
                code.AppendLine($"            length = {arraySpec.value().GetText()};");
            }
            else
            {
                // Variable size array
                code.AppendLine("            length = stream.ReadInt();");
            }

            code.AppendLine($"            value.InnerValue = new {baseType}[length];");
            code.AppendLine("            for(int i = 0; i < length; i++)");
            code.AppendLine("            {");
            code.AppendLine($"                value.InnerValue[i] = {GetDecodeStatement(typeSpecifier)};");
            code.AppendLine("            }");
        }
        else
        {
            code.AppendLine($"            value.InnerValue = {GetDecodeStatement(typeSpecifier)};");
        }
        code.AppendLine("            return value;");
        code.AppendLine("        }");
        code.AppendLine("    }");

        // Close namespace
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private void GenerateStruct(StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{structName}.cs");

        // Start with file header
        code.AppendLine("// Generated code - do not modify");
        code.AppendLine();
        code.AppendLine($"namespace {_context.CurrentNamespace}");
        code.AppendLine("{");

        // Generate struct class
        code.AppendLine($"    public partial class {structName}");
        code.AppendLine("    {");

        // Add properties for each field
        var members = context.structBody().structMember();
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                var fieldType = GetFieldType(decl);
                var fieldName = decl.identifier().GetText();
                code.AppendLine($"        public {fieldType} {fieldName} {{ get; set; }}");
            }
            // Handle void declarations if needed
        }
        code.AppendLine();

        // Add constructor
        code.AppendLine($"        public {structName}()");
        code.AppendLine("        {");
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                var text = decl.GetText();
                if (text.StartsWith("opaque") && decl.arraySizeSpec()?.value() != null)
                {
                    // Initialize fixed-size opaque arrays
                    var fieldName = decl.identifier().GetText();
                    var size = decl.arraySizeSpec().value().GetText();
                    code.AppendLine($"            {fieldName} = new byte[{size}];");
                }
            }
        }
        code.AppendLine("        }");
        code.AppendLine();

        // Generate static helper class for XDR serialization
        code.AppendLine($"    public static partial class {structName}Xdr");
        code.AppendLine("    {");

        // Add Encode method
        code.AppendLine($"        public static void Encode(XdrDataOutputStream stream, {structName} value)");
        code.AppendLine("        {");
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                var fieldName = decl.identifier().GetText();
                var encodeLine = GetEncodeStatementForField(decl, $"value.{fieldName}");
                code.AppendLine($"            {encodeLine};");
            }
        }
        code.AppendLine("        }");
        code.AppendLine();

        // Add Decode method
        code.AppendLine($"        public static {structName} Decode(XdrDataInputStream stream)");
        code.AppendLine("        {");
        code.AppendLine($"            var value = new {structName}();");
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                var fieldName = decl.identifier().GetText();
                var decodeLine = GetDecodeStatementForField(decl);
                code.AppendLine($"            value.{fieldName} = {decodeLine};");
            }
        }
        code.AppendLine("            return value;");
        code.AppendLine("        }");

        // Close classes and namespace
        code.AppendLine("    }");
        code.AppendLine("    }");
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private string GetCSharpType(StellarXdrParser.TypeSpecifierContext typeSpecifier)
    {
        var decl = typeSpecifier.Parent as StellarXdrParser.DeclarationContext;
        if (decl != null)
        {
            if (decl.GetText().StartsWith("opaque"))
                return "byte[]";
            if (decl.GetText().StartsWith("string"))
                return "string";
        }

        var text = typeSpecifier.GetText();
        return text switch
        {
            "unsigned int" => "uint",
            "int" => "int",
            "unsigned hyper" => "ulong",
            "hyper" => "long",
            "float" => "float",
            "double" => "double",
            "bool" => "bool",
            _ => typeSpecifier.identifier()?.GetText() ?? "object"
        };
    }

    private string GetEncodeStatement(StellarXdrParser.TypeSpecifierContext typeSpecifier, string valueName)
    {
        var decl = typeSpecifier.Parent as StellarXdrParser.DeclarationContext;
        if (decl != null)
        {
            // Handle opaque
            if (decl.GetText().StartsWith("opaque"))
            {
                var arraySizeSpec = decl.arraySizeSpec();
                if (arraySizeSpec?.value() != null)
                {
                    // Fixed length
                    var size = arraySizeSpec.value().GetText();
                    return $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName}, {size})";
                }
                else
                {
                    // Variable length with optional max
                    var maxSize = arraySizeSpec?.value()?.GetText();
                    return maxSize != null
                        ? $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName}, {maxSize})"
                        : $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName})";
                }
            }

            // Handle string
            if (decl.GetText().StartsWith("string"))
            {
                var maxLength = decl.arraySizeSpec()?.value()?.GetText() ?? "0";
                return $"XdrSpecialTypeHandler.EncodeString(stream, {valueName}, {maxLength})";
            }
        }

        var text = typeSpecifier.GetText();
        return text switch
        {
            "unsigned int" => $"stream.WriteUInt({valueName})",
            "int" => $"stream.WriteInt({valueName})",
            "unsigned hyper" => $"stream.WriteULong({valueName})",
            "hyper" => $"stream.WriteLong({valueName})",
            "float" => $"stream.WriteFloat({valueName})",
            "double" => $"stream.WriteDouble({valueName})",
            "bool" => $"stream.WriteInt({valueName} ? 1 : 0)",
            _ => $"{typeSpecifier.identifier()?.GetText()}Xdr.Encode(stream, {valueName})"
        };
    }

    private string GetDecodeStatement(StellarXdrParser.TypeSpecifierContext typeSpecifier)
    {
        var decl = typeSpecifier.Parent as StellarXdrParser.DeclarationContext;
        if (decl != null)
        {
            if (decl.GetText().StartsWith("opaque"))
            {
                var arraySizeSpec = decl.arraySizeSpec();
                if (arraySizeSpec?.value() != null)
                {
                    var size = arraySizeSpec.value().GetText();
                    return $"XdrSpecialTypeHandler.DecodeOpaque(stream, {size})";
                }
                return "XdrSpecialTypeHandler.DecodeOpaque(stream)";
            }

            if (decl.GetText().StartsWith("string"))
            {
                var maxLength = decl.arraySizeSpec()?.value()?.GetText() ?? "0";
                return $"XdrSpecialTypeHandler.DecodeString(stream, {maxLength})";
            }
        }

        var text = typeSpecifier.GetText();
        return text switch
        {
            "unsigned int" => "stream.ReadUInt()",
            "int" => "stream.ReadInt()",
            "unsigned hyper" => "stream.ReadULong()",
            "hyper" => "stream.ReadLong()",
            "float" => "stream.ReadFloat()",
            "double" => "stream.ReadDouble()",
            "bool" => "stream.ReadInt() != 0",
            _ => $"{typeSpecifier.identifier()?.GetText()}Xdr.Decode(stream)"
        };
    }

    private bool IsOptional(StellarXdrParser.DeclarationContext decl)
    {
        // In XDR, optional is marked with *
        return decl.GetText().Contains("*");
    }

    private void GenerateUnion(StellarXdrParser.UnionDefinitionContext context)
    {
        var unionName = context.identifier().GetText();
        var switchDecl = context.unionBody().declaration();
        var discriminatorType = GetCSharpType(switchDecl.typeSpecifier());
        var cases = context.unionBody().caseSpec();
        var defaultCase = context.unionBody().defaultCase();

        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{unionName}.cs");

        // Start with file header
        code.AppendLine("// Generated code - do not modify");
        code.AppendLine();
        code.AppendLine($"namespace {_context.CurrentNamespace}");
        code.AppendLine("{");

        // Generate abstract base class
        code.AppendLine($"    public partial abstract class {unionName}");
        code.AppendLine("    {");
        code.AppendLine($"        public abstract {discriminatorType} Discriminator {{ get; }}");
        code.AppendLine("    }");
        code.AppendLine();

        // Generate derived classes for each case
        foreach (var caseSpec in cases)
        {
            // Get all case values for this specification
            var caseValues = new List<string>();
            for (int i = 0; i < caseSpec.value().Length; i++)
            {
                var value = caseSpec.value(i);
                caseValues.Add(value.GetText());
            }

            var decl = caseSpec.declaration();
            bool isVoidDeclaration = decl.typeSpecifier() == null;

            if (isVoidDeclaration)
            {
                // For void cases, generate a simple class with just the discriminator
                foreach (var caseValue in caseValues)
                {
                    var className = $"{unionName}_{caseValue}";
                    code.AppendLine($"    public partial class {className} : {unionName}");
                    code.AppendLine("    {");
                    code.AppendLine($"        public override {discriminatorType} Discriminator => {caseValue};");
                    code.AppendLine("    }");
                    code.AppendLine();
                }
            }
            else
            {
                // For non-void cases, include the data
                var fieldType = GetFieldType(decl);
                var fieldName = decl.identifier().GetText();

                foreach (var caseValue in caseValues)
                {
                    var className = $"{unionName}_{caseValue}";
                    code.AppendLine($"    public partial class {className} : {unionName}");
                    code.AppendLine("    {");
                    code.AppendLine($"        public override {discriminatorType} Discriminator => {caseValue};");
                    code.AppendLine($"        public {fieldType} {fieldName} {{ get; set; }}");
                    code.AppendLine("    }");
                    code.AppendLine();
                }
            }
        }

        // Handle default case if present
        if (defaultCase != null)
        {
            var defaultDecl = defaultCase.declaration();
            bool isVoidDefault = defaultDecl.typeSpecifier() == null;

            if (!isVoidDefault)
            {
                var fieldType = GetFieldType(defaultDecl);
                var fieldName = defaultDecl.identifier().GetText();

                code.AppendLine($"    public partial class {unionName}_Default : {unionName}");
                code.AppendLine("    {");
                code.AppendLine($"        private readonly {discriminatorType} _discriminator;");
                code.AppendLine($"        public override {discriminatorType} Discriminator => _discriminator;");
                code.AppendLine($"        public {fieldType} {fieldName} {{ get; set; }}");
                code.AppendLine();
                code.AppendLine($"        public {unionName}_Default({discriminatorType} discriminator)");
                code.AppendLine("        {");
                code.AppendLine("            _discriminator = discriminator;");
                code.AppendLine("        }");
                code.AppendLine("    }");
                code.AppendLine();
            }
        }

        // Generate static helper class for XDR serialization
        code.AppendLine($"    public static partial class {unionName}Xdr");
        code.AppendLine("    {");

        // Add Encode method
        code.AppendLine($"        public static void Encode(XdrDataOutputStream stream, {unionName} value)");
        code.AppendLine("        {");
        code.AppendLine($"            {GetEncodeStatement(switchDecl.typeSpecifier(), "value.Discriminator")};");
        code.AppendLine("            switch (value)");
        code.AppendLine("            {");

        foreach (var caseSpec in cases)
        {
            foreach (var caseValue in caseSpec.value())
            {
                var className = $"{unionName}_{caseValue.GetText()}";
                code.AppendLine($"                case {className} v_{caseValue.GetText()}:");

                var decl = caseSpec.declaration();
                bool isVoidDeclaration = decl.typeSpecifier() == null;
                if (!isVoidDeclaration)
                {
                    var fieldName = decl.identifier().GetText();
                    code.AppendLine($"                    {GetEncodeStatementForField(decl, $"v_{caseValue.GetText()}.{fieldName}")};");
                }
                code.AppendLine("                    break;");
            }
        }

        if (defaultCase != null)
        {
            code.AppendLine($"                case {unionName}_Default defaultCase:");
            var defaultDecl = defaultCase.declaration();
            bool isVoidDeclaration = defaultDecl.typeSpecifier() == null;
            if (!isVoidDeclaration)
            {
                var fieldName = defaultDecl.identifier().GetText();
                code.AppendLine($"                    {GetEncodeStatementForField(defaultDecl, $"defaultCase.{fieldName}")};");
            }
            code.AppendLine("                    break;");
        }

        code.AppendLine("                default:");
        code.AppendLine("                    throw new Exception($\"Unknown {unionName} type: {value.GetType().Name}\");");
        code.AppendLine("            }");
        code.AppendLine("        }");
        code.AppendLine();

        // Add Decode method
        code.AppendLine($"        public static {unionName} Decode(XdrDataInputStream stream)");
        code.AppendLine("        {");
        code.AppendLine($"            var discriminator = {GetDecodeStatement(switchDecl.typeSpecifier())};");
        code.AppendLine("            switch (discriminator)");
        code.AppendLine("            {");

        foreach (var caseSpec in cases)
        {
            foreach (var caseValue in caseSpec.value())
            {
                code.AppendLine($"                case {caseValue.GetText()}:");
                var className = $"{unionName}_{caseValue.GetText()}";
                code.AppendLine($"                    var result_{caseValue.GetText()} = new {className}();");

                var decl = caseSpec.declaration();
                bool isVoidDeclaration = decl.typeSpecifier() == null;
                if (!isVoidDeclaration)
                {
                    var fieldName = decl.identifier().GetText();
                    code.AppendLine($"                    result_{caseValue.GetText()}.{fieldName} = {GetDecodeStatementForField(decl)};");
                }
                code.AppendLine($"                    return result_{caseValue.GetText()};");
            }
        }

        if (defaultCase != null)
        {
            code.AppendLine("                default:");
            code.AppendLine($"                    var defaultResult = new {unionName}_Default(discriminator);");
            var defaultDecl = defaultCase.declaration();
            bool isVoidDeclaration = defaultDecl.typeSpecifier() == null;
            if (!isVoidDeclaration)
            {
                var fieldName = defaultDecl.identifier().GetText();
                code.AppendLine($"                    defaultResult.{fieldName} = {GetDecodeStatementForField(defaultDecl)};");
            }
            code.AppendLine("                    return defaultResult;");
        }
        else
        {
            code.AppendLine("                default:");
            code.AppendLine("                    throw new Exception($\"Unknown discriminator for {unionName}: {discriminator}\");");
        }

        code.AppendLine("            }");
        code.AppendLine("        }");

        // Close classes and namespace
        code.AppendLine("    }");
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private string GetFieldType(StellarXdrParser.DeclarationContext decl)
    {
        if (decl.typeSpecifier() == null)
            return null;  // void case

        var text = decl.GetText();
        // Check for special types
        if (text.StartsWith("opaque"))
        {
            return "byte[]";
        }
        if (text.StartsWith("string"))
        {
            return "string";
        }

        // Check if it's optional (marked with *)
        bool isOptional = text.Contains("*");
        var baseType = GetCSharpType(decl.typeSpecifier());
        return isOptional ? $"{baseType}?" : baseType;
    }

    private string GetEncodeStatementForField(StellarXdrParser.DeclarationContext decl, string valueName)
    {
        if (decl.typeSpecifier() == null)
            return null;  // void case

        var text = decl.GetText();
        if (text.StartsWith("opaque"))
        {
            var arraySizeSpec = decl.arraySizeSpec();
            if (arraySizeSpec?.value() != null)
            {
                // Fixed length opaque
                return $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName}, {arraySizeSpec.value().GetText()})";
            }
            else
            {
                // Variable length opaque
                var maxSize = arraySizeSpec?.value()?.GetText();
                return maxSize != null
                    ? $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName}, {maxSize})"
                    : $"XdrSpecialTypeHandler.EncodeOpaque(stream, {valueName})";
            }
        }

        if (text.StartsWith("string"))
        {
            var maxLength = decl.arraySizeSpec()?.value()?.GetText() ?? "0";
            return $"XdrSpecialTypeHandler.EncodeString(stream, {valueName}, {maxLength})";
        }

        // Check if it's optional
        if (text.Contains("*"))
        {
            var innerType = GetCSharpType(decl.typeSpecifier());
            return $"XdrSpecialTypeHandler.EncodeOptional(stream, {valueName}, {innerType}Xdr.Encode)";
        }

        // Default to normal encoding
        return GetEncodeStatement(decl.typeSpecifier(), valueName);
    }

    private string GetDecodeStatementForField(StellarXdrParser.DeclarationContext decl)
    {
        if (decl.typeSpecifier() == null)
            return null;  // void case

        var text = decl.GetText();
        if (text.StartsWith("opaque"))
        {
            var arraySizeSpec = decl.arraySizeSpec();
            if (arraySizeSpec?.value() != null)
            {
                return $"XdrSpecialTypeHandler.DecodeOpaque(stream, {arraySizeSpec.value().GetText()})";
            }
            return "XdrSpecialTypeHandler.DecodeOpaque(stream)";
        }

        if (text.StartsWith("string"))
        {
            var maxLength = decl.arraySizeSpec()?.value()?.GetText() ?? "0";
            return $"XdrSpecialTypeHandler.DecodeString(stream, {maxLength})";
        }

        // Check if it's optional
        if (text.Contains("*"))
        {
            var innerType = GetCSharpType(decl.typeSpecifier());
            return $"XdrSpecialTypeHandler.DecodeOptional(stream, {innerType}Xdr.Decode)";
        }

        // Default to normal decoding
        return GetDecodeStatement(decl.typeSpecifier());
    }

    private string ExtractComments(ParserRuleContext context)
    {
        // TODO: Extract any comments before this context for documentation
        return string.Empty;
    }
}