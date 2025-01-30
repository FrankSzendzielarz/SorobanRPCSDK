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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SetOptionsResultCode
    {
        SET_OPTIONS_SUCCESS = 0,
        SET_OPTIONS_LOW_RESERVE = -1,
        SET_OPTIONS_TOO_MANY_SIGNERS = -2,
        SET_OPTIONS_BAD_FLAGS = -3,
        SET_OPTIONS_INVALID_INFLATION = -4,
        SET_OPTIONS_CANT_CHANGE = -5,
        SET_OPTIONS_UNKNOWN_FLAG = -6,
        SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = -7,
        SET_OPTIONS_BAD_SIGNER = -8,
        SET_OPTIONS_INVALID_HOME_DOMAIN = -9,
        SET_OPTIONS_AUTH_REVOCABLE_REQUIRED = -10,
    }

    public static partial class SetOptionsResultCodeXdr
    {
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
