// Generated code - do not modify
// Source:

// typedef ArchivalProofNode ProofLevel<>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ProofLevel
    {
        public ArchivalProofNode[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private ArchivalProofNode[] _innerValue;

        public ProofLevel() { }

        public ProofLevel(ArchivalProofNode[] value)
        {
            InnerValue = value;
        }
        public static implicit operator ArchivalProofNode[](ProofLevel _prooflevel) => _prooflevel.InnerValue;
        public static implicit operator ProofLevel(ArchivalProofNode[] value) => new ProofLevel(value);
    }
    public static partial class ProofLevelXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ProofLevel value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ProofLevelXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ProofLevel value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    ArchivalProofNodeXdr.Encode(stream, item);
            }
        }
        public static ProofLevel Decode(XdrReader stream)
        {
            var result = new ProofLevel();
            {
                var length = stream.ReadInt();
                result.InnerValue = new ArchivalProofNode[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = ArchivalProofNodeXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
