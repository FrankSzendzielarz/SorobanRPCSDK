using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;

namespace Generator.XDR;


/// <summary>
/// First pass parser to identify all types
/// </summary>
public partial class TypeExtractorVisitor : StellarXdrBaseVisitor<object>
{
  

    private class TypeContext
    {
        public string? Namespace { get; set; }
        public XDRTypeDefinition? CurrentType { get; set; } 
        public List<XDRTypeDefinition> AllTypes { get;set; } = new();
        public string CurrentNamespace => Namespace ?? "StellarGenerated";
        public string? CurrentTypeName => CurrentType?.FullName;

        public void AddType(string typeName, XDRType type, ParserRuleContext docsContext, ParserRuleContext ruleContext,string outputDir, Dictionary<IToken, string> commentMap, List<string> enumAliases=null)
        {
            var newType = new XDRTypeDefinition(type, docsContext,ruleContext, CurrentNamespace, typeName, CurrentType,outputDir, commentMap, enumAliases);
            if (CurrentType==null) AllTypes.Add(newType);
            CurrentType = newType;
            Console.WriteLine($"Found type: {CurrentTypeName}");
        }

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
        TypeDef
    }

    private CodeFile CurrentCodeFile { get; set; }
    private readonly TypeContext _context = new();
    private readonly string _outputDir;
    private Dictionary<IToken, string> _commentMap = new();

    public TypeExtractorVisitor(string outputDir)
    {
        _outputDir = outputDir;
     
    }

    public void BuildCommentMap(CommonTokenStream tokenStream)
    {
        _commentMap = new();
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
        _context.AddType(enumName, type,context, context.enumBody(),_outputDir,_commentMap,members);
        try
        {
            return base.VisitEnumDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }



    public override object VisitStructDefinition([NotNull] StellarXdrParser.StructDefinitionContext context)
    {
        var structName = context.identifier().GetText();
        XDRType type = XDRType.Struct;
        _context.AddType(structName, type, context,context.structBody(), _outputDir,_commentMap);
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
        _context.AddType(unionName, type, context,context.unionBody(), _outputDir,_commentMap );
        try
        {
            return base.VisitUnionDefinition(context);
        }
        finally
        {
            _context.Pop();
        }
    }

    public override object VisitTypedefDefinition([NotNull] StellarXdrParser.TypedefDefinitionContext context)
    {
        var typedefName = context.declaration().identifier().GetText();
        XDRType type = XDRType.TypeDef;
        _context.AddType(typedefName, type, context,context, _outputDir, _commentMap);
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
        _context.AddType(localName, type, context,context.unionBody(), _outputDir, _commentMap);
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
        _context.AddType(localName, type, context, context.enumBody(), _outputDir, _commentMap,members);
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
            results.Add(member.identifier(0).GetText());
        }
        return results;
    }

    public override object VisitStructTypeSpec([NotNull] StellarXdrParser.StructTypeSpecContext context)
    {
        string localName = GetNestedTypeName(context);
        XDRType type = XDRType.Struct;
        _context.AddType(localName, type, context, context.structBody(), _outputDir, _commentMap);
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
        foreach (var xdrDefinedType in _context.AllTypes)
        {
           
            xdrDefinedType.Generate(_context.AllTypes);
            xdrDefinedType.CodeFile.Write();
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
            return $"{declContext.identifier()?.GetText()}{typeSuffix}";
        }
        return $"Nested{typeSuffix}";
    }

   

}
