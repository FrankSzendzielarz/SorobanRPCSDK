// Generated code - do not modify
// Source:

// typedef PublicKey NodeID;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class NodeID
    {
        private PublicKey _innerValue;
        public PublicKey InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

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
