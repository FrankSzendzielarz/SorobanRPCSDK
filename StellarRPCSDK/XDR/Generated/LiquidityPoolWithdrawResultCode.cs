// Generated code - do not modify
// Source:

// enum LiquidityPoolWithdrawResultCode
// {
//     // codes considered as "success" for the operation
//     LIQUIDITY_POOL_WITHDRAW_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     LIQUIDITY_POOL_WITHDRAW_MALFORMED = -1,    // bad input
//     LIQUIDITY_POOL_WITHDRAW_NO_TRUST = -2,     // no trust line for one of the
//                                                // assets
//     LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = -3,  // not enough balance of the
//                                                // pool share
//     LIQUIDITY_POOL_WITHDRAW_LINE_FULL = -4,    // would go above limit for one
//                                                // of the assets
//     LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = -5 // didn't withdraw enough
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LiquidityPoolWithdrawResultCode
    {
        LIQUIDITY_POOL_WITHDRAW_SUCCESS = 0,
        LIQUIDITY_POOL_WITHDRAW_MALFORMED = -1,
        LIQUIDITY_POOL_WITHDRAW_NO_TRUST = -2,
        LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = -3,
        LIQUIDITY_POOL_WITHDRAW_LINE_FULL = -4,
        LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = -5,
    }

    public static partial class LiquidityPoolWithdrawResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolWithdrawResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolWithdrawResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolWithdrawResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LiquidityPoolWithdrawResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LiquidityPoolWithdrawResultCode), value))
              throw new InvalidOperationException($"Unknown LiquidityPoolWithdrawResultCode value: {value}");
            return (LiquidityPoolWithdrawResultCode)value;
        }
    }
}
