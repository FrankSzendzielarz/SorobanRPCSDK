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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class Transaction
    {
        /// <summary>
        /// account used to run the transaction
        /// </summary>
        public MuxedAccount sourceAccount
        {
            get => _sourceAccount;
            set
            {
                _sourceAccount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Source Account")]
        #endif
        private MuxedAccount _sourceAccount;

        /// <summary>
        /// the fee the sourceAccount will pay
        /// </summary>
        public uint32 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Fee")]
        #endif
        private uint32 _fee;

        /// <summary>
        /// sequence number to consume in the account
        /// </summary>
        public SequenceNumber seqNum
        {
            get => _seqNum;
            set
            {
                _seqNum = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Seq Num")]
        #endif
        private SequenceNumber _seqNum;

        /// <summary>
        /// validity conditions
        /// </summary>
        public Preconditions cond
        {
            get => _cond;
            set
            {
                _cond = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Cond")]
        #endif
        private Preconditions _cond;

        public Memo memo
        {
            get => _memo;
            set
            {
                _memo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Memo")]
        #endif
        private Memo _memo;

        [MaxLength(100)]
        public Operation[] operations
        {
            get => _operations;
            set
            {
                if (value.Length > Constants.MAX_OPS_PER_TX)
                	throw new ArgumentException($"Cannot exceed Constants.MAX_OPS_PER_TX in length");
                _operations = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Operations")]
        #endif
        private Operation[] _operations;

        /// <summary>
        /// reserved for future use
        /// </summary>
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public Transaction()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (operations.Length > Constants.MAX_OPS_PER_TX)
            	throw new InvalidOperationException($"operations cannot exceed Constants.MAX_OPS_PER_TX elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                public SorobanTransactionData sorobanData
                {
                    get => _sorobanData;
                    set
                    {
                        _sorobanData = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[InspectorName(@"Soroban Data")]
                #endif
                private SorobanTransactionData _sorobanData;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                    case extUnion.case_1 case_1:
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
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion.case_1();
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Transaction value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            {
                var length = stream.ReadInt();
                result.operations = new Operation[length];
                for (var i = 0; i < length; i++)
                {
                    result.operations[i] = OperationXdr.Decode(stream);
                }
            }
            result.ext = Transaction.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
