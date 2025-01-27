// Generated code - do not modify
// Source:

// typedef opaque AssetCode12[12];


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AssetCode12
    {
        private byte[] _innerValue = new byte[12];
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 12)
                	throw new ArgumentException($"Must be exactly 12 bytes");
                _innerValue = value;
            }
        }

        public AssetCode12() { }

        public AssetCode12(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class AssetCode12Xdr
    {
            public static void Encode(XdrWriter stream, AssetCode12 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static AssetCode12 Decode(XdrReader stream)
        {
            var result = new AssetCode12();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
