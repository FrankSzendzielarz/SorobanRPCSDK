// Generated code - do not modify
// Source:

// struct TransactionHistoryResultEntry
// {
//     uint32 ledgerSeq;
//     TransactionResultSet txResultSet;
// 
//     // reserved for future use
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
    public partial class TransactionHistoryResultEntry
    {
        private uint32 _ledgerSeq;
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }

        private TransactionResultSet _txResultSet;
        public TransactionResultSet txResultSet
        {
            get => _txResultSet;
            set
            {
                _txResultSet = value;
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

        public TransactionHistoryResultEntry()
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
    public static partial class TransactionHistoryResultEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionHistoryResultEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerSeq);
            TransactionResultSetXdr.Encode(stream, value.txResultSet);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionHistoryResultEntry Decode(XdrReader stream)
        {
            var result = new TransactionHistoryResultEntry();
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.txResultSet = TransactionResultSetXdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
