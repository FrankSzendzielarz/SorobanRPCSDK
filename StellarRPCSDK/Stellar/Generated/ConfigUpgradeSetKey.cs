// Generated code - do not modify
// Source:

// struct ConfigUpgradeSetKey {
//     Hash contractID;
//     Hash contentHash;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ConfigUpgradeSetKey
    {
        public Hash contractID
        {
            get => _contractID;
            set
            {
                _contractID = value;
            }
        }
        private Hash _contractID;

        public Hash contentHash
        {
            get => _contentHash;
            set
            {
                _contentHash = value;
            }
        }
        private Hash _contentHash;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigUpgradeSetKey value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigUpgradeSetKeyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
