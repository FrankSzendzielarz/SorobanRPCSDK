// Generated code - do not modify
// Source:

// struct ConfigSettingContractHistoricalDataV0
// {
//     int64 feeHistorical1KB; // Fee for storing 1KB in archives
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ConfigSettingContractHistoricalDataV0
{
    private int64 _feeHistorical1KB;
    public int64 feeHistorical1KB
    {
        get => _feeHistorical1KB;
        set
        {
            _feeHistorical1KB = value;
        }
    }

    public ConfigSettingContractHistoricalDataV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ConfigSettingContractHistoricalDataV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ConfigSettingContractHistoricalDataV0 value)
    {
        value.Validate();
        int64Xdr.Encode(stream, value.feeHistorical1KB);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ConfigSettingContractHistoricalDataV0 Decode(XdrReader stream)
    {
        var result = new ConfigSettingContractHistoricalDataV0();
        result.feeHistorical1KB = int64Xdr.Decode(stream);
        return result;
    }
}
}
