// Generated code - do not modify
// Source:

// struct ConfigUpgradeSet {
//     ConfigSettingEntry updatedEntry<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ConfigUpgradeSet
    {
        private ConfigSettingEntry[] _updatedEntry;
        public ConfigSettingEntry[] updatedEntry
        {
            get => _updatedEntry;
            set
            {
                _updatedEntry = value;
            }
        }

        public ConfigUpgradeSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigUpgradeSetXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigUpgradeSet value)
        {
            value.Validate();
            stream.WriteInt(value.updatedEntry.Length);
            foreach (var item in value.updatedEntry)
            {
                    ConfigSettingEntryXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigUpgradeSet Decode(XdrReader stream)
        {
            var result = new ConfigUpgradeSet();
            {
                var length = stream.ReadInt();
                result.updatedEntry = new ConfigSettingEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.updatedEntry[i] = ConfigSettingEntryXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
