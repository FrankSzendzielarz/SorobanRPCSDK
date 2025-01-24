// Generated code - do not modify
// Source:

// enum BinaryFuseFilterType
// {
//     BINARY_FUSE_FILTER_8_BIT = 0,
//     BINARY_FUSE_FILTER_16_BIT = 1,
//     BINARY_FUSE_FILTER_32_BIT = 2
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum BinaryFuseFilterType
{
    BINARY_FUSE_FILTER_8_BIT = 0,
    BINARY_FUSE_FILTER_16_BIT = 1,
    BINARY_FUSE_FILTER_32_BIT = 2,
}

public static partial class BinaryFuseFilterTypeXdr
{
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
