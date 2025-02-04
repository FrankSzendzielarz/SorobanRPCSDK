// Generated code - do not modify
// Source:

// typedef opaque DataValue<64>;


using System;
using System.IO;

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
        public static implicit operator byte[](DataValue _datavalue) => _datavalue.InnerValue;
        public static implicit operator DataValue(byte[] value) => new DataValue(value);
    }
    public static partial class DataValueXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DataValue value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DataValueXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
