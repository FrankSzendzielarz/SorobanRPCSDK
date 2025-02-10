// Generated code - do not modify
// Source:

// typedef int int32;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class int32
    {
        public int InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private int _innerValue;

        public int32() { }

        public int32(int value)
        {
            InnerValue = value;
        }
        public static implicit operator int(int32 _int32) => _int32.InnerValue;
        public static implicit operator int32(int value) => new int32(value);
    }
    public static partial class int32Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(int32 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                int32Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, int32 value)
        {
            stream.WriteInt(value.InnerValue);
        }
        public static int32 Decode(XdrReader stream)
        {
            var result = new int32();
            result.InnerValue = stream.ReadInt();
            return result;
        }
    }
}
