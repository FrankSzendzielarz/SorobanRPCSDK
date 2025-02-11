// Generated code - do not modify
// Source:

// enum ClaimableBalanceFlags
// {
//     // If set, the issuer account of the asset held by the claimable balance may
//     // clawback the claimable balance
//     CLAIMABLE_BALANCE_CLAWBACK_ENABLED_FLAG = 0x1
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public enum ClaimableBalanceFlags
    {
        /// <summary>
        /// clawback the claimable balance
        /// </summary>
        CLAIMABLE_BALANCE_CLAWBACK_ENABLED_FLAG = 1,
    }

    public static partial class ClaimableBalanceFlagsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimableBalanceFlags value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimableBalanceFlagsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimableBalanceFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimableBalanceFlags), value))
              throw new InvalidOperationException($"Unknown ClaimableBalanceFlags value: {value}");
            return (ClaimableBalanceFlags)value;
        }
    }
}
