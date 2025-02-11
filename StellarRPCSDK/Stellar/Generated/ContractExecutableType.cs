// Generated code - do not modify
// Source:

// enum ContractExecutableType
// {
//     CONTRACT_EXECUTABLE_WASM = 0,
//     CONTRACT_EXECUTABLE_STELLAR_ASSET = 1
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
    public enum ContractExecutableType
    {
        CONTRACT_EXECUTABLE_WASM = 0,
        CONTRACT_EXECUTABLE_STELLAR_ASSET = 1,
    }

    public static partial class ContractExecutableTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractExecutableType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractExecutableTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractExecutableType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractExecutableType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractExecutableType), value))
              throw new InvalidOperationException($"Unknown ContractExecutableType value: {value}");
            return (ContractExecutableType)value;
        }
    }
}
