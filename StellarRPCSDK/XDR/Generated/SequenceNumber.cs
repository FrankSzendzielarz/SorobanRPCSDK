// Generated code - do not modify
// Source:

// typedef int64 SequenceNumber;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SequenceNumber
    {
        private int64 _innerValue;
        public int64 InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SequenceNumber() { }

        public SequenceNumber(int64 value)
        {
            InnerValue = value;
        }
    }
    public static partial class SequenceNumberXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SequenceNumber value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SequenceNumberXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SequenceNumber value)
        {
            int64Xdr.Encode(stream, value.InnerValue);
        }
        public static SequenceNumber Decode(XdrReader stream)
        {
            var result = new SequenceNumber();
            result.InnerValue = int64Xdr.Decode(stream);
            return result;
        }
    }
}
