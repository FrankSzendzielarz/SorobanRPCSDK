﻿using Antlr4.Runtime;
using Generator.CodeGenVisitors;
using Generator.OpenRPC;
using Generator.XDR.Grammar;
using NJsonSchema.CodeGeneration.CSharp;
using System.Text.Json;


namespace Generator;

public class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: StellarXdrGenerator <stellar xdr folder> <stellar openRPC file> [output_dir]");
            return;
        }


        var xdrFolder = args[0];
        var openRPCFile = args[1];

        var outputDir = args.Length > 2 ? args[2] : Path.Combine(Directory.GetCurrentDirectory(), "Generated");

        try
        {
            if (!Directory.Exists(xdrFolder))
            {
                Console.WriteLine($"Duirectory {xdrFolder} not found.");
                return;
            }

            if (!File.Exists(openRPCFile))
            {
                Console.WriteLine($"OpenRPC file {openRPCFile} not found.");
                return;
            }

            // Create output directory if it doesn't exist
            Directory.CreateDirectory(outputDir);

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
                var visitor = new CSharpCodeGenVisitor(outputDir);
                visitor.Visit(tree);
            }
            Console.WriteLine($"XDR generation complete.");
            Console.WriteLine($"Generating code for OpenRPC file {openRPCFile}");

            var jsonContent = await File.ReadAllTextAsync(openRPCFile);
            var spec = JsonSerializer.Deserialize<OpenRpcSpec>(jsonContent);
            var generator = new CSharpOpenRPCGenerator(spec!, outputDir);
            await generator.GenerateAsync();

            Console.WriteLine($"Successfully generated code in {outputDir}");
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

