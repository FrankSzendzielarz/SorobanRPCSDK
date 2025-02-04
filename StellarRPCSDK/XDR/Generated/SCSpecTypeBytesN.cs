// Generated code - do not modify
// Source:

// struct SCSpecTypeBytesN
// {
//     uint32 n;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeBytesN
    {
        public uint32 n
        {
            get => _n;
            set
            {
                _n = value;
            }
        }
        private uint32 _n;

        public SCSpecTypeBytesN()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeBytesNXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeBytesN value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeBytesNXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeBytesN value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.n);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeBytesN Decode(XdrReader stream)
        {
            var result = new SCSpecTypeBytesN();
            result.n = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
