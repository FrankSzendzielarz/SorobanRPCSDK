// Generated code - do not modify
// Source:

// struct LedgerCloseValueSignature
// {
//     NodeID nodeID;       // which node introduced the value
//     Signature signature; // nodeID's signature
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerCloseValueSignature
    {
        private NodeID _nodeID;
        public NodeID nodeID
        {
            get => _nodeID;
            set
            {
                _nodeID = value;
            }
        }

        private Signature _signature;
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }

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
