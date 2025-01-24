// Generated code - do not modify
// Source:

// struct ConfigSettingContractComputeV0
// {
//     // Maximum instructions per ledger
//     int64 ledgerMaxInstructions;
//     // Maximum instructions per transaction
//     int64 txMaxInstructions;
//     // Cost of 10000 instructions
//     int64 feeRatePerInstructionsIncrement;
// 
//     // Memory limit per transaction. Unlike instructions, there is no fee
//     // for memory, just the limit.
//     uint32 txMemoryLimit;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ConfigSettingContractComputeV0
{
    private int64 _ledgerMaxInstructions;
    public int64 ledgerMaxInstructions
    {
        get => _ledgerMaxInstructions;
        set
        {
            _ledgerMaxInstructions = value;
        }
    }

    private int64 _txMaxInstructions;
    public int64 txMaxInstructions
    {
        get => _txMaxInstructions;
        set
        {
            _txMaxInstructions = value;
        }
    }

    private int64 _feeRatePerInstructionsIncrement;
    public int64 feeRatePerInstructionsIncrement
    {
        get => _feeRatePerInstructionsIncrement;
        set
        {
            _feeRatePerInstructionsIncrement = value;
        }
    }

    private uint32 _txMemoryLimit;
    public uint32 txMemoryLimit
    {
        get => _txMemoryLimit;
        set
        {
            _txMemoryLimit = value;
        }
    }

    public ConfigSettingContractComputeV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ConfigSettingContractComputeV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ConfigSettingContractComputeV0 value)
    {
        value.Validate();
        int64Xdr.Encode(stream, value.ledgerMaxInstructions);
        int64Xdr.Encode(stream, value.txMaxInstructions);
        int64Xdr.Encode(stream, value.feeRatePerInstructionsIncrement);
        uint32Xdr.Encode(stream, value.txMemoryLimit);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ConfigSettingContractComputeV0 Decode(XdrReader stream)
    {
        var result = new ConfigSettingContractComputeV0();
        result.ledgerMaxInstructions = int64Xdr.Decode(stream);
        result.txMaxInstructions = int64Xdr.Decode(stream);
        result.feeRatePerInstructionsIncrement = int64Xdr.Decode(stream);
        result.txMemoryLimit = uint32Xdr.Decode(stream);
        return result;
    }
}
}
