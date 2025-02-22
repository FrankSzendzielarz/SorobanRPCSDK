// Generated code - do not modify
// Source:

// enum SCErrorCode
// {
//     SCEC_ARITH_DOMAIN = 0,      // Some arithmetic was undefined (overflow, divide-by-zero).
//     SCEC_INDEX_BOUNDS = 1,      // Something was indexed beyond its bounds.
//     SCEC_INVALID_INPUT = 2,     // User provided some otherwise-bad data.
//     SCEC_MISSING_VALUE = 3,     // Some value was required but not provided.
//     SCEC_EXISTING_VALUE = 4,    // Some value was provided where not allowed.
//     SCEC_EXCEEDED_LIMIT = 5,    // Some arbitrary limit -- gas or otherwise -- was hit.
//     SCEC_INVALID_ACTION = 6,    // Data was valid but action requested was not.
//     SCEC_INTERNAL_ERROR = 7,    // The host detected an error in its own logic.
//     SCEC_UNEXPECTED_TYPE = 8,   // Some type wasn't as expected.
//     SCEC_UNEXPECTED_SIZE = 9    // Something's size wasn't as expected.
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
    public enum SCErrorCode
    {
        SCEC_ARITH_DOMAIN = 0,
        /// <summary>
        /// Some arithmetic was undefined (overflow, divide-by-zero).
        /// </summary>
        SCEC_INDEX_BOUNDS = 1,
        /// <summary>
        /// Something was indexed beyond its bounds.
        /// </summary>
        SCEC_INVALID_INPUT = 2,
        /// <summary>
        /// User provided some otherwise-bad data.
        /// </summary>
        SCEC_MISSING_VALUE = 3,
        /// <summary>
        /// Some value was required but not provided.
        /// </summary>
        SCEC_EXISTING_VALUE = 4,
        /// <summary>
        /// Some value was provided where not allowed.
        /// </summary>
        SCEC_EXCEEDED_LIMIT = 5,
        /// <summary>
        /// Some arbitrary limit -- gas or otherwise -- was hit.
        /// </summary>
        SCEC_INVALID_ACTION = 6,
        /// <summary>
        /// Data was valid but action requested was not.
        /// </summary>
        SCEC_INTERNAL_ERROR = 7,
        /// <summary>
        /// The host detected an error in its own logic.
        /// </summary>
        SCEC_UNEXPECTED_TYPE = 8,
        /// <summary>
        /// Some type wasn't as expected.
        /// </summary>
        SCEC_UNEXPECTED_SIZE = 9,
    }

    public static partial class SCErrorCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCErrorCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCErrorCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCErrorCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCErrorCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCErrorCode), value))
              throw new InvalidOperationException($"Unknown SCErrorCode value: {value}");
            return (SCErrorCode)value;
        }
    }
}
