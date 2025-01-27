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

namespace stellar {

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

        private object _ext;
        public object ext
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
    }
    public static partial class LedgerEntryExtensionV1Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntryExtensionV1 value)
        {
            value.Validate();
            SponsorshipDescriptorXdr.Encode(stream, value.sponsoringID);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new LedgerEntryExtensionV1();
            result.sponsoringID = SponsorshipDescriptorXdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
