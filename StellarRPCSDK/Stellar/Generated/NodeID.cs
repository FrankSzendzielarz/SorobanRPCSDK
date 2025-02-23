// Generated code - do not modify
// Source:

// typedef PublicKey NodeID;


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
    public partial class NodeID
    {
        [ProtoMember(1)]
        public PublicKey InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private PublicKey _innerValue;

        public NodeID() { }

        public NodeID(PublicKey value)
        {
            InnerValue = value;
        }
        public static implicit operator PublicKey(NodeID _nodeid) => _nodeid.InnerValue;
        public static implicit operator NodeID(PublicKey value) => new NodeID(value);
    }
    public static partial class NodeIDXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(NodeID value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                NodeIDXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static NodeID DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return NodeIDXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, NodeID value)
        {
            PublicKeyXdr.Encode(stream, value.InnerValue);
        }
        public static NodeID Decode(XdrReader stream)
        {
            var result = new NodeID();
            result.InnerValue = PublicKeyXdr.Decode(stream);
            return result;
        }
    }
}
