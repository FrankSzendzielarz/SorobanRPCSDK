// Generated code - do not modify
// Source:

// enum PublicKeyType
// {
//     PUBLIC_KEY_TYPE_ED25519 = KEY_TYPE_ED25519
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum PublicKeyType
    {
        PUBLIC_KEY_TYPE_ED25519 = CryptoKeyType.KEY_TYPE_ED25519,
    }

    public static partial class PublicKeyTypeXdr
    {
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
