// Generated code - do not modify
// Source:

// struct LedgerCloseValueSignature
// {
//     NodeID nodeID;       // which node introduced the value
//     Signature signature; // nodeID's signature
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
    public partial class LedgerCloseValueSignature
    {
        [ProtoMember(1)]
        public NodeID nodeID
        {
            get => _nodeID;
            set
            {
                _nodeID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Node I D")]
        #endif
        private NodeID _nodeID;

        /// <summary>
        /// which node introduced the value
        /// </summary>
        [ProtoMember(2)]
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Signature")]
        #endif
        private Signature _signature;

        public LedgerCloseValueSignature()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerCloseValueSignatureXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseValueSignature value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseValueSignatureXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerCloseValueSignature DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerCloseValueSignatureXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerCloseValueSignature value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.nodeID);
            SignatureXdr.Encode(stream, value.signature);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerCloseValueSignature Decode(XdrReader stream)
        {
            var result = new LedgerCloseValueSignature();
            result.nodeID = NodeIDXdr.Decode(stream);
            result.signature = SignatureXdr.Decode(stream);
            return result;
        }
    }
}
