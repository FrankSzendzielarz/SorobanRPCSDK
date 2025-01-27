// Generated code - do not modify
// Source:

// struct AccountEntryExtensionV2
// {
//     uint32 numSponsored;
//     uint32 numSponsoring;
//     SponsorshipDescriptor signerSponsoringIDs<MAX_SIGNERS>;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 3:
//         AccountEntryExtensionV3 v3;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountEntryExtensionV2
    {
        private uint32 _numSponsored;
        public uint32 numSponsored
        {
            get => _numSponsored;
            set
            {
                _numSponsored = value;
            }
        }

        private uint32 _numSponsoring;
        public uint32 numSponsoring
        {
            get => _numSponsoring;
            set
            {
                _numSponsoring = value;
            }
        }

        private SponsorshipDescriptor[] _signerSponsoringIDs;
        public SponsorshipDescriptor[] signerSponsoringIDs
        {
            get => _signerSponsoringIDs;
            set
            {
                _signerSponsoringIDs = value;
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

        public AccountEntryExtensionV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AccountEntryExtensionV2Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountEntryExtensionV2 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.numSponsored);
            uint32Xdr.Encode(stream, value.numSponsoring);
            stream.WriteInt(value.signerSponsoringIDs.Length);
            foreach (var item in value.signerSponsoringIDs)
            {
                    SponsorshipDescriptorXdr.Encode(stream, item);
            }
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntryExtensionV2 Decode(XdrReader stream)
        {
            var result = new AccountEntryExtensionV2();
            result.numSponsored = uint32Xdr.Decode(stream);
            result.numSponsoring = uint32Xdr.Decode(stream);
            var length = stream.ReadInt();
            result.signerSponsoringIDs = new SponsorshipDescriptor[length];
            for (var i = 0; i < length; i++)
            {
                result.signerSponsoringIDs[i] = SponsorshipDescriptorXdr.Decode(stream);
            }
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
