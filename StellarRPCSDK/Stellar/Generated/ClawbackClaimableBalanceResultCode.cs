// Generated code - do not modify
// Source:

// enum ClawbackClaimableBalanceResultCode
// {
//     // codes considered as "success" for the operation
//     CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
//     CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = -2,
//     CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = -3
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
    public enum ClawbackClaimableBalanceResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
        CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = -2,
        CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = -3,
    }

    public static partial class ClawbackClaimableBalanceResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClawbackClaimableBalanceResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClawbackClaimableBalanceResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClawbackClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClawbackClaimableBalanceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClawbackClaimableBalanceResultCode), value))
              throw new InvalidOperationException($"Unknown ClawbackClaimableBalanceResultCode value: {value}");
            return (ClawbackClaimableBalanceResultCode)value;
        }
    }
}
