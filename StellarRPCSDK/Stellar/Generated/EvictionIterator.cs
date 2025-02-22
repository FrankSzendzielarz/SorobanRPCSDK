// Generated code - do not modify
// Source:

// struct EvictionIterator {
//     uint32 bucketListLevel;
//     bool isCurrBucket;
//     uint64 bucketFileOffset;
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
    public partial class EvictionIterator
    {
        [ProtoMember(1)]
        public uint32 bucketListLevel
        {
            get => _bucketListLevel;
            set
            {
                _bucketListLevel = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bucket List Level")]
        #endif
        private uint32 _bucketListLevel;

        [ProtoMember(2)]
        public bool isCurrBucket
        {
            get => _isCurrBucket;
            set
            {
                _isCurrBucket = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Is Curr Bucket")]
        #endif
        private bool _isCurrBucket;

        [ProtoMember(3)]
        public uint64 bucketFileOffset
        {
            get => _bucketFileOffset;
            set
            {
                _bucketFileOffset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bucket File Offset")]
        #endif
        private uint64 _bucketFileOffset;

        public EvictionIterator()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class EvictionIteratorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EvictionIterator value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EvictionIteratorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, EvictionIterator value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.bucketListLevel);
            stream.WriteInt(value.isCurrBucket ? 1 : 0);
            uint64Xdr.Encode(stream, value.bucketFileOffset);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static EvictionIterator Decode(XdrReader stream)
        {
            var result = new EvictionIterator();
            result.bucketListLevel = uint32Xdr.Decode(stream);
            result.isCurrBucket = stream.ReadInt() != 0;
            result.bucketFileOffset = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
