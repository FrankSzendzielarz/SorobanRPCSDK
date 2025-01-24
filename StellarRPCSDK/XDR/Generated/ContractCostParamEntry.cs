// Generated code - do not modify
// Source:

// struct ContractCostParamEntry {
//     // use `ext` to add more terms (e.g. higher order polynomials) in the future
//     ExtensionPoint ext;
// 
//     int64 constTerm;
//     int64 linearTerm;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ContractCostParamEntry
{
    private ExtensionPoint _ext;
    public ExtensionPoint ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    private int64 _constTerm;
    public int64 constTerm
    {
        get => _constTerm;
        set
        {
            _constTerm = value;
        }
    }

    private int64 _linearTerm;
    public int64 linearTerm
    {
        get => _linearTerm;
        set
        {
            _linearTerm = value;
        }
    }

    public ContractCostParamEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ContractCostParamEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ContractCostParamEntry value)
    {
        value.Validate();
        ExtensionPointXdr.Encode(stream, value.ext);
        int64Xdr.Encode(stream, value.constTerm);
        int64Xdr.Encode(stream, value.linearTerm);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ContractCostParamEntry Decode(XdrReader stream)
    {
        var result = new ContractCostParamEntry();
        result.ext = ExtensionPointXdr.Decode(stream);
        result.constTerm = int64Xdr.Decode(stream);
        result.linearTerm = int64Xdr.Decode(stream);
        return result;
    }
}
}
