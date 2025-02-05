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
using System.IO;

namespace Stellar.XDR {

    /// <summary>
    /// containing a TransactionV0.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionV0
    {
        public uint256 sourceAccountEd25519
        {
            get => _sourceAccountEd25519;
            set
            {
                _sourceAccountEd25519 = value;
            }
        }
        private uint256 _sourceAccountEd25519;

        public uint32 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }
        private uint32 _fee;

        public SequenceNumber seqNum
        {
            get => _seqNum;
            set
            {
                _seqNum = value;
            }
        }
        private SequenceNumber _seqNum;

        public TimeBounds timeBounds
        {
            get => _timeBounds;
            set
            {
                _timeBounds = value;
            }
        }
        private TimeBounds _timeBounds;

        public Memo memo
        {
            get => _memo;
            set
            {
                _memo = value;
            }
        }
        private Memo _memo;

        public Operation[] operations
        {
            get => _operations;
            set
            {
                if (value.Length > Constants.MAX_OPS_PER_TX)
                	throw new ArgumentException($"Cannot exceed Constants.MAX_OPS_PER_TX bytes");
                _operations = value;
            }
        }
        private Operation[] _operations;

        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private extUnion _ext;

        public TransactionV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (operations.Length > Constants.MAX_OPS_PER_TX)
            	throw new InvalidOperationException($"operations cannot exceed Constants.MAX_OPS_PER_TX elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

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
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionV0 value)
        {
            value.Validate();
            uint256Xdr.Encode(stream, value.sourceAccountEd25519);
            uint32Xdr.Encode(stream, value.fee);
            SequenceNumberXdr.Encode(stream, value.seqNum);
            if (value.timeBounds==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                TimeBoundsXdr.Encode(stream, value.timeBounds);
            }
            MemoXdr.Encode(stream, value.memo);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationXdr.Encode(stream, item);
            }
            TransactionV0.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionV0 Decode(XdrReader stream)
        {
            var result = new TransactionV0();
            result.sourceAccountEd25519 = uint256Xdr.Decode(stream);
            result.fee = uint32Xdr.Decode(stream);
            result.seqNum = SequenceNumberXdr.Decode(stream);
            if (stream.ReadInt()==1)
            {
                result.timeBounds = TimeBoundsXdr.Decode(stream);
            }
            result.memo = MemoXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.operations = new Operation[length];
                for (var i = 0; i < length; i++)
                {
                    result.operations[i] = OperationXdr.Decode(stream);
                }
            }
            result.ext = TransactionV0.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
