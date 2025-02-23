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
    [ProtoInclude(100, typeof(EnvelopeTypeOpId), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(EnvelopeTypePoolRevokeOpId), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(EnvelopeTypeContractId), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(EnvelopeTypeSorobanAuthorization), DataFormat = DataFormat.Default)]
    public abstract partial class HashIDPreimage
    {
        public abstract EnvelopeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_operationIDStruct")]
        public partial class operationIDStruct
        {
            [ProtoMember(1)]
            public AccountID sourceAccount
            {
                get => _sourceAccount;
                set
                {
                    _sourceAccount = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Source Account")]
            #endif
            private AccountID _sourceAccount;

            [ProtoMember(2)]
            public SequenceNumber seqNum
            {
                get => _seqNum;
                set
                {
                    _seqNum = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Seq Num")]
            #endif
            private SequenceNumber _seqNum;

            [ProtoMember(3)]
            public uint32 opNum
            {
                get => _opNum;
                set
                {
                    _opNum = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Op Num")]
            #endif
            private uint32 _opNum;

            public operationIDStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class operationIDStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(operationIDStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    operationIDStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static operationIDStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return operationIDStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, operationIDStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.sourceAccount);
                SequenceNumberXdr.Encode(stream, value.seqNum);
                uint32Xdr.Encode(stream, value.opNum);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static operationIDStruct Decode(XdrReader stream)
            {
                var result = new operationIDStruct();
                result.sourceAccount = AccountIDXdr.Decode(stream);
                result.seqNum = SequenceNumberXdr.Decode(stream);
                result.opNum = uint32Xdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_revokeIDStruct")]
        public partial class revokeIDStruct
        {
            [ProtoMember(1)]
            public AccountID sourceAccount
            {
                get => _sourceAccount;
                set
                {
                    _sourceAccount = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Source Account")]
            #endif
            private AccountID _sourceAccount;

            [ProtoMember(2)]
            public SequenceNumber seqNum
            {
                get => _seqNum;
                set
                {
                    _seqNum = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Seq Num")]
            #endif
            private SequenceNumber _seqNum;

            [ProtoMember(3)]
            public uint32 opNum
            {
                get => _opNum;
                set
                {
                    _opNum = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Op Num")]
            #endif
            private uint32 _opNum;

            [ProtoMember(4)]
            public PoolID liquidityPoolID
            {
                get => _liquidityPoolID;
                set
                {
                    _liquidityPoolID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Liquidity Pool I D")]
            #endif
            private PoolID _liquidityPoolID;

            [ProtoMember(5)]
            public Asset asset
            {
                get => _asset;
                set
                {
                    _asset = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Asset")]
            #endif
            private Asset _asset;

            public revokeIDStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class revokeIDStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(revokeIDStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    revokeIDStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static revokeIDStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return revokeIDStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, revokeIDStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.sourceAccount);
                SequenceNumberXdr.Encode(stream, value.seqNum);
                uint32Xdr.Encode(stream, value.opNum);
                PoolIDXdr.Encode(stream, value.liquidityPoolID);
                AssetXdr.Encode(stream, value.asset);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static revokeIDStruct Decode(XdrReader stream)
            {
                var result = new revokeIDStruct();
                result.sourceAccount = AccountIDXdr.Decode(stream);
                result.seqNum = SequenceNumberXdr.Decode(stream);
                result.opNum = uint32Xdr.Decode(stream);
                result.liquidityPoolID = PoolIDXdr.Decode(stream);
                result.asset = AssetXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_contractIDStruct")]
        public partial class contractIDStruct
        {
            [ProtoMember(1)]
            public Hash networkID
            {
                get => _networkID;
                set
                {
                    _networkID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Network I D")]
            #endif
            private Hash _networkID;

            [ProtoMember(2)]
            public ContractIDPreimage contractIDPreimage
            {
                get => _contractIDPreimage;
                set
                {
                    _contractIDPreimage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract I D Preimage")]
            #endif
            private ContractIDPreimage _contractIDPreimage;

            public contractIDStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class contractIDStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(contractIDStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    contractIDStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static contractIDStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return contractIDStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, contractIDStruct value)
            {
                value.Validate();
                HashXdr.Encode(stream, value.networkID);
                ContractIDPreimageXdr.Encode(stream, value.contractIDPreimage);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static contractIDStruct Decode(XdrReader stream)
            {
                var result = new contractIDStruct();
                result.networkID = HashXdr.Decode(stream);
                result.contractIDPreimage = ContractIDPreimageXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_sorobanAuthorizationStruct")]
        public partial class sorobanAuthorizationStruct
        {
            [ProtoMember(1)]
            public Hash networkID
            {
                get => _networkID;
                set
                {
                    _networkID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Network I D")]
            #endif
            private Hash _networkID;

            [ProtoMember(2)]
            public int64 nonce
            {
                get => _nonce;
                set
                {
                    _nonce = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Nonce")]
            #endif
            private int64 _nonce;

            [ProtoMember(3)]
            public uint32 signatureExpirationLedger
            {
                get => _signatureExpirationLedger;
                set
                {
                    _signatureExpirationLedger = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signature Expiration Ledger")]
            #endif
            private uint32 _signatureExpirationLedger;

            [ProtoMember(4)]
            public SorobanAuthorizedInvocation invocation
            {
                get => _invocation;
                set
                {
                    _invocation = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Invocation")]
            #endif
            private SorobanAuthorizedInvocation _invocation;

            public sorobanAuthorizationStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class sorobanAuthorizationStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(sorobanAuthorizationStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    sorobanAuthorizationStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static sorobanAuthorizationStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return sorobanAuthorizationStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, sorobanAuthorizationStruct value)
            {
                value.Validate();
                HashXdr.Encode(stream, value.networkID);
                int64Xdr.Encode(stream, value.nonce);
                uint32Xdr.Encode(stream, value.signatureExpirationLedger);
                SorobanAuthorizedInvocationXdr.Encode(stream, value.invocation);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static sorobanAuthorizationStruct Decode(XdrReader stream)
            {
                var result = new sorobanAuthorizationStruct();
                result.networkID = HashXdr.Decode(stream);
                result.nonce = int64Xdr.Decode(stream);
                result.signatureExpirationLedger = uint32Xdr.Decode(stream);
                result.invocation = SorobanAuthorizedInvocationXdr.Decode(stream);
                return result;
            }
        }
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_EnvelopeTypeOpId")]
        public sealed partial class EnvelopeTypeOpId : HashIDPreimage
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_OP_ID;
            [ProtoMember(1)]
            public operationIDStruct operationID
            {
                get => _operationID;
                set
                {
                    _operationID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Operation I D")]
            #endif
            private operationIDStruct _operationID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_EnvelopeTypePoolRevokeOpId")]
        public sealed partial class EnvelopeTypePoolRevokeOpId : HashIDPreimage
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_POOL_REVOKE_OP_ID;
            [ProtoMember(2)]
            public revokeIDStruct revokeID
            {
                get => _revokeID;
                set
                {
                    _revokeID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Revoke I D")]
            #endif
            private revokeIDStruct _revokeID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_EnvelopeTypeContractId")]
        public sealed partial class EnvelopeTypeContractId : HashIDPreimage
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_CONTRACT_ID;
            [ProtoMember(3)]
            public contractIDStruct contractID
            {
                get => _contractID;
                set
                {
                    _contractID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract I D")]
            #endif
            private contractIDStruct _contractID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HashIDPreimage_EnvelopeTypeSorobanAuthorization")]
        public sealed partial class EnvelopeTypeSorobanAuthorization : HashIDPreimage
        {
            public override EnvelopeType Discriminator => EnvelopeType.ENVELOPE_TYPE_SOROBAN_AUTHORIZATION;
            [ProtoMember(4)]
            public sorobanAuthorizationStruct sorobanAuthorization
            {
                get => _sorobanAuthorization;
                set
                {
                    _sorobanAuthorization = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Soroban Authorization")]
            #endif
            private sorobanAuthorizationStruct _sorobanAuthorization;

            public override void ValidateCase() {}
        }
    }
    public static partial class HashIDPreimageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HashIDPreimage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HashIDPreimageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static HashIDPreimage DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return HashIDPreimageXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, HashIDPreimage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HashIDPreimage.EnvelopeTypeOpId case_ENVELOPE_TYPE_OP_ID:
                HashIDPreimage.operationIDStructXdr.Encode(stream, case_ENVELOPE_TYPE_OP_ID.operationID);
                break;
                case HashIDPreimage.EnvelopeTypePoolRevokeOpId case_ENVELOPE_TYPE_POOL_REVOKE_OP_ID:
                HashIDPreimage.revokeIDStructXdr.Encode(stream, case_ENVELOPE_TYPE_POOL_REVOKE_OP_ID.revokeID);
                break;
                case HashIDPreimage.EnvelopeTypeContractId case_ENVELOPE_TYPE_CONTRACT_ID:
                HashIDPreimage.contractIDStructXdr.Encode(stream, case_ENVELOPE_TYPE_CONTRACT_ID.contractID);
                break;
                case HashIDPreimage.EnvelopeTypeSorobanAuthorization case_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION:
                HashIDPreimage.sorobanAuthorizationStructXdr.Encode(stream, case_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION.sorobanAuthorization);
                break;
            }
        }
        public static HashIDPreimage Decode(XdrReader stream)
        {
            var discriminator = (EnvelopeType)stream.ReadInt();
            switch (discriminator)
            {
                case EnvelopeType.ENVELOPE_TYPE_OP_ID:
                var result_ENVELOPE_TYPE_OP_ID = new HashIDPreimage.EnvelopeTypeOpId();
                result_ENVELOPE_TYPE_OP_ID.operationID = HashIDPreimage.operationIDStructXdr.Decode(stream);
                return result_ENVELOPE_TYPE_OP_ID;
                case EnvelopeType.ENVELOPE_TYPE_POOL_REVOKE_OP_ID:
                var result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID = new HashIDPreimage.EnvelopeTypePoolRevokeOpId();
                result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID.revokeID = HashIDPreimage.revokeIDStructXdr.Decode(stream);
                return result_ENVELOPE_TYPE_POOL_REVOKE_OP_ID;
                case EnvelopeType.ENVELOPE_TYPE_CONTRACT_ID:
                var result_ENVELOPE_TYPE_CONTRACT_ID = new HashIDPreimage.EnvelopeTypeContractId();
                result_ENVELOPE_TYPE_CONTRACT_ID.contractID = HashIDPreimage.contractIDStructXdr.Decode(stream);
                return result_ENVELOPE_TYPE_CONTRACT_ID;
                case EnvelopeType.ENVELOPE_TYPE_SOROBAN_AUTHORIZATION:
                var result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION = new HashIDPreimage.EnvelopeTypeSorobanAuthorization();
                result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION.sorobanAuthorization = HashIDPreimage.sorobanAuthorizationStructXdr.Decode(stream);
                return result_ENVELOPE_TYPE_SOROBAN_AUTHORIZATION;
                default:
                throw new Exception($"Unknown discriminator for HashIDPreimage: {discriminator}");
            }
        }
    }
}
