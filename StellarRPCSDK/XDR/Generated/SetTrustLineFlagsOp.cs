// Generated code - do not modify
// Source:

// struct SetTrustLineFlagsOp
// {
//     AccountID trustor;
//     Asset asset;
// 
//     uint32 clearFlags; // which flags to clear
//     uint32 setFlags;   // which flags to set
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SetTrustLineFlagsOp
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

        private Asset _asset;
        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }

        private uint32 _clearFlags;
        public uint32 clearFlags
        {
            get => _clearFlags;
            set
            {
                _clearFlags = value;
            }
        }

        private uint32 _setFlags;
        public uint32 setFlags
        {
            get => _setFlags;
            set
            {
                _setFlags = value;
            }
        }

        public SetTrustLineFlagsOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SetTrustLineFlagsOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetTrustLineFlagsOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.trustor);
            AssetXdr.Encode(stream, value.asset);
            uint32Xdr.Encode(stream, value.clearFlags);
            uint32Xdr.Encode(stream, value.setFlags);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SetTrustLineFlagsOp Decode(XdrReader stream)
        {
            var result = new SetTrustLineFlagsOp();
            result.trustor = AccountIDXdr.Decode(stream);
            result.asset = AssetXdr.Decode(stream);
            result.clearFlags = uint32Xdr.Decode(stream);
            result.setFlags = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
