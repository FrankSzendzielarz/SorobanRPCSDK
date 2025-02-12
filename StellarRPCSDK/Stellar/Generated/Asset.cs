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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class Asset
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class AssetTypeNative : Asset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_NATIVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class AssetTypeCreditAlphanum4 : Asset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM4;
            public AlphaNum4 alphaNum4
            {
                get => _alphaNum4;
                set
                {
                    _alphaNum4 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Alpha Num4")]
            #endif
            private AlphaNum4 _alphaNum4;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class AssetTypeCreditAlphanum12 : Asset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM12;
            public AlphaNum12 alphaNum12
            {
                get => _alphaNum12;
                set
                {
                    _alphaNum12 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Alpha Num12")]
            #endif
            private AlphaNum12 _alphaNum12;

            public override void ValidateCase() {}
        }
    }
    public static partial class AssetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Asset value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Asset value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Asset.AssetTypeNative case_ASSET_TYPE_NATIVE:
                break;
                case Asset.AssetTypeCreditAlphanum4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AlphaNum4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4);
                break;
                case Asset.AssetTypeCreditAlphanum12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
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
                var result_ASSET_TYPE_NATIVE = new Asset.AssetTypeNative();
                return result_ASSET_TYPE_NATIVE;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new Asset.AssetTypeCreditAlphanum4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4 = AlphaNum4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new Asset.AssetTypeCreditAlphanum12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12 = AlphaNum12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                default:
                throw new Exception($"Unknown discriminator for Asset: {discriminator}");
            }
        }
    }
}
