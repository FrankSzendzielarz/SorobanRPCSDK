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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum RestoreFootprintResultCode
    {
        RESTORE_FOOTPRINT_SUCCESS = 0,
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
