// Generated code - do not modify
// Source:

// struct ColdArchiveDeletedLeaf
// {
//     uint32 index;
//     LedgerKey deletedKey;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ColdArchiveDeletedLeaf
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

        private LedgerKey _deletedKey;
        public LedgerKey deletedKey
        {
            get => _deletedKey;
            set
            {
                _deletedKey = value;
            }
        }

        public ColdArchiveDeletedLeaf()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveDeletedLeafXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveDeletedLeaf value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            LedgerKeyXdr.Encode(stream, value.deletedKey);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveDeletedLeaf Decode(XdrReader stream)
        {
            var result = new ColdArchiveDeletedLeaf();
            result.index = uint32Xdr.Decode(stream);
            result.deletedKey = LedgerKeyXdr.Decode(stream);
            return result;
        }
    }
}
