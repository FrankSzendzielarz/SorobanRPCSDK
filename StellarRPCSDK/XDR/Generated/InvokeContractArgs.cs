// Generated code - do not modify
// Source:

// struct InvokeContractArgs {
//     SCAddress contractAddress;
//     SCSymbol functionName;
//     SCVal args<>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class InvokeContractArgs
{
    private SCAddress _contractAddress;
    public SCAddress contractAddress
    {
        get => _contractAddress;
        set
        {
            _contractAddress = value;
        }
    }

    private SCSymbol _functionName;
    public SCSymbol functionName
    {
        get => _functionName;
        set
        {
            _functionName = value;
        }
    }

    private SCVal[] _args;
    public SCVal[] args
    {
        get => _args;
        set
        {
            _args = value;
        }
    }

    public InvokeContractArgs()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class InvokeContractArgsXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, InvokeContractArgs value)
    {
        value.Validate();
        SCAddressXdr.Encode(stream, value.contractAddress);
        SCSymbolXdr.Encode(stream, value.functionName);
        stream.WriteInt(value.args.Length);
        foreach (var item in value.args)
        {
            SCValXdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static InvokeContractArgs Decode(XdrReader stream)
    {
        var result = new InvokeContractArgs();
        result.contractAddress = SCAddressXdr.Decode(stream);
        result.functionName = SCSymbolXdr.Decode(stream);
        var length = stream.ReadInt();
        result.args = new SCVal[length];
        for (var i = 0; i < length; i++)
        {
            result.args[i] = SCValXdr.Decode(stream);
        }
        return result;
    }
}
}
