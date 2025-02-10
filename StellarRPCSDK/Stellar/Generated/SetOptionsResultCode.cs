// Generated code - do not modify
// Source:

// enum SetOptionsResultCode
// {
//     // codes considered as "success" for the operation
//     SET_OPTIONS_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     SET_OPTIONS_LOW_RESERVE = -1,      // not enough funds to add a signer
//     SET_OPTIONS_TOO_MANY_SIGNERS = -2, // max number of signers already reached
//     SET_OPTIONS_BAD_FLAGS = -3,        // invalid combination of clear/set flags
//     SET_OPTIONS_INVALID_INFLATION = -4,      // inflation account does not exist
//     SET_OPTIONS_CANT_CHANGE = -5,            // can no longer change this option
//     SET_OPTIONS_UNKNOWN_FLAG = -6,           // can't set an unknown flag
//     SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = -7, // bad value for weight/threshold
//     SET_OPTIONS_BAD_SIGNER = -8,             // signer cannot be masterkey
//     SET_OPTIONS_INVALID_HOME_DOMAIN = -9,    // malformed home domain
//     SET_OPTIONS_AUTH_REVOCABLE_REQUIRED =
//         -10 // auth revocable is required for clawback
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SetOptionsResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        SET_OPTIONS_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        SET_OPTIONS_LOW_RESERVE = -1,
        /// <summary>
        /// not enough funds to add a signer
        /// </summary>
        SET_OPTIONS_TOO_MANY_SIGNERS = -2,
        /// <summary>
        /// max number of signers already reached
        /// </summary>
        SET_OPTIONS_BAD_FLAGS = -3,
        /// <summary>
        /// invalid combination of clear/set flags
        /// </summary>
        SET_OPTIONS_INVALID_INFLATION = -4,
        /// <summary>
        /// inflation account does not exist
        /// </summary>
        SET_OPTIONS_CANT_CHANGE = -5,
        /// <summary>
        /// can no longer change this option
        /// </summary>
        SET_OPTIONS_UNKNOWN_FLAG = -6,
        /// <summary>
        /// can't set an unknown flag
        /// </summary>
        SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = -7,
        /// <summary>
        /// bad value for weight/threshold
        /// </summary>
        SET_OPTIONS_BAD_SIGNER = -8,
        /// <summary>
        /// signer cannot be masterkey
        /// </summary>
        SET_OPTIONS_INVALID_HOME_DOMAIN = -9,
        /// <summary>
        /// malformed home domain
        /// </summary>
        SET_OPTIONS_AUTH_REVOCABLE_REQUIRED = -10,
    }

    public static partial class SetOptionsResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SetOptionsResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SetOptionsResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetOptionsResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SetOptionsResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SetOptionsResultCode), value))
              throw new InvalidOperationException($"Unknown SetOptionsResultCode value: {value}");
            return (SetOptionsResultCode)value;
        }
    }
}
