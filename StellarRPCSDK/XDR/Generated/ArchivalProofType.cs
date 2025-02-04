// Generated code - do not modify
// Source:

// enum ArchivalProofType
// {
//     EXISTENCE = 0,
//     NONEXISTENCE = 1
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ArchivalProofType
    {
        EXISTENCE = 0,
        NONEXISTENCE = 1,
    }

    public static partial class ArchivalProofTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ArchivalProofType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ArchivalProofTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ArchivalProofType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ArchivalProofType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ArchivalProofType), value))
              throw new InvalidOperationException($"Unknown ArchivalProofType value: {value}");
            return (ArchivalProofType)value;
        }
    }
}
