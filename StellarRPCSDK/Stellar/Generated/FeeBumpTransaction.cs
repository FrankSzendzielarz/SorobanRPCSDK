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

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class FeeBumpTransaction
    {
        public MuxedAccount feeSource
        {
            get => _feeSource;
            set
            {
                _feeSource = value;
            }
        }
        private MuxedAccount _feeSource;

        public int64 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }
        private int64 _fee;

        public innerTxUnion innerTx
        {
            get => _innerTx;
            set
            {
                _innerTx = value;
            }
        }
        private innerTxUnion _innerTx;

        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private extUnion _ext;

        public FeeBumpTransaction()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class innerTxUnion
        {
            public abstract EnvelopeType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class EnvelopeTypeTx : innerTxUnion
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
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

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
