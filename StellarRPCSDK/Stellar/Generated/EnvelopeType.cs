// Generated code - do not modify
// Source:

// enum EnvelopeType
// {
//     ENVELOPE_TYPE_TX_V0 = 0,
//     ENVELOPE_TYPE_SCP = 1,
//     ENVELOPE_TYPE_TX = 2,
//     ENVELOPE_TYPE_AUTH = 3,
//     ENVELOPE_TYPE_SCPVALUE = 4,
//     ENVELOPE_TYPE_TX_FEE_BUMP = 5,
//     ENVELOPE_TYPE_OP_ID = 6,
//     ENVELOPE_TYPE_POOL_REVOKE_OP_ID = 7,
//     ENVELOPE_TYPE_CONTRACT_ID = 8,
//     ENVELOPE_TYPE_SOROBAN_AUTHORIZATION = 9
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    /// <summary>
    /// the respective envelopes
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum EnvelopeType
    {
        ENVELOPE_TYPE_TX_V0 = 0,
        ENVELOPE_TYPE_SCP = 1,
        ENVELOPE_TYPE_TX = 2,
        ENVELOPE_TYPE_AUTH = 3,
        ENVELOPE_TYPE_SCPVALUE = 4,
        ENVELOPE_TYPE_TX_FEE_BUMP = 5,
        ENVELOPE_TYPE_OP_ID = 6,
        ENVELOPE_TYPE_POOL_REVOKE_OP_ID = 7,
        ENVELOPE_TYPE_CONTRACT_ID = 8,
        ENVELOPE_TYPE_SOROBAN_AUTHORIZATION = 9,
    }

    public static partial class EnvelopeTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EnvelopeType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EnvelopeTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, EnvelopeType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static EnvelopeType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(EnvelopeType), value))
              throw new InvalidOperationException($"Unknown EnvelopeType value: {value}");
            return (EnvelopeType)value;
        }
    }
}
