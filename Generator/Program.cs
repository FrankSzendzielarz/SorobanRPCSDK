using Antlr4.Runtime;
using Generator.OpenRPC;
using Generator.XDR;
using Generator.XDR.Grammar;
using System.Text.Json;


namespace Generator;

public class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: StellarXdrGenerator <stellar xdr folder> <stellar openRPC file> [output dir xdr] [output dir rpc]");
            return;
        }


        var xdrFolder = args[0];
        var openRPCFile = args[1];

        var outputDirXdr = args.Length > 2 ? args[2] : Path.Combine(Directory.GetCurrentDirectory(), "GeneratedXDR");
        var outputDirRpc = args.Length > 3 ? args[3] : Path.Combine(Directory.GetCurrentDirectory(), "GeneratedRPC");

        try
        {
            if (!Directory.Exists(xdrFolder))
            {
                Console.WriteLine($"Directory {xdrFolder} not found.");
                return;
            }

            if (!File.Exists(openRPCFile))
            {
                Console.WriteLine($"OpenRPC file {openRPCFile} not found.");
                return;
            }

            // Create output directory if it doesn't exist
            Directory.CreateDirectory(outputDirXdr);

            var visitor = new TypeExtractorVisitor(outputDirXdr);

            // Read and parse the xdr input files
            foreach (var xdrFile in Directory.GetFiles(xdrFolder, "*.x"))
            {
                Console.WriteLine($"Generating code for XDR {xdrFile}");
                var fileContent = await File.ReadAllTextAsync(xdrFile);
                var inputStream = new AntlrInputStream(fileContent);

                // Create the lexer
                var lexer = new StellarXdrLexer(inputStream);
                var tokens = new CommonTokenStream(lexer);
                

                // Create the parser
                var parser = new StellarXdrParser(tokens);

                // Add error listeners
                lexer.RemoveErrorListeners();
                parser.RemoveErrorListeners();
                var errorListener = new ParsingErrorListener();
                lexer.AddErrorListener(errorListener);
                parser.AddErrorListener(errorListener);

                // Parse the input
                var tree = parser.compilationUnit();

                if (errorListener.HasErrors)
                {
                    foreach (var error in errorListener.Errors)
                    {
                        Console.Error.WriteLine(error);
                    }
                    return;
                }

                // Visit the parse tree

                //var visitor = new CSharpCodeGenVisitor(outputDir,tokens);
                visitor.BuildCommentMap(tokens);
                visitor.Visit(tree);
            }
            visitor.WriteAllTypes();
            Console.WriteLine($"XDR generation complete.");
            Console.WriteLine($"Generating code for OpenRPC file {openRPCFile}");

            var jsonContent = await File.ReadAllTextAsync(openRPCFile);
            var spec = JsonSerializer.Deserialize<OpenRpcSpec>(jsonContent);
            var generator = new CSharpOpenRPCGenerator(spec!, outputDirRpc);
            await generator.GenerateAsync();

            Console.WriteLine($"Successfully generated code in {outputDirXdr} and {outputDirRpc}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
        }
    }
}

// Custom error listener to collect all errors
public class ParsingErrorListener : IAntlrErrorListener<IToken>, IAntlrErrorListener<int>
{
    private readonly List<string> _errors = new();
    public IReadOnlyList<string> Errors => _errors;
    public bool HasErrors => _errors.Count > 0;

    public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line,
        int charPositionInLine, string msg, RecognitionException e)
    {
        _errors.Add($"Line {line}:{charPositionInLine} - {msg}");
    }

    public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line,
        int charPositionInLine, string msg, RecognitionException e)
    {
        _errors.Add($"Line {line}:{charPositionInLine} - {msg}");
    }
}

