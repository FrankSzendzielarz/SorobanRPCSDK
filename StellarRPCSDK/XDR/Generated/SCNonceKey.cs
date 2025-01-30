// Generated code - do not modify
// Source:

// struct SCNonceKey {
//     int64 nonce;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCNonceKey
    {
        private int64 _nonce;
        public int64 nonce
        {
            get => _nonce;
            set
            {
                _nonce = value;
            }
        }

        public SCNonceKey()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCNonceKeyXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCNonceKey value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.nonce);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCNonceKey Decode(XdrReader stream)
        {
            var result = new SCNonceKey();
            result.nonce = int64Xdr.Decode(stream);
            return result;
        }
    }
}
