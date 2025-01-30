// Generated code - do not modify
// Source:

// struct SCSpecTypeBytesN
// {
//     uint32 n;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeBytesN
    {
        private uint32 _n;
        public uint32 n
        {
            get => _n;
            set
            {
                _n = value;
            }
        }

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
