// Generated code - do not modify
// Source:

// enum ContractDataDurability {
//     TEMPORARY = 0,
//     PERSISTENT = 1
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ContractDataDurability
    {
        TEMPORARY = 0,
        PERSISTENT = 1,
    }

    public static partial class ContractDataDurabilityXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractDataDurability value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractDataDurabilityXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractDataDurability value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractDataDurability Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractDataDurability), value))
              throw new InvalidOperationException($"Unknown ContractDataDurability value: {value}");
            return (ContractDataDurability)value;
        }
    }
}
