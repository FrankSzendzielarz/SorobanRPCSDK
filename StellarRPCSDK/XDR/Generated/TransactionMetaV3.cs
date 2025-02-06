// Generated code - do not modify
// Source:

// struct TransactionMetaV3
// {
//     ExtensionPoint ext;
// 
//     LedgerEntryChanges txChangesBefore;  // tx level changes before operations
//                                          // are applied if any
//     OperationMeta operations<>;          // meta for each operation
//     LedgerEntryChanges txChangesAfter;   // tx level changes after operations are
//                                          // applied if any
//     SorobanTransactionMeta* sorobanMeta; // Soroban-specific meta (only for 
//                                          // Soroban transactions).
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionMetaV3
    {
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private ExtensionPoint _ext;

        public LedgerEntryChanges txChangesBefore
        {
            get => _txChangesBefore;
            set
            {
                _txChangesBefore = value;
            }
        }
        private LedgerEntryChanges _txChangesBefore;

        /// <summary>
        /// are applied if any
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

        /// <summary>
        /// meta for each operation
        /// </summary>
        public LedgerEntryChanges txChangesAfter
        {
            get => _txChangesAfter;
            set
            {
                _txChangesAfter = value;
            }
        }
        private LedgerEntryChanges _txChangesAfter;

        /// <summary>
        /// applied if any
        /// </summary>
        public SorobanTransactionMeta sorobanMeta
        {
            get => _sorobanMeta;
            set
            {
                _sorobanMeta = value;
            }
        }
        private SorobanTransactionMeta _sorobanMeta;

        public TransactionMetaV3()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionMetaV3Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionMetaV3 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionMetaV3Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionMetaV3 value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            LedgerEntryChangesXdr.Encode(stream, value.txChangesBefore);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationMetaXdr.Encode(stream, item);
            }
            LedgerEntryChangesXdr.Encode(stream, value.txChangesAfter);
            if (value.sorobanMeta==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                SorobanTransactionMetaXdr.Encode(stream, value.sorobanMeta);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionMetaV3 Decode(XdrReader stream)
        {
            var result = new TransactionMetaV3();
            result.ext = ExtensionPointXdr.Decode(stream);
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
            if (stream.ReadInt()==1)
            {
                result.sorobanMeta = SorobanTransactionMetaXdr.Decode(stream);
            }
            return result;
        }
    }
}
