// Generated code - do not modify
// Source:

// union SCAddress switch (SCAddressType type)
// {
// case SC_ADDRESS_TYPE_ACCOUNT:
//     AccountID accountId;
// case SC_ADDRESS_TYPE_CONTRACT:
//     Hash contractId;
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
    [ProtoInclude(100, typeof(ScAddressTypeAccount), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ScAddressTypeContract), DataFormat = DataFormat.Default)]
    public abstract partial class SCAddress
    {
        public abstract SCAddressType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SCAddress_ScAddressTypeAccount")]
        public sealed partial class ScAddressTypeAccount : SCAddress
        {
            public override SCAddressType Discriminator => SCAddressType.SC_ADDRESS_TYPE_ACCOUNT;
            [ProtoMember(1)]
            public AccountID accountId
            {
                get => _accountId;
                set
                {
                    _accountId = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Account Id")]
            #endif
            private AccountID _accountId;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCAddress_ScAddressTypeContract")]
        public sealed partial class ScAddressTypeContract : SCAddress
        {
            public override SCAddressType Discriminator => SCAddressType.SC_ADDRESS_TYPE_CONTRACT;
            [ProtoMember(2)]
            public Hash contractId
            {
                get => _contractId;
                set
                {
                    _contractId = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Id")]
            #endif
            private Hash _contractId;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCAddressXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCAddress value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCAddressXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCAddress DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCAddressXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SCAddress value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCAddress.ScAddressTypeAccount case_SC_ADDRESS_TYPE_ACCOUNT:
                AccountIDXdr.Encode(stream, case_SC_ADDRESS_TYPE_ACCOUNT.accountId);
                break;
                case SCAddress.ScAddressTypeContract case_SC_ADDRESS_TYPE_CONTRACT:
                HashXdr.Encode(stream, case_SC_ADDRESS_TYPE_CONTRACT.contractId);
                break;
            }
        }
        public static SCAddress Decode(XdrReader stream)
        {
            var discriminator = (SCAddressType)stream.ReadInt();
            switch (discriminator)
            {
                case SCAddressType.SC_ADDRESS_TYPE_ACCOUNT:
                var result_SC_ADDRESS_TYPE_ACCOUNT = new SCAddress.ScAddressTypeAccount();
                result_SC_ADDRESS_TYPE_ACCOUNT.accountId = AccountIDXdr.Decode(stream);
                return result_SC_ADDRESS_TYPE_ACCOUNT;
                case SCAddressType.SC_ADDRESS_TYPE_CONTRACT:
                var result_SC_ADDRESS_TYPE_CONTRACT = new SCAddress.ScAddressTypeContract();
                result_SC_ADDRESS_TYPE_CONTRACT.contractId = HashXdr.Decode(stream);
                return result_SC_ADDRESS_TYPE_CONTRACT;
                default:
                throw new Exception($"Unknown discriminator for SCAddress: {discriminator}");
            }
        }
    }
}
