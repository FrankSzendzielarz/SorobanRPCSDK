// Generated code - do not modify
// Source:

// struct LiquidityPoolDepositOp
// {
//     PoolID liquidityPoolID;
//     int64 maxAmountA; // maximum amount of first asset to deposit
//     int64 maxAmountB; // maximum amount of second asset to deposit
//     Price minPrice;   // minimum depositA/depositB
//     Price maxPrice;   // maximum depositA/depositB
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
    public partial class LiquidityPoolDepositOp
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

        public int64 maxAmountA
        {
            get => _maxAmountA;
            set
            {
                _maxAmountA = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Max Amount A")]
        #endif
        private int64 _maxAmountA;

        /// <summary>
        /// maximum amount of first asset to deposit
        /// </summary>
        public int64 maxAmountB
        {
            get => _maxAmountB;
            set
            {
                _maxAmountB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Max Amount B")]
        #endif
        private int64 _maxAmountB;

        /// <summary>
        /// maximum amount of second asset to deposit
        /// </summary>
        public Price minPrice
        {
            get => _minPrice;
            set
            {
                _minPrice = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Min Price")]
        #endif
        private Price _minPrice;

        /// <summary>
        /// minimum depositA/depositB
        /// </summary>
        public Price maxPrice
        {
            get => _maxPrice;
            set
            {
                _maxPrice = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Max Price")]
        #endif
        private Price _maxPrice;

        public LiquidityPoolDepositOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LiquidityPoolDepositOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolDepositOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolDepositOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolDepositOp value)
        {
            value.Validate();
            PoolIDXdr.Encode(stream, value.liquidityPoolID);
            int64Xdr.Encode(stream, value.maxAmountA);
            int64Xdr.Encode(stream, value.maxAmountB);
            PriceXdr.Encode(stream, value.minPrice);
            PriceXdr.Encode(stream, value.maxPrice);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LiquidityPoolDepositOp Decode(XdrReader stream)
        {
            var result = new LiquidityPoolDepositOp();
            result.liquidityPoolID = PoolIDXdr.Decode(stream);
            result.maxAmountA = int64Xdr.Decode(stream);
            result.maxAmountB = int64Xdr.Decode(stream);
            result.minPrice = PriceXdr.Decode(stream);
            result.maxPrice = PriceXdr.Decode(stream);
            return result;
        }
    }
}
