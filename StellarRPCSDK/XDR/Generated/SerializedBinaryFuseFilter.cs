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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SerializedBinaryFuseFilter
    {
        private BinaryFuseFilterType _type;
        public BinaryFuseFilterType type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }

        private ShortHashSeed _inputHashSeed;
        public ShortHashSeed inputHashSeed
        {
            get => _inputHashSeed;
            set
            {
                _inputHashSeed = value;
            }
        }

        private ShortHashSeed _filterSeed;
        public ShortHashSeed filterSeed
        {
            get => _filterSeed;
            set
            {
                _filterSeed = value;
            }
        }

        private uint32 _segmentLength;
        public uint32 segmentLength
        {
            get => _segmentLength;
            set
            {
                _segmentLength = value;
            }
        }

        private uint32 _segementLengthMask;
        public uint32 segementLengthMask
        {
            get => _segementLengthMask;
            set
            {
                _segementLengthMask = value;
            }
        }

        private uint32 _segmentCount;
        public uint32 segmentCount
        {
            get => _segmentCount;
            set
            {
                _segmentCount = value;
            }
        }

        private uint32 _segmentCountLength;
        public uint32 segmentCountLength
        {
            get => _segmentCountLength;
            set
            {
                _segmentCountLength = value;
            }
        }

        private uint32 _fingerprintLength;
        public uint32 fingerprintLength
        {
            get => _fingerprintLength;
            set
            {
                _fingerprintLength = value;
            }
        }

        private byte[] _fingerprints;
        public byte[] fingerprints
        {
            get => _fingerprints;
            set
            {
                _fingerprints = value;
            }
        }

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
