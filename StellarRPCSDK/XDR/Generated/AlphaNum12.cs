// Generated code - do not modify
// Source:

// struct AlphaNum12
// {
//     AssetCode12 assetCode;
//     AccountID issuer;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AlphaNum12
    {
        private AssetCode12 _assetCode;
        public AssetCode12 assetCode
        {
            get => _assetCode;
            set
            {
                _assetCode = value;
            }
        }

        private AccountID _issuer;
        public AccountID issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
            }
        }

        public AlphaNum12()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AlphaNum12Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AlphaNum12 value)
        {
            value.Validate();
            AssetCode12Xdr.Encode(stream, value.assetCode);
            AccountIDXdr.Encode(stream, value.issuer);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AlphaNum12 Decode(XdrReader stream)
        {
            var result = new AlphaNum12();
            result.assetCode = AssetCode12Xdr.Decode(stream);
            result.issuer = AccountIDXdr.Decode(stream);
            return result;
        }
    }
}
