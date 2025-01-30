// Generated code - do not modify
// Source:

// typedef int64 SequenceNumber;


using System;

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
