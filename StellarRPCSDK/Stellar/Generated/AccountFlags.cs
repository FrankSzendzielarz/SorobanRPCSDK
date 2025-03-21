// Generated code - do not modify
// Source:

// enum AccountFlags
// { // masks for each flag
// 
//     // Flags set on issuer accounts
//     // TrustLines are created with authorized set to "false" requiring
//     // the issuer to set it for each TrustLine
//     AUTH_REQUIRED_FLAG = 0x1,
//     // If set, the authorized flag in TrustLines can be cleared
//     // otherwise, authorization cannot be revoked
//     AUTH_REVOCABLE_FLAG = 0x2,
//     // Once set, causes all AUTH_* flags to be read-only
//     AUTH_IMMUTABLE_FLAG = 0x4,
//     // Trustlines are created with clawback enabled set to "true",
//     // and claimable balances created from those trustlines are created
//     // with clawback enabled set to "true"
//     AUTH_CLAWBACK_ENABLED_FLAG = 0x8
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum AccountFlags
    {
        /// <summary>
        /// the issuer to set it for each TrustLine
        /// </summary>
        AUTH_REQUIRED_FLAG = 1,
        /// <summary>
        /// otherwise, authorization cannot be revoked
        /// </summary>
        AUTH_REVOCABLE_FLAG = 2,
        /// <summary>
        /// Once set, causes all AUTH_* flags to be read-only
        /// </summary>
        AUTH_IMMUTABLE_FLAG = 4,
        /// <summary>
        /// with clawback enabled set to "true"
        /// </summary>
        AUTH_CLAWBACK_ENABLED_FLAG = 8,
    }

    public static partial class AccountFlagsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountFlags value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountFlagsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AccountFlags DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AccountFlagsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static AccountFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(AccountFlags), value))
              throw new InvalidOperationException($"Unknown AccountFlags value: {value}");
            return (AccountFlags)value;
        }
    }
}
