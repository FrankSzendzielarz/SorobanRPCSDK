// Generated code - do not modify
// Source:

// struct SCSpecTypeUDT
// {
//     string name<60>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeUDT
    {
        private string _name;
        public string name
        {
            get => _name;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 60)
                	throw new ArgumentException($"String exceeds 60 bytes when UTF8 encoded");
                _name = value;
            }
        }

        public SCSpecTypeUDT()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeUDTXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeUDT value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeUDTXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeUDT value)
        {
            value.Validate();
            stream.WriteString(value.name);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeUDT Decode(XdrReader stream)
        {
            var result = new SCSpecTypeUDT();
            result.name = stream.ReadString();
            return result;
        }
    }
}
