// Generated code - do not modify
// Source:

// enum ContractEventType
// {
//     SYSTEM = 0,
//     CONTRACT = 1,
//     DIAGNOSTIC = 2
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ContractEventType
    {
        SYSTEM = 0,
        CONTRACT = 1,
        DIAGNOSTIC = 2,
    }

    public static partial class ContractEventTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractEventType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractEventTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractEventType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractEventType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractEventType), value))
              throw new InvalidOperationException($"Unknown ContractEventType value: {value}");
            return (ContractEventType)value;
        }
    }
}
