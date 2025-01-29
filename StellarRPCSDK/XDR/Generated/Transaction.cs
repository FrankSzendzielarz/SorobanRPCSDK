// Generated code - do not modify
// Source:

// struct Transaction
// {
//     // account used to run the transaction
//     MuxedAccount sourceAccount;
// 
//     // the fee the sourceAccount will pay
//     uint32 fee;
// 
//     // sequence number to consume in the account
//     SequenceNumber seqNum;
// 
//     // validity conditions
//     Preconditions cond;
// 
//     Memo memo;
// 
//     Operation operations<MAX_OPS_PER_TX>;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         SorobanTransactionData sorobanData;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Transaction
    {
        private MuxedAccount _sourceAccount;
        public MuxedAccount sourceAccount
        {
            get => _sourceAccount;
            set
            {
                _sourceAccount = value;
            }
        }

        private uint32 _fee;
        public uint32 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }

        private SequenceNumber _seqNum;
        public SequenceNumber seqNum
        {
            get => _seqNum;
            set
            {
                _seqNum = value;
            }
        }

        private Preconditions _cond;
        public Preconditions cond
        {
            get => _cond;
            set
            {
                _cond = value;
            }
        }

        private Memo _memo;
        public Memo memo
        {
            get => _memo;
            set
            {
                _memo = value;
            }
        }

        private Operation[] _operations;
        public Operation[] operations
        {
            get => _operations;
            set
            {
                _operations = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public Transaction()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private SorobanTransactionData _sorobanData;
            public SorobanTransactionData sorobanData
            {
                get => _sorobanData;
                set
                {
                    _sorobanData = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
                    SorobanTransactionDataXdr.Encode(stream, case_1.sorobanData);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.sorobanData = SorobanTransactionDataXdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Transaction value)
        {
            value.Validate();
            MuxedAccountXdr.Encode(stream, value.sourceAccount);
            uint32Xdr.Encode(stream, value.fee);
            SequenceNumberXdr.Encode(stream, value.seqNum);
            PreconditionsXdr.Encode(stream, value.cond);
            MemoXdr.Encode(stream, value.memo);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationXdr.Encode(stream, item);
            }
            Transaction.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Transaction Decode(XdrReader stream)
        {
            var result = new Transaction();
            result.sourceAccount = MuxedAccountXdr.Decode(stream);
            result.fee = uint32Xdr.Decode(stream);
            result.seqNum = SequenceNumberXdr.Decode(stream);
            result.cond = PreconditionsXdr.Decode(stream);
            result.memo = MemoXdr.Decode(stream);
            var length = stream.ReadInt();
            result.operations = new Operation[length];
            for (var i = 0; i < length; i++)
            {
                result.operations[i] = OperationXdr.Decode(stream);
            }
            result.ext = Transaction.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
