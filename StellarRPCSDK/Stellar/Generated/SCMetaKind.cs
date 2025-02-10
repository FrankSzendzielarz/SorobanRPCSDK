// Generated code - do not modify
// Source:

// enum SCMetaKind
// {
//     SC_META_V0 = 0
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCMetaKind
    {
        SC_META_V0 = 0,
    }

    public static partial class SCMetaKindXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCMetaKind value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCMetaKindXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMetaKind value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCMetaKind Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCMetaKind), value))
              throw new InvalidOperationException($"Unknown SCMetaKind value: {value}");
            return (SCMetaKind)value;
        }
    }
}
