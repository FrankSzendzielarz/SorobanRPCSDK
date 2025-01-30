// Generated code - do not modify
// Source:

// struct SCMapEntry
// {
//     SCVal key;
//     SCVal val;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCMapEntry
    {
        private SCVal _key;
        public SCVal key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        private SCVal _val;
        public SCVal val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }

        public SCMapEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCMapEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMapEntry value)
        {
            value.Validate();
            SCValXdr.Encode(stream, value.key);
            SCValXdr.Encode(stream, value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCMapEntry Decode(XdrReader stream)
        {
            var result = new SCMapEntry();
            result.key = SCValXdr.Decode(stream);
            result.val = SCValXdr.Decode(stream);
            return result;
        }
    }
}
