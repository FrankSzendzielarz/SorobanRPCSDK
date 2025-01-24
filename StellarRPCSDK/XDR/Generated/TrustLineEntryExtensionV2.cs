// Generated code - do not modify
// Source:

// struct TrustLineEntryExtensionV2
// {
//     int32 liquidityPoolUseCount;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TrustLineEntryExtensionV2
{
    private int32 _liquidityPoolUseCount;
    public int32 liquidityPoolUseCount
    {
        get => _liquidityPoolUseCount;
        set
        {
            _liquidityPoolUseCount = value;
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

    public TrustLineEntryExtensionV2()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TrustLineEntryExtensionV2Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TrustLineEntryExtensionV2 value)
    {
        value.Validate();
        int32Xdr.Encode(stream, value.liquidityPoolUseCount);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TrustLineEntryExtensionV2 Decode(XdrReader stream)
    {
        var result = new TrustLineEntryExtensionV2();
        result.liquidityPoolUseCount = int32Xdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
