// Generated code - do not modify
// Source:

// enum SCSpecUDTUnionCaseV0Kind
// {
//     SC_SPEC_UDT_UNION_CASE_VOID_V0 = 0,
//     SC_SPEC_UDT_UNION_CASE_TUPLE_V0 = 1
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum SCSpecUDTUnionCaseV0Kind
    {
        SC_SPEC_UDT_UNION_CASE_VOID_V0 = 0,
        SC_SPEC_UDT_UNION_CASE_TUPLE_V0 = 1,
    }

    public static partial class SCSpecUDTUnionCaseV0KindXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTUnionCaseV0Kind value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTUnionCaseV0KindXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecUDTUnionCaseV0Kind DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecUDTUnionCaseV0KindXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseV0Kind value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCSpecUDTUnionCaseV0Kind Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCSpecUDTUnionCaseV0Kind), value))
              throw new InvalidOperationException($"Unknown SCSpecUDTUnionCaseV0Kind value: {value}");
            return (SCSpecUDTUnionCaseV0Kind)value;
        }
    }
}
