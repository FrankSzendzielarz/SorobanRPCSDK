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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LiquidityPoolWithdrawResult
    {
        public abstract LiquidityPoolWithdrawResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_SUCCESS : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_MALFORMED : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_NO_TRUST : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_LINE_FULL : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM : LiquidityPoolWithdrawResult
    {
        public override LiquidityPoolWithdrawResultCode Discriminator => LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM;

        public override void ValidateCase() {}
    }
    public static partial class LiquidityPoolWithdrawResultXdr
    {
        public static void Encode(XdrWriter stream, LiquidityPoolWithdrawResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_SUCCESS case_LIQUIDITY_POOL_WITHDRAW_SUCCESS:
                break;
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_MALFORMED case_LIQUIDITY_POOL_WITHDRAW_MALFORMED:
                break;
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_NO_TRUST case_LIQUIDITY_POOL_WITHDRAW_NO_TRUST:
                break;
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED case_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED:
                break;
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_LINE_FULL case_LIQUIDITY_POOL_WITHDRAW_LINE_FULL:
                break;
                case LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM case_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM:
                break;
            }
        }
        public static LiquidityPoolWithdrawResult Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolWithdrawResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_SUCCESS:
                var result_LIQUIDITY_POOL_WITHDRAW_SUCCESS = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_SUCCESS();
                return result_LIQUIDITY_POOL_WITHDRAW_SUCCESS;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_MALFORMED:
                var result_LIQUIDITY_POOL_WITHDRAW_MALFORMED = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_MALFORMED();
                return result_LIQUIDITY_POOL_WITHDRAW_MALFORMED;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_NO_TRUST:
                var result_LIQUIDITY_POOL_WITHDRAW_NO_TRUST = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_NO_TRUST();
                return result_LIQUIDITY_POOL_WITHDRAW_NO_TRUST;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED:
                var result_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED();
                return result_LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_LINE_FULL:
                var result_LIQUIDITY_POOL_WITHDRAW_LINE_FULL = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_LINE_FULL();
                return result_LIQUIDITY_POOL_WITHDRAW_LINE_FULL;
                case LiquidityPoolWithdrawResultCode.LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM:
                var result_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = new LiquidityPoolWithdrawResult_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM();
                return result_LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolWithdrawResult: {discriminator}");
            }
        }
    }
}
