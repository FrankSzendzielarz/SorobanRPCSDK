// Generated code - do not modify
// Source:

// struct FeeBumpTransaction
// {
//     MuxedAccount feeSource;
//     int64 fee;
//     union switch (EnvelopeType type)
//     {
//     case ENVELOPE_TYPE_TX:
//         TransactionV1Envelope v1;
//     }
//     innerTx;
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
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
    public partial class FeeBumpTransaction
    {
        [ProtoMember(1)]
        public MuxedAccount feeSource
        {
            get => _feeSource;
            set
            {
                _feeSource = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Source")]
        #endif
        private MuxedAccount _feeSource;

        [ProtoMember(2)]
        public int64 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee")]
        #endif
        private int64 _fee;

        [ProtoMember(3)]
        public innerTxUnion innerTx
        {
            get => _innerTx;
            set
            {
                _innerTx = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Tx")]
        #endif
        private innerTxUnion _innerTx;

        [ProtoMember(4)]
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public FeeBumpTransaction()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "FeeBumpTransaction.innerTxUnion")]
        [ProtoInclude(100, typeof(EnvelopeTypeTx), DataFormat = DataFormat.Default)]
        public abstract partial class innerTxUnion
        {
            public abstract EnvelopeType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx")]
            public sealed partial class EnvelopeTypeTx : innerTxUnion
            {
                public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_TX;
                [ProtoMember(1)]
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
                	[SerializeReference]
                	[InspectorName(@"V1")]
                #endif
                private TransactionV1Envelope _v1;

                public override void ValidateCase() {}
            }
        }
        public static partial class innerTxUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(innerTxUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    innerTxUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static innerTxUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return innerTxUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, innerTxUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case innerTxUnion.EnvelopeTypeTx case_ENVELOPE_TYPE_TX:
                    TransactionV1EnvelopeXdr.Encode(stream, case_ENVELOPE_TYPE_TX.v1);
                    break;
                }
            }
            public static innerTxUnion Decode(XdrReader stream)
            {
                var discriminator = (EnvelopeType)stream.ReadInt();
                switch (discriminator)
                {
                    case EnvelopeType.ENVELOPE_TYPE_TX:
                    var result_ENVELOPE_TYPE_TX = new innerTxUnion.EnvelopeTypeTx();
                    result_ENVELOPE_TYPE_TX.v1 = TransactionV1EnvelopeXdr.Decode(stream);
                    return result_ENVELOPE_TYPE_TX;
                    default:
                    throw new Exception($"Unknown discriminator for innerTxUnion: {discriminator}");
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "FeeBumpTransaction.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "FeeBumpTransaction.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class FeeBumpTransactionXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(FeeBumpTransaction value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                FeeBumpTransactionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static FeeBumpTransaction DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return FeeBumpTransactionXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FeeBumpTransaction value)
        {
            value.Validate();
            MuxedAccountXdr.Encode(stream, value.feeSource);
            int64Xdr.Encode(stream, value.fee);
            FeeBumpTransaction.innerTxUnionXdr.Encode(stream, value.innerTx);
            FeeBumpTransaction.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FeeBumpTransaction Decode(XdrReader stream)
        {
            var result = new FeeBumpTransaction();
            result.feeSource = MuxedAccountXdr.Decode(stream);
            result.fee = int64Xdr.Decode(stream);
            result.innerTx = FeeBumpTransaction.innerTxUnionXdr.Decode(stream);
            result.ext = FeeBumpTransaction.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
