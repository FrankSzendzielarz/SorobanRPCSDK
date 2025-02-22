// Generated code - do not modify
// Source:

// struct AccountEntryExtensionV1
// {
//     Liabilities liabilities;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 2:
//         AccountEntryExtensionV2 v2;
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
    public partial class AccountEntryExtensionV1
    {
        [ProtoMember(1)]
        public Liabilities liabilities
        {
            get => _liabilities;
            set
            {
                _liabilities = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Liabilities")]
        #endif
        private Liabilities _liabilities;

        [ProtoMember(2)]
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

        public AccountEntryExtensionV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "AccountEntryExtensionV1.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_2), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "AccountEntryExtensionV1.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "AccountEntryExtensionV1.extUnion.case_2")]
            public sealed partial class case_2 : extUnion
            {
                public override int Discriminator => 2;
                [ProtoMember(1)]
                public AccountEntryExtensionV2 v2
                {
                    get => _v2;
                    set
                    {
                        _v2 = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"V2")]
                #endif
                private AccountEntryExtensionV2 _v2;

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
                    case extUnion.case_2 case_2:
                    AccountEntryExtensionV2Xdr.Encode(stream, case_2.v2);
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
                    case 2:
                    var result_2 = new extUnion.case_2();
                    result_2.v2 = AccountEntryExtensionV2Xdr.Decode(stream);
                    return result_2;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class AccountEntryExtensionV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountEntryExtensionV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountEntryExtensionV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountEntryExtensionV1 value)
        {
            value.Validate();
            LiabilitiesXdr.Encode(stream, value.liabilities);
            AccountEntryExtensionV1.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new AccountEntryExtensionV1();
            result.liabilities = LiabilitiesXdr.Decode(stream);
            result.ext = AccountEntryExtensionV1.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
