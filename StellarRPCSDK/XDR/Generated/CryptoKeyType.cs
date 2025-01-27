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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum CryptoKeyType
    {
        KEY_TYPE_ED25519 = 0,
        KEY_TYPE_PRE_AUTH_TX = 1,
        KEY_TYPE_HASH_X = 2,
        KEY_TYPE_ED25519_SIGNED_PAYLOAD = 3,
        KEY_TYPE_MUXED_ED25519 = 0x100,
    }

    public static partial class CryptoKeyTypeXdr
    {
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
