// Generated code - do not modify
// Source:

// struct StoredDebugTransactionSet
// {
// 	StoredTransactionSet txSet;
// 	uint32 ledgerSeq;
// 	StellarValue scpValue;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class StoredDebugTransactionSet
    {
        public StoredTransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }
        private StoredTransactionSet _txSet;

        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }
        private uint32 _ledgerSeq;

        public StellarValue scpValue
        {
            get => _scpValue;
            set
            {
                _scpValue = value;
            }
        }
        private StellarValue _scpValue;

        public StoredDebugTransactionSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class StoredDebugTransactionSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StoredDebugTransactionSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StoredDebugTransactionSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, StoredDebugTransactionSet value)
        {
            value.Validate();
            StoredTransactionSetXdr.Encode(stream, value.txSet);
            uint32Xdr.Encode(stream, value.ledgerSeq);
            StellarValueXdr.Encode(stream, value.scpValue);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static StoredDebugTransactionSet Decode(XdrReader stream)
        {
            var result = new StoredDebugTransactionSet();
            result.txSet = StoredTransactionSetXdr.Decode(stream);
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.scpValue = StellarValueXdr.Decode(stream);
            return result;
        }
    }
}
