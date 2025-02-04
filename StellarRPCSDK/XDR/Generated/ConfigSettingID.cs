// Generated code - do not modify
// Source:

// enum ConfigSettingID
// {
//     CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES = 0,
//     CONFIG_SETTING_CONTRACT_COMPUTE_V0 = 1,
//     CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 = 2,
//     CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 = 3,
//     CONFIG_SETTING_CONTRACT_EVENTS_V0 = 4,
//     CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 = 5,
//     CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS = 6,
//     CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES = 7,
//     CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES = 8,
//     CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES = 9,
//     CONFIG_SETTING_STATE_ARCHIVAL = 10,
//     CONFIG_SETTING_CONTRACT_EXECUTION_LANES = 11,
//     CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW = 12,
//     CONFIG_SETTING_EVICTION_ITERATOR = 13
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ConfigSettingID
    {
        CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES = 0,
        CONFIG_SETTING_CONTRACT_COMPUTE_V0 = 1,
        CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 = 2,
        CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 = 3,
        CONFIG_SETTING_CONTRACT_EVENTS_V0 = 4,
        CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 = 5,
        CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS = 6,
        CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES = 7,
        CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES = 8,
        CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES = 9,
        CONFIG_SETTING_STATE_ARCHIVAL = 10,
        CONFIG_SETTING_CONTRACT_EXECUTION_LANES = 11,
        CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW = 12,
        CONFIG_SETTING_EVICTION_ITERATOR = 13,
    }

    public static partial class ConfigSettingIDXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingID value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingIDXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingID value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ConfigSettingID Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ConfigSettingID), value))
              throw new InvalidOperationException($"Unknown ConfigSettingID value: {value}");
            return (ConfigSettingID)value;
        }
    }
}
