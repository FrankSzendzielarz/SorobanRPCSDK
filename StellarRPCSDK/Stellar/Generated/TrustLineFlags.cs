// Generated code - do not modify
// Source:

// enum TrustLineFlags
// {
//     // issuer has authorized account to perform transactions with its credit
//     AUTHORIZED_FLAG = 1,
//     // issuer has authorized account to maintain and reduce liabilities for its
//     // credit
//     AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG = 2,
//     // issuer has specified that it may clawback its credit, and that claimable
//     // balances created with its credit may also be clawed back
//     TRUSTLINE_CLAWBACK_ENABLED_FLAG = 4
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum TrustLineFlags
    {
        /// <summary>
        /// issuer has authorized account to perform transactions with its credit
        /// </summary>
        AUTHORIZED_FLAG = 1,
        /// <summary>
        /// credit
        /// </summary>
        AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG = 2,
        /// <summary>
        /// balances created with its credit may also be clawed back
        /// </summary>
        TRUSTLINE_CLAWBACK_ENABLED_FLAG = 4,
    }

    public static partial class TrustLineFlagsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TrustLineFlags value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TrustLineFlagsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, TrustLineFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static TrustLineFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(TrustLineFlags), value))
              throw new InvalidOperationException($"Unknown TrustLineFlags value: {value}");
            return (TrustLineFlags)value;
        }
    }
}
