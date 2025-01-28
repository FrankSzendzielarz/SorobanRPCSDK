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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LiquidityPoolDepositResult
    {
        public abstract LiquidityPoolDepositResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_SUCCESS : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_MALFORMED : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NO_TRUST : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_LINE_FULL : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_BAD_PRICE;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_POOL_FULL : LiquidityPoolDepositResult
    {
        public override LiquidityPoolDepositResultCode Discriminator => LiquidityPoolDepositResultCode.LIQUIDITY_POOL_DEPOSIT_POOL_FULL;

        public override void ValidateCase() {}
    }
    public static partial class LiquidityPoolDepositResultXdr
    {
        public static void Encode(XdrWriter stream, LiquidityPoolDepositResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_SUCCESS case_LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_MALFORMED case_LIQUIDITY_POOL_DEPOSIT_MALFORMED:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NO_TRUST case_LIQUIDITY_POOL_DEPOSIT_NO_TRUST:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED case_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED case_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_LINE_FULL case_LIQUIDITY_POOL_DEPOSIT_LINE_FULL:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE case_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE:
                break;
                case LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_POOL_FULL case_LIQUIDITY_POOL_DEPOSIT_POOL_FULL:
                break;
            }
        }
        public static LiquidityPoolDepositResult Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolDepositResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                var result_LIQUIDITY_POOL_DEPOSIT_SUCCESS = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_SUCCESS();
                return result_LIQUIDITY_POOL_DEPOSIT_SUCCESS;
                case LIQUIDITY_POOL_DEPOSIT_MALFORMED:
                var result_LIQUIDITY_POOL_DEPOSIT_MALFORMED = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_MALFORMED();
                return result_LIQUIDITY_POOL_DEPOSIT_MALFORMED;
                case LIQUIDITY_POOL_DEPOSIT_NO_TRUST:
                var result_LIQUIDITY_POOL_DEPOSIT_NO_TRUST = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NO_TRUST();
                return result_LIQUIDITY_POOL_DEPOSIT_NO_TRUST;
                case LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED:
                var result_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED();
                return result_LIQUIDITY_POOL_DEPOSIT_NOT_AUTHORIZED;
                case LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED:
                var result_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED();
                return result_LIQUIDITY_POOL_DEPOSIT_UNDERFUNDED;
                case LIQUIDITY_POOL_DEPOSIT_LINE_FULL:
                var result_LIQUIDITY_POOL_DEPOSIT_LINE_FULL = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_LINE_FULL();
                return result_LIQUIDITY_POOL_DEPOSIT_LINE_FULL;
                case LIQUIDITY_POOL_DEPOSIT_BAD_PRICE:
                var result_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE();
                return result_LIQUIDITY_POOL_DEPOSIT_BAD_PRICE;
                case LIQUIDITY_POOL_DEPOSIT_POOL_FULL:
                var result_LIQUIDITY_POOL_DEPOSIT_POOL_FULL = new LiquidityPoolDepositResult_LIQUIDITY_POOL_DEPOSIT_POOL_FULL();
                return result_LIQUIDITY_POOL_DEPOSIT_POOL_FULL;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolDepositResult: {discriminator}");
            }
        }
    }
}
