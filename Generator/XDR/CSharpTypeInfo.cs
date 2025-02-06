using Generator.XDR.Grammar;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generator.XDR.Grammar.StellarXdrParser;

namespace Generator.XDR
{
    public enum ArrayType
    {
        None,
        Fixed,
        Variable
    }

    public class CSharpTypeInfo
    {
        public string CSharpType { get; private set; }     // The base C# type (byte, int, string, etc.)
        public bool IsOptional { get; private set; } =  false;
        public bool IsOpaque { get; private set; } = false;
        public bool IsString { get; private set; } = false;
        public bool IsVoid { get; private set; } = false;   
        public ArrayType ArrayType { get; private set; } = ArrayType.None;
        public string? MaxLength { get; private set; }        // Max length for arrays/strings, null if unbounded
        public bool HasMaxLength => MaxLength != null;
        public string FullCSharpType => ArrayType!=ArrayType.None ? $"{CSharpType}[]" : CSharpType;
        public TypeSpecifierContext TypeSpecifierContext { get; private set; }
        private TypeExtractorVisitor GenerationContext { get; }

        public CSharpTypeInfo(StellarXdrParser.DeclarationContext decl, TypeExtractorVisitor generationContext)
        {
            GenerationContext = generationContext;
            switch (decl)
            {
                case (GeneralDeclarationContext g):
                    {

                        TypeSpecifierContext = g.typeSpecifier();
                        var arraySizeSpec = g.arraySizeSpec();
                        if (arraySizeSpec != null)
                        {
                            GetArrayInfo(arraySizeSpec);
                        }
                        IdentifyType(g.typeSpecifier());
                    }
                    break;
                case (OpaqueDeclarationContext o):
                    {
                        var arraySizeSpec = o.arraySizeSpec();
                        GetArrayInfo(arraySizeSpec);
                        CSharpType = "byte";
                        IsOpaque = true;
                    }
                    break;
                case (StringDeclarationContext s):
                    {
                        IsString = true;
                        var arraySizeSpec = s.arraySizeSpec();
                        switch (arraySizeSpec)
                        {
                            case FixedArraySizeContext fixedArraySizeSpec:
                                throw new ArgumentException($"String declaration context attemps to be a fixed length array {s.GetText()}");

                            case VarArraySizeContext varArraySizeSpec:
                                MaxLength = varArraySizeSpec?.value() != null ? XDRTypeDefinition.GetValue(varArraySizeSpec.value(), generationContext.AllTypes) : null; //int.Parse(varArraySizeSpec.value().constant().GetText()) : null;
                           
                                break;
                        }
                        CSharpType = "string";
                    }
                    break;
                case (OptionalDeclarationContext op):
                    IsOptional = true;
                    IdentifyType(op.typeSpecifier());
                    TypeSpecifierContext = op.typeSpecifier();
                    break;
                case (VoidDeclarationContext v):
                    CSharpType = "void";
                    IsVoid = true;
                    break;
                default:
                    throw new ArgumentException($"Unrecognised declaration type {decl.GetText()}");
            }

            void GetArrayInfo(ArraySizeSpecContext arraySizeSpec)
            {
                if (arraySizeSpec is FixedArraySizeContext fixedArray)
                {
                    // Fixed size arrays (square brackets) always mean fixed array
                    ArrayType = ArrayType.Fixed;
                    MaxLength = XDRTypeDefinition.GetValue(fixedArray.value(), generationContext.AllTypes);
                }
                else
                {
                    // For opaque and other types, angle brackets specify variable array
                    ArrayType = ArrayType.Variable;
                    var value = ((VarArraySizeContext)arraySizeSpec).value();
                    if (value != null) MaxLength = XDRTypeDefinition.GetValue(((VarArraySizeContext)arraySizeSpec).value(),generationContext.AllTypes);
                    else
                    {
                        MaxLength = null;
                    }
                }
            }

            void IdentifyType(TypeSpecifierContext ts)
            {
                var baseType = ts.GetText() switch
                {
                    "unsignedint" => "uint",
                    "int" => "int",
                    "unsignedhyper" => "ulong",
                    "hyper" => "long",
                    "float" => "float",
                    "double" => "double",
                    "bool" => "bool",
                    _ => ts.identifier()?.GetText() ?? "object"
                };

                if (baseType == "object")
                {
                    if (ts?.baseType()?.unionTypeSpec() != null)
                        baseType = TypeExtractorVisitor.GetNestedTypeName(ts?.baseType()?.unionTypeSpec());
                    if (ts?.baseType()?.enumTypeSpec() != null)
                        baseType = TypeExtractorVisitor.GetNestedTypeName(ts?.baseType()?.enumTypeSpec());
                    if (ts?.baseType()?.structTypeSpec() != null)
                        baseType = TypeExtractorVisitor.GetNestedTypeName(ts?.baseType()?.structTypeSpec());
                }
                CSharpType = baseType;
            }
        }

        public long? ResolveMaxLengthToInteger()
        {
            if (long.TryParse(MaxLength, out var maxLength)) return maxLength;
            else
            {
                var constname = MaxLength?.Replace("Constants.","");
                var constant = GenerationContext.AllTypes.Where(t=>t.XDRType==TypeExtractorVisitor.XDRType.Const && t.Name==constname).FirstOrDefault();
                if (constant != null) return constant.ConstValue??0;
            }
            return null;
        }

      
    }
}
