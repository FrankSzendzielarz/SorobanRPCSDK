// Generated code - do not modify
// Source:

// enum BinaryFuseFilterType
// {
//     BINARY_FUSE_FILTER_8_BIT = 0,
//     BINARY_FUSE_FILTER_16_BIT = 1,
//     BINARY_FUSE_FILTER_32_BIT = 2
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
    public enum BinaryFuseFilterType
    {
        BINARY_FUSE_FILTER_8_BIT = 0,
        BINARY_FUSE_FILTER_16_BIT = 1,
        BINARY_FUSE_FILTER_32_BIT = 2,
    }

    public static partial class BinaryFuseFilterTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BinaryFuseFilterType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BinaryFuseFilterTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static BinaryFuseFilterType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return BinaryFuseFilterTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, BinaryFuseFilterType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static BinaryFuseFilterType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(BinaryFuseFilterType), value))
              throw new InvalidOperationException($"Unknown BinaryFuseFilterType value: {value}");
            return (BinaryFuseFilterType)value;
        }
    }
}
