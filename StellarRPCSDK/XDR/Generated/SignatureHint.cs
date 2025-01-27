// Generated code - do not modify
// Source:

// typedef opaque SignatureHint[4];


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignatureHint
    {
        private byte[] _innerValue = new byte[4];
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 4)
                	throw new ArgumentException($"Must be exactly 4 bytes");
                _innerValue = value;
            }
        }

        public SignatureHint() { }

        public SignatureHint(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class SignatureHintXdr
    {
            public static void Encode(XdrWriter stream, SignatureHint value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static SignatureHint Decode(XdrReader stream)
        {
            var result = new SignatureHint();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
