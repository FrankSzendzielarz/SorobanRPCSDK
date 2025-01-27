// Generated code - do not modify
// Source:

// typedef opaque EncryptedBody<64000>;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class EncryptedBody
    {
        private byte[] _innerValue;
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64000)
                	throw new ArgumentException($"Cannot exceed 64000 bytes");
                _innerValue = value;
            }
        }

        public EncryptedBody() { }

        public EncryptedBody(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class EncryptedBodyXdr
    {
            public static void Encode(XdrWriter stream, EncryptedBody value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static EncryptedBody Decode(XdrReader stream)
        {
            var result = new EncryptedBody();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
