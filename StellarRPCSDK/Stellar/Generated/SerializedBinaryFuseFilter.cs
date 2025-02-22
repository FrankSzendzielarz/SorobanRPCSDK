// Generated code - do not modify
// Source:

// struct SerializedBinaryFuseFilter
// {
//     BinaryFuseFilterType type;
// 
//     // Seed used to hash input to filter
//     ShortHashSeed inputHashSeed;
// 
//     // Seed used for internal filter hash operations
//     ShortHashSeed filterSeed;
//     uint32 segmentLength;
//     uint32 segementLengthMask;
//     uint32 segmentCount;
//     uint32 segmentCountLength;
//     uint32 fingerprintLength; // Length in terms of element count, not bytes
// 
//     // Array of uint8_t, uint16_t, or uint32_t depending on filter type
//     opaque fingerprints<>;
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
    public partial class SerializedBinaryFuseFilter
    {
        [ProtoMember(1)]
        public BinaryFuseFilterType type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Type")]
        #endif
        private BinaryFuseFilterType _type;

        /// <summary>
        /// Seed used to hash input to filter
        /// </summary>
        [ProtoMember(2)]
        public ShortHashSeed inputHashSeed
        {
            get => _inputHashSeed;
            set
            {
                _inputHashSeed = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Input Hash Seed")]
        #endif
        private ShortHashSeed _inputHashSeed;

        /// <summary>
        /// Seed used for internal filter hash operations
        /// </summary>
        [ProtoMember(3)]
        public ShortHashSeed filterSeed
        {
            get => _filterSeed;
            set
            {
                _filterSeed = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Filter Seed")]
        #endif
        private ShortHashSeed _filterSeed;

        [ProtoMember(4)]
        public uint32 segmentLength
        {
            get => _segmentLength;
            set
            {
                _segmentLength = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Segment Length")]
        #endif
        private uint32 _segmentLength;

        [ProtoMember(5)]
        public uint32 segementLengthMask
        {
            get => _segementLengthMask;
            set
            {
                _segementLengthMask = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Segement Length Mask")]
        #endif
        private uint32 _segementLengthMask;

        [ProtoMember(6)]
        public uint32 segmentCount
        {
            get => _segmentCount;
            set
            {
                _segmentCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Segment Count")]
        #endif
        private uint32 _segmentCount;

        [ProtoMember(7)]
        public uint32 segmentCountLength
        {
            get => _segmentCountLength;
            set
            {
                _segmentCountLength = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Segment Count Length")]
        #endif
        private uint32 _segmentCountLength;

        [ProtoMember(8)]
        public uint32 fingerprintLength
        {
            get => _fingerprintLength;
            set
            {
                _fingerprintLength = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fingerprint Length")]
        #endif
        private uint32 _fingerprintLength;

        /// <summary>
        /// Array of uint8_t, uint16_t, or uint32_t depending on filter type
        /// </summary>
        [ProtoMember(9)]
        public byte[] fingerprints
        {
            get => _fingerprints;
            set
            {
                _fingerprints = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fingerprints")]
        #endif
        private byte[] _fingerprints;

        public SerializedBinaryFuseFilter()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SerializedBinaryFuseFilterXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SerializedBinaryFuseFilter value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SerializedBinaryFuseFilterXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SerializedBinaryFuseFilter value)
        {
            value.Validate();
            BinaryFuseFilterTypeXdr.Encode(stream, value.type);
            ShortHashSeedXdr.Encode(stream, value.inputHashSeed);
            ShortHashSeedXdr.Encode(stream, value.filterSeed);
            uint32Xdr.Encode(stream, value.segmentLength);
            uint32Xdr.Encode(stream, value.segementLengthMask);
            uint32Xdr.Encode(stream, value.segmentCount);
            uint32Xdr.Encode(stream, value.segmentCountLength);
            uint32Xdr.Encode(stream, value.fingerprintLength);
            stream.WriteOpaque(value.fingerprints);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SerializedBinaryFuseFilter Decode(XdrReader stream)
        {
            var result = new SerializedBinaryFuseFilter();
            result.type = BinaryFuseFilterTypeXdr.Decode(stream);
            result.inputHashSeed = ShortHashSeedXdr.Decode(stream);
            result.filterSeed = ShortHashSeedXdr.Decode(stream);
            result.segmentLength = uint32Xdr.Decode(stream);
            result.segementLengthMask = uint32Xdr.Decode(stream);
            result.segmentCount = uint32Xdr.Decode(stream);
            result.segmentCountLength = uint32Xdr.Decode(stream);
            result.fingerprintLength = uint32Xdr.Decode(stream);
            result.fingerprints = stream.ReadOpaque();
            return result;
        }
    }
}
