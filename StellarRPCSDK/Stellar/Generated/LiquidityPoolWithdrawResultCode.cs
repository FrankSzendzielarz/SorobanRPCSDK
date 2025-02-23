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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum LiquidityPoolWithdrawResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        LIQUIDITY_POOL_WITHDRAW_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        LIQUIDITY_POOL_WITHDRAW_MALFORMED = -1,
        /// <summary>
        /// bad input
        /// </summary>
        LIQUIDITY_POOL_WITHDRAW_NO_TRUST = -2,
        /// <summary>
        /// assets
        /// </summary>
        LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = -3,
        /// <summary>
        /// pool share
        /// </summary>
        LIQUIDITY_POOL_WITHDRAW_LINE_FULL = -4,
        /// <summary>
        /// of the assets
        /// </summary>
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolWithdrawResultCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolWithdrawResultCodeXdr.Decode(reader);
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
