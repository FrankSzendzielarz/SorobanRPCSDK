// Generated code - do not modify
// Source:

// struct BumpSequenceOp
// {
//     SequenceNumber bumpTo;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class BumpSequenceOp
    {
        private SequenceNumber _bumpTo;
        public SequenceNumber bumpTo
        {
            get => _bumpTo;
            set
            {
                _bumpTo = value;
            }
        }

        public BumpSequenceOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class BumpSequenceOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, BumpSequenceOp value)
        {
            value.Validate();
            SequenceNumberXdr.Encode(stream, value.bumpTo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static BumpSequenceOp Decode(XdrReader stream)
        {
            var result = new BumpSequenceOp();
            result.bumpTo = SequenceNumberXdr.Decode(stream);
            return result;
        }
    }
}
