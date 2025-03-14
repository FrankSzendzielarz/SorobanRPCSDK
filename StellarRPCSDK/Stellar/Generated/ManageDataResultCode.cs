// Generated code - do not modify
// Source:

// enum ManageDataResultCode
// {
//     // codes considered as "success" for the operation
//     MANAGE_DATA_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     MANAGE_DATA_NOT_SUPPORTED_YET =
//         -1, // The network hasn't moved to this protocol change yet
//     MANAGE_DATA_NAME_NOT_FOUND =
//         -2, // Trying to remove a Data Entry that isn't there
//     MANAGE_DATA_LOW_RESERVE = -3, // not enough funds to create a new Data Entry
//     MANAGE_DATA_INVALID_NAME = -4 // Name not a valid string
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
    public enum ManageDataResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        MANAGE_DATA_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        MANAGE_DATA_NOT_SUPPORTED_YET = -1,
        /// <summary>
        /// The network hasn't moved to this protocol change yet
        /// </summary>
        MANAGE_DATA_NAME_NOT_FOUND = -2,
        /// <summary>
        /// Trying to remove a Data Entry that isn't there
        /// </summary>
        MANAGE_DATA_LOW_RESERVE = -3,
        /// <summary>
        /// not enough funds to create a new Data Entry
        /// </summary>
        MANAGE_DATA_INVALID_NAME = -4,
    }

    public static partial class ManageDataResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageDataResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageDataResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ManageDataResultCode DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ManageDataResultCodeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageDataResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ManageDataResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ManageDataResultCode), value))
              throw new InvalidOperationException($"Unknown ManageDataResultCode value: {value}");
            return (ManageDataResultCode)value;
        }
    }
}
