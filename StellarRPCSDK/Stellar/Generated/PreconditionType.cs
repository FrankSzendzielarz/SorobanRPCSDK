// Generated code - do not modify
// Source:

// enum PreconditionType
// {
//     PRECOND_NONE = 0,
//     PRECOND_TIME = 1,
//     PRECOND_V2 = 2
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
    public enum PreconditionType
    {
        PRECOND_NONE = 0,
        PRECOND_TIME = 1,
        PRECOND_V2 = 2,
    }

    public static partial class PreconditionTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PreconditionType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PreconditionTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, PreconditionType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static PreconditionType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(PreconditionType), value))
              throw new InvalidOperationException($"Unknown PreconditionType value: {value}");
            return (PreconditionType)value;
        }
    }
}
