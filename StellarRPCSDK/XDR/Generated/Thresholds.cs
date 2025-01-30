// Generated code - do not modify
// Source:

// typedef opaque Thresholds[4];


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Thresholds
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

        public Thresholds() { }

        public Thresholds(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class ThresholdsXdr
    {
        public static void Encode(XdrWriter stream, Thresholds value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static Thresholds Decode(XdrReader stream)
        {
            var result = new Thresholds();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
