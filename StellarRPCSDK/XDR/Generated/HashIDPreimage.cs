// Generated code - do not modify
// Source:

// union HashIDPreimage switch (EnvelopeType type)
// {
// case ENVELOPE_TYPE_OP_ID:
//     struct
//     {
//         AccountID sourceAccount;
//         SequenceNumber seqNum;
//         uint32 opNum;
//     } operationID;
// case ENVELOPE_TYPE_POOL_REVOKE_OP_ID:
//     struct
//     {
//         AccountID sourceAccount;
//         SequenceNumber seqNum; 
//         uint32 opNum;
//         PoolID liquidityPoolID;
//         Asset asset;
//     } revokeID;
// case ENVELOPE_TYPE_CONTRACT_ID:
//     struct
//     {
//         Hash networkID;
//         ContractIDPreimage contractIDPreimage;
//     } contractID;
// case ENVELOPE_TYPE_SOROBAN_AUTHORIZATION:
//     struct
//     {
//         Hash networkID;
//         int64 nonce;
//         uint32 signatureExpirationLedger;
//         SorobanAuthorizedInvocation invocation;
//     } sorobanAuthorization;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class HashIDPreimage
    {
        public abstract EnvelopeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class HashIDPreimage_ENVELOPE_TYPE_OP_ID : HashIDPreimage
    {
        public override EnvelopeType Discriminator => ENVELOPE_TYPE_OP_ID;
        private object _operationID;
        public object operationID
        {
            get => _operationID;
            set
            {
                _operationID = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HashIDPreimage_ENVELOPE_TYPE_POOL_REVOKE_OP_ID : HashIDPreimage
    {
        public override EnvelopeType Discriminator => ENVELOPE_TYPE_POOL_REVOKE_OP_ID;
        private object _revokeID;
        public object revokeID
        {
            get => _revokeID;
            set
            {
                _revokeID = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HashIDPreimage_ENVELOPE_TYPE_CONTRACT_ID : HashIDPreimage
    {
        public override EnvelopeType Discriminator => ENVELOPE_TYPE_CONTRACT_ID;
        private object _contractID;
        public object contractID
        {
            get => _contractID;
            set
            {
                _contractID = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HashIDPreimage_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION : HashIDPreimage
    {
        public override EnvelopeType Discriminator => ENVELOPE_TYPE_SOROBAN_AUTHORIZATION;
        private object _sorobanAuthorization;
        public object sorobanAuthorization
        {
            get => _sorobanAuthorization;
            set
            {
                _sorobanAuthorization = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class HashIDPreimageXdr
    {
        public static void Encode(XdrWriter stream, HashIDPreimage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HashIDPreimage_ENVELOPE_TYPE_OP_ID case_ENVELOPE_TYPE_OP_ID:
                Xdr.Encode(stream, case_ENVELOPE_TYPE_OP_ID.operationID);
                break;
                case HashIDPreimage_ENVELOPE_TYPE_POOL_REVOKE_OP_ID case_ENVELOPE_TYPE_POOL_REVOKE_OP_ID:
                Xdr.Encode(stream, case_ENVELOPE_TYPE_POOL_REVOKE_OP_ID.revokeID);
                break;
                case HashIDPreimage_ENVELOPE_TYPE_CONTRACT_ID case_ENVELOPE_TYPE_CONTRACT_ID:
                Xdr.Encode(stream, case_ENVELOPE_TYPE_CONTRACT_ID.contractID);
                break;
                case HashIDPreimage_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION case_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION:
                Xdr.Encode(stream, case_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION.sorobanAuthorization);
                break;
            }
        }
        public static HashIDPreimage Decode(XdrReader stream)
        {
            var discriminator = (EnvelopeType)stream.ReadInt();
            switch (discriminator)
            {
                case ENVELOPE_TYPE_OP_ID:
                var result_ENVELOPE_TYPE_OP_ID = new HashIDPreimage_ENVELOPE_TYPE_OP_ID();
                result_ENVELOPE_TYPE_OP_ID.                 = Xdr.Decode(stream);
                return result_ENVELOPE_TYPE_OP_ID;
                case ENVELOPE_TYPE_POOL_REVOKE_OP_ID:
                var result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID = new HashIDPreimage_ENVELOPE_TYPE_POOL_REVOKE_OP_ID();
                result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID.                 = Xdr.Decode(stream);
                return result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID;
                case ENVELOPE_TYPE_CONTRACT_ID:
                var result_ENVELOPE_TYPE_CONTRACT_ID = new HashIDPreimage_ENVELOPE_TYPE_CONTRACT_ID();
                result_ENVELOPE_TYPE_CONTRACT_ID.                 = Xdr.Decode(stream);
                return result_ENVELOPE_TYPE_CONTRACT_ID;
                case ENVELOPE_TYPE_SOROBAN_AUTHORIZATION:
                var result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION = new HashIDPreimage_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION();
                result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION.                 = Xdr.Decode(stream);
                return result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION;
                default:
                throw new Exception($"Unknown discriminator for HashIDPreimage: {discriminator}");
            }
        }
    }
}
