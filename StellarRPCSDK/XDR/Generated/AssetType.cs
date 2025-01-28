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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum AssetType
    {
        ASSET_TYPE_NATIVE = 0,
        ASSET_TYPE_CREDIT_ALPHANUM4 = 1,
        ASSET_TYPE_CREDIT_ALPHANUM12 = 2,
        ASSET_TYPE_POOL_SHARE = 3,
    }

    public static partial class AssetTypeXdr
    {
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
