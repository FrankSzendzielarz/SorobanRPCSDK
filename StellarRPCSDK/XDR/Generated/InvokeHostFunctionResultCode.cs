// Generated code - do not modify
// Source:

// enum InvokeHostFunctionResultCode
// {
//     // codes considered as "success" for the operation
//     INVOKE_HOST_FUNCTION_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     INVOKE_HOST_FUNCTION_MALFORMED = -1,
//     INVOKE_HOST_FUNCTION_TRAPPED = -2,
//     INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED = -3,
//     INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED = -4,
//     INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE = -5
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum InvokeHostFunctionResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        INVOKE_HOST_FUNCTION_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        INVOKE_HOST_FUNCTION_MALFORMED = -1,
        INVOKE_HOST_FUNCTION_TRAPPED = -2,
        INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED = -3,
        INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED = -4,
        INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE = -5,
    }

    public static partial class InvokeHostFunctionResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InvokeHostFunctionResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InvokeHostFunctionResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, InvokeHostFunctionResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static InvokeHostFunctionResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(InvokeHostFunctionResultCode), value))
              throw new InvalidOperationException($"Unknown InvokeHostFunctionResultCode value: {value}");
            return (InvokeHostFunctionResultCode)value;
        }
    }
}
