// Generated code - do not modify
// Source:

// struct BumpSequenceOp
// {
//     SequenceNumber bumpTo;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class BumpSequenceOp
    {
        public SequenceNumber bumpTo
        {
            get => _bumpTo;
            set
            {
                _bumpTo = value;
            }
        }
        private SequenceNumber _bumpTo;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BumpSequenceOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BumpSequenceOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
