// Generated code - do not modify
// Source:

// struct ClaimLiquidityAtom
// {
//     PoolID liquidityPoolID;
// 
//     // amount and asset taken from the pool
//     Asset assetSold;
//     int64 amountSold;
// 
//     // amount and asset sent to the pool
//     Asset assetBought;
//     int64 amountBought;
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
    public partial class ClaimLiquidityAtom
    {
        [ProtoMember(1)]
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

        /// <summary>
        /// amount and asset taken from the pool
        /// </summary>
        [ProtoMember(2)]
        public Asset assetSold
        {
            get => _assetSold;
            set
            {
                _assetSold = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset Sold")]
        #endif
        private Asset _assetSold;

        [ProtoMember(3)]
        public int64 amountSold
        {
            get => _amountSold;
            set
            {
                _amountSold = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Amount Sold")]
        #endif
        private int64 _amountSold;

        /// <summary>
        /// amount and asset sent to the pool
        /// </summary>
        [ProtoMember(4)]
        public Asset assetBought
        {
            get => _assetBought;
            set
            {
                _assetBought = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset Bought")]
        #endif
        private Asset _assetBought;

        [ProtoMember(5)]
        public int64 amountBought
        {
            get => _amountBought;
            set
            {
                _amountBought = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Amount Bought")]
        #endif
        private int64 _amountBought;

        public ClaimLiquidityAtom()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClaimLiquidityAtomXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimLiquidityAtom value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimLiquidityAtomXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ClaimLiquidityAtom DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClaimLiquidityAtomXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimLiquidityAtom value)
        {
            value.Validate();
            PoolIDXdr.Encode(stream, value.liquidityPoolID);
            AssetXdr.Encode(stream, value.assetSold);
            int64Xdr.Encode(stream, value.amountSold);
            AssetXdr.Encode(stream, value.assetBought);
            int64Xdr.Encode(stream, value.amountBought);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimLiquidityAtom Decode(XdrReader stream)
        {
            var result = new ClaimLiquidityAtom();
            result.liquidityPoolID = PoolIDXdr.Decode(stream);
            result.assetSold = AssetXdr.Decode(stream);
            result.amountSold = int64Xdr.Decode(stream);
            result.assetBought = AssetXdr.Decode(stream);
            result.amountBought = int64Xdr.Decode(stream);
            return result;
        }
    }
}
