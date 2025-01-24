// Generated code - do not modify
// Source:

// struct InvokeHostFunctionSuccessPreImage
// {
//     SCVal returnValue;
//     ContractEvent events<>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class InvokeHostFunctionSuccessPreImage
{
    private SCVal _returnValue;
    public SCVal returnValue
    {
        get => _returnValue;
        set
        {
            _returnValue = value;
        }
    }

    private ContractEvent[] _events;
    public ContractEvent[] events
    {
        get => _events;
        set
        {
            _events = value;
        }
    }

    public InvokeHostFunctionSuccessPreImage()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class InvokeHostFunctionSuccessPreImageXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, InvokeHostFunctionSuccessPreImage value)
    {
        value.Validate();
        SCValXdr.Encode(stream, value.returnValue);
        stream.WriteInt(value.events.Length);
        foreach (var item in value.events)
        {
            ContractEventXdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static InvokeHostFunctionSuccessPreImage Decode(XdrReader stream)
    {
        var result = new InvokeHostFunctionSuccessPreImage();
        result.returnValue = SCValXdr.Decode(stream);
        var length = stream.ReadInt();
        result.events = new ContractEvent[length];
        for (var i = 0; i < length; i++)
        {
            result.events[i] = ContractEventXdr.Decode(stream);
        }
        return result;
    }
}
}
