// Generated code - do not modify
// Source:

// enum IPAddrType
// {
//     IPv4 = 0,
//     IPv6 = 1
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum IPAddrType
    {
        IPv4 = 0,
        IPv6 = 1,
    }

    public static partial class IPAddrTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(IPAddrType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                IPAddrTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, IPAddrType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static IPAddrType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(IPAddrType), value))
              throw new InvalidOperationException($"Unknown IPAddrType value: {value}");
            return (IPAddrType)value;
        }
    }
}
