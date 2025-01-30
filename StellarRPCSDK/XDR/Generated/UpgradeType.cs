// Generated code - do not modify
// Source:

// typedef opaque UpgradeType<128>;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class UpgradeType
    {
        private byte[] _innerValue;
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 128)
                	throw new ArgumentException($"Cannot exceed 128 bytes");
                _innerValue = value;
            }
        }

        public UpgradeType() { }

        public UpgradeType(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class UpgradeTypeXdr
    {
        public static void Encode(XdrWriter stream, UpgradeType value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static UpgradeType Decode(XdrReader stream)
        {
            var result = new UpgradeType();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
