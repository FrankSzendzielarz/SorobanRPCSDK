// Generated code - do not modify
// Source:

// struct ContractEvent
// {
//     // We can use this to add more fields, or because it
//     // is first, to change ContractEvent into a union.
//     ExtensionPoint ext;
// 
//     Hash* contractID;
//     ContractEventType type;
// 
//     union switch (int v)
//     {
//     case 0:
//         struct
//         {
//             SCVal topics<>;
//             SCVal data;
//         } v0;
//     }
//     body;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ContractEvent
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

    private Hash _contractID;
    public Hash contractID
    {
        get => _contractID;
        set
        {
            _contractID = value;
        }
    }

    private ContractEventType _type;
    public ContractEventType type
    {
        get => _type;
        set
        {
            _type = value;
        }
    }

    private object _body;
    public object body
    {
        get => _body;
        set
        {
            _body = value;
        }
    }

    public ContractEvent()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ContractEventXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ContractEvent value)
    {
        value.Validate();
        ExtensionPointXdr.Encode(stream, value.ext);
        HashXdr.Encode(stream, value.contractID);
        ContractEventTypeXdr.Encode(stream, value.type);
        Xdr.Encode(stream, value.body);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ContractEvent Decode(XdrReader stream)
    {
        var result = new ContractEvent();
        result.ext = ExtensionPointXdr.Decode(stream);
        result.contractID = HashXdr.Decode(stream);
        result.type = ContractEventTypeXdr.Decode(stream);
        result.body = Xdr.Decode(stream);
        return result;
    }
}
}
