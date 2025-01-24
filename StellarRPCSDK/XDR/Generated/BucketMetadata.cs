// Generated code - do not modify
// Source:

// struct BucketMetadata
// {
//     // Indicates the protocol version used to create / merge this bucket.
//     uint32 ledgerVersion;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         BucketListType bucketListType;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class BucketMetadata
{
    private uint32 _ledgerVersion;
    public uint32 ledgerVersion
    {
        get => _ledgerVersion;
        set
        {
            _ledgerVersion = value;
        }
    }

    private object _ext;
    public object ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    public BucketMetadata()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class BucketMetadataXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, BucketMetadata value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.ledgerVersion);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static BucketMetadata Decode(XdrReader stream)
    {
        var result = new BucketMetadata();
        result.ledgerVersion = uint32Xdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
