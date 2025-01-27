// Generated code - do not modify
// Source:

// typedef PublicKey NodeID;


using System;

namespace stellar {

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
    }
    public static partial class NodeIDXdr
    {
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
