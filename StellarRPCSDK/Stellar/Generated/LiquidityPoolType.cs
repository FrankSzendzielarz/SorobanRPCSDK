// Generated code - do not modify
// Source:

// enum LiquidityPoolType
// {
//     LIQUIDITY_POOL_CONSTANT_PRODUCT = 0
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LiquidityPoolType
    {
        LIQUIDITY_POOL_CONSTANT_PRODUCT = 0,
    }

    public static partial class LiquidityPoolTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
