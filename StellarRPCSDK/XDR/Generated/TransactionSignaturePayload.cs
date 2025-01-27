// Generated code - do not modify
// Source:

// struct TransactionSignaturePayload
// {
//     Hash networkId;
//     union switch (EnvelopeType type)
//     {
//     // Backwards Compatibility: Use ENVELOPE_TYPE_TX to sign ENVELOPE_TYPE_TX_V0
//     case ENVELOPE_TYPE_TX:
//         Transaction tx;
//     case ENVELOPE_TYPE_TX_FEE_BUMP:
//         FeeBumpTransaction feeBump;
//     }
//     taggedTransaction;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionSignaturePayload
    {
        private Hash _networkId;
        public Hash networkId
        {
            get => _networkId;
            set
            {
                _networkId = value;
            }
        }

        private object _taggedTransaction;
        public object taggedTransaction
        {
            get => _taggedTransaction;
            set
            {
                _taggedTransaction = value;
            }
        }

        public TransactionSignaturePayload()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionSignaturePayloadXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionSignaturePayload value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.networkId);
            Xdr.Encode(stream, value.taggedTransaction);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionSignaturePayload Decode(XdrReader stream)
        {
            var result = new TransactionSignaturePayload();
            result.networkId = HashXdr.Decode(stream);
            result.taggedTransaction = Xdr.Decode(stream);
            return result;
        }
    }
}
