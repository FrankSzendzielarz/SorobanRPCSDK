// Generated code - do not modify
// Source:

// enum PublicKeyType
// {
//     PUBLIC_KEY_TYPE_ED25519 = KEY_TYPE_ED25519
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public enum PublicKeyType
    {
        PUBLIC_KEY_TYPE_ED25519 = CryptoKeyType.KEY_TYPE_ED25519,
    }

    public static partial class PublicKeyTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PublicKeyType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PublicKeyTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, PublicKeyType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static PublicKeyType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(PublicKeyType), value))
              throw new InvalidOperationException($"Unknown PublicKeyType value: {value}");
            return (PublicKeyType)value;
        }
    }
}
