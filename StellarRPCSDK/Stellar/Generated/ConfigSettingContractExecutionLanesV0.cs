// Generated code - do not modify
// Source:

// struct ConfigSettingContractExecutionLanesV0
// {
//     // maximum number of Soroban transactions per ledger
//     uint32 ledgerMaxTxCount;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    /// <summary>
    /// General “Soroban execution lane” settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ConfigSettingContractExecutionLanesV0
    {
        /// <summary>
        /// maximum number of Soroban transactions per ledger
        /// </summary>
        public uint32 ledgerMaxTxCount
        {
            get => _ledgerMaxTxCount;
            set
            {
                _ledgerMaxTxCount = value;
            }
        }
        private uint32 _ledgerMaxTxCount;

        public ConfigSettingContractExecutionLanesV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigSettingContractExecutionLanesV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractExecutionLanesV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractExecutionLanesV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingContractExecutionLanesV0 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerMaxTxCount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigSettingContractExecutionLanesV0 Decode(XdrReader stream)
        {
            var result = new ConfigSettingContractExecutionLanesV0();
            result.ledgerMaxTxCount = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
