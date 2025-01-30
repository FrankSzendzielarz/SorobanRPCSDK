// Generated code - do not modify
// Source:

// struct AlphaNum4
// {
//     AssetCode4 assetCode;
//     AccountID issuer;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AlphaNum4
    {
        private AssetCode4 _assetCode;
        public AssetCode4 assetCode
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

        public AlphaNum4()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AlphaNum4Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AlphaNum4 value)
        {
            value.Validate();
            AssetCode4Xdr.Encode(stream, value.assetCode);
            AccountIDXdr.Encode(stream, value.issuer);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AlphaNum4 Decode(XdrReader stream)
        {
            var result = new AlphaNum4();
            result.assetCode = AssetCode4Xdr.Decode(stream);
            result.issuer = AccountIDXdr.Decode(stream);
            return result;
        }
    }
}
