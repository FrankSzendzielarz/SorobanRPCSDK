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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TransactionSignaturePayload
    {
        [ProtoMember(1)]
        public Hash networkId
        {
            get => _networkId;
            set
            {
                _networkId = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Network Id")]
        #endif
        private Hash _networkId;

        [ProtoMember(2)]
        public taggedTransactionUnion taggedTransaction
        {
            get => _taggedTransaction;
            set
            {
                _taggedTransaction = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tagged Transaction")]
        #endif
        private taggedTransactionUnion _taggedTransaction;

        public TransactionSignaturePayload()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "TransactionSignaturePayload_taggedTransactionUnion")]
        [ProtoInclude(100, typeof(EnvelopeTypeTx), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(EnvelopeTypeTxFeeBump), DataFormat = DataFormat.Default)]
        public abstract partial class taggedTransactionUnion
        {
            public abstract EnvelopeType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            /// <summary>
            /// Backwards Compatibility: Use ENVELOPE_TYPE_TX to sign ENVELOPE_TYPE_TX_V0
            /// </summary>
            [System.Serializable]
            [ProtoContract(Name = "TransactionSignaturePayload_taggedTransactionUnion_EnvelopeTypeTx")]
            public sealed partial class EnvelopeTypeTx : taggedTransactionUnion
            {
                public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX;
                [ProtoMember(1)]
                public Transaction tx
                {
                    get => _tx;
                    set
                    {
                        _tx = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Tx")]
                #endif
                private Transaction _tx;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "TransactionSignaturePayload_taggedTransactionUnion_EnvelopeTypeTxFeeBump")]
            public sealed partial class EnvelopeTypeTxFeeBump : taggedTransactionUnion
            {
                public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP;
                [ProtoMember(2)]
                public FeeBumpTransaction feeBump
                {
                    get => _feeBump;
                    set
                    {
                        _feeBump = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Fee Bump")]
                #endif
                private FeeBumpTransaction _feeBump;

                public override void ValidateCase() {}
            }
        }
        public static partial class taggedTransactionUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(taggedTransactionUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    taggedTransactionUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static taggedTransactionUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return taggedTransactionUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, taggedTransactionUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case taggedTransactionUnion.EnvelopeTypeTx case_ENVELOPE_TYPE_TX:
                    TransactionXdr.Encode(stream, case_ENVELOPE_TYPE_TX.tx);
                    break;
                    case taggedTransactionUnion.EnvelopeTypeTxFeeBump case_ENVELOPE_TYPE_TX_FEE_BUMP:
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
                    var result_ENVELOPE_TYPE_TX = new taggedTransactionUnion.EnvelopeTypeTx();
                    result_ENVELOPE_TYPE_TX.tx = TransactionXdr.Decode(stream);
                    return result_ENVELOPE_TYPE_TX;
                    case EnvelopeType.ENVELOPE_TYPE_TX_FEE_BUMP:
                    var result_ENVELOPE_TYPE_TX_FEE_BUMP = new taggedTransactionUnion.EnvelopeTypeTxFeeBump();
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionSignaturePayload value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionSignaturePayloadXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionSignaturePayload DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionSignaturePayloadXdr.Decode(reader);
            }
        }
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
