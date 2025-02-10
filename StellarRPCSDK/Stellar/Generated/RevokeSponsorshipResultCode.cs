// Generated code - do not modify
// Source:

// enum RevokeSponsorshipResultCode
// {
//     // codes considered as "success" for the operation
//     REVOKE_SPONSORSHIP_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     REVOKE_SPONSORSHIP_DOES_NOT_EXIST = -1,
//     REVOKE_SPONSORSHIP_NOT_SPONSOR = -2,
//     REVOKE_SPONSORSHIP_LOW_RESERVE = -3,
//     REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = -4,
//     REVOKE_SPONSORSHIP_MALFORMED = -5
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum RevokeSponsorshipResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        REVOKE_SPONSORSHIP_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        REVOKE_SPONSORSHIP_DOES_NOT_EXIST = -1,
        REVOKE_SPONSORSHIP_NOT_SPONSOR = -2,
        REVOKE_SPONSORSHIP_LOW_RESERVE = -3,
        REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = -4,
        REVOKE_SPONSORSHIP_MALFORMED = -5,
    }

    public static partial class RevokeSponsorshipResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RevokeSponsorshipResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RevokeSponsorshipResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, RevokeSponsorshipResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static RevokeSponsorshipResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(RevokeSponsorshipResultCode), value))
              throw new InvalidOperationException($"Unknown RevokeSponsorshipResultCode value: {value}");
            return (RevokeSponsorshipResultCode)value;
        }
    }
}
