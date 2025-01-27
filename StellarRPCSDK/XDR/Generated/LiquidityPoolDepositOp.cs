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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LiquidityPoolDepositOp
    {
        private PoolID _liquidityPoolID;
        public PoolID liquidityPoolID
        {
            get => _liquidityPoolID;
            set
            {
                _liquidityPoolID = value;
            }
        }

        private int64 _maxAmountA;
        public int64 maxAmountA
        {
            get => _maxAmountA;
            set
            {
                _maxAmountA = value;
            }
        }

        private int64 _maxAmountB;
        public int64 maxAmountB
        {
            get => _maxAmountB;
            set
            {
                _maxAmountB = value;
            }
        }

        private Price _minPrice;
        public Price minPrice
        {
            get => _minPrice;
            set
            {
                _minPrice = value;
            }
        }

        private Price _maxPrice;
        public Price maxPrice
        {
            get => _maxPrice;
            set
            {
                _maxPrice = value;
            }
        }

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
