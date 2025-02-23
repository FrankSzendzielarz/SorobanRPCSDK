// Generated code - do not modify
// Source:

// union ContractIDPreimage switch (ContractIDPreimageType type)
// {
// case CONTRACT_ID_PREIMAGE_FROM_ADDRESS:
//     struct
//     {
//         SCAddress address;
//         uint256 salt;
//     } fromAddress;
// case CONTRACT_ID_PREIMAGE_FROM_ASSET:
//     Asset fromAsset;
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
    [ProtoInclude(100, typeof(ContractIdPreimageFromAddress), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ContractIdPreimageFromAsset), DataFormat = DataFormat.Default)]
    public abstract partial class ContractIDPreimage
    {
        public abstract ContractIDPreimageType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "ContractIDPreimage.fromAddressStruct")]
        public partial class fromAddressStruct
        {
            [ProtoMember(1)]
            public SCAddress address
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
            private SCAddress _address;

            [ProtoMember(2)]
            public uint256 salt
            {
                get => _salt;
                set
                {
                    _salt = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Salt")]
            #endif
            private uint256 _salt;

            public fromAddressStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class fromAddressStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(fromAddressStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    fromAddressStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static fromAddressStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return fromAddressStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, fromAddressStruct value)
            {
                value.Validate();
                SCAddressXdr.Encode(stream, value.address);
                uint256Xdr.Encode(stream, value.salt);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static fromAddressStruct Decode(XdrReader stream)
            {
                var result = new fromAddressStruct();
                result.address = SCAddressXdr.Decode(stream);
                result.salt = uint256Xdr.Decode(stream);
                return result;
            }
        }
        [System.Serializable]
        [ProtoContract(Name = "ContractIDPreimage.ContractIdPreimageFromAddress")]
        public sealed partial class ContractIdPreimageFromAddress : ContractIDPreimage
        {
            public override ContractIDPreimageType Discriminator => ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
            [ProtoMember(1)]
            public fromAddressStruct fromAddress
            {
                get => _fromAddress;
                set
                {
                    _fromAddress = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"From Address")]
            #endif
            private fromAddressStruct _fromAddress;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ContractIDPreimage.ContractIdPreimageFromAsset")]
        public sealed partial class ContractIdPreimageFromAsset : ContractIDPreimage
        {
            public override ContractIDPreimageType Discriminator => ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ASSET;
            [ProtoMember(2)]
            public Asset fromAsset
            {
                get => _fromAsset;
                set
                {
                    _fromAsset = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"From Asset")]
            #endif
            private Asset _fromAsset;

            public override void ValidateCase() {}
        }
    }
    public static partial class ContractIDPreimageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractIDPreimage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractIDPreimageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractIDPreimage DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractIDPreimageXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ContractIDPreimage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ContractIDPreimage.ContractIdPreimageFromAddress case_CONTRACT_ID_PREIMAGE_FROM_ADDRESS:
                ContractIDPreimage.fromAddressStructXdr.Encode(stream, case_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.fromAddress);
                break;
                case ContractIDPreimage.ContractIdPreimageFromAsset case_CONTRACT_ID_PREIMAGE_FROM_ASSET:
                AssetXdr.Encode(stream, case_CONTRACT_ID_PREIMAGE_FROM_ASSET.fromAsset);
                break;
            }
        }
        public static ContractIDPreimage Decode(XdrReader stream)
        {
            var discriminator = (ContractIDPreimageType)stream.ReadInt();
            switch (discriminator)
            {
                case ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ADDRESS:
                var result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS = new ContractIDPreimage.ContractIdPreimageFromAddress();
                result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.fromAddress = ContractIDPreimage.fromAddressStructXdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
                case ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ASSET:
                var result_CONTRACT_ID_PREIMAGE_FROM_ASSET = new ContractIDPreimage.ContractIdPreimageFromAsset();
                result_CONTRACT_ID_PREIMAGE_FROM_ASSET.fromAsset = AssetXdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ASSET;
                default:
                throw new Exception($"Unknown discriminator for ContractIDPreimage: {discriminator}");
            }
        }
    }
}
