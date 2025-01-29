// Generated code - do not modify
// Source:

// struct TransactionV0Envelope
// {
//     TransactionV0 tx;
//     /* Each decorated signature is a signature over the SHA256 hash of
//      * a TransactionSignaturePayload */
//     DecoratedSignature signatures<20>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionV0Envelope
    {
        private TransactionV0 _tx;
        public TransactionV0 tx
        {
            get => _tx;
            set
            {
                _tx = value;
            }
        }

        private DecoratedSignature[] _signatures;
        public DecoratedSignature[] signatures
        {
            get => _signatures;
            set
            {
                if (value.Length > 20)
                	throw new ArgumentException($"Cannot exceed 20 bytes");
                _signatures = value;
            }
        }

        public TransactionV0Envelope()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (signatures.Length > 20)
            	throw new InvalidOperationException($"signatures cannot exceed 20 elements");
        }
    }
    public static partial class TransactionV0EnvelopeXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionV0Envelope value)
        {
            value.Validate();
            TransactionV0Xdr.Encode(stream, value.tx);
            stream.WriteInt(value.signatures.Length);
            foreach (var item in value.signatures)
            {
                    DecoratedSignatureXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionV0Envelope Decode(XdrReader stream)
        {
            var result = new TransactionV0Envelope();
            result.tx = TransactionV0Xdr.Decode(stream);
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
