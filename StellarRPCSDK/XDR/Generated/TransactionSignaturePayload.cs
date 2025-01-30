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

namespace Stellar.XDR {

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

        private taggedTransactionUnion _taggedTransaction;
        public taggedTransactionUnion taggedTransaction
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
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class taggedTransactionUnion
        {
            public abstract EnvelopeType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class taggedTransactionUnion_ENVELOPE_TYPE_TX : taggedTransactionUnion
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX;
            private Transaction _tx;
            public Transaction tx
            {
                get => _tx;
                set
                {
                    _tx = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class taggedTransactionUnion_ENVELOPE_TYPE_TX_FEE_BUMP : taggedTransactionUnion
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP;
            private FeeBumpTransaction _feeBump;
            public FeeBumpTransaction feeBump
            {
                get => _feeBump;
                set
                {
                    _feeBump = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class taggedTransactionUnionXdr
        {
            public static void Encode(XdrWriter stream, taggedTransactionUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case taggedTransactionUnion_ENVELOPE_TYPE_TX case_ENVELOPE_TYPE_TX:
                    TransactionXdr.Encode(stream, case_ENVELOPE_TYPE_TX.tx);
                    break;
                    case taggedTransactionUnion_ENVELOPE_TYPE_TX_FEE_BUMP case_ENVELOPE_TYPE_TX_FEE_BUMP:
                    FeeBumpTransactionXdr.Encode(stream, case_ENVELOPE_TYPE_TX_FEE_BUMP.feeBump);
                    break;
                }
            }
            public static taggedTransactionUnion Decode(XdrReader stream)
            {
                var discriminator = (EnvelopeType)stream.ReadInt();
                switch (discriminator)
                {
                    case EnvelopeType.ENVELOPE_TYPE_TX:
                    var result_ENVELOPE_TYPE_TX = new taggedTransactionUnion_ENVELOPE_TYPE_TX();
                    result_ENVELOPE_TYPE_TX.tx = TransactionXdr.Decode(stream);
                    return result_ENVELOPE_TYPE_TX;
                    case EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP:
                    var result_ENVELOPE_TYPE_TX_FEE_BUMP = new taggedTransactionUnion_ENVELOPE_TYPE_TX_FEE_BUMP();
                    result_ENVELOPE_TYPE_TX_FEE_BUMP.feeBump = FeeBumpTransactionXdr.Decode(stream);
                    return result_ENVELOPE_TYPE_TX_FEE_BUMP;
                    default:
                    throw new Exception($"Unknown discriminator for taggedTransactionUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionSignaturePayloadXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionSignaturePayload value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.networkId);
            TransactionSignaturePayload.taggedTransactionUnionXdr.Encode(stream, value.taggedTransaction);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionSignaturePayload Decode(XdrReader stream)
        {
            var result = new TransactionSignaturePayload();
            result.networkId = HashXdr.Decode(stream);
            result.taggedTransaction = TransactionSignaturePayload.taggedTransactionUnionXdr.Decode(stream);
            return result;
        }
    }
}
