// Generated code - do not modify
// Source:

// union SorobanCredentials switch (SorobanCredentialsType type)
// {
// case SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
//     void;
// case SOROBAN_CREDENTIALS_ADDRESS:
//     SorobanAddressCredentials address;
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
    [ProtoInclude(100, typeof(SorobanCredentialsSourceAccount), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(SorobanCredentialsAddress), DataFormat = DataFormat.Default)]
    public abstract partial class SorobanCredentials
    {
        public abstract SorobanCredentialsType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SorobanCredentials_SorobanCredentialsSourceAccount")]
        public sealed partial class SorobanCredentialsSourceAccount : SorobanCredentials
        {
            public override SorobanCredentialsType Discriminator => SorobanCredentialsType.SOROBAN_CREDENTIALS_SOURCE_ACCOUNT;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SorobanCredentials_SorobanCredentialsAddress")]
        public sealed partial class SorobanCredentialsAddress : SorobanCredentials
        {
            public override SorobanCredentialsType Discriminator => SorobanCredentialsType.SOROBAN_CREDENTIALS_ADDRESS;
            [ProtoMember(1)]
            public SorobanAddressCredentials address
            {
                get => _address;
                set
                {
                    _address = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Address")]
            #endif
            private SorobanAddressCredentials _address;

            public override void ValidateCase() {}
        }
    }
    public static partial class SorobanCredentialsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanCredentials value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanCredentialsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanCredentials DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanCredentialsXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SorobanCredentials value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanCredentials.SorobanCredentialsSourceAccount case_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
                break;
                case SorobanCredentials.SorobanCredentialsAddress case_SOROBAN_CREDENTIALS_ADDRESS:
                SorobanAddressCredentialsXdr.Encode(stream, case_SOROBAN_CREDENTIALS_ADDRESS.address);
                break;
            }
        }
        public static SorobanCredentials Decode(XdrReader stream)
        {
            var discriminator = (SorobanCredentialsType)stream.ReadInt();
            switch (discriminator)
            {
                case SorobanCredentialsType.SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
                var result_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = new SorobanCredentials.SorobanCredentialsSourceAccount();
                return result_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT;
                case SorobanCredentialsType.SOROBAN_CREDENTIALS_ADDRESS:
                var result_SOROBAN_CREDENTIALS_ADDRESS = new SorobanCredentials.SorobanCredentialsAddress();
                result_SOROBAN_CREDENTIALS_ADDRESS.address = SorobanAddressCredentialsXdr.Decode(stream);
                return result_SOROBAN_CREDENTIALS_ADDRESS;
                default:
                throw new Exception($"Unknown discriminator for SorobanCredentials: {discriminator}");
            }
        }
    }
}
