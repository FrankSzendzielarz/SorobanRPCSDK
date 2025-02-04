// Generated code - do not modify
// Source:

// enum LiquidityPoolDepositResultCode
// {
//     // codes considered as "success" for the operation
//     LIQUIDITY_POOL_DEPOSIT_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     LIQUIDITY_POOL_DEPOSIT_MALFORMED = -1,      // bad input
//     LIQUIDITY_POOL_DEPOSIT_NO_TRUST = -2,       // no trust line for one of the
//                                                 // assets
//     LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED = -3, // not authorized for one of the
//                                                 // assets
//     LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED = -4,    // not enough balance for one of
//                                                 // the assets
//     LIQUIDITY_POOL_DEPOSIT_LINE_FULL = -5,      // pool share trust line doesn't
//                                                 // have sufficient limit
//     LIQUIDITY_POOL_DEPOSIT_BAD_PRICE = -6,      // deposit price outside bounds
//     LIQUIDITY_POOL_DEPOSIT_POOL_FULL = -7       // pool reserves are full
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LiquidityPoolDepositResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_MALFORMED = -1,
        /// <summary>
        /// bad input
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_NO_TRUST = -2,
        /// <summary>
        /// assets
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED = -3,
        /// <summary>
        /// assets
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED = -4,
        /// <summary>
        /// the assets
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_LINE_FULL = -5,
        /// <summary>
        /// have sufficient limit
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_BAD_PRICE = -6,
        /// <summary>
        /// deposit price outside bounds
        /// </summary>
        LIQUIDITY_POOL_DEPOSIT_POOL_FULL = -7,
    }

    public static partial class LiquidityPoolDepositResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolDepositResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolDepositResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolDepositResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LiquidityPoolDepositResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LiquidityPoolDepositResultCode), value))
              throw new InvalidOperationException($"Unknown LiquidityPoolDepositResultCode value: {value}");
            return (LiquidityPoolDepositResultCode)value;
        }
    }
}
