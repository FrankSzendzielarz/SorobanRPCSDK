// Generated code - do not modify
// Source:

// struct AccountEntryExtensionV1
// {
//     Liabilities liabilities;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 2:
//         AccountEntryExtensionV2 v2;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class AccountEntryExtensionV1
{
    private Liabilities _liabilities;
    public Liabilities liabilities
    {
        get => _liabilities;
        set
        {
            _liabilities = value;
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

    public AccountEntryExtensionV1()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class AccountEntryExtensionV1Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, AccountEntryExtensionV1 value)
    {
        value.Validate();
        LiabilitiesXdr.Encode(stream, value.liabilities);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static AccountEntryExtensionV1 Decode(XdrReader stream)
    {
        var result = new AccountEntryExtensionV1();
        result.liabilities = LiabilitiesXdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
