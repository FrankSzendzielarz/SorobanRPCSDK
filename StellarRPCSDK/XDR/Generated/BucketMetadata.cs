// Generated code - do not modify
// Source:

// struct BucketMetadata
// {
//     // Indicates the protocol version used to create / merge this bucket.
//     uint32 ledgerVersion;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         BucketListType bucketListType;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class BucketMetadata
    {
        private uint32 _ledgerVersion;
        public uint32 ledgerVersion
        {
            get => _ledgerVersion;
            set
            {
                _ledgerVersion = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public BucketMetadata()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private BucketListType _bucketListType;
            public BucketListType bucketListType
            {
                get => _bucketListType;
                set
                {
                    _bucketListType = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
                    BucketListTypeXdr.Encode(stream, case_1.bucketListType);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.bucketListType = BucketListTypeXdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class BucketMetadataXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, BucketMetadata value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerVersion);
            BucketMetadata.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static BucketMetadata Decode(XdrReader stream)
        {
            var result = new BucketMetadata();
            result.ledgerVersion = uint32Xdr.Decode(stream);
            result.ext = BucketMetadata.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
