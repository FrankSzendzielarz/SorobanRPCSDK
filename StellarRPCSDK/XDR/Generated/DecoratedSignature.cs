// Generated code - do not modify
// Source:

// struct DecoratedSignature
// {
//     SignatureHint hint;  // last 4 bytes of the public key, used as a hint
//     Signature signature; // actual signature
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DecoratedSignature
    {
        public SignatureHint hint
        {
            get => _hint;
            set
            {
                _hint = value;
            }
        }
        private SignatureHint _hint;

        /// <summary>
        /// last 4 bytes of the public key, used as a hint
        /// </summary>
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        private Signature _signature;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DecoratedSignature value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DecoratedSignatureXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
