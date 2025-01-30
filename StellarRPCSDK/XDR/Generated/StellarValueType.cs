// Generated code - do not modify
// Source:

// enum StellarValueType
// {
//     STELLAR_VALUE_BASIC = 0,
//     STELLAR_VALUE_SIGNED = 1
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum StellarValueType
    {
        STELLAR_VALUE_BASIC = 0,
        STELLAR_VALUE_SIGNED = 1,
    }

    public static partial class StellarValueTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, StellarValueType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static StellarValueType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(StellarValueType), value))
              throw new InvalidOperationException($"Unknown StellarValueType value: {value}");
            return (StellarValueType)value;
        }
    }
}
