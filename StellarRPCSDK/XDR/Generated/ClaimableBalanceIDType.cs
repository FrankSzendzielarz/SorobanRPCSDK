// Generated code - do not modify
// Source:

// enum ClaimableBalanceIDType
// {
//     CLAIMABLE_BALANCE_ID_TYPE_V0 = 0
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClaimableBalanceIDType
    {
        CLAIMABLE_BALANCE_ID_TYPE_V0 = 0,
    }

    public static partial class ClaimableBalanceIDTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimableBalanceIDType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimableBalanceIDTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceIDType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimableBalanceIDType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimableBalanceIDType), value))
              throw new InvalidOperationException($"Unknown ClaimableBalanceIDType value: {value}");
            return (ClaimableBalanceIDType)value;
        }
    }
}
