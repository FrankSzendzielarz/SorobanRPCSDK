// Generated code - do not modify
// Source:

// typedef opaque AssetCode4[4];


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AssetCode4
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

        public AssetCode4() { }

        public AssetCode4(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class AssetCode4Xdr
    {
        public static void Encode(XdrWriter stream, AssetCode4 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static AssetCode4 Decode(XdrReader stream)
        {
            var result = new AssetCode4();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
