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

        private object _ext;
        public object ext
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
            Xdr.Encode(stream, value.ext);
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
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
