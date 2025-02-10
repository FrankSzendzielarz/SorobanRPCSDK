// Generated code - do not modify
// Source:

// enum SCAddressType
// {
//     SC_ADDRESS_TYPE_ACCOUNT = 0,
//     SC_ADDRESS_TYPE_CONTRACT = 1
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCAddressType
    {
        SC_ADDRESS_TYPE_ACCOUNT = 0,
        SC_ADDRESS_TYPE_CONTRACT = 1,
    }

    public static partial class SCAddressTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCAddressType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCAddressTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCAddressType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCAddressType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCAddressType), value))
              throw new InvalidOperationException($"Unknown SCAddressType value: {value}");
            return (SCAddressType)value;
        }
    }
}
