// Generated code - do not modify
// Source:

// struct ConfigSettingContractEventsV0
// {
//     // Maximum size of events that a contract call can emit.
//     uint32 txMaxContractEventsSizeBytes;
//     // Fee for generating 1KB of contract events.
//     int64 feeContractEvents1KB;
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
    /// Contract event-related settings.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class ConfigSettingContractEventsV0
    {
        /// <summary>
        /// Maximum size of events that a contract call can emit.
        /// </summary>
        [ProtoMember(1)]
        public uint32 txMaxContractEventsSizeBytes
        {
            get => _txMaxContractEventsSizeBytes;
            set
            {
                _txMaxContractEventsSizeBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Max Contract Events Size Bytes")]
        #endif
        private uint32 _txMaxContractEventsSizeBytes;

        /// <summary>
        /// Fee for generating 1KB of contract events.
        /// </summary>
        [ProtoMember(2)]
        public int64 feeContractEvents1KB
        {
            get => _feeContractEvents1KB;
            set
            {
                _feeContractEvents1KB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Contract Events1 K B")]
        #endif
        private int64 _feeContractEvents1KB;

        public ConfigSettingContractEventsV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigSettingContractEventsV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractEventsV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractEventsV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ConfigSettingContractEventsV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ConfigSettingContractEventsV0Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingContractEventsV0 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.txMaxContractEventsSizeBytes);
            int64Xdr.Encode(stream, value.feeContractEvents1KB);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigSettingContractEventsV0 Decode(XdrReader stream)
        {
            var result = new ConfigSettingContractEventsV0();
            result.txMaxContractEventsSizeBytes = uint32Xdr.Decode(stream);
            result.feeContractEvents1KB = int64Xdr.Decode(stream);
            return result;
        }
    }
}
