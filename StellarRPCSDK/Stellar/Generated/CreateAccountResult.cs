// Generated code - do not modify
// Source:

// union CreateAccountResult switch (CreateAccountResultCode code)
// {
// case CREATE_ACCOUNT_SUCCESS:
//     void;
// case CREATE_ACCOUNT_MALFORMED:
// case CREATE_ACCOUNT_UNDERFUNDED:
// case CREATE_ACCOUNT_LOW_RESERVE:
// case CREATE_ACCOUNT_ALREADY_EXIST:
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
    [ProtoInclude(100, typeof(CreateAccountSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(CreateAccountMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(CreateAccountUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(CreateAccountLowReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(CreateAccountAlreadyExist), DataFormat = DataFormat.Default)]
    public abstract partial class CreateAccountResult
    {
        public abstract CreateAccountResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "CreateAccountResult.CreateAccountSuccess")]
        public sealed partial class CreateAccountSuccess : CreateAccountResult
        {
            public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateAccountResult.CreateAccountMalformed")]
        public sealed partial class CreateAccountMalformed : CreateAccountResult
        {
            public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateAccountResult.CreateAccountUnderfunded")]
        public sealed partial class CreateAccountUnderfunded : CreateAccountResult
        {
            public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateAccountResult.CreateAccountLowReserve")]
        public sealed partial class CreateAccountLowReserve : CreateAccountResult
        {
            public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "CreateAccountResult.CreateAccountAlreadyExist")]
        public sealed partial class CreateAccountAlreadyExist : CreateAccountResult
        {
            public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_ALREADY_EXIST;

            public override void ValidateCase() {}
        }
    }
    public static partial class CreateAccountResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateAccountResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateAccountResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, CreateAccountResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case CreateAccountResult.CreateAccountSuccess case_CREATE_ACCOUNT_SUCCESS:
                break;
                case CreateAccountResult.CreateAccountMalformed case_CREATE_ACCOUNT_MALFORMED:
                break;
                case CreateAccountResult.CreateAccountUnderfunded case_CREATE_ACCOUNT_UNDERFUNDED:
                break;
                case CreateAccountResult.CreateAccountLowReserve case_CREATE_ACCOUNT_LOW_RESERVE:
                break;
                case CreateAccountResult.CreateAccountAlreadyExist case_CREATE_ACCOUNT_ALREADY_EXIST:
                break;
            }
        }
        public static CreateAccountResult Decode(XdrReader stream)
        {
            var discriminator = (CreateAccountResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case CreateAccountResultCode.CREATE_ACCOUNT_SUCCESS:
                var result_CREATE_ACCOUNT_SUCCESS = new CreateAccountResult.CreateAccountSuccess();
                return result_CREATE_ACCOUNT_SUCCESS;
                case CreateAccountResultCode.CREATE_ACCOUNT_MALFORMED:
                var result_CREATE_ACCOUNT_MALFORMED = new CreateAccountResult.CreateAccountMalformed();
                return result_CREATE_ACCOUNT_MALFORMED;
                case CreateAccountResultCode.CREATE_ACCOUNT_UNDERFUNDED:
                var result_CREATE_ACCOUNT_UNDERFUNDED = new CreateAccountResult.CreateAccountUnderfunded();
                return result_CREATE_ACCOUNT_UNDERFUNDED;
                case CreateAccountResultCode.CREATE_ACCOUNT_LOW_RESERVE:
                var result_CREATE_ACCOUNT_LOW_RESERVE = new CreateAccountResult.CreateAccountLowReserve();
                return result_CREATE_ACCOUNT_LOW_RESERVE;
                case CreateAccountResultCode.CREATE_ACCOUNT_ALREADY_EXIST:
                var result_CREATE_ACCOUNT_ALREADY_EXIST = new CreateAccountResult.CreateAccountAlreadyExist();
                return result_CREATE_ACCOUNT_ALREADY_EXIST;
                default:
                throw new Exception($"Unknown discriminator for CreateAccountResult: {discriminator}");
            }
        }
    }
}
