// Generated code - do not modify
// Source:

// typedef opaque DataValue<64>;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DataValue
    {
        private byte[] _innerValue;
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64)
                	throw new ArgumentException($"Cannot exceed 64 bytes");
                _innerValue = value;
            }
        }

        public DataValue() { }

        public DataValue(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class DataValueXdr
    {
        public static void Encode(XdrWriter stream, DataValue value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static DataValue Decode(XdrReader stream)
        {
            var result = new DataValue();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
