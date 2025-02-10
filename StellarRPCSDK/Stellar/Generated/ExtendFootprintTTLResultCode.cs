// Generated code - do not modify
// Source:

// enum ExtendFootprintTTLResultCode
// {
//     // codes considered as "success" for the operation
//     EXTEND_FOOTPRINT_TTL_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     EXTEND_FOOTPRINT_TTL_MALFORMED = -1,
//     EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED = -2,
//     EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE = -3
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ExtendFootprintTTLResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        EXTEND_FOOTPRINT_TTL_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        EXTEND_FOOTPRINT_TTL_MALFORMED = -1,
        EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED = -2,
        EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE = -3,
    }

    public static partial class ExtendFootprintTTLResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ExtendFootprintTTLResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ExtendFootprintTTLResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ExtendFootprintTTLResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ExtendFootprintTTLResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ExtendFootprintTTLResultCode), value))
              throw new InvalidOperationException($"Unknown ExtendFootprintTTLResultCode value: {value}");
            return (ExtendFootprintTTLResultCode)value;
        }
    }
}
