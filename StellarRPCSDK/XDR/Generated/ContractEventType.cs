// Generated code - do not modify
// Source:

// enum ContractEventType
// {
//     SYSTEM = 0,
//     CONTRACT = 1,
//     DIAGNOSTIC = 2
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ContractEventType
    {
        SYSTEM = 0,
        CONTRACT = 1,
        DIAGNOSTIC = 2,
    }

    public static partial class ContractEventTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractEventType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractEventType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractEventType), value))
              throw new InvalidOperationException($"Unknown ContractEventType value: {value}");
            return (ContractEventType)value;
        }
    }
}
