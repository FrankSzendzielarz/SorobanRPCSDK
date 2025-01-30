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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum InflationResultCode
    {
        INFLATION_SUCCESS = 0,
        INFLATION_NOT_TIME = -1,
    }

    public static partial class InflationResultCodeXdr
    {
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
