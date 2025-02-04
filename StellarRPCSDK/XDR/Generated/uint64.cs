// Generated code - do not modify
// Source:

// typedef unsigned hyper uint64;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class uint64
    {
        public ulong InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private ulong _innerValue;

        public uint64() { }

        public uint64(ulong value)
        {
            InnerValue = value;
        }
        public static implicit operator ulong(uint64 _uint64) => _uint64.InnerValue;
        public static implicit operator uint64(ulong value) => new uint64(value);
    }
    public static partial class uint64Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(uint64 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                uint64Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, uint64 value)
        {
            stream.WriteULong(value.InnerValue);
        }
        public static uint64 Decode(XdrReader stream)
        {
            var result = new uint64();
            result.InnerValue = stream.ReadULong();
            return result;
        }
    }
}
