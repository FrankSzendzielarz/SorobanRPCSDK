// Generated code - do not modify
// Source:

// union TransactionMeta switch (int v)
// {
// case 0:
//     OperationMeta operations<>;
// case 1:
//     TransactionMetaV1 v1;
// case 2:
//     TransactionMetaV2 v2;
// case 3:
//     TransactionMetaV3 v3;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class TransactionMeta
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class TransactionMeta_0 : TransactionMeta
    {
        public override int Discriminator => 0;
        private OperationMeta[] _operations;
        public OperationMeta[] operations
        {
            get => _operations;
            set
            {
                _operations = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class TransactionMeta_1 : TransactionMeta
    {
        public override int Discriminator => 1;
        private TransactionMetaV1 _v1;
        public TransactionMetaV1 v1
        {
            get => _v1;
            set
            {
                _v1 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class TransactionMeta_2 : TransactionMeta
    {
        public override int Discriminator => 2;
        private TransactionMetaV2 _v2;
        public TransactionMetaV2 v2
        {
            get => _v2;
            set
            {
                _v2 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class TransactionMeta_3 : TransactionMeta
    {
        public override int Discriminator => 3;
        private TransactionMetaV3 _v3;
        public TransactionMetaV3 v3
        {
            get => _v3;
            set
            {
                _v3 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class TransactionMetaXdr
    {
        public static void Encode(XdrWriter stream, TransactionMeta value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TransactionMeta_0 case_0:
                stream.WriteInt(case_0.operations.Length);
                foreach (var item in case_0.operations)
                {
                        OperationMetaXdr.Encode(stream, item);
                }
                break;
                case TransactionMeta_1 case_1:
                TransactionMetaV1Xdr.Encode(stream, case_1.v1);
                break;
                case TransactionMeta_2 case_2:
                TransactionMetaV2Xdr.Encode(stream, case_2.v2);
                break;
                case TransactionMeta_3 case_3:
                TransactionMetaV3Xdr.Encode(stream, case_3.v3);
                break;
            }
        }
        public static TransactionMeta Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new TransactionMeta_0();
                {
                    var length = stream.ReadInt();
                    result_0.operations = new OperationMeta[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_0.operations[i] = OperationMetaXdr.Decode(stream);
                    }
                }
                return result_0;
                case 1:
                var result_1 = new TransactionMeta_1();
                result_1.v1 = TransactionMetaV1Xdr.Decode(stream);
                return result_1;
                case 2:
                var result_2 = new TransactionMeta_2();
                result_2.v2 = TransactionMetaV2Xdr.Decode(stream);
                return result_2;
                case 3:
                var result_3 = new TransactionMeta_3();
                result_3.v3 = TransactionMetaV3Xdr.Decode(stream);
                return result_3;
                default:
                throw new Exception($"Unknown discriminator for TransactionMeta: {discriminator}");
            }
        }
    }
}
