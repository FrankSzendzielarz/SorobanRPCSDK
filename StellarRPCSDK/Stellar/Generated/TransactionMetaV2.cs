// Generated code - do not modify
// Source:

// struct TransactionMetaV2
// {
//     LedgerEntryChanges txChangesBefore; // tx level changes before operations
//                                         // are applied if any
//     OperationMeta operations<>;         // meta for each operation
//     LedgerEntryChanges txChangesAfter;  // tx level changes after operations are
//                                         // applied if any
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
    public partial class TransactionMetaV2
    {
        [ProtoMember(1)]
        public LedgerEntryChanges txChangesBefore
        {
            get => _txChangesBefore;
            set
            {
                _txChangesBefore = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Changes Before")]
        #endif
        private LedgerEntryChanges _txChangesBefore;

        /// <summary>
        /// are applied if any
        /// </summary>
        [ProtoMember(2, OverwriteList = true)]
        public OperationMeta[] operations
        {
            get => _operations;
            set
            {
                _operations = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Operations")]
        #endif
        private OperationMeta[] _operations;

        /// <summary>
        /// meta for each operation
        /// </summary>
        [ProtoMember(3)]
        public LedgerEntryChanges txChangesAfter
        {
            get => _txChangesAfter;
            set
            {
                _txChangesAfter = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Changes After")]
        #endif
        private LedgerEntryChanges _txChangesAfter;

        public TransactionMetaV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionMetaV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionMetaV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionMetaV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionMetaV2 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionMetaV2Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionMetaV2 value)
        {
            value.Validate();
            LedgerEntryChangesXdr.Encode(stream, value.txChangesBefore);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationMetaXdr.Encode(stream, item);
            }
            LedgerEntryChangesXdr.Encode(stream, value.txChangesAfter);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionMetaV2 Decode(XdrReader stream)
        {
            var result = new TransactionMetaV2();
            result.txChangesBefore = LedgerEntryChangesXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.operations = new OperationMeta[length];
                for (var i = 0; i < length; i++)
                {
                    result.operations[i] = OperationMetaXdr.Decode(stream);
                }
            }
            result.txChangesAfter = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
