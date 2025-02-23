// Generated code - do not modify
// Source:

// union TrustLineAsset switch (AssetType type)
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
//     PoolID liquidityPoolID;
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
    public abstract partial class TrustLineAsset
    {
        public abstract AssetType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "TrustLineAsset_AssetTypeNative")]
        public sealed partial class AssetTypeNative : TrustLineAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_NATIVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "TrustLineAsset_AssetTypeCreditAlphanum4")]
        public sealed partial class AssetTypeCreditAlphanum4 : TrustLineAsset
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
        [ProtoContract(Name = "TrustLineAsset_AssetTypeCreditAlphanum12")]
        public sealed partial class AssetTypeCreditAlphanum12 : TrustLineAsset
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
        [ProtoContract(Name = "TrustLineAsset_AssetTypePoolShare")]
        public sealed partial class AssetTypePoolShare : TrustLineAsset
        {
            public override AssetType Discriminator => AssetType.ASSET_TYPE_POOL_SHARE;
            [ProtoMember(3)]
            public PoolID liquidityPoolID
            {
                get => _liquidityPoolID;
                set
                {
                    _liquidityPoolID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Liquidity Pool I D")]
            #endif
            private PoolID _liquidityPoolID;

            public override void ValidateCase() {}
        }
    }
    public static partial class TrustLineAssetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TrustLineAsset value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TrustLineAssetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TrustLineAsset DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TrustLineAssetXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, TrustLineAsset value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TrustLineAsset.AssetTypeNative case_ASSET_TYPE_NATIVE:
                break;
                case TrustLineAsset.AssetTypeCreditAlphanum4 case_ASSET_TYPE_CREDIT_ALPHANUM4:
                AlphaNum4Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4);
                break;
                case TrustLineAsset.AssetTypeCreditAlphanum12 case_ASSET_TYPE_CREDIT_ALPHANUM12:
                AlphaNum12Xdr.Encode(stream, case_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12);
                break;
                case TrustLineAsset.AssetTypePoolShare case_ASSET_TYPE_POOL_SHARE:
                PoolIDXdr.Encode(stream, case_ASSET_TYPE_POOL_SHARE.liquidityPoolID);
                break;
            }
        }
        public static TrustLineAsset Decode(XdrReader stream)
        {
            var discriminator = (AssetType)stream.ReadInt();
            switch (discriminator)
            {
                case AssetType.ASSET_TYPE_NATIVE:
                var result_ASSET_TYPE_NATIVE = new TrustLineAsset.AssetTypeNative();
                return result_ASSET_TYPE_NATIVE;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM4:
                var result_ASSET_TYPE_CREDIT_ALPHANUM4 = new TrustLineAsset.AssetTypeCreditAlphanum4();
                result_ASSET_TYPE_CREDIT_ALPHANUM4.alphaNum4 = AlphaNum4Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM4;
                case AssetType.ASSET_TYPE_CREDIT_ALPHANUM12:
                var result_ASSET_TYPE_CREDIT_ALPHANUM12 = new TrustLineAsset.AssetTypeCreditAlphanum12();
                result_ASSET_TYPE_CREDIT_ALPHANUM12.alphaNum12 = AlphaNum12Xdr.Decode(stream);
                return result_ASSET_TYPE_CREDIT_ALPHANUM12;
                case AssetType.ASSET_TYPE_POOL_SHARE:
                var result_ASSET_TYPE_POOL_SHARE = new TrustLineAsset.AssetTypePoolShare();
                result_ASSET_TYPE_POOL_SHARE.liquidityPoolID = PoolIDXdr.Decode(stream);
                return result_ASSET_TYPE_POOL_SHARE;
                default:
                throw new Exception($"Unknown discriminator for TrustLineAsset: {discriminator}");
            }
        }
    }
}
