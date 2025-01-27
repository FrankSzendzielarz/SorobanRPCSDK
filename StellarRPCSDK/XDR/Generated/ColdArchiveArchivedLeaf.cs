// Generated code - do not modify
// Source:

// struct ColdArchiveArchivedLeaf
// {
//     uint32 index;
//     LedgerEntry archivedEntry;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ColdArchiveArchivedLeaf
    {
        private uint32 _index;
        public uint32 index
        {
            get => _index;
            set
            {
                _index = value;
            }
        }

        private LedgerEntry _archivedEntry;
        public LedgerEntry archivedEntry
        {
            get => _archivedEntry;
            set
            {
                _archivedEntry = value;
            }
        }

        public ColdArchiveArchivedLeaf()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveArchivedLeafXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveArchivedLeaf value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            LedgerEntryXdr.Encode(stream, value.archivedEntry);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveArchivedLeaf Decode(XdrReader stream)
        {
            var result = new ColdArchiveArchivedLeaf();
            result.index = uint32Xdr.Decode(stream);
            result.archivedEntry = LedgerEntryXdr.Decode(stream);
            return result;
        }
    }
}
