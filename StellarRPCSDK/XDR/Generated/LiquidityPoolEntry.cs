// Generated code - do not modify
// Source:

// struct LiquidityPoolEntry
// {
//     PoolID liquidityPoolID;
// 
//     union switch (LiquidityPoolType type)
//     {
//     case LIQUIDITY_POOL_CONSTANT_PRODUCT:
//         struct
//         {
//             LiquidityPoolConstantProductParameters params;
// 
//             int64 reserveA;        // amount of A in the pool
//             int64 reserveB;        // amount of B in the pool
//             int64 totalPoolShares; // total number of pool shares issued
//             int64 poolSharesTrustLineCount; // number of trust lines for the
//                                             // associated pool shares
//         } constantProduct;
//     }
//     body;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LiquidityPoolEntry
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

        private object _body;
        public object body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }

        public LiquidityPoolEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LiquidityPoolEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolEntry value)
        {
            value.Validate();
            PoolIDXdr.Encode(stream, value.liquidityPoolID);
            Xdr.Encode(stream, value.body);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LiquidityPoolEntry Decode(XdrReader stream)
        {
            var result = new LiquidityPoolEntry();
            result.liquidityPoolID = PoolIDXdr.Decode(stream);
            result.body = Xdr.Decode(stream);
            return result;
        }
    }
}
