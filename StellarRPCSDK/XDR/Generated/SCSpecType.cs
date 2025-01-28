// Generated code - do not modify
// Source:

// enum SCSpecType
// {
//     SC_SPEC_TYPE_VAL = 0,
// 
//     // Types with no parameters.
//     SC_SPEC_TYPE_BOOL = 1,
//     SC_SPEC_TYPE_VOID = 2,
//     SC_SPEC_TYPE_ERROR = 3,
//     SC_SPEC_TYPE_U32 = 4,
//     SC_SPEC_TYPE_I32 = 5,
//     SC_SPEC_TYPE_U64 = 6,
//     SC_SPEC_TYPE_I64 = 7,
//     SC_SPEC_TYPE_TIMEPOINT = 8,
//     SC_SPEC_TYPE_DURATION = 9,
//     SC_SPEC_TYPE_U128 = 10,
//     SC_SPEC_TYPE_I128 = 11,
//     SC_SPEC_TYPE_U256 = 12,
//     SC_SPEC_TYPE_I256 = 13,
//     SC_SPEC_TYPE_BYTES = 14,
//     SC_SPEC_TYPE_STRING = 16,
//     SC_SPEC_TYPE_SYMBOL = 17,
//     SC_SPEC_TYPE_ADDRESS = 19,
// 
//     // Types with parameters.
//     SC_SPEC_TYPE_OPTION = 1000,
//     SC_SPEC_TYPE_RESULT = 1001,
//     SC_SPEC_TYPE_VEC = 1002,
//     SC_SPEC_TYPE_MAP = 1004,
//     SC_SPEC_TYPE_TUPLE = 1005,
//     SC_SPEC_TYPE_BYTES_N = 1006,
// 
//     // User defined types.
//     SC_SPEC_TYPE_UDT = 2000
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCSpecType
    {
        SC_SPEC_TYPE_VAL = 0,
        SC_SPEC_TYPE_BOOL = 1,
        SC_SPEC_TYPE_VOID = 2,
        SC_SPEC_TYPE_ERROR = 3,
        SC_SPEC_TYPE_U32 = 4,
        SC_SPEC_TYPE_I32 = 5,
        SC_SPEC_TYPE_U64 = 6,
        SC_SPEC_TYPE_I64 = 7,
        SC_SPEC_TYPE_TIMEPOINT = 8,
        SC_SPEC_TYPE_DURATION = 9,
        SC_SPEC_TYPE_U128 = 10,
        SC_SPEC_TYPE_I128 = 11,
        SC_SPEC_TYPE_U256 = 12,
        SC_SPEC_TYPE_I256 = 13,
        SC_SPEC_TYPE_BYTES = 14,
        SC_SPEC_TYPE_STRING = 16,
        SC_SPEC_TYPE_SYMBOL = 17,
        SC_SPEC_TYPE_ADDRESS = 19,
        SC_SPEC_TYPE_OPTION = 1000,
        SC_SPEC_TYPE_RESULT = 1001,
        SC_SPEC_TYPE_VEC = 1002,
        SC_SPEC_TYPE_MAP = 1004,
        SC_SPEC_TYPE_TUPLE = 1005,
        SC_SPEC_TYPE_BYTES_N = 1006,
        SC_SPEC_TYPE_UDT = 2000,
    }

    public static partial class SCSpecTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCSpecType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCSpecType), value))
              throw new InvalidOperationException($"Unknown SCSpecType value: {value}");
            return (SCSpecType)value;
        }
    }
}
