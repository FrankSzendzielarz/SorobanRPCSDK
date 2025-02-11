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
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ClaimLiquidityAtom
    {
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
        	[InspectorName(@"Liquidity Pool I D")]
        #endif
        private PoolID _liquidityPoolID;

        /// <summary>
        /// amount and asset taken from the pool
        /// </summary>
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
        	[InspectorName(@"Asset Sold")]
        #endif
        private Asset _assetSold;

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
        	[InspectorName(@"Amount Sold")]
        #endif
        private int64 _amountSold;

        /// <summary>
        /// amount and asset sent to the pool
        /// </summary>
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
        	[InspectorName(@"Asset Bought")]
        #endif
        private Asset _assetBought;

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
