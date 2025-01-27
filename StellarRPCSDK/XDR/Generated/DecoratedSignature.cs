// Generated code - do not modify
// Source:

// struct DecoratedSignature
// {
//     SignatureHint hint;  // last 4 bytes of the public key, used as a hint
//     Signature signature; // actual signature
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DecoratedSignature
    {
        private SignatureHint _hint;
        public SignatureHint hint
        {
            get => _hint;
            set
            {
                _hint = value;
            }
        }

        private Signature _signature;
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }

        public DecoratedSignature()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class DecoratedSignatureXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, DecoratedSignature value)
        {
            value.Validate();
            SignatureHintXdr.Encode(stream, value.hint);
            SignatureXdr.Encode(stream, value.signature);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static DecoratedSignature Decode(XdrReader stream)
        {
            var result = new DecoratedSignature();
            result.hint = SignatureHintXdr.Decode(stream);
            result.signature = SignatureXdr.Decode(stream);
            return result;
        }
    }
}
