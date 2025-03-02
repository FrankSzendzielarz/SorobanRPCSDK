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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TransactionHistoryResultEntry
    {
        [ProtoMember(1)]
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Seq")]
        #endif
        private uint32 _ledgerSeq;

        [ProtoMember(2)]
        public TransactionResultSet txResultSet
        {
            get => _txResultSet;
            set
            {
                _txResultSet = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Result Set")]
        #endif
        private TransactionResultSet _txResultSet;

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(3)]
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
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public TransactionHistoryResultEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "TransactionHistoryResultEntry_extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "TransactionHistoryResultEntry_extUnion_case_0")]
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
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
    public static partial class TransactionHistoryResultEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionHistoryResultEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionHistoryResultEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionHistoryResultEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionHistoryResultEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionHistoryResultEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerSeq);
            TransactionResultSetXdr.Encode(stream, value.txResultSet);
            TransactionHistoryResultEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionHistoryResultEntry Decode(XdrReader stream)
        {
            var result = new TransactionHistoryResultEntry();
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.txResultSet = TransactionResultSetXdr.Decode(stream);
            result.ext = TransactionHistoryResultEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
