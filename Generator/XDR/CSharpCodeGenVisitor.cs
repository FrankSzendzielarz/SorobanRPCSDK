

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;
using System.Text;
using System.Text.RegularExpressions;
using static Generator.XDR.Grammar.StellarXdrParser;

namespace Generator.XDR;


public partial class CSharpCodeGenVisitor : StellarXdrBaseVisitor<object>
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
    private readonly Dictionary<IToken, string> _commentMap = new();

    public CSharpCodeGenVisitor(string outputDir, CommonTokenStream tokenStream)
    {
        _outputDir = outputDir;
        BuildCommentMap(tokenStream);
    }

    private void BuildCommentMap(CommonTokenStream tokenStream)
    {
        var tokens = tokenStream.GetTokens();
        IToken? lastToken = null;

        foreach (var token in tokens)
        {
            if (token.Channel == Lexer.Hidden)
            {
                if (token.Type == StellarXdrLexer.BLOCK_COMMENT ||
                    token.Type == StellarXdrLexer.LINE_COMMENT)
                {
                    if (lastToken != null)
                    {
                        string comment = token.Text;
                        comment = comment.Replace("/*", "").Replace("*/", "")
                                      .Replace("//", "").Trim();
                        if (!string.IsNullOrWhiteSpace(comment))
                        {
                            _commentMap[lastToken] = comment;
                        }
                    }
                }
            }
            lastToken = token;
        }
    }

    private string GetDocumentationComment(ParserRuleContext context, bool isProperty = false)
    {
        if (_commentMap.TryGetValue(context.Start, out var comment))
        {
            var lines = comment.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            sb.AppendLine(isProperty ? "    /// <value>" : "    /// <summary>");
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    sb.AppendLine($"    /// {trimmedLine}");
                }
            }
            sb.AppendLine(isProperty ? "    /// </value>" : "    /// </summary>");
            return sb.ToString();
        }
        return string.Empty;
    }

    private IEnumerable<string> ExtractConstraints(string comment)
    {
        var constraints = new List<string>();
        var constraintRegex = new Regex(@"(\d+(?:-\d+)?)\s*((?:alphanum(?:eric)?|byte|char|character)s?)");
        var matches = constraintRegex.Matches(comment);

        foreach (Match match in matches)
        {
            var size = match.Groups[1].Value;
            var type = match.Groups[2].Value;
            constraints.Add($"Requires {size} {type}");
        }
        return constraints;
    }

    public override object VisitNamespaceDefinition([NotNull] StellarXdrParser.NamespaceDefinitionContext context)
    {
        _context.Namespace = context.identifier().GetText();
        Console.WriteLine($"Visiting namespace: {_context.Namespace}");
        return base.VisitNamespaceDefinition(context);
    }

    public override object VisitEnumDefinition([NotNull] StellarXdrParser.EnumDefinitionContext context)
    {
        var enumName = context.identifier().GetText();
        Console.WriteLine($"Visiting enum: {enumName}");
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
        Console.WriteLine($"Visiting struct: {structName}");
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
        Console.WriteLine($"Visiting union: {unionName}");
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
        Console.WriteLine($"Visiting typedef: {typedefName}");
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

    private void WriteFileHeader(StringBuilder code, ParserRuleContext context)
    {
        code.AppendLine("// Generated code - do not modify");
        code.AppendLine($"// Source: {context.Start.InputStream.SourceName}");
        code.AppendLine();
        code.AppendLine("#nullable enable");
        code.AppendLine();
        code.AppendLine($"namespace {_context.CurrentNamespace};");
        code.AppendLine();
    }

    protected CSharpTypeInfo GetCSharpTypeInfo(StellarXdrParser.DeclarationContext decl)
    {
        var text = decl.GetText();
        var arraySizeSpec = decl.arraySizeSpec();
        ArrayType arrayType = ArrayType.None;
        int? maxLength = null;
        if (arraySizeSpec != null)
        {
            if (arraySizeSpec is FixedArraySizeContext fixedArray)
            {
                arrayType = ArrayType.Fixed;
                maxLength = int.Parse(fixedArray.value().GetText());
            }

            if (arraySizeSpec is VarArraySizeContext varArray)
            {
                arrayType = ArrayType.Variable;
                maxLength = varArray?.value()?.constant() != null ? int.Parse(varArray.value().constant().GetText()) : null;
            }
        }
       
        if (text.StartsWith("opaque"))
            return new CSharpTypeInfo("byte", arrayType, maxLength);

        if (text.StartsWith("string"))
            return new CSharpTypeInfo("string", arrayType, maxLength);

        var baseType = decl.typeSpecifier().GetText() switch
        {
            "unsigned int" => "uint",
            "int" => "int",
            "unsigned hyper" => "ulong",
            "hyper" => "long",
            "float" => "float",
            "double" => "double",
            "bool" => "bool",
            _ => decl.typeSpecifier().identifier()?.GetText() ?? "object"
        };

        return new CSharpTypeInfo(baseType, arrayType, maxLength);
    }
    private void GenerateEnum(StellarXdrParser.EnumDefinitionContext context)
    {
        var enumName = context.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{enumName}.cs");

        WriteFileHeader(code, context);

        var docComment = GetDocumentationComment(context);
        if (!string.IsNullOrEmpty(docComment))
        {
            code.Append(docComment);
        }

        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public partial enum {enumName}");
        code.AppendLine("{");

        var enumMembers = context.enumBody().enumMember();
        foreach (var member in enumMembers)
        {
            var memberDoc = GetDocumentationComment(member);
            if (!string.IsNullOrEmpty(memberDoc))
            {
                code.Append(memberDoc);
            }

            var name = member.identifier(0).GetText();
            string value;

            if (member.constant() != null)
                value = member.constant().GetText();
            else if (member.identifier().Length > 1)
                value = member.identifier(1).GetText();
            else
                value = "0";

            code.AppendLine($"    {name} = {value},");
        }

        code.AppendLine("}");
        code.AppendLine();

        // Generate static XDR helper class
        code.AppendLine($"public static partial class {enumName}Xdr");
        code.AppendLine("{");
        code.AppendLine("    /// <summary>Encodes enum value to XDR stream</summary>");
        code.AppendLine($"    public static void Encode(XdrWriter stream, {enumName} value)");
        code.AppendLine("    {");
        code.AppendLine("       stream.WriteEnumValue((int)value);");
        code.AppendLine("    }");
        code.AppendLine();

        code.AppendLine("    /// <summary>Decodes enum value from XDR stream</summary>");
        code.AppendLine($"    public static {enumName} Decode(XdrReader stream)");
        code.AppendLine("    {");
        code.AppendLine("        var value = stream.ReadEnumValue();");
        code.AppendLine($"        if (!Enum.IsDefined(typeof({enumName}), value))");
        code.AppendLine($"            throw new InvalidOperationException($\"Unknown {enumName} value: {{value}}\");");
        code.AppendLine($"        return ({enumName})value;");
        code.AppendLine("    }");
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private void GenerateStruct(StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{structName}.cs");

        WriteFileHeader(code, context);

        var docComment = GetDocumentationComment(context);
        if (!string.IsNullOrEmpty(docComment))
        {
            code.Append(docComment);
        }

        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public partial class {structName}");
        code.AppendLine("{");

        // Generate properties
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() == null) continue;

            var memberDoc = GetDocumentationComment(member, true);
            if (!string.IsNullOrEmpty(memberDoc))
            {
                code.Append(memberDoc);
            }

            var fieldType = GetCSharpTypeInfo(decl);
            var fieldName = decl.identifier().GetText();
            GenerateProperty(code, decl, fieldType, fieldName);
            code.AppendLine();
        }

        // Generate constructor
        code.AppendLine($"    public {structName}()");
        code.AppendLine("    {");
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() == null) continue;

            GenerateInitialization(code, decl);
        }
        code.AppendLine("    }");
        code.AppendLine();

        // Generate validation method
        code.AppendLine("    /// <summary>Validates all fields have valid values</summary>");
        code.AppendLine("    public virtual void Validate()");
        code.AppendLine("    {");
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                GenerateValidation(code, decl);
            }
        }
        code.AppendLine("    }");

        code.AppendLine("}");
        code.AppendLine();

        // Generate XDR helper class
        GenerateStructXdrHelperClass(code, structName, context.structBody().structMember());

        File.WriteAllText(filename, code.ToString());
    }

    private void GenerateProperty(StringBuilder code, StellarXdrParser.DeclarationContext decl,
                                CSharpTypeInfo fieldType, string fieldName)
    {


        switch (fieldType.ArrayType)
        {
            case ArrayType.Fixed:
                code.AppendLine($"    private {fieldType.CSharpType}[] _value = new {fieldType.CSharpType}[{fieldType.MaxLength}];");
                break;
            case ArrayType.Variable:
                code.AppendLine($"    private {fieldType.CSharpType}[] _value;");
                break;
            case ArrayType.None:
                code.AppendLine($"    private {fieldType.CSharpType} _value;");
                break;

        }

        code.AppendLine($"    public {fieldType.FullCSharpType} {fieldName}");
        code.AppendLine("    {");
        code.AppendLine($"        get => _{fieldName.ToCamelCase()};");
        code.AppendLine("        set");
        code.AppendLine("        {");

        GeneratePropertyValidation(code, decl, "value", fieldType);

        code.AppendLine($"            _{fieldName.ToCamelCase()} = value;");
        code.AppendLine("        }");
        code.AppendLine("    }");


    }

    private void GenerateInitialization(StringBuilder code, StellarXdrParser.DeclarationContext decl)
    {
        var typeInfo = GetCSharpTypeInfo(decl);

        if (typeInfo.ArrayType == ArrayType.Fixed)
        {
            var size = typeInfo.MaxLength;
            var fieldName = decl.identifier().GetText();
            var fieldType = typeInfo.CSharpType;
            code.AppendLine($"        {fieldName} = new {fieldType}[{size}];");
        }
    }

    private void GenerateValidation(StringBuilder code, StellarXdrParser.DeclarationContext decl)
    {
        var typeInfo = GetCSharpTypeInfo(decl);
        var fieldName = decl.identifier().GetText();


        if (typeInfo.ArrayType == ArrayType.Fixed)
        {
            var size = typeInfo.MaxLength;
            code.AppendLine($"        if ({fieldName}.Length != {size})");
            code.AppendLine($"            throw new InvalidOperationException($\"{fieldName} must be exactly {size} elements\");");
        }
        else if (typeInfo.ArrayType == ArrayType.Variable)
        {
            var maxSize = typeInfo.MaxLength;
            code.AppendLine($"        if ({fieldName}.Length > {maxSize})");
            code.AppendLine($"            throw new InvalidOperationException($\"{fieldName} cannot exceed {maxSize} elements\");");
        }
    }

    private void GenerateStructXdrHelperClass(StringBuilder code, string structName,
                                            IEnumerable<StellarXdrParser.StructMemberContext> members)
    {
        code.AppendLine($"public static partial class {structName}Xdr");
        code.AppendLine("{");

        // Generate Encode method
        code.AppendLine("    /// <summary>Encodes struct to XDR stream</summary>");
        code.AppendLine($"    public static void Encode(XdrWriter stream, {structName} value)");
        code.AppendLine("    {");
        code.AppendLine("        value.Validate();");
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                GenerateEncodeStatement(code, decl, "value");
            }
        }
        code.AppendLine("    }");
        code.AppendLine();

        // Generate Decode method
        code.AppendLine("    /// <summary>Decodes struct from XDR stream</summary>");
        code.AppendLine($"    public static {structName} Decode(XdrReader stream)");
        code.AppendLine("    {");
        code.AppendLine($"        var result = new {structName}();");
        foreach (var member in members)
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                GenerateDecodeStatement(code, decl, "result");
            }
        }
        code.AppendLine("        return result;");
        code.AppendLine("    }");
        code.AppendLine("}");
    }

    private void GeneratePropertyValidation(StringBuilder code, StellarXdrParser.DeclarationContext decl, string valueName, CSharpTypeInfo typeInfo)
    {
        if (typeInfo.FullCSharpType == "string")
        {
            var maxLength = typeInfo.MaxLength;
            if (maxLength != null)
            {
                code.AppendLine($"            if (System.Text.Encoding.UTF8.GetByteCount({valueName}) > {maxLength})");
                code.AppendLine($"                throw new ArgumentException($\"String exceeds {maxLength} bytes when UTF8 encoded\");");
            }
        }
        else
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                var size = typeInfo.MaxLength;
                code.AppendLine($"            if ({valueName}.Length != {size})");
                code.AppendLine($"                throw new ArgumentException($\"Must be exactly {size} bytes\");");
            }
            else if (typeInfo.ArrayType == ArrayType.Variable)
            {
                var maxSize = typeInfo.MaxLength;
                if (maxSize != null)
                {
                    code.AppendLine($"            if ({valueName}.Length > {maxSize})");
                    code.AppendLine($"                throw new ArgumentException($\"Cannot exceed {maxSize} bytes\");");
                }
            }
        }
    }


    private void GenerateUnion(StellarXdrParser.UnionDefinitionContext context)
    {
        var unionName = context.identifier().GetText();
        var switchDecl = context.unionBody().declaration();
        var discriminatorType = GetCSharpTypeInfo(switchDecl);
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{unionName}.cs");

        WriteFileHeader(code, context);

        var docComment = GetDocumentationComment(context);
        if (!string.IsNullOrEmpty(docComment))
        {
            code.Append(docComment);
        }

        // Generate abstract base class
        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public abstract partial class {unionName}");
        code.AppendLine("{");
        code.AppendLine($"    public abstract {discriminatorType.CSharpType} Discriminator {{ get; }}");
        code.AppendLine();
        code.AppendLine("    /// <summary>Validates the union case matches its discriminator</summary>");
        code.AppendLine("    protected abstract void ValidateCase();");
        code.AppendLine("}");
        code.AppendLine();

        // Generate case classes
        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                var caseDoc = GetDocumentationComment(caseSpec);
                if (!string.IsNullOrEmpty(caseDoc))
                {
                    code.Append(caseDoc);
                }

                var className = $"{unionName}_{value.GetText()}";
                code.AppendLine($"public sealed partial class {className} : {unionName}");
                code.AppendLine("{");
                code.AppendLine($"    public override {discriminatorType.CSharpType} Discriminator => {value.GetText()};");

                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldType = GetCSharpTypeInfo(decl);
                    var fieldName = decl.identifier().GetText();

                    GenerateProperty(code, decl, fieldType, fieldName);

                }

                code.AppendLine();
                code.AppendLine("    protected override void ValidateCase() {}");
                code.AppendLine("}");
                code.AppendLine();
            }
        }

        // Generate default case if present
        var defaultCase = context.unionBody().defaultCase();
        if (defaultCase != null)
        {
            code.AppendLine($"public sealed partial class {unionName}_Default : {unionName}");
            code.AppendLine("{");
            code.AppendLine($"    private readonly {discriminatorType.CSharpType} _discriminator;");
            code.AppendLine($"    public override {discriminatorType.CSharpType} Discriminator => _discriminator;");

            var defaultDecl = defaultCase.declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldType = GetCSharpTypeInfo(defaultDecl);
                var fieldName = defaultDecl.identifier().GetText();
                GenerateProperty(code, defaultDecl, fieldType, fieldName);
            }

            code.AppendLine();
            code.AppendLine($"    public {unionName}_Default({discriminatorType.CSharpType} discriminator)");
            code.AppendLine("    {");
            code.AppendLine("        _discriminator = discriminator;");
            code.AppendLine("    }");

            code.AppendLine();
            code.AppendLine("    protected override void ValidateCase() {}");
            code.AppendLine("}");
        }

        // Generate XDR helper class
        code.AppendLine($"public static partial class {unionName}Xdr");
        code.AppendLine("{");
        GenerateUnionEncodeMethods(code, unionName, discriminatorType.CSharpType, context);
        GenerateUnionDecodeMethods(code, unionName, discriminatorType.CSharpType, context);
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }

    private void GenerateTypedef(StellarXdrParser.TypedefDefinitionContext context)
    {
        var declaration = context.declaration();
        var typedefName = declaration.identifier().GetText();
        var code = new StringBuilder();
        var filename = Path.Combine(_outputDir, $"{typedefName}.cs");

        WriteFileHeader(code, context);

        var docComment = GetDocumentationComment(context);
        if (!string.IsNullOrEmpty(docComment))
        {
            code.Append(docComment);
        }

        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public partial class {typedefName}");
        code.AppendLine("{");

        var baseType = GetCSharpTypeInfo(declaration);


        GenerateProperty(code, declaration, baseType, "Value");


        // Generate constructors
        code.AppendLine();
        code.AppendLine($"    public {typedefName}() {{ }}");
        code.AppendLine();
        code.AppendLine($"    public {typedefName}({baseType.FullCSharpType} value)");
        code.AppendLine("    {");
        code.AppendLine("        Value = value;");
        code.AppendLine("    }");

        code.AppendLine("}");
        code.AppendLine();

        // Generate XDR helper class
        code.AppendLine($"public static partial class {typedefName}Xdr");
        code.AppendLine("{");
        GenerateTypedefEncodeMethods(code, typedefName, declaration);
        GenerateTypedefDecodeMethods(code, typedefName, declaration);
        code.AppendLine("}");

        File.WriteAllText(filename, code.ToString());
    }



    private void GenerateUnionEncodeMethods(StringBuilder code, string unionName, string discriminatorType,
                                          StellarXdrParser.UnionDefinitionContext context)
    {
        code.AppendLine($"    public static void Encode(XdrWriter stream, {unionName} value)");
        code.AppendLine("    {");
        code.AppendLine("        value.ValidateCase();");
        code.AppendLine($"        stream.WriteInt((int)value.Discriminator);");
        code.AppendLine("        switch (value)");
        code.AppendLine("        {");

        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                code.AppendLine($"            case {unionName}_{value.GetText()} case_{value.GetText()}:");
                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldName = decl.identifier().GetText();
                    GenerateEncodeStatement(code, decl, $"case_{value.GetText()}", "                ");
                }
                code.AppendLine("                break;");
            }
        }

        if (context.unionBody().defaultCase() != null)
        {
            code.AppendLine("            case var defaultCase:");
            var defaultDecl = context.unionBody().defaultCase().declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldName = defaultDecl.identifier().GetText();
                GenerateEncodeStatement(code, defaultDecl, "defaultCase", "                ");
            }
            code.AppendLine("                break;");
        }

        code.AppendLine("        }");
        code.AppendLine("    }");
    }

    private void GenerateUnionDecodeMethods(StringBuilder code, string unionName, string discriminatorType,
                                          StellarXdrParser.UnionDefinitionContext context)
    {
        code.AppendLine($"    public static {unionName} Decode(XdrReader stream)");
        code.AppendLine("    {");
        code.AppendLine($"        var discriminator = ({discriminatorType})stream.ReadInt();");
        code.AppendLine("        switch (discriminator)");
        code.AppendLine("        {");

        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                code.AppendLine($"            case {value.GetText()}:");
                code.AppendLine($"                var result_{value.GetText()} = new {unionName}_{value.GetText()}();");
                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldName = decl.identifier().GetText();
                    GenerateDecodeStatement(code, decl, $"result_{value.GetText()}", "                ");
                }
                code.AppendLine($"                return result_{value.GetText()};");
            }
        }

        if (context.unionBody().defaultCase() != null)
        {
            code.AppendLine("            default:");
            code.AppendLine($"                var defaultResult = new {unionName}_Default(discriminator);");
            var defaultDecl = context.unionBody().defaultCase().declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldName = defaultDecl.identifier().GetText();
                GenerateDecodeStatement(code, defaultDecl, "defaultResult", "                ");
            }
            code.AppendLine("                return defaultResult;");
        }
        else
        {
            code.AppendLine("            default:");
            code.AppendLine($"                throw new Exception($\"Unknown discriminator for {unionName}: {{discriminator}}\");");
        }

        code.AppendLine("        }");
        code.AppendLine("    }");
    }

    private void GenerateTypedefEncodeMethods(StringBuilder code, string typedefName,
                                            StellarXdrParser.DeclarationContext declaration)
    {
        code.AppendLine($"    public static void Encode(XdrWriter stream, {typedefName} value)");
        code.AppendLine("    {");
        GenerateEncodeStatement(code, declaration, "value");
        code.AppendLine("    }");
    }

    private void GenerateTypedefDecodeMethods(StringBuilder code, string typedefName,
                                            StellarXdrParser.DeclarationContext declaration)
    {
        code.AppendLine($"    public static {typedefName} Decode(XdrReader stream)");
        code.AppendLine("    {");
        code.AppendLine($"        var result = new {typedefName}();");
        GenerateDecodeStatement(code, declaration, "result");
        code.AppendLine("        return result;");
        code.AppendLine("    }");
    }

    private void GenerateEncodeStatement(StringBuilder code, StellarXdrParser.DeclarationContext decl,
                                       string valueName, string indent = "        ")
    {
        var typeSpec = decl.typeSpecifier();
        var typeInfo = GetCSharpTypeInfo(decl);
        var fieldName = decl.identifier().GetText();


        if (decl.GetText().StartsWith("opaque"))
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                code.AppendLine($"{indent}stream.WriteFixedOpaque({valueName}.{fieldName});");
            }
            else
            {
                code.AppendLine($"{indent}stream.WriteOpaque({valueName}.{fieldName});");
            }
        }
        else if (decl.GetText().StartsWith("string"))
        {
            code.AppendLine($"{indent}stream.WriteString({valueName}.{fieldName});");
        }
        else if (typeInfo.ArrayType != ArrayType.None)
        {
            if (typeInfo.ArrayType == ArrayType.Variable)
            {
                code.AppendLine($"{indent}stream.WriteInt({valueName}.{fieldName}.Length);");
            }
            code.AppendLine($"{indent}foreach (var item in {valueName}.{fieldName})");
            code.AppendLine($"{indent}{{");
            code.AppendLine($"{indent}    {GetEncodeStatement(typeSpec, "item")};");
            code.AppendLine($"{indent}}}");
        }
        else
        {
            code.AppendLine($"{indent}{GetEncodeStatement(typeSpec, $"{valueName}.{fieldName}")};");
        }
    }

    private void GenerateDecodeStatement(StringBuilder code, StellarXdrParser.DeclarationContext decl,
                                       string valueName, string indent = "        ")
    {
        var typeSpec = decl.typeSpecifier();
        var fieldName = decl.identifier().GetText();
        var typeInfo = GetCSharpTypeInfo(decl);

        if (decl.GetText().StartsWith("opaque"))
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                code.AppendLine($"{indent}stream.ReadFixedOpaque({valueName}.{fieldName});");
            }
            else
            {
                code.AppendLine($"{indent}{valueName}.{fieldName} = stream.ReadOpaque();");
            }
        }
        else if (decl.GetText().StartsWith("string"))
        {
            code.AppendLine($"{indent}{valueName}.{fieldName} = stream.ReadString();");
        }
        else if (typeInfo.ArrayType != ArrayType.None)
        {
            string length;
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                length = typeInfo.MaxLength.ToString();
            }
            else
            {
                code.AppendLine($"{indent}var length = stream.ReadInt();");
                length = "length";
            }

            code.AppendLine($"{indent}{valueName}.{fieldName} = new {typeInfo.CSharpType}[{length}];");
            code.AppendLine($"{indent}for (var i = 0; i < {length}; i++)");
            code.AppendLine($"{indent}{{");
            code.AppendLine($"{indent}    {valueName}.{fieldName}[i] = {GetDecodeStatement(typeSpec)};");
            code.AppendLine($"{indent}}}");
        }
        else
        {
            code.AppendLine($"{indent}{valueName}.{fieldName} = {GetDecodeStatement(typeSpec)};");
        }
    }

    private string GetEncodeStatement(StellarXdrParser.TypeSpecifierContext typeSpec, string valueName)
    {
        return typeSpec.GetText() switch
        {
            "unsigned int" => $"stream.WriteUInt({valueName})",
            "int" => $"stream.WriteInt({valueName})",
            "unsigned hyper" => $"stream.WriteULong({valueName})",
            "hyper" => $"stream.WriteLong({valueName})",
            "float" => $"stream.WriteFloat({valueName})",
            "double" => $"stream.WriteDouble({valueName})",
            "bool" => $"stream.WriteInt({valueName} ? 1 : 0)",
            _ => $"{typeSpec.identifier()?.GetText()}Xdr.Encode(stream, {valueName})"
        };
    }

    private string GetDecodeStatement(StellarXdrParser.TypeSpecifierContext typeSpec)
    {
        return typeSpec.GetText() switch
        {
            "unsigned int" => "stream.ReadUInt()",
            "int" => "stream.ReadInt()",
            "unsigned hyper" => "stream.ReadULong()",
            "hyper" => "stream.ReadLong()",
            "float" => "stream.ReadFloat()",
            "double" => "stream.ReadDouble()",
            "bool" => "stream.ReadInt() != 0",
            _ => $"{typeSpec.identifier()?.GetText()}Xdr.Decode(stream)"
        };
    }

}
