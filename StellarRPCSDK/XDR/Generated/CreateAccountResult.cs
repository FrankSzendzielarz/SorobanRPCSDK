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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class CreateAccountResult
    {
        public abstract CreateAccountResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class CreateAccountResult_CREATE_ACCOUNT_SUCCESS : CreateAccountResult
    {
        public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class CreateAccountResult_CREATE_ACCOUNT_MALFORMED : CreateAccountResult
    {
        public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class CreateAccountResult_CREATE_ACCOUNT_UNDERFUNDED : CreateAccountResult
    {
        public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class CreateAccountResult_CREATE_ACCOUNT_LOW_RESERVE : CreateAccountResult
    {
        public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public sealed partial class CreateAccountResult_CREATE_ACCOUNT_ALREADY_EXIST : CreateAccountResult
    {
        public override CreateAccountResultCode Discriminator => CreateAccountResultCode.CREATE_ACCOUNT_ALREADY_EXIST;

        public override void ValidateCase() {}
    }
    public static partial class CreateAccountResultXdr
    {
        public static void Encode(XdrWriter stream, CreateAccountResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case CreateAccountResult_CREATE_ACCOUNT_SUCCESS case_CREATE_ACCOUNT_SUCCESS:
                break;
                case CreateAccountResult_CREATE_ACCOUNT_MALFORMED case_CREATE_ACCOUNT_MALFORMED:
                break;
                case CreateAccountResult_CREATE_ACCOUNT_UNDERFUNDED case_CREATE_ACCOUNT_UNDERFUNDED:
                break;
                case CreateAccountResult_CREATE_ACCOUNT_LOW_RESERVE case_CREATE_ACCOUNT_LOW_RESERVE:
                break;
                case CreateAccountResult_CREATE_ACCOUNT_ALREADY_EXIST case_CREATE_ACCOUNT_ALREADY_EXIST:
                break;
            }
        }
        public static CreateAccountResult Decode(XdrReader stream)
        {
            var discriminator = (CreateAccountResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case CreateAccountResultCode.CREATE_ACCOUNT_SUCCESS:
                var result_CREATE_ACCOUNT_SUCCESS = new CreateAccountResult_CREATE_ACCOUNT_SUCCESS();
                return result_CREATE_ACCOUNT_SUCCESS;
                case CreateAccountResultCode.CREATE_ACCOUNT_MALFORMED:
                var result_CREATE_ACCOUNT_MALFORMED = new CreateAccountResult_CREATE_ACCOUNT_MALFORMED();
                return result_CREATE_ACCOUNT_MALFORMED;
                case CreateAccountResultCode.CREATE_ACCOUNT_UNDERFUNDED:
                var result_CREATE_ACCOUNT_UNDERFUNDED = new CreateAccountResult_CREATE_ACCOUNT_UNDERFUNDED();
                return result_CREATE_ACCOUNT_UNDERFUNDED;
                case CreateAccountResultCode.CREATE_ACCOUNT_LOW_RESERVE:
                var result_CREATE_ACCOUNT_LOW_RESERVE = new CreateAccountResult_CREATE_ACCOUNT_LOW_RESERVE();
                return result_CREATE_ACCOUNT_LOW_RESERVE;
                case CreateAccountResultCode.CREATE_ACCOUNT_ALREADY_EXIST:
                var result_CREATE_ACCOUNT_ALREADY_EXIST = new CreateAccountResult_CREATE_ACCOUNT_ALREADY_EXIST();
                return result_CREATE_ACCOUNT_ALREADY_EXIST;
                default:
                throw new Exception($"Unknown discriminator for CreateAccountResult: {discriminator}");
            }
        }
    }
}
