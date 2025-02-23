// Generated code - do not modify
// Source:

// enum CreateClaimableBalanceResultCode
// {
//     CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
//     CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
//     CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
//     CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
//     CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
//     CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5
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
    public enum CreateClaimableBalanceResultCode
    {
        CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
        CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
        CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
        CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
        CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
        CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5,
    }

    public static partial class CreateClaimableBalanceResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateClaimableBalanceResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateClaimableBalanceResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CreateClaimableBalanceResultCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CreateClaimableBalanceResultCodeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static CreateClaimableBalanceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(CreateClaimableBalanceResultCode), value))
              throw new InvalidOperationException($"Unknown CreateClaimableBalanceResultCode value: {value}");
            return (CreateClaimableBalanceResultCode)value;
        }
    }
}
