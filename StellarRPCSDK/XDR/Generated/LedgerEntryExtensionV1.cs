// Generated code - do not modify
// Source:

// struct LedgerEntryExtensionV1
// {
//     SponsorshipDescriptor sponsoringID;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerEntryExtensionV1
    {
        private SponsorshipDescriptor _sponsoringID;
        public SponsorshipDescriptor sponsoringID
        {
            get => _sponsoringID;
            set
            {
                _sponsoringID = value;
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

        public LedgerEntryExtensionV1()
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
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LedgerEntryExtensionV1Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntryExtensionV1 value)
        {
            value.Validate();
            SponsorshipDescriptorXdr.Encode(stream, value.sponsoringID);
            LedgerEntryExtensionV1.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new LedgerEntryExtensionV1();
            result.sponsoringID = SponsorshipDescriptorXdr.Decode(stream);
            result.ext = LedgerEntryExtensionV1.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
