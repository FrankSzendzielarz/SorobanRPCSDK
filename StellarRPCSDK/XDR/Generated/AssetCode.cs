// Generated code - do not modify
// Source:

// union AssetCode switch (AssetType type)
// {
// case ASSET_TYPE_CREDIT_ALPHANUM4:
//     AssetCode4 assetCode4;
// 
// case ASSET_TYPE_CREDIT_ALPHANUM12:
//     AssetCode12 assetCode12;
// 
//     // add other asset types here in the future
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class AssetCode
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class AssetCode_ASSET_TYPE_CREDIT_ALPHANUM4 : AssetCode
    {
        public override AssetType Discriminator => ASSET_TYPE_CREDIT_ALPHANUM4;
        private AssetCode4 _assetCode4;
        public AssetCode4 assetCode4
        {
            get => _assetCode4;
            set
            {
                _assetCode4 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class AssetCode_ASSET_TYPE_CREDIT_ALPHANUM12 : AssetCode
    {
        public override AssetType Discriminator => ASSET_TYPE_CREDIT_ALPHANUM12;
        private AssetCode12 _assetCode12;
        public AssetCode12 assetCode12
        {
            get => _assetCode12;
            set
            {
                _assetCode12 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class AssetCodeXdr
    {
        public static void Encode(XdrWriter stream, AssetCode value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AssetCode_ASSET_TYPE_CREDIT_ALPHANUM4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AssetCode4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.assetCode4);
                break;
                case AssetCode_ASSET_TYPE_CREDIT_ALPHANUM12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
                AssetCode12Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM12.assetCode12);
                break;
            }
        }
        public static AssetCode Decode(XdrReader stream)
        {
            var discriminator = (AssetType)stream.ReadInt();
            switch (discriminator)
            {
                case ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new AssetCode_ASSET_TYPE_CREDIT_ALPHANUM4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.                 = AssetCode4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new AssetCode_ASSET_TYPE_CREDIT_ALPHANUM12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.                 = AssetCode12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                default:
                throw new Exception($"Unknown discriminator for AssetCode: {discriminator}");
            }
        }
    }
}
