// Generated code - do not modify
// Source:

// union ClawbackResult switch (ClawbackResultCode code)
// {
// case CLAWBACK_SUCCESS:
//     void;
// case CLAWBACK_MALFORMED:
// case CLAWBACK_NOT_CLAWBACK_ENABLED:
// case CLAWBACK_NO_TRUST:
// case CLAWBACK_UNDERFUNDED:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClawbackResult
    {
        public abstract ClawbackResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class ClawbackSuccess : ClawbackResult
        {
            public override ClawbackResultCode Discriminator => ClawbackResultCode.CLAWBACK_SUCCESS;

            public override void ValidateCase() {}
        }
        public sealed partial class ClawbackMalformed : ClawbackResult
        {
            public override ClawbackResultCode Discriminator => ClawbackResultCode.CLAWBACK_MALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class ClawbackNotClawbackEnabled : ClawbackResult
        {
            public override ClawbackResultCode Discriminator => ClawbackResultCode.CLAWBACK_NOT_CLAWBACK_ENABLED;

            public override void ValidateCase() {}
        }
        public sealed partial class ClawbackNoTrust : ClawbackResult
        {
            public override ClawbackResultCode Discriminator => ClawbackResultCode.CLAWBACK_NO_TRUST;

            public override void ValidateCase() {}
        }
        public sealed partial class ClawbackUnderfunded : ClawbackResult
        {
            public override ClawbackResultCode Discriminator => ClawbackResultCode.CLAWBACK_UNDERFUNDED;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClawbackResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClawbackResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClawbackResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ClawbackResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClawbackResult.ClawbackSuccess case_CLAWBACK_SUCCESS:
                break;
                case ClawbackResult.ClawbackMalformed case_CLAWBACK_MALFORMED:
                break;
                case ClawbackResult.ClawbackNotClawbackEnabled case_CLAWBACK_NOT_CLAWBACK_ENABLED:
                break;
                case ClawbackResult.ClawbackNoTrust case_CLAWBACK_NO_TRUST:
                break;
                case ClawbackResult.ClawbackUnderfunded case_CLAWBACK_UNDERFUNDED:
                break;
            }
        }
        public static ClawbackResult Decode(XdrReader stream)
        {
            var discriminator = (ClawbackResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ClawbackResultCode.CLAWBACK_SUCCESS:
                var result_CLAWBACK_SUCCESS = new ClawbackResult.ClawbackSuccess();
                return result_CLAWBACK_SUCCESS;
                case ClawbackResultCode.CLAWBACK_MALFORMED:
                var result_CLAWBACK_MALFORMED = new ClawbackResult.ClawbackMalformed();
                return result_CLAWBACK_MALFORMED;
                case ClawbackResultCode.CLAWBACK_NOT_CLAWBACK_ENABLED:
                var result_CLAWBACK_NOT_CLAWBACK_ENABLED = new ClawbackResult.ClawbackNotClawbackEnabled();
                return result_CLAWBACK_NOT_CLAWBACK_ENABLED;
                case ClawbackResultCode.CLAWBACK_NO_TRUST:
                var result_CLAWBACK_NO_TRUST = new ClawbackResult.ClawbackNoTrust();
                return result_CLAWBACK_NO_TRUST;
                case ClawbackResultCode.CLAWBACK_UNDERFUNDED:
                var result_CLAWBACK_UNDERFUNDED = new ClawbackResult.ClawbackUnderfunded();
                return result_CLAWBACK_UNDERFUNDED;
                default:
                throw new Exception($"Unknown discriminator for ClawbackResult: {discriminator}");
            }
        }
    }
}
