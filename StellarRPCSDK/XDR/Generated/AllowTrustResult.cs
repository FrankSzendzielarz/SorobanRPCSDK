// Generated code - do not modify
// Source:

// union AllowTrustResult switch (AllowTrustResultCode code)
// {
// case ALLOW_TRUST_SUCCESS:
//     void;
// case ALLOW_TRUST_MALFORMED:
// case ALLOW_TRUST_NO_TRUST_LINE:
// case ALLOW_TRUST_TRUST_NOT_REQUIRED:
// case ALLOW_TRUST_CANT_REVOKE:
// case ALLOW_TRUST_SELF_NOT_ALLOWED:
// case ALLOW_TRUST_LOW_RESERVE:
//     void;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class AllowTrustResult
    {
        public abstract AllowTrustResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_SUCCESS : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_MALFORMED : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_NO_TRUST_LINE : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_NO_TRUST_LINE;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_TRUST_NOT_REQUIRED : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_TRUST_NOT_REQUIRED;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_CANT_REVOKE : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_CANT_REVOKE;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_SELF_NOT_ALLOWED : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_SELF_NOT_ALLOWED;

        public override void ValidateCase() {}
    }
    public sealed partial class AllowTrustResult_ALLOW_TRUST_LOW_RESERVE : AllowTrustResult
    {
        public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public static partial class AllowTrustResultXdr
    {
        public static void Encode(XdrWriter stream, AllowTrustResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AllowTrustResult_ALLOW_TRUST_SUCCESS case_ALLOW_TRUST_SUCCESS:
                break;
                case AllowTrustResult_ALLOW_TRUST_MALFORMED case_ALLOW_TRUST_MALFORMED:
                break;
                case AllowTrustResult_ALLOW_TRUST_NO_TRUST_LINE case_ALLOW_TRUST_NO_TRUST_LINE:
                break;
                case AllowTrustResult_ALLOW_TRUST_TRUST_NOT_REQUIRED case_ALLOW_TRUST_TRUST_NOT_REQUIRED:
                break;
                case AllowTrustResult_ALLOW_TRUST_CANT_REVOKE case_ALLOW_TRUST_CANT_REVOKE:
                break;
                case AllowTrustResult_ALLOW_TRUST_SELF_NOT_ALLOWED case_ALLOW_TRUST_SELF_NOT_ALLOWED:
                break;
                case AllowTrustResult_ALLOW_TRUST_LOW_RESERVE case_ALLOW_TRUST_LOW_RESERVE:
                break;
            }
        }
        public static AllowTrustResult Decode(XdrReader stream)
        {
            var discriminator = (AllowTrustResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case AllowTrustResultCode.ALLOW_TRUST_SUCCESS:
                var result_ALLOW_TRUST_SUCCESS = new AllowTrustResult_ALLOW_TRUST_SUCCESS();
                return result_ALLOW_TRUST_SUCCESS;
                case AllowTrustResultCode.ALLOW_TRUST_MALFORMED:
                var result_ALLOW_TRUST_MALFORMED = new AllowTrustResult_ALLOW_TRUST_MALFORMED();
                return result_ALLOW_TRUST_MALFORMED;
                case AllowTrustResultCode.ALLOW_TRUST_NO_TRUST_LINE:
                var result_ALLOW_TRUST_NO_TRUST_LINE = new AllowTrustResult_ALLOW_TRUST_NO_TRUST_LINE();
                return result_ALLOW_TRUST_NO_TRUST_LINE;
                case AllowTrustResultCode.ALLOW_TRUST_TRUST_NOT_REQUIRED:
                var result_ALLOW_TRUST_TRUST_NOT_REQUIRED = new AllowTrustResult_ALLOW_TRUST_TRUST_NOT_REQUIRED();
                return result_ALLOW_TRUST_TRUST_NOT_REQUIRED;
                case AllowTrustResultCode.ALLOW_TRUST_CANT_REVOKE:
                var result_ALLOW_TRUST_CANT_REVOKE = new AllowTrustResult_ALLOW_TRUST_CANT_REVOKE();
                return result_ALLOW_TRUST_CANT_REVOKE;
                case AllowTrustResultCode.ALLOW_TRUST_SELF_NOT_ALLOWED:
                var result_ALLOW_TRUST_SELF_NOT_ALLOWED = new AllowTrustResult_ALLOW_TRUST_SELF_NOT_ALLOWED();
                return result_ALLOW_TRUST_SELF_NOT_ALLOWED;
                case AllowTrustResultCode.ALLOW_TRUST_LOW_RESERVE:
                var result_ALLOW_TRUST_LOW_RESERVE = new AllowTrustResult_ALLOW_TRUST_LOW_RESERVE();
                return result_ALLOW_TRUST_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for AllowTrustResult: {discriminator}");
            }
        }
    }
}
