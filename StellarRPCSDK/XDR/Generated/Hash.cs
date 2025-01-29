// Generated code - do not modify
// Source:

// typedef opaque Hash[32];


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Hash
    {
        private byte[] _innerValue = new byte[32];
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 bytes");
                _innerValue = value;
            }
        }

        public Hash() { }

        public Hash(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class HashXdr
    {
        public static void Encode(XdrWriter stream, Hash value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static Hash Decode(XdrReader stream)
        {
            var result = new Hash();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
