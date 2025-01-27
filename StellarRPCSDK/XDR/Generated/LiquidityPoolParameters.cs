// Generated code - do not modify
// Source:

// union LiquidityPoolParameters switch (LiquidityPoolType type)
// {
// case LIQUIDITY_POOL_CONSTANT_PRODUCT:
//     LiquidityPoolConstantProductParameters constantProduct;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LiquidityPoolParameters
    {
        public abstract LiquidityPoolType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class LiquidityPoolParameters_LIQUIDITY_POOL_CONSTANT_PRODUCT : LiquidityPoolParameters
    {
        public override LiquidityPoolType Discriminator => LIQUIDITY_POOL_CONSTANT_PRODUCT;
        private LiquidityPoolConstantProductParameters _constantProduct;
        public LiquidityPoolConstantProductParameters constantProduct
        {
            get => _constantProduct;
            set
            {
                _constantProduct = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class LiquidityPoolParametersXdr
    {
        public static void Encode(XdrWriter stream, LiquidityPoolParameters value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolParameters_LIQUIDITY_POOL_CONSTANT_PRODUCT case_LIQUIDITY_POOL_CONSTANT_PRODUCT:
                LiquidityPoolConstantProductParametersXdr.Encode(stream, case_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct);
                break;
            }
        }
        public static LiquidityPoolParameters Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolType)stream.ReadInt();
            switch (discriminator)
            {
                case LIQUIDITY_POOL_CONSTANT_PRODUCT:
                var result_LIQUIDITY_POOL_CONSTANT_PRODUCT = new LiquidityPoolParameters_LIQUIDITY_POOL_CONSTANT_PRODUCT();
                result_LIQUIDITY_POOL_CONSTANT_PRODUCT.                 = LiquidityPoolConstantProductParametersXdr.Decode(stream);
                return result_LIQUIDITY_POOL_CONSTANT_PRODUCT;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolParameters: {discriminator}");
            }
        }
    }
}
