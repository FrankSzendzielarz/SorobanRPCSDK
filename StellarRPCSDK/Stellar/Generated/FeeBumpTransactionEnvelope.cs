// Generated code - do not modify
// Source:

// struct FeeBumpTransactionEnvelope
// {
//     FeeBumpTransaction tx;
//     /* Each decorated signature is a signature over the SHA256 hash of
//      * a TransactionSignaturePayload */
//     DecoratedSignature signatures<20>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class FeeBumpTransactionEnvelope
    {
        public FeeBumpTransaction tx
        {
            get => _tx;
            set
            {
                _tx = value;
            }
        }
        private FeeBumpTransaction _tx;

        [MaxLength(20)]
        public DecoratedSignature[] signatures
        {
            get => _signatures;
            set
            {
                if (value.Length > 20)
                	throw new ArgumentException($"Cannot exceed 20 in length");
                _signatures = value;
            }
        }
        private DecoratedSignature[] _signatures;

        public FeeBumpTransactionEnvelope()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (signatures.Length > 20)
            	throw new InvalidOperationException($"signatures cannot exceed 20 elements");
        }
    }
    public static partial class FeeBumpTransactionEnvelopeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(FeeBumpTransactionEnvelope value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                FeeBumpTransactionEnvelopeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FeeBumpTransactionEnvelope value)
        {
            value.Validate();
            FeeBumpTransactionXdr.Encode(stream, value.tx);
            stream.WriteInt(value.signatures.Length);
            foreach (var item in value.signatures)
            {
                    DecoratedSignatureXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FeeBumpTransactionEnvelope Decode(XdrReader stream)
        {
            var result = new FeeBumpTransactionEnvelope();
            result.tx = FeeBumpTransactionXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.signatures = new DecoratedSignature[length];
                for (var i = 0; i < length; i++)
                {
                    result.signatures[i] = DecoratedSignatureXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
