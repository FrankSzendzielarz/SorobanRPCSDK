// Generated code - do not modify
// Source:

// enum ClawbackResultCode
// {
//     // codes considered as "success" for the operation
//     CLAWBACK_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     CLAWBACK_MALFORMED = -1,
//     CLAWBACK_NOT_CLAWBACK_ENABLED = -2,
//     CLAWBACK_NO_TRUST = -3,
//     CLAWBACK_UNDERFUNDED = -4
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
    public enum ClawbackResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        CLAWBACK_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        CLAWBACK_MALFORMED = -1,
        CLAWBACK_NOT_CLAWBACK_ENABLED = -2,
        CLAWBACK_NO_TRUST = -3,
        CLAWBACK_UNDERFUNDED = -4,
    }

    public static partial class ClawbackResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClawbackResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClawbackResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClawbackResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClawbackResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClawbackResultCode), value))
              throw new InvalidOperationException($"Unknown ClawbackResultCode value: {value}");
            return (ClawbackResultCode)value;
        }
    }
}
