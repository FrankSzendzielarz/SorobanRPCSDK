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
    public partial class AccountEntryExtensionV2
    {
        [ProtoMember(1)]
        public uint32 numSponsored
        {
            get => _numSponsored;
            set
            {
                _numSponsored = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Num Sponsored")]
        #endif
        private uint32 _numSponsored;

        [ProtoMember(2)]
        public uint32 numSponsoring
        {
            get => _numSponsoring;
            set
            {
                _numSponsoring = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Num Sponsoring")]
        #endif
        private uint32 _numSponsoring;

        [ProtoMember(3)]
        [MaxLength(20)]
        public SponsorshipDescriptor[] signerSponsoringIDs
        {
            get => _signerSponsoringIDs;
            set
            {
                if (value.Length > Constants.MAX_SIGNERS)
                	throw new ArgumentException($"Cannot exceed Constants.MAX_SIGNERS in length");
                _signerSponsoringIDs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Signer Sponsoring I Ds")]
        #endif
        private SponsorshipDescriptor[] _signerSponsoringIDs;

        [ProtoMember(4)]
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public AccountEntryExtensionV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (signerSponsoringIDs.Length > Constants.MAX_SIGNERS)
            	throw new InvalidOperationException($"signerSponsoringIDs cannot exceed Constants.MAX_SIGNERS elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "AccountEntryExtensionV2.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_3), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "AccountEntryExtensionV2.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "AccountEntryExtensionV2.extUnion.case_3")]
            public sealed partial class case_3 : extUnion
            {
                public override int Discriminator => 3;
                [ProtoMember(1)]
                public AccountEntryExtensionV3 v3
                {
                    get => _v3;
                    set
                    {
                        _v3 = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"V3")]
                #endif
                private AccountEntryExtensionV3 _v3;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                    case extUnion.case_3 case_3:
                    AccountEntryExtensionV3Xdr.Encode(stream, case_3.v3);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    case 3:
                    var result_3 = new extUnion.case_3();
                    result_3.v3 = AccountEntryExtensionV3Xdr.Decode(stream);
                    return result_3;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class AccountEntryExtensionV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountEntryExtensionV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountEntryExtensionV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            AccountEntryExtensionV2.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntryExtensionV2 Decode(XdrReader stream)
        {
            var result = new AccountEntryExtensionV2();
            result.numSponsored = uint32Xdr.Decode(stream);
            result.numSponsoring = uint32Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.signerSponsoringIDs = new SponsorshipDescriptor[length];
                for (var i = 0; i < length; i++)
                {
                    result.signerSponsoringIDs[i] = SponsorshipDescriptorXdr.Decode(stream);
                }
            }
            result.ext = AccountEntryExtensionV2.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
