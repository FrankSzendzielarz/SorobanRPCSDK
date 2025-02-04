using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Generator.XDR.Grammar.StellarXdrParser;
using static Generator.XDR.TypeExtractorVisitor;

namespace Generator.XDR
{
    public class XDRTypeDefinition
    {
        public XDRType XDRType { get; }
        public ParserRuleContext ParserRuleContext { get; }
        public string Namespace { get; }
        public string Name { get; }
        public List<XDRTypeDefinition> NestedTypes { get; } = new();

        public List<string> EnumAliases { get; } 
        public XDRTypeDefinition? Parent { get; } = null;
        private CodeFile? _codeFile { get; }
        public CodeFile? CodeFile => _codeFile != null ? _codeFile : Parent?.CodeFile;
        public string FullName => Parent == null ? Name : $"{Parent.FullName}.{Name}";
        public Dictionary<IToken, string> CommentMap { get; } 
        public XDRTypeDefinition(XDRType xdrType, ParserRuleContext? documentationContext, ParserRuleContext parserRuleContext, string _namespace, string name, XDRTypeDefinition? parent, string outputDir, Dictionary<IToken, string> commentMap, List<string> enumAliases)
        {
            EnumAliases = enumAliases;
            XDRType = xdrType;
            ParserRuleContext = parserRuleContext;
            Namespace = $"{_namespace.ToPascalCase()}.XDR";
            Name = name;
            Parent = parent;
            CommentMap = commentMap;
            if (parent != null)
            {
                parent.NestedTypes.Add(this);
            }
            else
            {
                _codeFile = new CodeFile(Path.Combine(outputDir, $"{name}.cs"));
                if (documentationContext!= null) {
                    WriteFileHeader(documentationContext);
                    WriteDocumentationComment(documentationContext);
                }
                
            }

        }

        public void Generate(List<XDRTypeDefinition> allTypes)
        {
            Console.WriteLine($"Generating {FullName}");
            switch (this.XDRType)
            {
                case XDRType.Enum:
                    GenerateEnum(ParserRuleContext as EnumBodyContext, allTypes);
                    break;
                case XDRType.TypeDef:
                    GenerateTypedef(ParserRuleContext as TypedefDefinitionContext);
                    break;
                case XDRType.Union:
                    GenerateUnion(ParserRuleContext as UnionBodyContext,allTypes);
                    break;
                case XDRType.Struct:
                    GenerateStruct(ParserRuleContext as StructBodyContext,allTypes);
                    break;

            }
            
            WriteFooter();
        }
        private void WriteFileHeader(ParserRuleContext context)
        {
            var code = CodeFile;
            code.AppendLine("// Generated code - do not modify");
            code.AppendLine($"// Source:");
            code.AppendLine();

            string source = context.Start.InputStream.GetText(
                    new Interval(context.Start.StartIndex, context.Stop.StopIndex)
                );
            foreach (var comment in source.Split("\n"))
            {
                code.AppendLine($"// {comment.Trim('\r', '\n')}");
            }

            code.AppendLine();
            code.AppendLine();
            code.AppendLine("using System;");
            code.AppendLine("using System.IO;");
            code.AppendLine();
            code.AppendLine($"namespace {Namespace} {{");
            code.AppendLine();
            code.Indent();
            
        }
        private void WriteFooter()
        {
            if (Parent == null) {   
                var code = CodeFile;
                code.Unindent();
                if (code.IsRoot)
                {
                    code.AppendLine($"}}");
                }
            }
        }

        private void WriteDocumentationComment(ParserRuleContext context,  bool isProperty = false)
        {

            if (CommentMap.TryGetValue(context.Start, out var comment))
            {
                var lines = comment.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                CodeFile.AppendLine(isProperty ? "/// <value>" : "    /// <summary>");
                foreach (var line in lines)
                {
                    var trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        CodeFile.AppendLine($"/// {trimmedLine}");
                    }
                }
                CodeFile.AppendLine(isProperty ? "/// </value>" : "    /// </summary>");
            }
        }

        
        private void GenerateEnum(StellarXdrParser.EnumBodyContext context, List<XDRTypeDefinition> allTypes)
        {

            string enumName = Name;

            var code = CodeFile;
            code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
            code.AppendLine($"public enum {enumName}");
            code.OpenBlock();
            var enumMembers = context.enumMember();

            foreach (var member in enumMembers)
            {
                WriteDocumentationComment(member);

                var name = member.identifier(0).GetText();
                string value;
                if (member.constant() != null)
                    value = member.constant().GetText();
                else if (member.identifier().Length > 1)
                    value = LookUpEnumAlias(member.identifier(1).GetText(), allTypes);
                else
                    value = "0";

                code.AppendLine($"{name} = {value},");
            }
            code.CloseBlock();
            code.AppendLine();

            // Generate static XDR helper class
            code.AppendLine($"public static partial class {enumName}Xdr");
            code.OpenBlock();

            AddGeneralBase64EncodeBlock(enumName, code);

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


            foreach (var child in this.NestedTypes)
            {
                child.Generate(allTypes);
            }

            code.CloseBlock();




        }

        private static void AddGeneralBase64EncodeBlock(string typeName, CodeFile? code)
        {
            code.AppendLine("/// <summary>Encodes value to XDR base64 string</summary>");
            code.AppendLine($"public static string EncodeToBase64({typeName} value)");
            code.OpenBlock();
            code.AppendLine("using (var memoryStream = new MemoryStream())");
            code.OpenBlock();
            code.AppendLine("XdrWriter writer = new XdrWriter(memoryStream);");
            code.AppendLine($"{typeName}Xdr.Encode(writer, value);");
            code.AppendLine("return Convert.ToBase64String(memoryStream.ToArray());");
            code.CloseBlock();
            code.CloseBlock();
        }

    

        private string LookUpEnumAlias(string enumMember, List<XDRTypeDefinition> allTypes)
        {
            var type=allTypes.Where(t=>t.XDRType==XDRType.Enum && t.EnumAliases.Contains(enumMember)).FirstOrDefault();  
            if (type == null)
            {
                Console.Error.WriteLine($"Enum member not found {enumMember}");
                return enumMember;
            }else
            {
                return $"{type.FullName}.{enumMember}";
            }
        }

        private void GenerateStruct(StellarXdrParser.StructBodyContext context, List<XDRTypeDefinition> allTypes)
        {
            var code = CodeFile;
            code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
            code.AppendLine($"public partial class {Name}");
            code.OpenBlock();

            // Generate properties
            foreach (var member in context.structMember())
            {
                var decl = member.declaration();
           //     if (decl.typeSpecifier() == null) continue;

                WriteDocumentationComment(member, true);

                var fieldType = new CSharpTypeInfo(decl);
                var fieldName = getFieldName(decl);
                GenerateProperty(decl, fieldType, fieldName);
                code.AppendLine();
            }

            // Generate constructor
            code.AppendLine($"public {Name}()");
            code.OpenBlock();
            foreach (var member in context.structMember())
            {
                var decl = member.declaration();


                GenerateInitialization(decl);
            }
            code.CloseBlock();

            // Generate validation method
            code.AppendLine("/// <summary>Validates all fields have valid values</summary>");
            code.AppendLine("public virtual void Validate()");
            code.OpenBlock();
            foreach (var member in context.structMember())
            {
                var decl = member.declaration();
               // if (decl.typeSpecifier() != null)
              //  {
                    GenerateValidation(decl);
               // }
            }
            code.CloseBlock();

            foreach (var child in this.NestedTypes)
            {
                child.Generate(allTypes);
            }
            code.CloseBlock();

            // Generate XDR helper class
            GenerateStructXdrHelperClass(Name, context.structMember());

            


        }
        private void GenerateProperty(DeclarationContext decl, CSharpTypeInfo fieldType, string fieldName)
        {
            if (fieldType.IsVoid) return;

            var code = CodeFile;
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

            GeneratePropertyValidation(decl, "value", fieldType);

            code.AppendLine($"_{fieldName.ToCamelCase()} = value;");
            code.CloseBlock();
            code.CloseBlock();


        }

        private void GenerateInitialization(StellarXdrParser.DeclarationContext decl)
        {
            var code = CodeFile;
            var typeInfo = new CSharpTypeInfo(decl);

            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                var size = typeInfo.MaxLength;
                var fieldName = getFieldName(decl);
                var fieldType = typeInfo.CSharpType;
                code.AppendLine($"{fieldName} = new {fieldType}[{size}];");
            }
        }

        private void GenerateValidation(StellarXdrParser.DeclarationContext decl)
        {
            var code = CodeFile;
            var typeInfo = new CSharpTypeInfo(decl);
            var fieldName = getFieldName(decl);

            if (typeInfo.ArrayType == ArrayType.Fixed)
            {
                var size = typeInfo.MaxLength;
                code.AppendLine($"if ({fieldName}.Length != {size})");
                code.AppendLine($"\tthrow new InvalidOperationException($\"{fieldName} must be exactly {size} elements\");");
            }
            else if (typeInfo.ArrayType == ArrayType.Variable)
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
            var code = CodeFile;
            code.AppendLine($"public static partial class {structName}Xdr");
            code.OpenBlock();

            AddGeneralBase64EncodeBlock(structName, code);

            // Generate Encode method
            code.AppendLine("/// <summary>Encodes struct to XDR stream</summary>");
            code.AppendLine($"public static void Encode(XdrWriter stream, {structName} value)");
            code.OpenBlock();
            code.AppendLine("value.Validate();");
            foreach (var member in members)
            {
                var decl = member.declaration();
                string fieldName = getFieldName(decl);
                GenerateEncodeStatement(decl, "value", fieldName);
              
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
                GenerateDecodeStatement(decl, "result");
            }
            code.AppendLine("return result;");
            code.CloseBlock();

            code.CloseBlock();
        }

        private void GeneratePropertyValidation(StellarXdrParser.DeclarationContext decl, string valueName, CSharpTypeInfo typeInfo)
        {
            var code = CodeFile;
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


        private bool isEnum(string typeName, List<XDRTypeDefinition> allTypes)
        {
            var xdr = allTypes.Where(t => t.Name == typeName).FirstOrDefault(); //TODO - should check against full name really including namespace
            if (xdr != null)
            {
                return xdr.XDRType == XDRType.Enum;
            }
            return false;
        }

        private void GenerateUnion(StellarXdrParser.UnionBodyContext context, List<XDRTypeDefinition> allTypes)
        {
            var switchDecl = context.declaration();
            var discriminatorType = new CSharpTypeInfo(switchDecl);
            var code = CodeFile;



            // Generate abstract base class
            code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
            code.AppendLine($"public abstract partial class {Name}");
            code.OpenBlock();
            if (isEnum(discriminatorType.CSharpType,allTypes))
            {
                code.AppendLine($"public abstract {discriminatorType.CSharpType} Discriminator {{ get; }}");
            }
            else
            {
                code.AppendLine($"public abstract int Discriminator {{ get; }}");
            }

            code.AppendLine();
            code.AppendLine("/// <summary>Validates the union case matches its discriminator</summary>");
            code.AppendLine("public abstract void ValidateCase();");
            code.AppendLine();
            foreach (var child in this.NestedTypes)
            {
                child.Generate(allTypes);
            }
            code.CloseBlock();

            // Generate case classes
            foreach (var caseSpec in context.caseSpec())
            {
                foreach (var value in caseSpec.value())
                {
                    WriteDocumentationComment(caseSpec);

                    var className = $"{Name}_{value.GetText()}";
                    code.AppendLine($"public sealed partial class {className} : {Name}");
                    code.OpenBlock();
                    /*

                        Discriminants must be one of these types:

                           int
                           unsigned int
                           bool
                           enum
                           typedef that resolves to one of the above

                        The discriminant is encoded as a 4-byte value
                        The discriminant must match one of the case values in the union definition
                        The discriminant encoding precedes the encoding of the selected union arm



                    */
                    if (isEnum(discriminatorType.CSharpType, allTypes))
                    {
                        code.AppendLine($"public override {discriminatorType.CSharpType} Discriminator => {discriminatorType.CSharpType}.{value.GetText()};");
                    }
                    else
                    {
                        if (discriminatorType.CSharpType == "bool")
                        {
                            code.AppendLine($"public override int Discriminator => Convert.ToInt32({value.GetText().ToLower()});");
                        }
                        else
                        {
                            code.AppendLine($"public override int Discriminator => {value.GetText()};");
                        }
                    }
                    var decl = caseSpec.declaration();
                    var fieldType = new CSharpTypeInfo(decl);
                   
                    var fieldName = getFieldName(decl);
                    GenerateProperty(decl, fieldType, fieldName);
                    

                    
                    code.AppendLine();
                    code.AppendLine("public override void ValidateCase() {}");
            
      
                    code.CloseBlock();
                }
            }

            string discriminatorString = "int";
            if (isEnum(discriminatorType.CSharpType, allTypes))
            {
                discriminatorString = discriminatorType.CSharpType;
            }

            // Generate default case if present
            var defaultCase = context.defaultCase();
            if (defaultCase != null)
            {
                code.AppendLine($"public sealed partial class {Name}_Default : {Name}");
                code.OpenBlock();
                code.AppendLine($"private readonly {discriminatorString} _discriminator;");

                code.AppendLine($"public override {discriminatorString} Discriminator => _discriminator;");

                var defaultDecl = defaultCase.declaration();
           
                var fieldType = new CSharpTypeInfo(defaultDecl);
         
                var fieldName = getFieldName(defaultDecl);
                GenerateProperty(defaultDecl, fieldType, fieldName);
                

                code.AppendLine();
                code.AppendLine($"public {Name}_Default({discriminatorString} discriminator)");
                code.OpenBlock();
                code.AppendLine(" _discriminator = discriminator;");
                code.CloseBlock();

                code.AppendLine();
                code.AppendLine("public override void ValidateCase() {}");
                code.CloseBlock();
            }

            // Generate XDR helper class
            code.AppendLine($"public static partial class {Name}Xdr");
            code.OpenBlock();
            AddGeneralBase64EncodeBlock(Name, code);
            GenerateUnionEncodeMethods(Name, context);
            GenerateUnionDecodeMethods(Name, discriminatorString, context,allTypes);
            code.CloseBlock();
         


        }

        private void GenerateTypedef(StellarXdrParser.TypedefDefinitionContext context)
        {
            var declaration = context.declaration();


            var code = CodeFile;
            code.AppendLine("[System.CodeDom.Compiler.GeneratedCode(\"XdrGenerator\", \"1.0\")]");
            code.AppendLine($"public partial class {Name}");
            code.OpenBlock();

            var baseType = new CSharpTypeInfo(declaration);

            GenerateProperty(declaration, baseType, "InnerValue");


            // Generate constructors
            code.AppendLine();
            code.AppendLine($"public {Name}() {{ }}");
            code.AppendLine();
            code.AppendLine($"public {Name}({baseType.FullCSharpType} value)");
            code.OpenBlock();
            code.AppendLine("InnerValue = value;");
            code.CloseBlock();

            code.CloseBlock();

            // Generate XDR helper class
            code.AppendLine($"public static partial class {Name}Xdr");
            code.OpenBlock();
            AddGeneralBase64EncodeBlock(Name, code);
            GenerateTypedefEncodeMethods(Name, declaration);
            GenerateTypedefDecodeMethods(Name, declaration);
            code.CloseBlock();

        


        }



        private void GenerateUnionEncodeMethods(string unionName,
                                              StellarXdrParser.UnionBodyContext context)
        {
            var code = CodeFile;
            code.AppendLine($"public static void Encode(XdrWriter stream, {unionName} value)");
            code.OpenBlock();
            code.AppendLine("value.ValidateCase();");
            code.AppendLine($"stream.WriteInt((int)value.Discriminator);");
            code.AppendLine("switch (value)");
            code.OpenBlock();

            foreach (var caseSpec in context.caseSpec())
            {
                foreach (var value in caseSpec.value())
                {
                    code.AppendLine($"case {unionName}_{value.GetText()} case_{value.GetText()}:");
                    var decl = caseSpec.declaration();
                    if (decl is GeneralDeclarationContext || decl is OptionalDeclarationContext)
                    {
                        var fieldName = getFieldName(decl);
                        GenerateEncodeStatement(decl, $"case_{value.GetText()}", fieldName);
                    
                    }
                    code.AppendLine("break;");
                }
            }

            if (context.defaultCase() != null)
            {
                code.AppendLine("case var defaultCase:");
                var defaultDecl = context.defaultCase().declaration();
                if (defaultDecl is GeneralDeclarationContext || defaultDecl is OptionalDeclarationContext)
                {
                    var fieldName = getFieldName(defaultDecl);
                    GenerateEncodeStatement(defaultDecl, "defaultCase", fieldName);
                }
                code.AppendLine("break;");
            }

            code.CloseBlock();
            code.CloseBlock();
        }

        private void GenerateUnionDecodeMethods(string unionName, string discriminatorType,
                                              StellarXdrParser.UnionBodyContext context,List<XDRTypeDefinition> allTypes)
        {
            var code = CodeFile;

            code.AppendLine($"public static {unionName} Decode(XdrReader stream)");
            code.OpenBlock();
            code.AppendLine($"var discriminator = ({discriminatorType})stream.ReadInt();");
            code.AppendLine("switch (discriminator)");
            code.OpenBlock();
            bool en = isEnum(discriminatorType, allTypes);
            foreach (var caseSpec in context.caseSpec())
            {
                foreach (var value in caseSpec.value())
                {
                    if (en)
                    {
                        code.AppendLine($"case {discriminatorType}.{value.GetText()}:");
                    }
                    else
                    {
                        code.AppendLine($"case {value.GetText()}:");
                    }
                    
                    code.AppendLine($"var result_{value.GetText()} = new {unionName}_{value.GetText()}();");
                    var decl = caseSpec.declaration();
                    if (decl is GeneralDeclarationContext || decl is OptionalDeclarationContext)
                    {
                        var fieldName = getFieldName(decl);
                        GenerateDecodeStatement(decl, $"result_{value.GetText()}",fieldName);
                    }
                    code.AppendLine($"return result_{value.GetText()};");
                }
            }

            if (context.defaultCase() != null)
            {
                code.AppendLine("default:");
                code.AppendLine($"var defaultResult = new {unionName}_Default(discriminator);");
                var defaultDecl = context.defaultCase().declaration();
                if (defaultDecl is GeneralDeclarationContext || defaultDecl is OptionalDeclarationContext)
                {
                    var fieldName = getFieldName(defaultDecl);
                    GenerateDecodeStatement(defaultDecl, "defaultResult",fieldName);
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

        private void GenerateTypedefEncodeMethods(string typedefName,
                                                StellarXdrParser.DeclarationContext declaration)
        {
            var code = CodeFile;
            code.AppendLine($"public static void Encode(XdrWriter stream, {typedefName} value)");
            code.OpenBlock();
            GenerateEncodeStatement(declaration, "value", "InnerValue");
            code.CloseBlock();
        }

        private void GenerateTypedefDecodeMethods(string typedefName,
                                                StellarXdrParser.DeclarationContext declaration)
        {
            var code = CodeFile;
            code.AppendLine($"public static {typedefName} Decode(XdrReader stream)");
            code.OpenBlock();
            code.AppendLine($"var result = new {typedefName}();");
            GenerateDecodeStatement(declaration, "result", fieldName: "InnerValue");
            code.AppendLine("return result;");
            code.CloseBlock();
        }

        private void GenerateEncodeStatement(StellarXdrParser.DeclarationContext decl,
                                           string valueName, string fieldName)
        {
    
            var typeInfo = new CSharpTypeInfo(decl);
            var code = CodeFile;
            if (typeInfo.IsOptional)
            {
                code.AppendLine($"if ({valueName}.{fieldName}==null){{");
                code.AppendLine($"\tstream.WriteInt(0);");
                code.AppendLine("}");
                code.AppendLine("else");
                code.OpenBlock();
                code.AppendLine($"stream.WriteInt(1);");
            }
            if (typeInfo.IsOpaque) 
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
            else if (typeInfo.IsString)
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
                code.AppendLine($"    {GetEncodeStatement(typeInfo.TypeSpecifierContext, "item")};");
                code.CloseBlock();
            }
            else
            {
                code.AppendLine($"{GetEncodeStatement(typeInfo.TypeSpecifierContext, $"{valueName}.{fieldName}")};");
            }
            if (typeInfo.IsOptional)
            {
              
                code.CloseBlock();
            }
        }

        private static string getFieldName(DeclarationContext decl)
        {
            string fieldName = DeclarationIdentifier(decl);
            if (SyntaxFacts.IsKeywordKind(SyntaxFacts.GetKeywordKind(fieldName)))
            {
                fieldName = $"_{fieldName}";
            }
            return fieldName;
        }

        private void GenerateDecodeStatement(StellarXdrParser.DeclarationContext decl,
                                           string valueName, string fieldName = null)
        {
            var code = CodeFile;
         
            if (String.IsNullOrEmpty(fieldName)) fieldName = getFieldName(decl);
            var typeInfo = new CSharpTypeInfo(decl);
            var typeSpec = typeInfo.TypeSpecifierContext;
            if (typeInfo.IsOptional)
            {
                code.AppendLine($"if (stream.ReadInt()==1)");
                code.OpenBlock();
            }
            if (typeInfo.IsOpaque)
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
            else if (typeInfo.IsString)
            {
                code.AppendLine($"{valueName}.{fieldName} = stream.ReadString();");
            }
            else if (typeInfo.ArrayType != ArrayType.None)
            {
                code.OpenBlock();
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
                code.CloseBlock();
            }
            else
            {
                code.AppendLine($"{valueName}.{fieldName} = {GetDecodeStatement(typeSpec)};");
            }
            if (typeInfo.IsOptional)
            {
                code.CloseBlock();
            }
        }

        private string GetEncodeStatement(StellarXdrParser.TypeSpecifierContext typeSpec, string valueName)
        {
            switch (typeSpec.GetText())
            {
                case null:
                    throw new InvalidOperationException("Type specification cannot be null");
                case "unsignedint":
                    return $"stream.WriteUInt({valueName})";
                case "int":
                    return $"stream.WriteInt({valueName})";
                case "unsignedhyper":
                    return $"stream.WriteULong({valueName})";
                case "hyper":
                    return $"stream.WriteLong({valueName})";
                case "float":
                    return $"stream.WriteFloat({valueName})";
                case "double":
                    return $"stream.WriteDouble({valueName})";
                case "bool":
                    return $"stream.WriteInt({valueName} ? 1 : 0)";
                default:
                    var result = typeSpec.identifier()?.GetText();
                    if (String.IsNullOrEmpty(result))
                    {
                        if (typeSpec?.baseType()?.unionTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName(typeSpec?.baseType()?.unionTypeSpec());
                        if (typeSpec?.baseType()?.enumTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName(typeSpec?.baseType()?.enumTypeSpec());
                        if (typeSpec?.baseType()?.structTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName(typeSpec?.baseType()?.structTypeSpec());
                        result = $"{Name}.{result}";
                    }
                    return $"{result}Xdr.Encode(stream, {valueName})";
            }
        }

        private string GetDecodeStatement(StellarXdrParser.TypeSpecifierContext typeSpec)
        {
            switch (typeSpec.GetText())
            {
                case null:
                    throw new InvalidOperationException("Type specification cannot be null");
                case "unsignedint": return "stream.ReadUInt()";
                case "int": return "stream.ReadInt()";
                case "unsignedhyper": return "stream.ReadULong()";
                case "hyper": return "stream.ReadLong()";
                case "float": return "stream.ReadFloat()";
                case "double": return "stream.ReadDouble()";
                case "bool": return "stream.ReadInt() != 0";
                default:
                    var result = typeSpec.identifier()?.GetText();
                    if (String.IsNullOrEmpty(result))
                    {
                        if (typeSpec?.baseType()?.unionTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName( typeSpec?.baseType()?.unionTypeSpec());
                        if (typeSpec?.baseType()?.enumTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName(  typeSpec?.baseType()?.enumTypeSpec());
                        if (typeSpec?.baseType()?.structTypeSpec() != null) result = TypeExtractorVisitor.GetNestedTypeName(typeSpec?.baseType()?.structTypeSpec());
                        result = $"{Name}.{result}";
                    }
             
                    return $"{result}Xdr.Decode(stream)";
            }
        }

    }
}
