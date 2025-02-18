// Generated code - do not modify
// Source:

// enum ContractIDPreimageType
// {
//     CONTRACT_ID_PREIMAGE_FROM_ADDRESS = 0,
//     CONTRACT_ID_PREIMAGE_FROM_ASSET = 1
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
    public enum ContractIDPreimageType
    {
        CONTRACT_ID_PREIMAGE_FROM_ADDRESS = 0,
        CONTRACT_ID_PREIMAGE_FROM_ASSET = 1,
    }

    public static partial class ContractIDPreimageTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractIDPreimageType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractIDPreimageTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractIDPreimageType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractIDPreimageType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractIDPreimageType), value))
              throw new InvalidOperationException($"Unknown ContractIDPreimageType value: {value}");
            return (ContractIDPreimageType)value;
        }
    }
}
