// Generated code - do not modify
// Source:

// enum AssetType
// {
//     ASSET_TYPE_NATIVE = 0,
//     ASSET_TYPE_CREDIT_ALPHANUM4 = 1,
//     ASSET_TYPE_CREDIT_ALPHANUM12 = 2,
//     ASSET_TYPE_POOL_SHARE = 3
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
    public enum AssetType
    {
        ASSET_TYPE_NATIVE = 0,
        ASSET_TYPE_CREDIT_ALPHANUM4 = 1,
        ASSET_TYPE_CREDIT_ALPHANUM12 = 2,
        ASSET_TYPE_POOL_SHARE = 3,
    }

    public static partial class AssetTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AssetType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, AssetType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static AssetType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(AssetType), value))
              throw new InvalidOperationException($"Unknown AssetType value: {value}");
            return (AssetType)value;
        }
    }
}
