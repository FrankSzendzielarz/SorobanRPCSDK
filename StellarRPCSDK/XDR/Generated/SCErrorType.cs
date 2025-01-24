// Generated code - do not modify
// Source:

// enum SCErrorType
// {
//     SCE_CONTRACT = 0,          // Contract-specific, user-defined codes.
//     SCE_WASM_VM = 1,           // Errors while interpreting WASM bytecode.
//     SCE_CONTEXT = 2,           // Errors in the contract's host context.
//     SCE_STORAGE = 3,           // Errors accessing host storage.
//     SCE_OBJECT = 4,            // Errors working with host objects.
//     SCE_CRYPTO = 5,            // Errors in cryptographic operations.
//     SCE_EVENTS = 6,            // Errors while emitting events.
//     SCE_BUDGET = 7,            // Errors relating to budget limits.
//     SCE_VALUE = 8,             // Errors working with host values or SCVals.
//     SCE_AUTH = 9               // Errors from the authentication subsystem.
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum SCErrorType
{
    SCE_CONTRACT = 0,
    SCE_WASM_VM = 1,
    SCE_CONTEXT = 2,
    SCE_STORAGE = 3,
    SCE_OBJECT = 4,
    SCE_CRYPTO = 5,
    SCE_EVENTS = 6,
    SCE_BUDGET = 7,
    SCE_VALUE = 8,
    SCE_AUTH = 9,
}

public static partial class SCErrorTypeXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCErrorType value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static SCErrorType Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(SCErrorType), value))
            throw new InvalidOperationException($"Unknown SCErrorType value: {value}");
        return (SCErrorType)value;
    }
}
}
