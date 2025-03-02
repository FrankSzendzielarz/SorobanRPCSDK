// Generated code - do not modify
// Source:

// enum SCPStatementType
// {
//     SCP_ST_PREPARE = 0,
//     SCP_ST_CONFIRM = 1,
//     SCP_ST_EXTERNALIZE = 2,
//     SCP_ST_NOMINATE = 3
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
    public enum SCPStatementType
    {
        SCP_ST_PREPARE = 0,
        SCP_ST_CONFIRM = 1,
        SCP_ST_EXTERNALIZE = 2,
        SCP_ST_NOMINATE = 3,
    }

    public static partial class SCPStatementTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPStatementType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPStatementTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCPStatementType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCPStatementTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPStatementType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCPStatementType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCPStatementType), value))
              throw new InvalidOperationException($"Unknown SCPStatementType value: {value}");
            return (SCPStatementType)value;
        }
    }
}
