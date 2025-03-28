// Generated code - do not modify
// Source:

// union CreateClaimableBalanceResult switch (
//     CreateClaimableBalanceResultCode code)
// {
// case CREATE_CLAIMABLE_BALANCE_SUCCESS:
//     ClaimableBalanceID balanceID;
// case CREATE_CLAIMABLE_BALANCE_MALFORMED:
// case CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
// case CREATE_CLAIMABLE_BALANCE_NO_TRUST:
// case CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
// case CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
//     void;
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
    [ProtoInclude(100, typeof(CreateClaimableBalanceSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(CreateClaimableBalanceMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(CreateClaimableBalanceLowReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(CreateClaimableBalanceNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(CreateClaimableBalanceNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(CreateClaimableBalanceUnderfunded), DataFormat = DataFormat.Default)]
    public abstract partial class CreateClaimableBalanceResult
    {
        public abstract CreateClaimableBalanceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceSuccess")]
        public sealed partial class CreateClaimableBalanceSuccess : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_SUCCESS;
            [ProtoMember(1)]
            public ClaimableBalanceID balanceID
            {
                get => _balanceID;
                set
                {
                    _balanceID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Balance I D")]
            #endif
            private ClaimableBalanceID _balanceID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceMalformed")]
        public sealed partial class CreateClaimableBalanceMalformed : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceLowReserve")]
        public sealed partial class CreateClaimableBalanceLowReserve : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceNoTrust")]
        public sealed partial class CreateClaimableBalanceNoTrust : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceNotAuthorized")]
        public sealed partial class CreateClaimableBalanceNotAuthorized : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateClaimableBalanceResult_CreateClaimableBalanceUnderfunded")]
        public sealed partial class CreateClaimableBalanceUnderfunded : CreateClaimableBalanceResult
        {
            public override CreateClaimableBalanceResultCode Discriminator => CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_UNDERFUNDED;

            public override void ValidateCase() {}
        }
    }
    public static partial class CreateClaimableBalanceResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateClaimableBalanceResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateClaimableBalanceResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CreateClaimableBalanceResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CreateClaimableBalanceResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, CreateClaimableBalanceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case CreateClaimableBalanceResult.CreateClaimableBalanceSuccess case_CREATE_CLAIMABLE_BALANCE_SUCCESS:
                ClaimableBalanceIDXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE_SUCCESS.balanceID);
                break;
                case CreateClaimableBalanceResult.CreateClaimableBalanceMalformed case_CREATE_CLAIMABLE_BALANCE_MALFORMED:
                break;
                case CreateClaimableBalanceResult.CreateClaimableBalanceLowReserve case_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
                break;
                case CreateClaimableBalanceResult.CreateClaimableBalanceNoTrust case_CREATE_CLAIMABLE_BALANCE_NO_TRUST:
                break;
                case CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized case_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                break;
                case CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded case_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
                break;
            }
        }
        public static CreateClaimableBalanceResult Decode(XdrReader stream)
        {
            var discriminator = (CreateClaimableBalanceResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_SUCCESS:
                var result_CREATE_CLAIMABLE_BALANCE_SUCCESS = new CreateClaimableBalanceResult.CreateClaimableBalanceSuccess();
                result_CREATE_CLAIMABLE_BALANCE_SUCCESS.balanceID = ClaimableBalanceIDXdr.Decode(stream);
                return result_CREATE_CLAIMABLE_BALANCE_SUCCESS;
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_MALFORMED:
                var result_CREATE_CLAIMABLE_BALANCE_MALFORMED = new CreateClaimableBalanceResult.CreateClaimableBalanceMalformed();
                return result_CREATE_CLAIMABLE_BALANCE_MALFORMED;
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
                var result_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = new CreateClaimableBalanceResult.CreateClaimableBalanceLowReserve();
                return result_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE;
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_NO_TRUST:
                var result_CREATE_CLAIMABLE_BALANCE_NO_TRUST = new CreateClaimableBalanceResult.CreateClaimableBalanceNoTrust();
                return result_CREATE_CLAIMABLE_BALANCE_NO_TRUST;
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                var result_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = new CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized();
                return result_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED;
                case CreateClaimableBalanceResultCode.CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
                var result_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = new CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded();
                return result_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED;
                default:
                throw new Exception($"Unknown discriminator for CreateClaimableBalanceResult: {discriminator}");
            }
        }
    }
}
