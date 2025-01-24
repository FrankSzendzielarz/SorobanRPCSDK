// Generated code - do not modify
// Source:

// struct DiagnosticEvent
// {
//     bool inSuccessfulContractCall;
//     ContractEvent event;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class DiagnosticEvent
{
    private bool _inSuccessfulContractCall;
    public bool inSuccessfulContractCall
    {
        get => _inSuccessfulContractCall;
        set
        {
            _inSuccessfulContractCall = value;
        }
    }

    private ContractEvent __event;
    public ContractEvent _event
    {
        get => __event;
        set
        {
            __event = value;
        }
    }

    public DiagnosticEvent()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class DiagnosticEventXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, DiagnosticEvent value)
    {
        value.Validate();
        stream.WriteInt(value.inSuccessfulContractCall ? 1 : 0);
        ContractEventXdr.Encode(stream, value._event);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static DiagnosticEvent Decode(XdrReader stream)
    {
        var result = new DiagnosticEvent();
        result.inSuccessfulContractCall = stream.ReadInt() != 0;
        result._event = ContractEventXdr.Decode(stream);
        return result;
    }
}
}
