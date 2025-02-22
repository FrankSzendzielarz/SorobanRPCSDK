// Generated code - do not modify
// Source:

// enum InflationResultCode
// {
//     // codes considered as "success" for the operation
//     INFLATION_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     INFLATION_NOT_TIME = -1
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
    public enum InflationResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        INFLATION_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        INFLATION_NOT_TIME = -1,
    }

    public static partial class InflationResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InflationResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InflationResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, InflationResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static InflationResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(InflationResultCode), value))
              throw new InvalidOperationException($"Unknown InflationResultCode value: {value}");
            return (InflationResultCode)value;
        }
    }
}
