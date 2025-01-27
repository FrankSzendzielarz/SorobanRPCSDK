// Generated code - do not modify
// Source:

// struct ArchivalProofNode
// {
//     uint32 index;
//     Hash hash;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ArchivalProofNode
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

        private Hash _hash;
        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }

        public ArchivalProofNode()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ArchivalProofNodeXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ArchivalProofNode value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            HashXdr.Encode(stream, value.hash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ArchivalProofNode Decode(XdrReader stream)
        {
            var result = new ArchivalProofNode();
            result.index = uint32Xdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            return result;
        }
    }
}
