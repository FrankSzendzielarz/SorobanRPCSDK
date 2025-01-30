// Generated code - do not modify
// Source:

// enum SCAddressType
// {
//     SC_ADDRESS_TYPE_ACCOUNT = 0,
//     SC_ADDRESS_TYPE_CONTRACT = 1
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCAddressType
    {
        SC_ADDRESS_TYPE_ACCOUNT = 0,
        SC_ADDRESS_TYPE_CONTRACT = 1,
    }

    public static partial class SCAddressTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCAddressType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCAddressType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCAddressType), value))
              throw new InvalidOperationException($"Unknown SCAddressType value: {value}");
            return (SCAddressType)value;
        }
    }
}
