// Generated code - do not modify
// Source:

// enum SCPStatementType
// {
//     SCP_ST_PREPARE = 0,
//     SCP_ST_CONFIRM = 1,
//     SCP_ST_EXTERNALIZE = 2,
//     SCP_ST_NOMINATE = 3
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCPStatementType
    {
        SCP_ST_PREPARE = 0,
        SCP_ST_CONFIRM = 1,
        SCP_ST_EXTERNALIZE = 2,
        SCP_ST_NOMINATE = 3,
    }

    public static partial class SCPStatementTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPStatementType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCPStatementType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCPStatementType), value))
              throw new InvalidOperationException($"Unknown SCPStatementType value: {value}");
            return (SCPStatementType)value;
        }
    }
}
