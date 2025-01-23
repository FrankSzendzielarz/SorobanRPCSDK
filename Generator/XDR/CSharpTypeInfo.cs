using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string CSharpType { get; }     // The base C# type (byte, int, string, etc.)
       
        public ArrayType ArrayType { get; }
        public int? MaxLength { get; }        // Max length for arrays/strings, null if unbounded

        public string FullCSharpType => ArrayType!=ArrayType.None ? $"{CSharpType}[]" : CSharpType;

        public CSharpTypeInfo(string csharpType, ArrayType arrayType, int? maxLength = null)
        {
            CSharpType = csharpType;
            ArrayType = arrayType;
            MaxLength = maxLength;
        }
    }
}
