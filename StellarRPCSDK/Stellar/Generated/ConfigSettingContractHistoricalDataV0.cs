// Generated code - do not modify
// Source:

// struct ConfigSettingContractHistoricalDataV0
// {
//     int64 feeHistorical1KB; // Fee for storing 1KB in archives
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// Historical data (pushed to core archives) settings for contracts.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ConfigSettingContractHistoricalDataV0
    {
        public int64 feeHistorical1KB
        {
            get => _feeHistorical1KB;
            set
            {
                _feeHistorical1KB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Historical1 K B")]
        #endif
        private int64 _feeHistorical1KB;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractHistoricalDataV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractHistoricalDataV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
