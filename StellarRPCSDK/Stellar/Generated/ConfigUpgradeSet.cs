// Generated code - do not modify
// Source:

// struct ConfigUpgradeSet {
//     ConfigSettingEntry updatedEntry<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class ConfigUpgradeSet
    {
        [ProtoMember(1)]
        public ConfigSettingEntry[] updatedEntry
        {
            get => _updatedEntry;
            set
            {
                _updatedEntry = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Updated Entry")]
        #endif
        private ConfigSettingEntry[] _updatedEntry;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigUpgradeSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigUpgradeSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ConfigUpgradeSet DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ConfigUpgradeSetXdr.Decode(reader);
            }
        }
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
