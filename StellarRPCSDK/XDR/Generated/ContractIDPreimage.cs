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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ContractIDPreimage
    {
        public abstract ContractIDPreimageType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ADDRESS : ContractIDPreimage
    {
        public override ContractIDPreimageType Discriminator => ContractIDPreimageType.CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
        private object _fromAddress;
        public object fromAddress
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
                Xdr.Encode(stream, case_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.fromAddress);
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
                case CONTRACT_ID_PREIMAGE_FROM_ADDRESS:
                var result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS = new ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ADDRESS();
                result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS.                 = Xdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ADDRESS;
                case CONTRACT_ID_PREIMAGE_FROM_ASSET:
                var result_CONTRACT_ID_PREIMAGE_FROM_ASSET = new ContractIDPreimage_CONTRACT_ID_PREIMAGE_FROM_ASSET();
                result_CONTRACT_ID_PREIMAGE_FROM_ASSET.                 = AssetXdr.Decode(stream);
                return result_CONTRACT_ID_PREIMAGE_FROM_ASSET;
                default:
                throw new Exception($"Unknown discriminator for ContractIDPreimage: {discriminator}");
            }
        }
    }
}
