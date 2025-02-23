// Generated code - do not modify
// Source:

// enum ErrorCode
// {
//     ERR_MISC = 0, // Unspecific error
//     ERR_DATA = 1, // Malformed data
//     ERR_CONF = 2, // Misconfiguration error
//     ERR_AUTH = 3, // Authentication failure
//     ERR_LOAD = 4  // System overloaded
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
    public enum ErrorCode
    {
        ERR_MISC = 0,
        /// <summary>
        /// Unspecific error
        /// </summary>
        ERR_DATA = 1,
        /// <summary>
        /// Malformed data
        /// </summary>
        ERR_CONF = 2,
        /// <summary>
        /// Misconfiguration error
        /// </summary>
        ERR_AUTH = 3,
        /// <summary>
        /// Authentication failure
        /// </summary>
        ERR_LOAD = 4,
    }

    public static partial class ErrorCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ErrorCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ErrorCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ErrorCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ErrorCodeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ErrorCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ErrorCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ErrorCode), value))
              throw new InvalidOperationException($"Unknown ErrorCode value: {value}");
            return (ErrorCode)value;
        }
    }
}
