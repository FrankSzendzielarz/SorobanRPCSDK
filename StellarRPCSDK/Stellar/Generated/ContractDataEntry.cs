// Generated code - do not modify
// Source:

// struct ContractDataEntry {
//     ExtensionPoint ext;
// 
//     SCAddress contract;
//     SCVal key;
//     ContractDataDurability durability;
//     SCVal val;
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
    public partial class ContractDataEntry
    {
        [ProtoMember(1)]
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private ExtensionPoint _ext;

        [ProtoMember(2)]
        public SCAddress contract
        {
            get => _contract;
            set
            {
                _contract = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Contract")]
        #endif
        private SCAddress _contract;

        [ProtoMember(3)]
        public SCVal key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Key")]
        #endif
        private SCVal _key;

        [ProtoMember(4)]
        public ContractDataDurability durability
        {
            get => _durability;
            set
            {
                _durability = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Durability")]
        #endif
        private ContractDataDurability _durability;

        [ProtoMember(5)]
        public SCVal val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Val")]
        #endif
        private SCVal _val;

        public ContractDataEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ContractDataEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractDataEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractDataEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractDataEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractDataEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractDataEntry value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            SCAddressXdr.Encode(stream, value.contract);
            SCValXdr.Encode(stream, value.key);
            ContractDataDurabilityXdr.Encode(stream, value.durability);
            SCValXdr.Encode(stream, value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractDataEntry Decode(XdrReader stream)
        {
            var result = new ContractDataEntry();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.contract = SCAddressXdr.Decode(stream);
            result.key = SCValXdr.Decode(stream);
            result.durability = ContractDataDurabilityXdr.Decode(stream);
            result.val = SCValXdr.Decode(stream);
            return result;
        }
    }
}
