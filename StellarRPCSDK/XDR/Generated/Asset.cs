// Generated code - do not modify
// Source:

// union Asset switch (AssetType type)
// {
// case ASSET_TYPE_NATIVE: // Not credit
//     void;
// 
// case ASSET_TYPE_CREDIT_ALPHANUM4:
//     AlphaNum4 alphaNum4;
// 
// case ASSET_TYPE_CREDIT_ALPHANUM12:
//     AlphaNum12 alphaNum12;
// 
//     // add other asset types here in the future
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class Asset
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class Asset_ASSET_TYPE_NATIVE : Asset
    {
        public override AssetType Discriminator => AssetType.ASSET_TYPE_NATIVE;

        public override void ValidateCase() {}
    }
    public sealed partial class Asset_ASSET_TYPE_CREDIT_ALPHANUM4 : Asset
    {
        public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM4;
        private AlphaNum4 _alphaNum4;
        public AlphaNum4 alphaNum4
        {
            get => _alphaNum4;
            set
            {
                _alphaNum4 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class Asset_ASSET_TYPE_CREDIT_ALPHANUM12 : Asset
    {
        public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM12;
        private AlphaNum12 _alphaNum12;
        public AlphaNum12 alphaNum12
        {
            get => _alphaNum12;
            set
            {
                _alphaNum12 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class AssetXdr
    {
        public static void Encode(XdrWriter stream, Asset value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Asset_ASSET_TYPE_NATIVE case_ASSET_TYPE_NATIVE:
                break;
                case Asset_ASSET_TYPE_CREDIT_ALPHANUM4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AlphaNum4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4);
                break;
                case Asset_ASSET_TYPE_CREDIT_ALPHANUM12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
                AlphaNum12Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12);
                break;
            }
        }
        public static Asset Decode(XdrReader stream)
        {
            var discriminator = (AssetType)stream.ReadInt();
            switch (discriminator)
            {
                case AssetType.ASSET_TYPE_NATIVE:
                var result_ASSET_TYPE_NATIVE = new Asset_ASSET_TYPE_NATIVE();
                return result_ASSET_TYPE_NATIVE;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new Asset_ASSET_TYPE_CREDIT_ALPHANUM4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4 = AlphaNum4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new Asset_ASSET_TYPE_CREDIT_ALPHANUM12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12 = AlphaNum12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                default:
                throw new Exception($"Unknown discriminator for Asset: {discriminator}");
            }
        }
    }
}
