// Generated code - do not modify
// Source:

// union TxSetComponent switch (TxSetComponentType type)
// {
// case TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
//   struct
//   {
//     int64* baseFee;
//     TransactionEnvelope txs<>;
//   } txsMaybeDiscountedFee;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class TxSetComponent
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class TxSetComponent_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE : TxSetComponent
    {
        public override int Discriminator => TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE;
        private object _txsMaybeDiscountedFee;
        public object txsMaybeDiscountedFee
        {
            get => _txsMaybeDiscountedFee;
            set
            {
                _txsMaybeDiscountedFee = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class TxSetComponentXdr
    {
        public static void Encode(XdrWriter stream, TxSetComponent value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TxSetComponent_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE case_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
                Xdr.Encode(stream, case_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE.txsMaybeDiscountedFee);
                break;
            }
        }
        public static TxSetComponent Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
                var result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE = new TxSetComponent_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE();
                result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE.                 = Xdr.Decode(stream);
                return result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE;
                default:
                throw new Exception($"Unknown discriminator for TxSetComponent: {discriminator}");
            }
        }
    }
}
