using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Generator.XDR.Grammar;

namespace Generator.XDR;


/// <summary>
/// First pass parser to identify all types
/// </summary>
public partial class TypeExtractorVisitor : StellarXdrBaseVisitor<object>
{
    public class XDRTypeDefinition
    {
        public XDRType XDRType { get;  }
        public ParserRuleContext ParserRuleContext { get; }
        public string Namespace { get; }
        public string Name { get; }
        public List<XDRTypeDefinition> NestedTypes { get; } = new();
        public XDRTypeDefinition? Parent { get; } = null;
        private CodeFile? _codeFile { get; }
        public CodeFile? CodeFile => _codeFile != null ? _codeFile: Parent?.CodeFile;
        public string FullName =>  Parent == null ? Name  : $"{Parent.FullName}.{Name}";
        public XDRTypeDefinition(XDRType xdrType, ParserRuleContext parserRuleContext, string _namespace, string name, XDRTypeDefinition? parent, string outputDir)
        {
            XDRType = xdrType;
            ParserRuleContext = parserRuleContext;
            Namespace = _namespace;
            Name = name;
            Parent = parent;
            if (parent!= null)
            {
                parent.NestedTypes.Add(this);
            }
            else
            {
                _codeFile = new CodeFile(Path.Combine(outputDir, $"{name}.cs"));
            }
            
        }

    }

    private class TypeContext
    {
        public string? Namespace { get; set; }
        public XDRTypeDefinition? CurrentType { get; set; } 
        public List<XDRTypeDefinition> AllTypes { get;set; } = new();
        public string CurrentNamespace => Namespace ?? "StellarGenerated";
        public string? CurrentTypeName => CurrentType?.FullName;

        public void AddType(string typeName, XDRType type, ParserRuleContext ruleContext,string outputDir)
        {
            var newType = new XDRTypeDefinition(type, ruleContext, CurrentNamespace, typeName, CurrentType,outputDir);
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
    public Dictionary<string, XDRType> Types = new();
    private readonly Dictionary<IToken, string> _commentMap = new();

    public TypeExtractorVisitor(string outputDir)
    {
        _outputDir = outputDir;
     
    }

    public void BuildCommentMap(CommonTokenStream tokenStream)
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
        _context.AddType(enumName, type,context,_outputDir);
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
        _context.AddType(structName, type, context, _outputDir);
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
        _context.AddType(unionName, type, context, _outputDir);
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
        _context.AddType(typedefName, type, context, _outputDir);
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
        string localName = GetNestedTypeName(context, "Union");
        XDRType type = XDRType.Union;
        _context.AddType(localName, type, context, _outputDir);
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
        string localName = GetNestedTypeName(context, "Enum");
        XDRType type = XDRType.Enum;
        _context.AddType(localName, type, context, _outputDir);
        try
        {
            return base.VisitEnumTypeSpec(context);
        }
        finally
        {
            _context.Pop();
        }

    }

    public override object VisitStructTypeSpec([NotNull] StellarXdrParser.StructTypeSpecContext context)
    {
        string localName = GetNestedTypeName(context, "Struct");
        XDRType type = XDRType.Struct;
        _context.AddType(localName, type, context, _outputDir);
        try
        {
            return base.VisitStructTypeSpec(context);
        }
        finally
        {
            _context.Pop();
        }

    }

    public static string GetNestedTypeName(ParserRuleContext context, string typeSuffix)
    {
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

    private void WriteDocumentationComment(ParserRuleContext context, CodeFile code, bool isProperty = false)
    {

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

}
