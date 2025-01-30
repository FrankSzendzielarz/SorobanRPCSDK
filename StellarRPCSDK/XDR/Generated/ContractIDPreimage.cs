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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ContractIDPreimage
    {
        public abstract ContractIDPreimageType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class fromAddressStruct
        {
            private SCAddress _address;
            public SCAddress address
            {
                get => _address;
                set
                {
                    _address = value;
                }
            }

            private uint256 _salt;
            public uint256 salt
            {
                get => _salt;
                set
                {
                    _salt = value;
                }
            }

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
    }
    public sealed partial class ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ADDRESS : ContractIDPreimage
    {
        public override ContractIDPreimageType Discriminator => ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
        private fromAddressStruct _fromAddress;
        public fromAddressStruct fromAddress
        {
            get => _fromAddress;
            set
            {
                _fromAddress = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ASSET : ContractIDPreimage
    {
        public override ContractIDPreimageType Discriminator => ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ASSET;
        private Asset _fromAsset;
        public Asset fromAsset
        {
            get => _fromAsset;
            set
            {
                _fromAsset = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ContractIDPreimageXdr
    {
        public static void Encode(XdrWriter stream, ContractIDPreimage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ADDRESS case_CONTRACT_ID_PREIMAGE_FROM_ADDRESS:
                ContractIDPreimage.fromAddressStructXdr.Encode(stream, case_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.fromAddress);
                break;
                case ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ASSET case_CONTRACT_ID_PREIMAGE_FROM_ASSET:
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
                var result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS = new ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ADDRESS();
                result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.fromAddress = ContractIDPreimage.fromAddressStructXdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
                case ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ASSET:
                var result_CONTRACT_ID_PREIMAGE_FROM_ASSET = new ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ASSET();
                result_CONTRACT_ID_PREIMAGE_FROM_ASSET.fromAsset = AssetXdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ASSET;
                default:
                throw new Exception($"Unknown discriminator for ContractIDPreimage: {discriminator}");
            }
        }
    }
}
