// Generated code - do not modify
// Source:

// struct TransactionV0
// {
//     uint256 sourceAccountEd25519;
//     uint32 fee;
//     SequenceNumber seqNum;
//     TimeBounds* timeBounds;
//     Memo memo;
//     Operation operations<MAX_OPS_PER_TX>;
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionV0
    {
        private uint256 _sourceAccountEd25519;
        public uint256 sourceAccountEd25519
        {
            get => _sourceAccountEd25519;
            set
            {
                _sourceAccountEd25519 = value;
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

        private TimeBounds _timeBounds;
        public TimeBounds timeBounds
        {
            get => _timeBounds;
            set
            {
                _timeBounds = value;
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

        public TransactionV0()
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
            public override int Discriminator => int.0;

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
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionV0 value)
        {
            value.Validate();
            uint256Xdr.Encode(stream, value.sourceAccountEd25519);
            uint32Xdr.Encode(stream, value.fee);
            SequenceNumberXdr.Encode(stream, value.seqNum);
            TimeBoundsXdr.Encode(stream, value.timeBounds);
            MemoXdr.Encode(stream, value.memo);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationXdr.Encode(stream, item);
            }
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionV0 Decode(XdrReader stream)
        {
            var result = new TransactionV0();
            result.sourceAccountEd25519 = uint256Xdr.Decode(stream);
            result.fee = uint32Xdr.Decode(stream);
            result.seqNum = SequenceNumberXdr.Decode(stream);
            result.timeBounds = TimeBoundsXdr.Decode(stream);
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
