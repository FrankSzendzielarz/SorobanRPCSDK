// Generated code - do not modify
// Source:

// struct ClawbackOp
// {
//     Asset asset;
//     MuxedAccount from;
//     int64 amount;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClawbackOp
    {
        private Asset _asset;
        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }

        private MuxedAccount _from;
        public MuxedAccount from
        {
            get => _from;
            set
            {
                _from = value;
            }
        }

        private int64 _amount;
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }

        public ClawbackOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClawbackOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClawbackOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.asset);
            MuxedAccountXdr.Encode(stream, value.from);
            int64Xdr.Encode(stream, value.amount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClawbackOp Decode(XdrReader stream)
        {
            var result = new ClawbackOp();
            result.asset = AssetXdr.Decode(stream);
            result.from = MuxedAccountXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            return result;
        }
    }
}
