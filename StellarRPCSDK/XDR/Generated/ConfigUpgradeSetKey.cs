// Generated code - do not modify
// Source:

// struct ConfigUpgradeSetKey {
//     Hash contractID;
//     Hash contentHash;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ConfigUpgradeSetKey
{
    private Hash _contractID;
    public Hash contractID
    {
        get => _contractID;
        set
        {
            _contractID = value;
        }
    }

    private Hash _contentHash;
    public Hash contentHash
    {
        get => _contentHash;
        set
        {
            _contentHash = value;
        }
    }

    public ConfigUpgradeSetKey()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ConfigUpgradeSetKeyXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ConfigUpgradeSetKey value)
    {
        value.Validate();
        HashXdr.Encode(stream, value.contractID);
        HashXdr.Encode(stream, value.contentHash);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ConfigUpgradeSetKey Decode(XdrReader stream)
    {
        var result = new ConfigUpgradeSetKey();
        result.contractID = HashXdr.Decode(stream);
        result.contentHash = HashXdr.Decode(stream);
        return result;
    }
}
}
