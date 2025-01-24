// Generated code - do not modify
// Source:

// struct ConfigSettingContractEventsV0
// {
//     // Maximum size of events that a contract call can emit.
//     uint32 txMaxContractEventsSizeBytes;
//     // Fee for generating 1KB of contract events.
//     int64 feeContractEvents1KB;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ConfigSettingContractEventsV0
{
    private uint32 _txMaxContractEventsSizeBytes;
    public uint32 txMaxContractEventsSizeBytes
    {
        get => _txMaxContractEventsSizeBytes;
        set
        {
            _txMaxContractEventsSizeBytes = value;
        }
    }

    private int64 _feeContractEvents1KB;
    public int64 feeContractEvents1KB
    {
        get => _feeContractEvents1KB;
        set
        {
            _feeContractEvents1KB = value;
        }
    }

    public ConfigSettingContractEventsV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ConfigSettingContractEventsV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ConfigSettingContractEventsV0 value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.txMaxContractEventsSizeBytes);
        int64Xdr.Encode(stream, value.feeContractEvents1KB);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ConfigSettingContractEventsV0 Decode(XdrReader stream)
    {
        var result = new ConfigSettingContractEventsV0();
        result.txMaxContractEventsSizeBytes = uint32Xdr.Decode(stream);
        result.feeContractEvents1KB = int64Xdr.Decode(stream);
        return result;
    }
}
}
