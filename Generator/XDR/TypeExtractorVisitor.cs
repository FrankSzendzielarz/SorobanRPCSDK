﻿using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;
using Microsoft.CodeAnalysis;
using static Generator.XDR.Grammar.StellarXdrParser;

namespace Generator.XDR;


/// <summary>
/// First pass parser to identify all types
/// </summary>
public partial class TypeExtractorVisitor : StellarXdrBaseVisitor<object>
{
    

    internal class TypeContext
    {

        public string? Namespace { get; set; }
        public XDRTypeDefinition? CurrentType { get; set; } 
        
        public string CurrentNamespace => Namespace ?? "StellarGenerated";
        public string? CurrentTypeName => CurrentType?.FullName;

        

        public void Pop()
        {
            if (CurrentType != null) CurrentType = CurrentType.Parent;
        }

    }

  

    public enum XDRType
    {
        Enum,
        Struct,
        Union,
        TypeDef,
        Const
    }

    private CodeFile CurrentCodeFile { get; set; }
    internal readonly TypeContext _context = new();
    private readonly string _outputDir;
    private Dictionary<IToken, string> _commentMap = new();
    internal CodeFile ConstantsCodeFile { get; }
    public List<XDRTypeDefinition> AllTypes { get; set; } = new();

    public TypeExtractorVisitor(string outputDir)
    {
        _outputDir = outputDir;
        ConstantsCodeFile = new ConstantsCodeFile(Path.Combine(outputDir, $"Constants.cs"));

    }
    public void AddType(string typeName, XDRType type, ParserRuleContext docsContext, ParserRuleContext ruleContext, string outputDir, Dictionary<IToken, string> commentMap, List<string> enumAliases = null, long constant = 0)
    {
        var newType = new XDRTypeDefinition(this,type, docsContext, ruleContext, _context.CurrentNamespace, typeName, _context.CurrentType, outputDir, commentMap, enumAliases, constant);
        if (_context.CurrentType == null) AllTypes.Add(newType);
        _context.CurrentType = newType;
        Console.WriteLine($"Found type: {_context.CurrentTypeName}");
    }
    public void BuildCommentMap(CommonTokenStream tokenStream)
    {
        _commentMap = new();
        var tokens = tokenStream.GetTokens();

        // Dictionary to store pending comments keyed by line number
        Dictionary<int, string> pendingComments = new();

        foreach (var token in tokens)
        {
            if (token.Channel == TokenConstants.HiddenChannel)
            {
                if (token.Type == StellarXdrLexer.BLOCK_COMMENT ||
                    token.Type == StellarXdrLexer.LINE_COMMENT)
                {
                    string comment = token.Text;
                    comment = comment.Replace("/*", "").Replace("*/", "")
                                   .Replace("//", "").Trim();

                    if (!string.IsNullOrWhiteSpace(comment))
                    {
                        // Store comment for next non-hidden token
                        int nextLine = token.Line + 1;
                        if (!pendingComments.ContainsKey(nextLine))
                        {
                            pendingComments[nextLine] = comment;
                        }
                        else
                        {
                            pendingComments[nextLine] += Environment.NewLine + comment;
                        }
                    }
                }
            }
            else // Non-hidden token
            {
                // If we have pending comments for this line, associate them with this token
                if (pendingComments.TryGetValue(token.Line, out var comment))
                {
                    _commentMap[token] = comment;
                    pendingComments.Remove(token.Line);
                }
            }
        }
    }

   

    internal static long ExtractValueFromConstant( ConstantContext constant)
    {
        long value=0;
        if (constant != null)
        {
            try
            {
                value = constant switch
                {
                    _ when constant.HEXADECIMAL_CONSTANT()?.GetText() is string hex
                        => Convert.ToInt64(hex.Replace("0x", ""), 16),

                    _ when constant.INTEGER_CONSTANT()?.GetText() is string dec
                        => Convert.ToInt64(dec, 10),

                    _ when constant.OCTAL_CONSTANT()?.GetText() is string oct
                        => Convert.ToInt64(oct.Replace("0", ""), 8),

                    _ => 0
                };
            }
            catch
            {
                throw new Exception($"Could not parse value in constant {constant.GetText()}");
            }
        }

        return value;
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
        XDRType type = XDRType.Enum;
        List<string> members = GetEnumMemberNames(context.enumBody());
        AddType(enumName, type,context, context.enumBody(),_outputDir,_commentMap,members);
        try
        {
            return base.VisitEnumDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }

    public override object VisitConstantDefinition([NotNull] ConstantDefinitionContext context)
    {

        string id = context.identifier().GetText();
        var constant = context.constant();
        long value = 0;
        value = ExtractValueFromConstant(constant);
        AddType(id, XDRType.Const, context, constant, _outputDir, _commentMap, null, value);
        _context.Pop();
        return null;
    }

    public override object VisitStructDefinition([NotNull] StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        XDRType type = XDRType.Struct;
        AddType(structName, type, context,context.structBody(), _outputDir,_commentMap);
        try
        {
            return base.VisitStructDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }

    public override object VisitUnionDefinition([NotNull] StellarXdrParser.UnionDefinitionContext context)
    {
        var unionName = context.identifier().GetText();
        XDRType type = XDRType.Union;
        AddType(unionName, type, context,context.unionBody(), _outputDir,_commentMap );
        try
        {
            return base.VisitUnionDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }

    internal static string DeclarationIdentifier(DeclarationContext dc)
    {
        switch (dc)
        {
            case (GeneralDeclarationContext g):
                return g.identifier().GetText();
            case (OpaqueDeclarationContext o):
                return o.identifier().GetText();
            case (StringDeclarationContext s):
                return s.identifier().GetText();
            case (OptionalDeclarationContext op):
                return op.identifier().GetText();   
            case (VoidDeclarationContext v):
                return String.Empty;
            default:
                throw new ArgumentException($"Unrecognised declaration type {dc.GetText()}");
        }
    }

    public override object VisitTypedefDefinition([NotNull] StellarXdrParser.TypedefDefinitionContext context)
    {
        var typedefName = DeclarationIdentifier(context.declaration());
        XDRType type = XDRType.TypeDef;
        AddType(typedefName, type, context,context, _outputDir, _commentMap);
        try 
        { 
            return base.VisitTypedefDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }

    public override object VisitUnionTypeSpec([NotNull] StellarXdrParser.UnionTypeSpecContext context)
    {
        string localName = GetNestedTypeName(context);
        XDRType type = XDRType.Union;
        AddType(localName, type, context,context.unionBody(), _outputDir, _commentMap);
        try
        {
            return base.VisitUnionTypeSpec(context);
        }
        finally
        {
            _context.Pop();
        }
 
    }

    public override object VisitEnumTypeSpec([NotNull] StellarXdrParser.EnumTypeSpecContext context)
    {
        string localName = GetNestedTypeName(context);
        XDRType type = XDRType.Enum;
        List<string> members = GetEnumMemberNames(context.enumBody());
        AddType(localName, type, context, context.enumBody(), _outputDir, _commentMap,members);
        try
        {
            return base.VisitEnumTypeSpec(context);
        }
        finally
        {
            _context.Pop();
        }

    }

    private List<string> GetEnumMemberNames(StellarXdrParser.EnumBodyContext enumBodyContext)
    {
        List<string> results=new List<string>();
        foreach (var member in enumBodyContext.enumMember())
        {
            results.Add(member.identifier().GetText());
        }
        return results;
    }

    public override object VisitStructTypeSpec([NotNull] StellarXdrParser.StructTypeSpecContext context)
    {
        string localName = GetNestedTypeName(context);
        XDRType type = XDRType.Struct;
        AddType(localName, type, context, context.structBody(), _outputDir, _commentMap);
        try
        {
            return base.VisitStructTypeSpec(context);
        }
        finally
        {
            _context.Pop();
        }

    }

    public void WriteAllTypes()
    {
        foreach (var xdrDefinedType in AllTypes)
        {
            xdrDefinedType.Generate();
        }

        var allCodeFiles=  AllTypes.Select(a => a.CodeFile).Distinct();

        foreach (var codeFile in allCodeFiles)
        {
            codeFile.Write();
        }
    }

    internal static string GetNestedTypeName(ParserRuleContext context)
    {
        string typeSuffix="Unknown";
        switch (context)
        {
            case StellarXdrParser.UnionTypeSpecContext u:
                typeSuffix = "Union";
                break;
            case StellarXdrParser.StructTypeSpecContext s:
                typeSuffix = "Struct";
                break;
            case StellarXdrParser.EnumTypeSpecContext e:
                typeSuffix = "Enum";
                break;

        }
     

        var parentDecl = context.Parent;
        while (parentDecl != null && !(parentDecl is StellarXdrParser.DeclarationContext))
        {
            parentDecl = parentDecl.Parent;
        }

        if (parentDecl is StellarXdrParser.DeclarationContext declContext)
        {
            return $"{DeclarationIdentifier(declContext)}{typeSuffix}";
        }
        return $"Nested{typeSuffix}";
    }

   

}
