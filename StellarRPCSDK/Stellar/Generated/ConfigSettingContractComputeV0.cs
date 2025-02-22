// Generated code - do not modify
// Source:

// struct ConfigSettingContractComputeV0
// {
//     // Maximum instructions per ledger
//     int64 ledgerMaxInstructions;
//     // Maximum instructions per transaction
//     int64 txMaxInstructions;
//     // Cost of 10000 instructions
//     int64 feeRatePerInstructionsIncrement;
// 
//     // Memory limit per transaction. Unlike instructions, there is no fee
//     // for memory, just the limit.
//     uint32 txMemoryLimit;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// "Compute" settings for contracts (instructions and memory).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class ConfigSettingContractComputeV0
    {
        /// <summary>
        /// Maximum instructions per ledger
        /// </summary>
        [ProtoMember(1)]
        public int64 ledgerMaxInstructions
        {
            get => _ledgerMaxInstructions;
            set
            {
                _ledgerMaxInstructions = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Max Instructions")]
        #endif
        private int64 _ledgerMaxInstructions;

        /// <summary>
        /// Maximum instructions per transaction
        /// </summary>
        [ProtoMember(2)]
        public int64 txMaxInstructions
        {
            get => _txMaxInstructions;
            set
            {
                _txMaxInstructions = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Max Instructions")]
        #endif
        private int64 _txMaxInstructions;

        /// <summary>
        /// Cost of 10000 instructions
        /// </summary>
        [ProtoMember(3)]
        public int64 feeRatePerInstructionsIncrement
        {
            get => _feeRatePerInstructionsIncrement;
            set
            {
                _feeRatePerInstructionsIncrement = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Rate Per Instructions Increment")]
        #endif
        private int64 _feeRatePerInstructionsIncrement;

        /// <summary>
        /// for memory, just the limit.
        /// </summary>
        [ProtoMember(4)]
        public uint32 txMemoryLimit
        {
            get => _txMemoryLimit;
            set
            {
                _txMemoryLimit = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Memory Limit")]
        #endif
        private uint32 _txMemoryLimit;

        public ConfigSettingContractComputeV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigSettingContractComputeV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractComputeV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractComputeV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingContractComputeV0 value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.ledgerMaxInstructions);
            int64Xdr.Encode(stream, value.txMaxInstructions);
            int64Xdr.Encode(stream, value.feeRatePerInstructionsIncrement);
            uint32Xdr.Encode(stream, value.txMemoryLimit);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigSettingContractComputeV0 Decode(XdrReader stream)
        {
            var result = new ConfigSettingContractComputeV0();
            result.ledgerMaxInstructions = int64Xdr.Decode(stream);
            result.txMaxInstructions = int64Xdr.Decode(stream);
            result.feeRatePerInstructionsIncrement = int64Xdr.Decode(stream);
            result.txMemoryLimit = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
