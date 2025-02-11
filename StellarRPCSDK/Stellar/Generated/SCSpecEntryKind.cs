// Generated code - do not modify
// Source:

// enum SCSpecEntryKind
// {
//     SC_SPEC_ENTRY_FUNCTION_V0 = 0,
//     SC_SPEC_ENTRY_UDT_STRUCT_V0 = 1,
//     SC_SPEC_ENTRY_UDT_UNION_V0 = 2,
//     SC_SPEC_ENTRY_UDT_ENUM_V0 = 3,
//     SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0 = 4
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public enum SCSpecEntryKind
    {
        SC_SPEC_ENTRY_FUNCTION_V0 = 0,
        SC_SPEC_ENTRY_UDT_STRUCT_V0 = 1,
        SC_SPEC_ENTRY_UDT_UNION_V0 = 2,
        SC_SPEC_ENTRY_UDT_ENUM_V0 = 3,
        SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0 = 4,
    }

    public static partial class SCSpecEntryKindXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecEntryKind value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecEntryKindXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecEntryKind value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCSpecEntryKind Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCSpecEntryKind), value))
              throw new InvalidOperationException($"Unknown SCSpecEntryKind value: {value}");
            return (SCSpecEntryKind)value;
        }
    }
}
