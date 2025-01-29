// Generated code - do not modify
// Source:

// union GeneralizedTransactionSet switch (int v)
// {
// // We consider the legacy TransactionSet to be v0.
// case 1:
//     TransactionSetV1 v1TxSet;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class GeneralizedTransactionSet
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class GeneralizedTransactionSet_1 : GeneralizedTransactionSet
    {
        public override int Discriminator => 1;
        private TransactionSetV1 _v1TxSet;
        public TransactionSetV1 v1TxSet
        {
            get => _v1TxSet;
            set
            {
                _v1TxSet = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class GeneralizedTransactionSetXdr
    {
        public static void Encode(XdrWriter stream, GeneralizedTransactionSet value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case GeneralizedTransactionSet_1 case_1:
                TransactionSetV1Xdr.Encode(stream, case_1.v1TxSet);
                break;
            }
        }
        public static GeneralizedTransactionSet Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 1:
                var result_1 = new GeneralizedTransactionSet_1();
                result_1.v1TxSet = TransactionSetV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for GeneralizedTransactionSet: {discriminator}");
            }
        }
    }
}
