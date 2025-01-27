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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ErrorCode
    {
        ERR_MISC = 0,
        ERR_DATA = 1,
        ERR_CONF = 2,
        ERR_AUTH = 3,
        ERR_LOAD = 4,
    }

    public static partial class ErrorCodeXdr
    {
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
