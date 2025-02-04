// Generated code - do not modify
// Source:

// typedef opaque AssetCode12[12];


using System;
using System.IO;

namespace Stellar.XDR {

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AssetCode12 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetCode12Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
