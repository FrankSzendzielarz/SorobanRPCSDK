// Generated code - do not modify
// Source:

// union LiquidityPoolWithdrawResult switch (LiquidityPoolWithdrawResultCode code)
// {
// case LIQUIDITY_POOL_WITHDRAW_SUCCESS:
//     void;
// case LIQUIDITY_POOL_WITHDRAW_MALFORMED:
// case LIQUIDITY_POOL_WITHDRAW_NO_TRUST:
// case LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED:
// case LIQUIDITY_POOL_WITHDRAW_LINE_FULL:
// case LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM:
//     void;
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
    [ProtoInclude(100, typeof(LiquidityPoolWithdrawSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(LiquidityPoolWithdrawMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(LiquidityPoolWithdrawNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(LiquidityPoolWithdrawUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(LiquidityPoolWithdrawLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(LiquidityPoolWithdrawUnderMinimum), DataFormat = DataFormat.Default)]
    public abstract partial class LiquidityPoolWithdrawResult
    {
        public abstract LiquidityPoolWithdrawResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawSuccess")]
        public sealed partial class LiquidityPoolWithdrawSuccess : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawMalformed")]
        public sealed partial class LiquidityPoolWithdrawMalformed : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawNoTrust")]
        public sealed partial class LiquidityPoolWithdrawNoTrust : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawUnderfunded")]
        public sealed partial class LiquidityPoolWithdrawUnderfunded : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawLineFull")]
        public sealed partial class LiquidityPoolWithdrawLineFull : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolWithdrawResult_LiquidityPoolWithdrawUnderMinimum")]
        public sealed partial class LiquidityPoolWithdrawUnderMinimum : LiquidityPoolWithdrawResult
        {
            public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM;

            public override void ValidateCase() {}
        }
    }
    public static partial class LiquidityPoolWithdrawResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolWithdrawResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolWithdrawResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolWithdrawResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolWithdrawResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, LiquidityPoolWithdrawResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawSuccess case_LIQUIDITY_POOL_WITHDRAW_SUCCESS:
                break;
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed case_LIQUIDITY_POOL_WITHDRAW_MALFORMED:
                break;
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawNoTrust case_LIQUIDITY_POOL_WITHDRAW_NO_TRUST:
                break;
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderfunded case_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED:
                break;
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull case_LIQUIDITY_POOL_WITHDRAW_LINE_FULL:
                break;
                case LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderMinimum case_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM:
                break;
            }
        }
        public static LiquidityPoolWithdrawResult Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolWithdrawResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_SUCCESS:
                var result_LIQUIDITY_POOL_WITHDRAW_SUCCESS = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawSuccess();
                return result_LIQUIDITY_POOL_WITHDRAW_SUCCESS;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_MALFORMED:
                var result_LIQUIDITY_POOL_WITHDRAW_MALFORMED = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed();
                return result_LIQUIDITY_POOL_WITHDRAW_MALFORMED;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_NO_TRUST:
                var result_LIQUIDITY_POOL_WITHDRAW_NO_TRUST = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawNoTrust();
                return result_LIQUIDITY_POOL_WITHDRAW_NO_TRUST;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED:
                var result_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderfunded();
                return result_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_LINE_FULL:
                var result_LIQUIDITY_POOL_WITHDRAW_LINE_FULL = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull();
                return result_LIQUIDITY_POOL_WITHDRAW_LINE_FULL;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM:
                var result_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = new LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderMinimum();
                return result_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolWithdrawResult: {discriminator}");
            }
        }
    }
}
