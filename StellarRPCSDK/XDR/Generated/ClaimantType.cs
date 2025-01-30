// Generated code - do not modify
// Source:

// enum ClaimantType
// {
//     CLAIMANT_TYPE_V0 = 0
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClaimantType
    {
        CLAIMANT_TYPE_V0 = 0,
    }

    public static partial class ClaimantTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimantType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimantType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimantType), value))
              throw new InvalidOperationException($"Unknown ClaimantType value: {value}");
            return (ClaimantType)value;
        }
    }
}
