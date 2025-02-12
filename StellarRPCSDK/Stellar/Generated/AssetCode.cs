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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class AssetCode
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class AssetTypeCreditAlphanum4 : AssetCode
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM4;
            public AssetCode4 assetCode4
            {
                get => _assetCode4;
                set
                {
                    _assetCode4 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Asset Code4")]
            #endif
            private AssetCode4 _assetCode4;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class AssetTypeCreditAlphanum12 : AssetCode
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM12;
            public AssetCode12 assetCode12
            {
                get => _assetCode12;
                set
                {
                    _assetCode12 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Asset Code12")]
            #endif
            private AssetCode12 _assetCode12;

            public override void ValidateCase() {}
        }
    }
    public static partial class AssetCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AssetCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, AssetCode value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AssetCode.AssetTypeCreditAlphanum4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AssetCode4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.assetCode4);
                break;
                case AssetCode.AssetTypeCreditAlphanum12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
                AssetCode12Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM12.assetCode12);
                break;
            }
        }
        public static AssetCode Decode(XdrReader stream)
        {
            var discriminator = (AssetType)stream.ReadInt();
            switch (discriminator)
            {
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new AssetCode.AssetTypeCreditAlphanum4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.assetCode4 = AssetCode4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new AssetCode.AssetTypeCreditAlphanum12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.assetCode12 = AssetCode12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                default:
                throw new Exception($"Unknown discriminator for AssetCode: {discriminator}");
            }
        }
    }
}
