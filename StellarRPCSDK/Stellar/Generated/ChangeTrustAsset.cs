// Generated code - do not modify
// Source:

// union ChangeTrustAsset switch (AssetType type)
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
// case ASSET_TYPE_POOL_SHARE:
//     LiquidityPoolParameters liquidityPool;
// 
//     // add other asset types here in the future
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(AssetTypeNative), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(AssetTypeCreditAlphanum4), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(AssetTypeCreditAlphanum12), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(AssetTypePoolShare), DataFormat = DataFormat.Default)]
    public abstract partial class ChangeTrustAsset
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustAsset.AssetTypeNative")]
        public sealed partial class AssetTypeNative : ChangeTrustAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_NATIVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustAsset.AssetTypeCreditAlphanum4")]
        public sealed partial class AssetTypeCreditAlphanum4 : ChangeTrustAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM4;
            [ProtoMember(1)]
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
        [ProtoContract(Name = "ChangeTrustAsset.AssetTypeCreditAlphanum12")]
        public sealed partial class AssetTypeCreditAlphanum12 : ChangeTrustAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_CREDIT_ALPHANUM12;
            [ProtoMember(2)]
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
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustAsset.AssetTypePoolShare")]
        public sealed partial class AssetTypePoolShare : ChangeTrustAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_POOL_SHARE;
            [ProtoMember(3)]
            public LiquidityPoolParameters liquidityPool
            {
                get => _liquidityPool;
                set
                {
                    _liquidityPool = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Liquidity Pool")]
            #endif
            private LiquidityPoolParameters _liquidityPool;

            public override void ValidateCase() {}
        }
    }
    public static partial class ChangeTrustAssetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ChangeTrustAsset value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ChangeTrustAssetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ChangeTrustAsset DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ChangeTrustAssetXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ChangeTrustAsset value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ChangeTrustAsset.AssetTypeNative case_ASSET_TYPE_NATIVE:
                break;
                case ChangeTrustAsset.AssetTypeCreditAlphanum4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AlphaNum4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4);
                break;
                case ChangeTrustAsset.AssetTypeCreditAlphanum12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
                AlphaNum12Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12);
                break;
                case ChangeTrustAsset.AssetTypePoolShare case_ASSET_TYPE_POOL_SHARE:
                LiquidityPoolParametersXdr.Encode(stream, case_ASSET_TYPE_POOL_SHARE.liquidityPool);
                break;
            }
        }
        public static ChangeTrustAsset Decode(XdrReader stream)
        {
            var discriminator = (AssetType)stream.ReadInt();
            switch (discriminator)
            {
                case AssetType.ASSET_TYPE_NATIVE:
                var result_ASSET_TYPE_NATIVE = new ChangeTrustAsset.AssetTypeNative();
                return result_ASSET_TYPE_NATIVE;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new ChangeTrustAsset.AssetTypeCreditAlphanum4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4 = AlphaNum4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new ChangeTrustAsset.AssetTypeCreditAlphanum12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12 = AlphaNum12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                case AssetType.ASSET_TYPE_POOL_SHARE:
                var result_ASSET_TYPE_POOL_SHARE = new ChangeTrustAsset.AssetTypePoolShare();
                result_ASSET_TYPE_POOL_SHARE.liquidityPool = LiquidityPoolParametersXdr.Decode(stream);
                return result_ASSET_TYPE_POOL_SHARE;
                default:
                throw new Exception($"Unknown discriminator for ChangeTrustAsset: {discriminator}");
            }
        }
    }
}
