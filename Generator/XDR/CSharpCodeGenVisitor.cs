

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;
using Microsoft.CodeAnalysis.CSharp;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.IO;
using System.Security.Claims;
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
        public CodeFile CurrentCodeFile { get; set; }
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

    private void WriteDocumentationComment(ParserRuleContext context, bool isProperty = false)
    {
        var code = _context.CurrentCodeFile;
        if (_commentMap.TryGetValue(context.Start, out var comment))
        {
            var lines = comment.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        
            code.AppendLine(isProperty ? "/// <value>" : "    /// <summary>");
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    code.AppendLine($"/// {trimmedLine}");
                }
            }
            code.AppendLine(isProperty ? "/// </value>" : "    /// </summary>");
        }
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
        _context.CurrentCodeFile = new CodeFile(Path.Combine(_outputDir, $"{enumName}.cs"));
        try
        {
            GenerateEnum(context,enumName);
        }
        finally
        {
            _context.CurrentCodeFile.Write();
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitStructDefinition([NotNull] StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        Console.WriteLine($"Visiting struct: {structName}");
        _context.TypeStack.Push(structName);
        _context.CurrentCodeFile = new CodeFile(Path.Combine(_outputDir, $"{structName}.cs"));
        try
        {
            GenerateStruct(context,structName);
        }
        finally
        {
            _context.CurrentCodeFile.Write();
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitUnionDefinition([NotNull] StellarXdrParser.UnionDefinitionContext context)
    {
        var unionName = context.identifier().GetText();
        Console.WriteLine($"Visiting union: {unionName}");
        _context.TypeStack.Push(unionName);
        _context.CurrentCodeFile = new CodeFile(Path.Combine(_outputDir, $"{unionName}.cs"));
        try
        {
            GenerateUnion(context,unionName);
        }
        finally
        {
            _context.CurrentCodeFile.Write();
            _context.TypeStack.Pop();
        }

        return null;
    }

    public override object VisitTypedefDefinition([NotNull] StellarXdrParser.TypedefDefinitionContext context)
    {
        var typedefName = context.declaration().identifier().GetText();
        Console.WriteLine($"Visiting typedef: {typedefName}");
        _context.TypeStack.Push(typedefName);
        _context.CurrentCodeFile = new CodeFile(Path.Combine(_outputDir, $"{typedefName}.cs"));
        try
        {
            GenerateTypedef(context,typedefName);
        }
        finally
        {
            _context.CurrentCodeFile.Write();
            _context.TypeStack.Pop();
        }

        return null;
    }

    private void WriteFileHeader( ParserRuleContext context)
    {
        var code=_context.CurrentCodeFile;
        if (code.IsRoot)
        {
            code.AppendLine("// Generated code - do not modify");
            code.AppendLine($"// Source:");
            code.AppendLine();

            string source = context.Start.InputStream.GetText(
                  new Interval(context.Start.StartIndex, context.Stop.StopIndex)
              );
            foreach (var comment in source.Split("\n"))
            {
                code.AppendLine($"// {comment}");
            }

            code.AppendLine();
            code.AppendLine();
            code.AppendLine("using System;");
            code.AppendLine();
            code.AppendLine($"namespace {_context.CurrentNamespace} {{");
            code.AppendLine();
            code.Indent();
        }
    }



    private void WriteFileFooter()
    {
        var code = _context.CurrentCodeFile;
        code.Unindent();
        if (code.IsRoot)
        {
            code.AppendLine($"}}");
        }
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
            "unsignedint" => "uint",
            "int" => "int",
            "unsignedhyper" => "ulong",
            "hyper" => "long",
            "float" => "float",
            "double" => "double",
            "bool" => "bool",
            _ => decl.typeSpecifier().identifier()?.GetText() ?? "object"
        };

        if (baseType=="object")
        {
            var x = decl.typeSpecifier().GetText();
        }

        return new CSharpTypeInfo(baseType, arrayType, maxLength);
    }
    private void GenerateEnum(StellarXdrParser.EnumDefinitionContext context, string enumName)
    {
       
        WriteFileHeader(context);
        WriteDocumentationComment(context);

        var code = _context.CurrentCodeFile;
        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public enum {enumName}");
        code.OpenBlock();
        var enumMembers = context.enumBody().enumMember();
  
        foreach (var member in enumMembers)
        {
            WriteDocumentationComment(member);

            var name = member.identifier(0).GetText();
            string value;
            if (member.constant() != null)
                value = member.constant().GetText();
            else if (member.identifier().Length > 1)
                value = member.identifier(1).GetText();
            else
                value = "0";
            
            code.AppendLine($"{name} = {value},");
        }
        code.CloseBlock();
        code.AppendLine();

        // Generate static XDR helper class
        code.AppendLine($"public static partial class {enumName}Xdr");
        code.OpenBlock();

        code.AppendLine("/// <summary>Encodes enum value to XDR stream</summary>");
        code.AppendLine($"public static void Encode(XdrWriter stream, {enumName} value)");
        code.OpenBlock();
        code.AppendLine("stream.WriteInt((int)value);");
        code.CloseBlock();

        code.AppendLine("/// <summary>Decodes enum value from XDR stream</summary>");
        code.AppendLine($"public static {enumName} Decode(XdrReader stream)");
        code.OpenBlock();
        code.AppendLine("var value = stream.ReadInt();");
        code.AppendLine($"if (!Enum.IsDefined(typeof({enumName}), value))");
        code.AppendLine($"  throw new InvalidOperationException($\"Unknown {enumName} value: {{value}}\");");
        code.AppendLine($"return ({enumName})value;");
        code.CloseBlock();

        code.CloseBlock();



        
    }

    private void GenerateStruct(StellarXdrParser.StructDefinitionContext context,string structName)
    {
        WriteFileHeader(context);

        WriteDocumentationComment(context);

        var code = _context.CurrentCodeFile;
        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public partial class {structName}");
        code.OpenBlock();

        // Generate properties
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() == null) continue;

            WriteDocumentationComment(member, true);

            var fieldType = GetCSharpTypeInfo(decl);
            var fieldName = getFieldName(decl);
            GenerateProperty( decl, fieldType, fieldName);
            code.AppendLine();
        }

        // Generate constructor
        code.AppendLine($"public {structName}()");
        code.OpenBlock();
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() == null) continue;

            GenerateInitialization(decl);
        }
        code.CloseBlock();

        // Generate validation method
        code.AppendLine("/// <summary>Validates all fields have valid values</summary>");
        code.AppendLine("public virtual void Validate()");
        code.OpenBlock();
        foreach (var member in context.structBody().structMember())
        {
            var decl = member.declaration();
            if (decl.typeSpecifier() != null)
            {
                GenerateValidation( decl);
            }
        }
        code.CloseBlock();
        code.CloseBlock();

        // Generate XDR helper class
        GenerateStructXdrHelperClass( structName, context.structBody().structMember());

        WriteFileFooter();

       
    }

    private void GenerateProperty(DeclarationContext decl, CSharpTypeInfo fieldType, string fieldName)
    {
        var code = _context.CurrentCodeFile;
        switch (fieldType.ArrayType)
        {
            case ArrayType.Fixed:
                code.AppendLine($"private {fieldType.CSharpType}[] _{fieldName.ToCamelCase()} = new {fieldType.CSharpType}[{fieldType.MaxLength}];");
                break;
            case ArrayType.Variable:
                code.AppendLine($"private {fieldType.CSharpType}[] _{fieldName.ToCamelCase()};");
                break;
            case ArrayType.None:
                code.AppendLine($"private {fieldType.CSharpType} _{fieldName.ToCamelCase()};");
                break;

        }

        code.AppendLine($"public {fieldType.FullCSharpType} {fieldName}");
        code.OpenBlock();
        code.AppendLine($"get => _{fieldName.ToCamelCase()};");
        code.AppendLine("set");
        code.OpenBlock();

        GeneratePropertyValidation( decl, "value", fieldType);

        code.AppendLine($"_{fieldName.ToCamelCase()} = value;");
        code.CloseBlock();
        code.CloseBlock();


    }

    private void GenerateInitialization( StellarXdrParser.DeclarationContext decl)
    {
        var code = _context.CurrentCodeFile;
        var typeInfo = GetCSharpTypeInfo(decl);

        if (typeInfo.ArrayType == ArrayType.Fixed)
        {
            var size = typeInfo.MaxLength;
            var fieldName = getFieldName(decl);
            var fieldType = typeInfo.CSharpType;
            code.AppendLine($"{fieldName} = new {fieldType}[{size}];");
        }
    }

    private void GenerateValidation( StellarXdrParser.DeclarationContext decl)
    {
        var code = _context.CurrentCodeFile;
        var typeInfo = GetCSharpTypeInfo(decl);
        var fieldName = getFieldName(decl);

        if (typeInfo.ArrayType == ArrayType.Fixed)
        {
            var size = typeInfo.MaxLength;
            code.AppendLine($"if ({fieldName}.Length != {size})");
            code.AppendLine($"\tthrow new InvalidOperationException($\"{fieldName} must be exactly {size} elements\");");
        }
        else if (typeInfo.ArrayType == ArrayType.Variable )
        {
            var maxSize = typeInfo.MaxLength;
            if (maxSize != null)
            {
                code.AppendLine($"if ({fieldName}.Length > {maxSize})");
                code.AppendLine($"\tthrow new InvalidOperationException($\"{fieldName} cannot exceed {maxSize} elements\");");
            }
        }
    }

    private void GenerateStructXdrHelperClass(string structName,
                                            IEnumerable<StellarXdrParser.StructMemberContext> members)
    {
        var code = _context.CurrentCodeFile;
        code.AppendLine($"public static partial class {structName}Xdr");
        code.OpenBlock();

            // Generate Encode method
            code.AppendLine("/// <summary>Encodes struct to XDR stream</summary>");
            code.AppendLine($"public static void Encode(XdrWriter stream, {structName} value)");
            code.OpenBlock();
                code.AppendLine("value.Validate();");
                foreach (var member in members)
                {
                    var decl = member.declaration();
                    if (decl.typeSpecifier() != null)
                    {
                        string fieldName = getFieldName(decl);
                        GenerateEncodeStatement(decl, "value",fieldName);
                    }
                }
            code.CloseBlock();

            // Generate Decode method
            code.AppendLine("/// <summary>Decodes struct from XDR stream</summary>");
            code.AppendLine($"public static {structName} Decode(XdrReader stream)");
            code.OpenBlock();
                code.AppendLine($"var result = new {structName}();");
                foreach (var member in members)
                {
                    var decl = member.declaration();
                    if (decl.typeSpecifier() != null)
                    {
                        GenerateDecodeStatement(decl, "result");
                    }
                }
                code.AppendLine("return result;");
            code.CloseBlock();

        code.CloseBlock();
    }

    private void GeneratePropertyValidation( StellarXdrParser.DeclarationContext decl, string valueName, CSharpTypeInfo typeInfo)
    {
        var code= _context.CurrentCodeFile;
        if (typeInfo.FullCSharpType == "string")
        {
            var maxLength = typeInfo.MaxLength;
            if (maxLength != null)
            {
                code.AppendLine($"if (System.Text.Encoding.UTF8.GetByteCount({valueName}) > {maxLength})");
                code.AppendLine($"\tthrow new ArgumentException($\"String exceeds {maxLength} bytes when UTF8 encoded\");");
            }
        }
        else
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                var size = typeInfo.MaxLength;
                code.AppendLine($"if ({valueName}.Length != {size})");
                code.AppendLine($"\tthrow new ArgumentException($\"Must be exactly {size} bytes\");");
            }
            else if (typeInfo.ArrayType == ArrayType.Variable)
            {
                var maxSize = typeInfo.MaxLength;
                if (maxSize != null)
                {
                    code.AppendLine($"if ({valueName}.Length > {maxSize})");
                    code.AppendLine($"\tthrow new ArgumentException($\"Cannot exceed {maxSize} bytes\");");
                }
            }
        }
    }


    private void GenerateUnion(StellarXdrParser.UnionDefinitionContext context,string unionName)
    {
        var switchDecl = context.unionBody().declaration();
        var discriminatorType = GetCSharpTypeInfo(switchDecl);
        var code = _context.CurrentCodeFile;

        WriteFileHeader( context);
        WriteDocumentationComment(context);

        // Generate abstract base class
        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public abstract partial class {unionName}");
        code.OpenBlock();
        code.AppendLine($"public abstract {discriminatorType.CSharpType} Discriminator {{ get; }}");
        code.AppendLine();
        code.AppendLine("/// <summary>Validates the union case matches its discriminator</summary>");
        code.AppendLine("public abstract void ValidateCase();");
        code.CloseBlock();

        // Generate case classes
        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                WriteDocumentationComment(caseSpec);

                var className = $"{unionName}_{value.GetText()}";
                code.AppendLine($"public sealed partial class {className} : {unionName}");
                code.OpenBlock();
                code.AppendLine($"public override {discriminatorType.CSharpType} Discriminator => {value.GetText()};");
                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldType = GetCSharpTypeInfo(decl);
                    var fieldName = getFieldName(decl);

                    GenerateProperty(decl, fieldType, fieldName);

                }
                code.AppendLine();
                code.AppendLine("public override void ValidateCase() {}");
                code.CloseBlock();
            }
        }

        // Generate default case if present
        var defaultCase = context.unionBody().defaultCase();
        if (defaultCase != null)
        {
            code.AppendLine($"public sealed partial class {unionName}_Default : {unionName}");
            code.OpenBlock();
            code.AppendLine($"private readonly {discriminatorType.CSharpType} _discriminator;");
            code.AppendLine($"public override {discriminatorType.CSharpType} Discriminator => _discriminator;");

            var defaultDecl = defaultCase.declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldType = GetCSharpTypeInfo(defaultDecl);
                var fieldName = getFieldName(defaultDecl);
                GenerateProperty( defaultDecl, fieldType, fieldName);
            }

            code.AppendLine();
            code.AppendLine($"public {unionName}_Default({discriminatorType.CSharpType} discriminator)");
            code.OpenBlock();
            code.AppendLine(" _discriminator = discriminator;");
            code.CloseBlock(); 

            code.AppendLine();
            code.AppendLine("public override void ValidateCase() {}");
            code.CloseBlock();
        }

        // Generate XDR helper class
        code.AppendLine($"public static partial class {unionName}Xdr");
        code.OpenBlock();
        GenerateUnionEncodeMethods(unionName, discriminatorType.CSharpType, context);
        GenerateUnionDecodeMethods(unionName, discriminatorType.CSharpType, context);
        code.CloseBlock();
        WriteFileFooter();

      
    }

    private void GenerateTypedef(StellarXdrParser.TypedefDefinitionContext context,string typedefName)
    {
        var declaration = context.declaration();

        if (typedefName=="uint32")
        {

        }

        WriteFileHeader( context);
        WriteDocumentationComment(context);

        var code = _context.CurrentCodeFile;
        code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
        code.AppendLine($"public partial class {typedefName}");
        code.OpenBlock();

        var baseType = GetCSharpTypeInfo(declaration);

        GenerateProperty( declaration, baseType, "InnerValue");


        // Generate constructors
        code.AppendLine();
        code.AppendLine($"public {typedefName}() {{ }}");
        code.AppendLine();
        code.AppendLine($"public {typedefName}({baseType.FullCSharpType} value)");
        code.OpenBlock();
        code.AppendLine("InnerValue = value;");
        code.CloseBlock();

        code.CloseBlock();

        // Generate XDR helper class
        code.AppendLine($"public static partial class {typedefName}Xdr");
        code.OpenBlock();
        GenerateTypedefEncodeMethods(typedefName, declaration);
        GenerateTypedefDecodeMethods(typedefName, declaration);
        code.CloseBlock();

        WriteFileFooter();

       
    }



    private void GenerateUnionEncodeMethods( string unionName, string discriminatorType,
                                          StellarXdrParser.UnionDefinitionContext context)
    {
        var code = _context.CurrentCodeFile;
        code.AppendLine($"public static void Encode(XdrWriter stream, {unionName} value)");
        code.OpenBlock();
        code.AppendLine("value.ValidateCase();");
        code.AppendLine($"stream.WriteInt((int)value.Discriminator);");
        code.AppendLine("switch (value)");
        code.OpenBlock();

        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                code.AppendLine($"case {unionName}_{value.GetText()} case_{value.GetText()}:");
                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldName = getFieldName(decl);
                    GenerateEncodeStatement( decl, $"case_{value.GetText()}", fieldName);
                }
                code.AppendLine("break;");
            }
        }

        if (context.unionBody().defaultCase() != null)
        {
            code.AppendLine("case var defaultCase:");
            var defaultDecl = context.unionBody().defaultCase().declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldName = getFieldName(defaultDecl);
                GenerateEncodeStatement(defaultDecl, "defaultCase", fieldName);
            }
            code.AppendLine("break;");
        }

        code.CloseBlock();
        code.CloseBlock();
    }

    private void GenerateUnionDecodeMethods( string unionName, string discriminatorType,
                                          StellarXdrParser.UnionDefinitionContext context)
    {
        var code = _context.CurrentCodeFile;

        code.AppendLine($"public static {unionName} Decode(XdrReader stream)");
        code.OpenBlock();
        code.AppendLine($"var discriminator = ({discriminatorType})stream.ReadInt();");
        code.AppendLine("switch (discriminator)");
        code.OpenBlock();

        foreach (var caseSpec in context.unionBody().caseSpec())
        {
            foreach (var value in caseSpec.value())
            {
                code.AppendLine($"case {value.GetText()}:");
                code.AppendLine($"var result_{value.GetText()} = new {unionName}_{value.GetText()}();");
                var decl = caseSpec.declaration();
                if (decl.typeSpecifier() != null)
                {
                    var fieldName = getFieldName(decl);
                    GenerateDecodeStatement(decl, $"result_{value.GetText()}", "                ");
                }
                code.AppendLine($"return result_{value.GetText()};");
            }
        }

        if (context.unionBody().defaultCase() != null)
        {
            code.AppendLine("default:");
            code.AppendLine($"var defaultResult = new {unionName}_Default(discriminator);");
            var defaultDecl = context.unionBody().defaultCase().declaration();
            if (defaultDecl.typeSpecifier() != null)
            {
                var fieldName = getFieldName(defaultDecl);
                GenerateDecodeStatement( defaultDecl, "defaultResult", "                ");
            }
            code.AppendLine("return defaultResult;");
        }
        else
        {
            code.AppendLine("default:");
            code.AppendLine($"throw new Exception($\"Unknown discriminator for {unionName}: {{discriminator}}\");");
        }

        code.CloseBlock();
        code.CloseBlock();
    }

    private void GenerateTypedefEncodeMethods( string typedefName,
                                            StellarXdrParser.DeclarationContext declaration)
    {
        var code = _context.CurrentCodeFile;
        code.AppendLine($"    public static void Encode(XdrWriter stream, {typedefName} value)");
        code.OpenBlock();
        GenerateEncodeStatement( declaration, "value", "InnerValue");
        code.CloseBlock();
    }

    private void GenerateTypedefDecodeMethods(string typedefName,
                                            StellarXdrParser.DeclarationContext declaration)
    {
        var code = _context.CurrentCodeFile;
        code.AppendLine($"public static {typedefName} Decode(XdrReader stream)");
        code.OpenBlock();
        code.AppendLine($"var result = new {typedefName}();");
        GenerateDecodeStatement(declaration, "result",fieldName: "InnerValue");
        code.AppendLine("return result;");
        code.CloseBlock();
    }

    private void GenerateEncodeStatement( StellarXdrParser.DeclarationContext decl,
                                       string valueName,string fieldName)
    {
        var typeSpec = decl.typeSpecifier();
        var typeInfo = GetCSharpTypeInfo(decl);
        var code = _context.CurrentCodeFile;

        if (decl.GetText().StartsWith("opaque"))
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                code.AppendLine($"stream.WriteFixedOpaque({valueName}.{fieldName});");
            }
            else
            {
                code.AppendLine($"stream.WriteOpaque({valueName}.{fieldName});");
            }
        }
        else if (decl.GetText().StartsWith("string"))
        {
            code.AppendLine($"stream.WriteString({valueName}.{fieldName});");
        }
        else if (typeInfo.ArrayType != ArrayType.None)
        {
            if (typeInfo.ArrayType == ArrayType.Variable)
            {
                code.AppendLine($"stream.WriteInt({valueName}.{fieldName}.Length);");
            }
            code.AppendLine($"foreach (var item in {valueName}.{fieldName})");
            code.OpenBlock();
            code.AppendLine($"    {GetEncodeStatement(typeSpec, "item")};");
            code.CloseBlock();
        }
        else
        {
            code.AppendLine($"{GetEncodeStatement(typeSpec, $"{valueName}.{fieldName}")};");
        }
    }

    private static string getFieldName(DeclarationContext decl)
    {
        string fieldName= decl.identifier().GetText();
        if (SyntaxFacts.IsKeywordKind(SyntaxFacts.GetKeywordKind(fieldName)))
        {
            fieldName= $"_{fieldName}";
        }
        return fieldName;
    }

    private void GenerateDecodeStatement( StellarXdrParser.DeclarationContext decl,
                                       string valueName,  string fieldName=null)
    {
        var code = _context.CurrentCodeFile;
        var typeSpec = decl.typeSpecifier();
        if (String.IsNullOrEmpty(fieldName)) fieldName = getFieldName(decl);
        var typeInfo = GetCSharpTypeInfo(decl);

        if (decl.GetText().StartsWith("opaque"))
        {
            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                code.AppendLine($"stream.ReadFixedOpaque({valueName}.{fieldName});");
            }
            else
            {
                code.AppendLine($"{valueName}.{fieldName} = stream.ReadOpaque();");
            }
        }
        else if (decl.GetText().StartsWith("string"))
        {
            code.AppendLine($"{valueName}.{fieldName} = stream.ReadString();");
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
                code.AppendLine($"var length = stream.ReadInt();");
                length = "length";
            }

            code.AppendLine($"{valueName}.{fieldName} = new {typeInfo.CSharpType}[{length}];");
            code.AppendLine($"for (var i = 0; i < {length}; i++)");
            code.OpenBlock();
            code.AppendLine($"{valueName}.{fieldName}[i] = {GetDecodeStatement(typeSpec)};");
            code.CloseBlock();
        }
        else
        {
            code.AppendLine($"{valueName}.{fieldName} = {GetDecodeStatement(typeSpec)};");
        }
    }

    private string GetEncodeStatement(StellarXdrParser.TypeSpecifierContext typeSpec, string valueName)
    {
        return typeSpec.GetText() switch
        {
            "unsignedint" => $"stream.WriteUInt({valueName})",
            "int" => $"stream.WriteInt({valueName})",
            "unsignedhyper" => $"stream.WriteULong({valueName})",
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
            "unsignedint" => "stream.ReadUInt()",
            "int" => "stream.ReadInt()",
            "unsignedhyper" => "stream.ReadULong()",
            "hyper" => "stream.ReadLong()",
            "float" => "stream.ReadFloat()",
            "double" => "stream.ReadDouble()",
            "bool" => "stream.ReadInt() != 0",
            _ => $"{typeSpec.identifier()?.GetText()}Xdr.Decode(stream)"
        };
    }

}
