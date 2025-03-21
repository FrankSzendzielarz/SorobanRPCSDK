// Generated code - do not modify
// Source:

// struct ColdArchiveBoundaryLeaf
// {
//     uint32 index;
//     bool isLowerBound;
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
    public partial class ColdArchiveBoundaryLeaf
    {
        [ProtoMember(1)]
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
        	[SerializeReference]
        	[InspectorName(@"Index")]
        #endif
        private uint32 _index;

        [ProtoMember(2)]
        public bool isLowerBound
        {
            get => _isLowerBound;
            set
            {
                _isLowerBound = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Is Lower Bound")]
        #endif
        private bool _isLowerBound;

        public ColdArchiveBoundaryLeaf()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveBoundaryLeafXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveBoundaryLeaf value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveBoundaryLeafXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ColdArchiveBoundaryLeaf DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ColdArchiveBoundaryLeafXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveBoundaryLeaf value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            stream.WriteInt(value.isLowerBound ? 1 : 0);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveBoundaryLeaf Decode(XdrReader stream)
        {
            var result = new ColdArchiveBoundaryLeaf();
            result.index = uint32Xdr.Decode(stream);
            result.isLowerBound = stream.ReadInt() != 0;
            return result;
        }
    }
}
