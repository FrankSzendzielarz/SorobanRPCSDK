// Generated code - do not modify
// Source:

// struct TransactionMetaV1
// {
//     LedgerEntryChanges txChanges; // tx level changes if any
//     OperationMeta operations<>;   // meta for each operation
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionMetaV1
    {
        public LedgerEntryChanges txChanges
        {
            get => _txChanges;
            set
            {
                _txChanges = value;
            }
        }
        private LedgerEntryChanges _txChanges;

        /// <summary>
        /// tx level changes if any
        /// </summary>
        public OperationMeta[] operations
        {
            get => _operations;
            set
            {
                _operations = value;
            }
        }
        private OperationMeta[] _operations;

        public TransactionMetaV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionMetaV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionMetaV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionMetaV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionMetaV1 value)
        {
            value.Validate();
            LedgerEntryChangesXdr.Encode(stream, value.txChanges);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationMetaXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionMetaV1 Decode(XdrReader stream)
        {
            var result = new TransactionMetaV1();
            result.txChanges = LedgerEntryChangesXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.operations = new OperationMeta[length];
                for (var i = 0; i < length; i++)
                {
                    result.operations[i] = OperationMetaXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
