// Generated code - do not modify
// Source:

// enum RestoreFootprintResultCode
// {
//     // codes considered as "success" for the operation
//     RESTORE_FOOTPRINT_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     RESTORE_FOOTPRINT_MALFORMED = -1,
//     RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED = -2,
//     RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE = -3
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
    public enum RestoreFootprintResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        RESTORE_FOOTPRINT_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        RESTORE_FOOTPRINT_MALFORMED = -1,
        RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED = -2,
        RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE = -3,
    }

    public static partial class RestoreFootprintResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RestoreFootprintResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RestoreFootprintResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static RestoreFootprintResultCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return RestoreFootprintResultCodeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, RestoreFootprintResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static RestoreFootprintResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(RestoreFootprintResultCode), value))
              throw new InvalidOperationException($"Unknown RestoreFootprintResultCode value: {value}");
            return (RestoreFootprintResultCode)value;
        }
    }
}
