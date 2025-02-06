// Generated code - do not modify
// Source:

// typedef opaque Value<>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Value
    {
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private byte[] _innerValue;

        public Value() { }

        public Value(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](Value _value) => _value.InnerValue;
        public static implicit operator Value(byte[] value) => new Value(value);
    }
    public static partial class ValueXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Value value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ValueXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Value value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static Value Decode(XdrReader stream)
        {
            var result = new Value();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
