// Generated code - do not modify
// Source:

// union ChangeTrustResult switch (ChangeTrustResultCode code)
// {
// case CHANGE_TRUST_SUCCESS:
//     void;
// case CHANGE_TRUST_MALFORMED:
// case CHANGE_TRUST_NO_ISSUER:
// case CHANGE_TRUST_INVALID_LIMIT:
// case CHANGE_TRUST_LOW_RESERVE:
// case CHANGE_TRUST_SELF_NOT_ALLOWED:
// case CHANGE_TRUST_TRUST_LINE_MISSING:
// case CHANGE_TRUST_CANNOT_DELETE:
// case CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ChangeTrustResult
    {
        public abstract ChangeTrustResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_SUCCESS : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_MALFORMED : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_NO_ISSUER : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_NO_ISSUER;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_INVALID_LIMIT : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_INVALID_LIMIT;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_LOW_RESERVE : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_SELF_NOT_ALLOWED : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_SELF_NOT_ALLOWED;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_TRUST_LINE_MISSING : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_TRUST_LINE_MISSING;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_CANNOT_DELETE : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_CANNOT_DELETE;

        public override void ValidateCase() {}
    }
    public sealed partial class ChangeTrustResult_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES : ChangeTrustResult
    {
        public override ChangeTrustResultCode Discriminator => CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES;

        public override void ValidateCase() {}
    }
    public static partial class ChangeTrustResultXdr
    {
        public static void Encode(XdrWriter stream, ChangeTrustResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ChangeTrustResult_CHANGE_TRUST_SUCCESS case_CHANGE_TRUST_SUCCESS:
                break;
                case ChangeTrustResult_CHANGE_TRUST_MALFORMED case_CHANGE_TRUST_MALFORMED:
                break;
                case ChangeTrustResult_CHANGE_TRUST_NO_ISSUER case_CHANGE_TRUST_NO_ISSUER:
                break;
                case ChangeTrustResult_CHANGE_TRUST_INVALID_LIMIT case_CHANGE_TRUST_INVALID_LIMIT:
                break;
                case ChangeTrustResult_CHANGE_TRUST_LOW_RESERVE case_CHANGE_TRUST_LOW_RESERVE:
                break;
                case ChangeTrustResult_CHANGE_TRUST_SELF_NOT_ALLOWED case_CHANGE_TRUST_SELF_NOT_ALLOWED:
                break;
                case ChangeTrustResult_CHANGE_TRUST_TRUST_LINE_MISSING case_CHANGE_TRUST_TRUST_LINE_MISSING:
                break;
                case ChangeTrustResult_CHANGE_TRUST_CANNOT_DELETE case_CHANGE_TRUST_CANNOT_DELETE:
                break;
                case ChangeTrustResult_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES case_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
                break;
            }
        }
        public static ChangeTrustResult Decode(XdrReader stream)
        {
            var discriminator = (ChangeTrustResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case CHANGE_TRUST_SUCCESS:
                var result_CHANGE_TRUST_SUCCESS = new ChangeTrustResult_CHANGE_TRUST_SUCCESS();
                return result_CHANGE_TRUST_SUCCESS;
                case CHANGE_TRUST_MALFORMED:
                var result_CHANGE_TRUST_MALFORMED = new ChangeTrustResult_CHANGE_TRUST_MALFORMED();
                return result_CHANGE_TRUST_MALFORMED;
                case CHANGE_TRUST_NO_ISSUER:
                var result_CHANGE_TRUST_NO_ISSUER = new ChangeTrustResult_CHANGE_TRUST_NO_ISSUER();
                return result_CHANGE_TRUST_NO_ISSUER;
                case CHANGE_TRUST_INVALID_LIMIT:
                var result_CHANGE_TRUST_INVALID_LIMIT = new ChangeTrustResult_CHANGE_TRUST_INVALID_LIMIT();
                return result_CHANGE_TRUST_INVALID_LIMIT;
                case CHANGE_TRUST_LOW_RESERVE:
                var result_CHANGE_TRUST_LOW_RESERVE = new ChangeTrustResult_CHANGE_TRUST_LOW_RESERVE();
                return result_CHANGE_TRUST_LOW_RESERVE;
                case CHANGE_TRUST_SELF_NOT_ALLOWED:
                var result_CHANGE_TRUST_SELF_NOT_ALLOWED = new ChangeTrustResult_CHANGE_TRUST_SELF_NOT_ALLOWED();
                return result_CHANGE_TRUST_SELF_NOT_ALLOWED;
                case CHANGE_TRUST_TRUST_LINE_MISSING:
                var result_CHANGE_TRUST_TRUST_LINE_MISSING = new ChangeTrustResult_CHANGE_TRUST_TRUST_LINE_MISSING();
                return result_CHANGE_TRUST_TRUST_LINE_MISSING;
                case CHANGE_TRUST_CANNOT_DELETE:
                var result_CHANGE_TRUST_CANNOT_DELETE = new ChangeTrustResult_CHANGE_TRUST_CANNOT_DELETE();
                return result_CHANGE_TRUST_CANNOT_DELETE;
                case CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
                var result_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES = new ChangeTrustResult_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES();
                return result_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES;
                default:
                throw new Exception($"Unknown discriminator for ChangeTrustResult: {discriminator}");
            }
        }
    }
}
