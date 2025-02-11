// Generated code - do not modify
// Source:

// struct ConfigSettingContractBandwidthV0
// {
//     // Maximum sum of all transaction sizes in the ledger in bytes
//     uint32 ledgerMaxTxsSizeBytes;
//     // Maximum size in bytes for a transaction
//     uint32 txMaxSizeBytes;
// 
//     // Fee for 1 KB of transaction size
//     int64 feeTxSize1KB;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// this concerns only transaction sizes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ConfigSettingContractBandwidthV0
    {
        /// <summary>
        /// Maximum sum of all transaction sizes in the ledger in bytes
        /// </summary>
        public uint32 ledgerMaxTxsSizeBytes
        {
            get => _ledgerMaxTxsSizeBytes;
            set
            {
                _ledgerMaxTxsSizeBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Max Txs Size Bytes")]
        #endif
        private uint32 _ledgerMaxTxsSizeBytes;

        /// <summary>
        /// Maximum size in bytes for a transaction
        /// </summary>
        public uint32 txMaxSizeBytes
        {
            get => _txMaxSizeBytes;
            set
            {
                _txMaxSizeBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Tx Max Size Bytes")]
        #endif
        private uint32 _txMaxSizeBytes;

        /// <summary>
        /// Fee for 1 KB of transaction size
        /// </summary>
        public int64 feeTxSize1KB
        {
            get => _feeTxSize1KB;
            set
            {
                _feeTxSize1KB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Fee Tx Size1 K B")]
        #endif
        private int64 _feeTxSize1KB;

        public ConfigSettingContractBandwidthV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigSettingContractBandwidthV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractBandwidthV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractBandwidthV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingContractBandwidthV0 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerMaxTxsSizeBytes);
            uint32Xdr.Encode(stream, value.txMaxSizeBytes);
            int64Xdr.Encode(stream, value.feeTxSize1KB);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigSettingContractBandwidthV0 Decode(XdrReader stream)
        {
            var result = new ConfigSettingContractBandwidthV0();
            result.ledgerMaxTxsSizeBytes = uint32Xdr.Decode(stream);
            result.txMaxSizeBytes = uint32Xdr.Decode(stream);
            result.feeTxSize1KB = int64Xdr.Decode(stream);
            return result;
        }
    }
}
