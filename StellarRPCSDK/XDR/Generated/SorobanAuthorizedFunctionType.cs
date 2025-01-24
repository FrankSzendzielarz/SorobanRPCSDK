// Generated code - do not modify
// Source:

// enum SorobanAuthorizedFunctionType
// {
//     SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN = 0,
//     SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN = 1,
//     SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN = 2
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum SorobanAuthorizedFunctionType
{
    SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN = 0,
    SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN = 1,
    SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN = 2,
}

public static partial class SorobanAuthorizedFunctionTypeXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, SorobanAuthorizedFunctionType value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static SorobanAuthorizedFunctionType Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(SorobanAuthorizedFunctionType), value))
            throw new InvalidOperationException($"Unknown SorobanAuthorizedFunctionType value: {value}");
        return (SorobanAuthorizedFunctionType)value;
    }
}
}
