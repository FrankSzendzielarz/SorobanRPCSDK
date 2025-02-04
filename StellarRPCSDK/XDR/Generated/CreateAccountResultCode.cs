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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum CreateAccountResultCode
    {
        CREATE_ACCOUNT_SUCCESS = 0,
        CREATE_ACCOUNT_MALFORMED = -1,
        CREATE_ACCOUNT_UNDERFUNDED = -2,
        CREATE_ACCOUNT_LOW_RESERVE = -3,
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
