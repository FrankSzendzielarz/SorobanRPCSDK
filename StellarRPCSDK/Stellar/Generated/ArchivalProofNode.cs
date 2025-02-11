// Generated code - do not modify
// Source:

// struct ArchivalProofNode
// {
//     uint32 index;
//     Hash hash;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ArchivalProofNode
    {
        public uint32 index
        {
            get => _index;
            set
            {
                _index = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Index")]
        #endif
        private uint32 _index;

        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Hash")]
        #endif
        private Hash _hash;

        public ArchivalProofNode()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ArchivalProofNodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ArchivalProofNode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ArchivalProofNodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ArchivalProofNode value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            HashXdr.Encode(stream, value.hash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ArchivalProofNode Decode(XdrReader stream)
        {
            var result = new ArchivalProofNode();
            result.index = uint32Xdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            return result;
        }
    }
}
