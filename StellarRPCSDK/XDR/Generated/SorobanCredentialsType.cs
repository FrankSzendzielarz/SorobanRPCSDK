// Generated code - do not modify
// Source:

// enum SorobanCredentialsType
// {
//     SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = 0,
//     SOROBAN_CREDENTIALS_ADDRESS = 1
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SorobanCredentialsType
    {
        SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = 0,
        SOROBAN_CREDENTIALS_ADDRESS = 1,
    }

    public static partial class SorobanCredentialsTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanCredentialsType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanCredentialsTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanCredentialsType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SorobanCredentialsType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SorobanCredentialsType), value))
              throw new InvalidOperationException($"Unknown SorobanCredentialsType value: {value}");
            return (SorobanCredentialsType)value;
        }
    }
}
