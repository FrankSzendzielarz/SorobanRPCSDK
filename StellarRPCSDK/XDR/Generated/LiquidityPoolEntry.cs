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
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class bodyUnion
        {
            public abstract LiquidityPoolType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();
        }
        public sealed partial class bodyUnion_LIQUIDITY_POOL_CONSTANT_PRODUCT : bodyUnion
        {
            public override LiquidityPoolType Discriminator => LiquidityPoolType.LIQUIDITY_POOL_CONSTANT_PRODUCT;
            private object _constantProduct;
            public object constantProduct
            {
                get => _constantProduct;
                set
                {
                    _constantProduct = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class bodyUnionXdr
        {
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion_LIQUIDITY_POOL_CONSTANT_PRODUCT case_LIQUIDITY_POOL_CONSTANT_PRODUCT:
                    Xdr.Encode(stream, case_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct);
                    break;
                }
            }
            public static bodyUnion Decode(XdrReader stream)
            {
                var discriminator = (LiquidityPoolType)stream.ReadInt();
                switch (discriminator)
                {
                    case LIQUIDITY_POOL_CONSTANT_PRODUCT:
                    var result_LIQUIDITY_POOL_CONSTANT_PRODUCT = new bodyUnion_LIQUIDITY_POOL_CONSTANT_PRODUCT();
                    result_LIQUIDITY_POOL_CONSTANT_PRODUCT.                 = Xdr.Decode(stream);
                    return result_LIQUIDITY_POOL_CONSTANT_PRODUCT;
                    default:
                    throw new Exception($"Unknown discriminator for bodyUnion: {discriminator}");
                }
            }
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
