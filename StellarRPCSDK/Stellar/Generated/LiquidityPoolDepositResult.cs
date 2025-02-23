// Generated code - do not modify
// Source:

// union LiquidityPoolDepositResult switch (LiquidityPoolDepositResultCode code)
// {
// case LIQUIDITY_POOL_DEPOSIT_SUCCESS:
//     void;
// case LIQUIDITY_POOL_DEPOSIT_MALFORMED:
// case LIQUIDITY_POOL_DEPOSIT_NO_TRUST:
// case LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED:
// case LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED:
// case LIQUIDITY_POOL_DEPOSIT_LINE_FULL:
// case LIQUIDITY_POOL_DEPOSIT_BAD_PRICE:
// case LIQUIDITY_POOL_DEPOSIT_POOL_FULL:
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
    [ProtoInclude(100, typeof(LiquidityPoolDepositSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(LiquidityPoolDepositMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(LiquidityPoolDepositNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(LiquidityPoolDepositNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(LiquidityPoolDepositUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(LiquidityPoolDepositLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(LiquidityPoolDepositBadPrice), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(LiquidityPoolDepositPoolFull), DataFormat = DataFormat.Default)]
    public abstract partial class LiquidityPoolDepositResult
    {
        public abstract LiquidityPoolDepositResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositSuccess")]
        public sealed partial class LiquidityPoolDepositSuccess : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositMalformed")]
        public sealed partial class LiquidityPoolDepositMalformed : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositNoTrust")]
        public sealed partial class LiquidityPoolDepositNoTrust : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositNotAuthorized")]
        public sealed partial class LiquidityPoolDepositNotAuthorized : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositUnderfunded")]
        public sealed partial class LiquidityPoolDepositUnderfunded : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositLineFull")]
        public sealed partial class LiquidityPoolDepositLineFull : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositBadPrice")]
        public sealed partial class LiquidityPoolDepositBadPrice : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_BAD_PRICE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolDepositResult_LiquidityPoolDepositPoolFull")]
        public sealed partial class LiquidityPoolDepositPoolFull : LiquidityPoolDepositResult
        {
            public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_POOL_FULL;

            public override void ValidateCase() {}
        }
    }
    public static partial class LiquidityPoolDepositResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolDepositResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolDepositResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolDepositResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolDepositResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, LiquidityPoolDepositResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolDepositResult.LiquidityPoolDepositSuccess case_LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositMalformed case_LIQUIDITY_POOL_DEPOSIT_MALFORMED:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust case_LIQUIDITY_POOL_DEPOSIT_NO_TRUST:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized case_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded case_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositLineFull case_LIQUIDITY_POOL_DEPOSIT_LINE_FULL:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice case_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE:
                break;
                case LiquidityPoolDepositResult.LiquidityPoolDepositPoolFull case_LIQUIDITY_POOL_DEPOSIT_POOL_FULL:
                break;
            }
        }
        public static LiquidityPoolDepositResult Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolDepositResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                var result_LIQUIDITY_POOL_DEPOSIT_SUCCESS = new LiquidityPoolDepositResult.LiquidityPoolDepositSuccess();
                return result_LIQUIDITY_POOL_DEPOSIT_SUCCESS;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_MALFORMED:
                var result_LIQUIDITY_POOL_DEPOSIT_MALFORMED = new LiquidityPoolDepositResult.LiquidityPoolDepositMalformed();
                return result_LIQUIDITY_POOL_DEPOSIT_MALFORMED;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NO_TRUST:
                var result_LIQUIDITY_POOL_DEPOSIT_NO_TRUST = new LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust();
                return result_LIQUIDITY_POOL_DEPOSIT_NO_TRUST;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED:
                var result_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED = new LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized();
                return result_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED:
                var result_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED = new LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded();
                return result_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_LINE_FULL:
                var result_LIQUIDITY_POOL_DEPOSIT_LINE_FULL = new LiquidityPoolDepositResult.LiquidityPoolDepositLineFull();
                return result_LIQUIDITY_POOL_DEPOSIT_LINE_FULL;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_BAD_PRICE:
                var result_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE = new LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice();
                return result_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE;
                case LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_POOL_FULL:
                var result_LIQUIDITY_POOL_DEPOSIT_POOL_FULL = new LiquidityPoolDepositResult.LiquidityPoolDepositPoolFull();
                return result_LIQUIDITY_POOL_DEPOSIT_POOL_FULL;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolDepositResult: {discriminator}");
            }
        }
    }
}
