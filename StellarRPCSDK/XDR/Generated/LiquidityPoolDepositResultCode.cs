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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LiquidityPoolDepositResultCode
    {
        LIQUIDITY_POOL_DEPOSIT_SUCCESS = 0,
        LIQUIDITY_POOL_DEPOSIT_MALFORMED = -1,
        LIQUIDITY_POOL_DEPOSIT_NO_TRUST = -2,
        LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED = -3,
        LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED = -4,
        LIQUIDITY_POOL_DEPOSIT_LINE_FULL = -5,
        LIQUIDITY_POOL_DEPOSIT_BAD_PRICE = -6,
        LIQUIDITY_POOL_DEPOSIT_POOL_FULL = -7,
    }

    public static partial class LiquidityPoolDepositResultCodeXdr
    {
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
