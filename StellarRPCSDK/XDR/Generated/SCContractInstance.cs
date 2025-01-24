// Generated code - do not modify
// Source:

// struct SCContractInstance {
//     ContractExecutable executable;
//     SCMap* storage;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCContractInstance
{
    private ContractExecutable _executable;
    public ContractExecutable executable
    {
        get => _executable;
        set
        {
            _executable = value;
        }
    }

    private SCMap _storage;
    public SCMap storage
    {
        get => _storage;
        set
        {
            _storage = value;
        }
    }

    public SCContractInstance()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SCContractInstanceXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCContractInstance value)
    {
        value.Validate();
        ContractExecutableXdr.Encode(stream, value.executable);
        SCMapXdr.Encode(stream, value.storage);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCContractInstance Decode(XdrReader stream)
    {
        var result = new SCContractInstance();
        result.executable = ContractExecutableXdr.Decode(stream);
        result.storage = SCMapXdr.Decode(stream);
        return result;
    }
}
}
