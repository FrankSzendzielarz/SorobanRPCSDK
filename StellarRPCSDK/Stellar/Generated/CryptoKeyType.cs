// Generated code - do not modify
// Source:

// enum CryptoKeyType
// {
//     KEY_TYPE_ED25519 = 0,
//     KEY_TYPE_PRE_AUTH_TX = 1,
//     KEY_TYPE_HASH_X = 2,
//     KEY_TYPE_ED25519_SIGNED_PAYLOAD = 3,
//     // MUXED enum values for supported type are derived from the enum values
//     // above by ORing them with 0x100
//     KEY_TYPE_MUXED_ED25519 = 0x100
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
    public enum CryptoKeyType
    {
        KEY_TYPE_ED25519 = 0,
        KEY_TYPE_PRE_AUTH_TX = 1,
        KEY_TYPE_HASH_X = 2,
        KEY_TYPE_ED25519_SIGNED_PAYLOAD = 3,
        /// <summary>
        /// above by ORing them with 0x100
        /// </summary>
        KEY_TYPE_MUXED_ED25519 = 256,
    }

    public static partial class CryptoKeyTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CryptoKeyType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CryptoKeyTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CryptoKeyType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CryptoKeyTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, CryptoKeyType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static CryptoKeyType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(CryptoKeyType), value))
              throw new InvalidOperationException($"Unknown CryptoKeyType value: {value}");
            return (CryptoKeyType)value;
        }
    }
}
