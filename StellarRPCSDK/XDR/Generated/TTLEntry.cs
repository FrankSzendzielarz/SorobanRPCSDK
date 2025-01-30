// Generated code - do not modify
// Source:

// struct TTLEntry {
//     // Hash of the LedgerKey that is associated with this TTLEntry
//     Hash keyHash;
//     uint32 liveUntilLedgerSeq;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TTLEntry
    {
        private Hash _keyHash;
        public Hash keyHash
        {
            get => _keyHash;
            set
            {
                _keyHash = value;
            }
        }

        private uint32 _liveUntilLedgerSeq;
        public uint32 liveUntilLedgerSeq
        {
            get => _liveUntilLedgerSeq;
            set
            {
                _liveUntilLedgerSeq = value;
            }
        }

        public TTLEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TTLEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TTLEntry value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.keyHash);
            uint32Xdr.Encode(stream, value.liveUntilLedgerSeq);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TTLEntry Decode(XdrReader stream)
        {
            var result = new TTLEntry();
            result.keyHash = HashXdr.Decode(stream);
            result.liveUntilLedgerSeq = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
