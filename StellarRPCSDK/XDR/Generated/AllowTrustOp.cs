// Generated code - do not modify
// Source:

// struct AllowTrustOp
// {
//     AccountID trustor;
//     AssetCode asset;
// 
//     // One of 0, AUTHORIZED_FLAG, or AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG
//     uint32 authorize;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AllowTrustOp
    {
        private AccountID _trustor;
        public AccountID trustor
        {
            get => _trustor;
            set
            {
                _trustor = value;
            }
        }

        private AssetCode _asset;
        public AssetCode asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }

        private uint32 _authorize;
        public uint32 authorize
        {
            get => _authorize;
            set
            {
                _authorize = value;
            }
        }

        public AllowTrustOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AllowTrustOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AllowTrustOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.trustor);
            AssetCodeXdr.Encode(stream, value.asset);
            uint32Xdr.Encode(stream, value.authorize);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AllowTrustOp Decode(XdrReader stream)
        {
            var result = new AllowTrustOp();
            result.trustor = AccountIDXdr.Decode(stream);
            result.asset = AssetCodeXdr.Decode(stream);
            result.authorize = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
