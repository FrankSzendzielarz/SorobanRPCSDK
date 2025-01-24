// Generated code - do not modify
// Source:

// enum ContractExecutableType
// {
//     CONTRACT_EXECUTABLE_WASM = 0,
//     CONTRACT_EXECUTABLE_STELLAR_ASSET = 1
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum ContractExecutableType
{
    CONTRACT_EXECUTABLE_WASM = 0,
    CONTRACT_EXECUTABLE_STELLAR_ASSET = 1,
}

public static partial class ContractExecutableTypeXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, ContractExecutableType value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static ContractExecutableType Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(ContractExecutableType), value))
            throw new InvalidOperationException($"Unknown ContractExecutableType value: {value}");
        return (ContractExecutableType)value;
    }
}
}
