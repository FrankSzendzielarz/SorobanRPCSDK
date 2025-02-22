// Generated code - do not modify
// Source:

// enum SignerKeyType
// {
//     SIGNER_KEY_TYPE_ED25519 = KEY_TYPE_ED25519,
//     SIGNER_KEY_TYPE_PRE_AUTH_TX = KEY_TYPE_PRE_AUTH_TX,
//     SIGNER_KEY_TYPE_HASH_X = KEY_TYPE_HASH_X,
//     SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD = KEY_TYPE_ED25519_SIGNED_PAYLOAD
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
    public enum SignerKeyType
    {
        SIGNER_KEY_TYPE_ED25519 = CryptoKeyType.KEY_TYPE_ED25519,
        SIGNER_KEY_TYPE_PRE_AUTH_TX = CryptoKeyType.KEY_TYPE_PRE_AUTH_TX,
        SIGNER_KEY_TYPE_HASH_X = CryptoKeyType.KEY_TYPE_HASH_X,
        SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD = CryptoKeyType.KEY_TYPE_ED25519_SIGNED_PAYLOAD,
    }

    public static partial class SignerKeyTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignerKeyType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignerKeyTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignerKeyType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SignerKeyType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SignerKeyType), value))
              throw new InvalidOperationException($"Unknown SignerKeyType value: {value}");
            return (SignerKeyType)value;
        }
    }
}
