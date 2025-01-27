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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class FeeBumpTransaction
    {
        private MuxedAccount _feeSource;
        public MuxedAccount feeSource
        {
            get => _feeSource;
            set
            {
                _feeSource = value;
            }
        }

        private int64 _fee;
        public int64 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }

        private object _innerTx;
        public object innerTx
        {
            get => _innerTx;
            set
            {
                _innerTx = value;
            }
        }

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public FeeBumpTransaction()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class FeeBumpTransactionXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FeeBumpTransaction value)
        {
            value.Validate();
            MuxedAccountXdr.Encode(stream, value.feeSource);
            int64Xdr.Encode(stream, value.fee);
            Xdr.Encode(stream, value.innerTx);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FeeBumpTransaction Decode(XdrReader stream)
        {
            var result = new FeeBumpTransaction();
            result.feeSource = MuxedAccountXdr.Decode(stream);
            result.fee = int64Xdr.Decode(stream);
            result.innerTx = Xdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
