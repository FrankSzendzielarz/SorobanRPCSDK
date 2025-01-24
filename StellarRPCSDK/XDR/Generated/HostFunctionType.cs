// Generated code - do not modify
// Source:

// enum HostFunctionType
// {
//     HOST_FUNCTION_TYPE_INVOKE_CONTRACT = 0,
//     HOST_FUNCTION_TYPE_CREATE_CONTRACT = 1,
//     HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = 2,
//     HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = 3
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum HostFunctionType
{
    HOST_FUNCTION_TYPE_INVOKE_CONTRACT = 0,
    HOST_FUNCTION_TYPE_CREATE_CONTRACT = 1,
    HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = 2,
    HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = 3,
}

public static partial class HostFunctionTypeXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, HostFunctionType value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static HostFunctionType Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(HostFunctionType), value))
            throw new InvalidOperationException($"Unknown HostFunctionType value: {value}");
        return (HostFunctionType)value;
    }
}
}
