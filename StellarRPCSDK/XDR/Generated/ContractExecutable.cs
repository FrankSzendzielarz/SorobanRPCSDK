// Generated code - do not modify
// Source:

// union ContractExecutable switch (ContractExecutableType type)
// {
// case CONTRACT_EXECUTABLE_WASM:
//     Hash wasm_hash;
// case CONTRACT_EXECUTABLE_STELLAR_ASSET:
//     void;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class ContractExecutable
{
    public abstract ContractExecutableType Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class ContractExecutable_CONTRACT_EXECUTABLE_WASM : ContractExecutable
{
    public override ContractExecutableType Discriminator => CONTRACT_EXECUTABLE_WASM;
    private Hash _wasm_hash;
    public Hash wasm_hash
    {
        get => _wasm_hash;
        set
        {
            _wasm_hash = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ContractExecutable_CONTRACT_EXECUTABLE_STELLAR_ASSET : ContractExecutable
{
    public override ContractExecutableType Discriminator => CONTRACT_EXECUTABLE_STELLAR_ASSET;

    public override void ValidateCase() {}
}

public static partial class ContractExecutableXdr
{
    public static void Encode(XdrWriter stream, ContractExecutable value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case ContractExecutable_CONTRACT_EXECUTABLE_WASM case_CONTRACT_EXECUTABLE_WASM:
                HashXdr.Encode(stream, case_CONTRACT_EXECUTABLE_WASM.wasm_hash);
                break;
            case ContractExecutable_CONTRACT_EXECUTABLE_STELLAR_ASSET case_CONTRACT_EXECUTABLE_STELLAR_ASSET:
                break;
        }
    }
    public static ContractExecutable Decode(XdrReader stream)
    {
        var discriminator = (ContractExecutableType)stream.ReadInt();
        switch (discriminator)
        {
            case CONTRACT_EXECUTABLE_WASM:
                var result_CONTRACT_EXECUTABLE_WASM = new ContractExecutable_CONTRACT_EXECUTABLE_WASM();
                result_CONTRACT_EXECUTABLE_WASM.wasm_hash = HashXdr.Decode(stream);
                return result_CONTRACT_EXECUTABLE_WASM;
            case CONTRACT_EXECUTABLE_STELLAR_ASSET:
                var result_CONTRACT_EXECUTABLE_STELLAR_ASSET = new ContractExecutable_CONTRACT_EXECUTABLE_STELLAR_ASSET();
                return result_CONTRACT_EXECUTABLE_STELLAR_ASSET;
            default:
                throw new Exception($"Unknown discriminator for ContractExecutable: {discriminator}");
        }
    }
}
}
