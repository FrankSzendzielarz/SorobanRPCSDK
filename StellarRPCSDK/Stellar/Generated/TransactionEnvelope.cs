// Generated code - do not modify
// Source:

// union TransactionEnvelope switch (EnvelopeType type)
// {
// case ENVELOPE_TYPE_TX_V0:
//     TransactionV0Envelope v0;
// case ENVELOPE_TYPE_TX:
//     TransactionV1Envelope v1;
// case ENVELOPE_TYPE_TX_FEE_BUMP:
//     FeeBumpTransactionEnvelope feeBump;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// A TransactionEnvelope wraps a transaction with signatures.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class TransactionEnvelope
    {
        public abstract EnvelopeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class EnvelopeTypeTxV0 : TransactionEnvelope
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX_V0;
            public TransactionV0Envelope v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"V0")]
            #endif
            private TransactionV0Envelope _v0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class EnvelopeTypeTx : TransactionEnvelope
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX;
            public TransactionV1Envelope v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"V1")]
            #endif
            private TransactionV1Envelope _v1;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class EnvelopeTypeTxFeeBump : TransactionEnvelope
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP;
            public FeeBumpTransactionEnvelope feeBump
            {
                get => _feeBump;
                set
                {
                    _feeBump = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Fee Bump")]
            #endif
            private FeeBumpTransactionEnvelope _feeBump;

            public override void ValidateCase() {}
        }
    }
    public static partial class TransactionEnvelopeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionEnvelope value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionEnvelopeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, TransactionEnvelope value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TransactionEnvelope.EnvelopeTypeTxV0 case_ENVELOPE_TYPE_TX_V0:
                TransactionV0EnvelopeXdr.Encode(stream, case_ENVELOPE_TYPE_TX_V0.v0);
                break;
                case TransactionEnvelope.EnvelopeTypeTx case_ENVELOPE_TYPE_TX:
                TransactionV1EnvelopeXdr.Encode(stream, case_ENVELOPE_TYPE_TX.v1);
                break;
                case TransactionEnvelope.EnvelopeTypeTxFeeBump case_ENVELOPE_TYPE_TX_FEE_BUMP:
                FeeBumpTransactionEnvelopeXdr.Encode(stream, case_ENVELOPE_TYPE_TX_FEE_BUMP.feeBump);
                break;
            }
        }
        public static TransactionEnvelope Decode(XdrReader stream)
        {
            var discriminator = (EnvelopeType)stream.ReadInt();
            switch (discriminator)
            {
                case EnvelopeType.ENVELOPE_TYPE_TX_V0:
                var result_ENVELOPE_TYPE_TX_V0 = new TransactionEnvelope.EnvelopeTypeTxV0();
                result_ENVELOPE_TYPE_TX_V0.v0 = TransactionV0EnvelopeXdr.Decode(stream);
                return result_ENVELOPE_TYPE_TX_V0;
                case EnvelopeType.ENVELOPE_TYPE_TX:
                var result_ENVELOPE_TYPE_TX = new TransactionEnvelope.EnvelopeTypeTx();
                result_ENVELOPE_TYPE_TX.v1 = TransactionV1EnvelopeXdr.Decode(stream);
                return result_ENVELOPE_TYPE_TX;
                case EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP:
                var result_ENVELOPE_TYPE_TX_FEE_BUMP = new TransactionEnvelope.EnvelopeTypeTxFeeBump();
                result_ENVELOPE_TYPE_TX_FEE_BUMP.feeBump = FeeBumpTransactionEnvelopeXdr.Decode(stream);
                return result_ENVELOPE_TYPE_TX_FEE_BUMP;
                default:
                throw new Exception($"Unknown discriminator for TransactionEnvelope: {discriminator}");
            }
        }
    }
}
