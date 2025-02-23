// Generated code - do not modify
// Source:

// struct BumpSequenceOp
// {
//     SequenceNumber bumpTo;
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
    public partial class BumpSequenceOp
    {
        [ProtoMember(1)]
        public SequenceNumber bumpTo
        {
            get => _bumpTo;
            set
            {
                _bumpTo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bump To")]
        #endif
        private SequenceNumber _bumpTo;

        public BumpSequenceOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class BumpSequenceOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BumpSequenceOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BumpSequenceOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static BumpSequenceOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return BumpSequenceOpXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, BumpSequenceOp value)
        {
            value.Validate();
            SequenceNumberXdr.Encode(stream, value.bumpTo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static BumpSequenceOp Decode(XdrReader stream)
        {
            var result = new BumpSequenceOp();
            result.bumpTo = SequenceNumberXdr.Decode(stream);
            return result;
        }
    }
}
