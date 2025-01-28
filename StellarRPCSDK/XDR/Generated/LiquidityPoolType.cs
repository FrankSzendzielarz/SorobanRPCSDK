// Generated code - do not modify
// Source:

// enum LiquidityPoolType
// {
//     LIQUIDITY_POOL_CONSTANT_PRODUCT = 0
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LiquidityPoolType
    {
        LIQUIDITY_POOL_CONSTANT_PRODUCT = 0,
    }

    public static partial class LiquidityPoolTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LiquidityPoolType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LiquidityPoolType), value))
              throw new InvalidOperationException($"Unknown LiquidityPoolType value: {value}");
            return (LiquidityPoolType)value;
        }
    }
}
