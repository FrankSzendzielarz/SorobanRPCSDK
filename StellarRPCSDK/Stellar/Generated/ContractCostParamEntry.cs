// Generated code - do not modify
// Source:

// struct ContractCostParamEntry {
//     // use `ext` to add more terms (e.g. higher order polynomials) in the future
//     ExtensionPoint ext;
// 
//     int64 constTerm;
//     int64 linearTerm;
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
    public partial class ContractCostParamEntry
    {
        /// <summary>
        /// use `ext` to add more terms (e.g. higher order polynomials) in the future
        /// </summary>
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
        public int64 constTerm
        {
            get => _constTerm;
            set
            {
                _constTerm = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Const Term")]
        #endif
        private int64 _constTerm;

        [ProtoMember(3)]
        public int64 linearTerm
        {
            get => _linearTerm;
            set
            {
                _linearTerm = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Linear Term")]
        #endif
        private int64 _linearTerm;

        public ContractCostParamEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ContractCostParamEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractCostParamEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractCostParamEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractCostParamEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractCostParamEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCostParamEntry value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            int64Xdr.Encode(stream, value.constTerm);
            int64Xdr.Encode(stream, value.linearTerm);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractCostParamEntry Decode(XdrReader stream)
        {
            var result = new ContractCostParamEntry();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.constTerm = int64Xdr.Decode(stream);
            result.linearTerm = int64Xdr.Decode(stream);
            return result;
        }
    }
}
