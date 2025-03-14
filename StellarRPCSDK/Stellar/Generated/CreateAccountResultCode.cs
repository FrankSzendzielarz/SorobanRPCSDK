// Generated code - do not modify
// Source:

// enum CreateAccountResultCode
// {
//     // codes considered as "success" for the operation
//     CREATE_ACCOUNT_SUCCESS = 0, // account was created
// 
//     // codes considered as "failure" for the operation
//     CREATE_ACCOUNT_MALFORMED = -1,   // invalid destination
//     CREATE_ACCOUNT_UNDERFUNDED = -2, // not enough funds in source account
//     CREATE_ACCOUNT_LOW_RESERVE =
//         -3, // would create an account below the min reserve
//     CREATE_ACCOUNT_ALREADY_EXIST = -4 // account already exists
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
    public enum CreateAccountResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        CREATE_ACCOUNT_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        CREATE_ACCOUNT_MALFORMED = -1,
        /// <summary>
        /// invalid destination
        /// </summary>
        CREATE_ACCOUNT_UNDERFUNDED = -2,
        /// <summary>
        /// not enough funds in source account
        /// </summary>
        CREATE_ACCOUNT_LOW_RESERVE = -3,
        /// <summary>
        /// would create an account below the min reserve
        /// </summary>
        CREATE_ACCOUNT_ALREADY_EXIST = -4,
    }

    public static partial class CreateAccountResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateAccountResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateAccountResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CreateAccountResultCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CreateAccountResultCodeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateAccountResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static CreateAccountResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(CreateAccountResultCode), value))
              throw new InvalidOperationException($"Unknown CreateAccountResultCode value: {value}");
            return (CreateAccountResultCode)value;
        }
    }
}
