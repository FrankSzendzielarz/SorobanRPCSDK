// Generated code - do not modify
// Source:

// union RevokeSponsorshipResult switch (RevokeSponsorshipResultCode code)
// {
// case REVOKE_SPONSORSHIP_SUCCESS:
//     void;
// case REVOKE_SPONSORSHIP_DOES_NOT_EXIST:
// case REVOKE_SPONSORSHIP_NOT_SPONSOR:
// case REVOKE_SPONSORSHIP_LOW_RESERVE:
// case REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE:
// case REVOKE_SPONSORSHIP_MALFORMED:
//     void;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class RevokeSponsorshipResult
    {
        public abstract RevokeSponsorshipResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_SUCCESS : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_DOES_NOT_EXIST : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_DOES_NOT_EXIST;

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_NOT_SPONSOR : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_NOT_SPONSOR;

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_LOW_RESERVE : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE;

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipResult_REVOKE_SPONSORSHIP_MALFORMED : RevokeSponsorshipResult
    {
        public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_MALFORMED;

        public override void ValidateCase() {}
    }
    public static partial class RevokeSponsorshipResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RevokeSponsorshipResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RevokeSponsorshipResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, RevokeSponsorshipResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_SUCCESS case_REVOKE_SPONSORSHIP_SUCCESS:
                break;
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_DOES_NOT_EXIST case_REVOKE_SPONSORSHIP_DOES_NOT_EXIST:
                break;
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_NOT_SPONSOR case_REVOKE_SPONSORSHIP_NOT_SPONSOR:
                break;
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_LOW_RESERVE case_REVOKE_SPONSORSHIP_LOW_RESERVE:
                break;
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE case_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE:
                break;
                case RevokeSponsorshipResult_REVOKE_SPONSORSHIP_MALFORMED case_REVOKE_SPONSORSHIP_MALFORMED:
                break;
            }
        }
        public static RevokeSponsorshipResult Decode(XdrReader stream)
        {
            var discriminator = (RevokeSponsorshipResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_SUCCESS:
                var result_REVOKE_SPONSORSHIP_SUCCESS = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_SUCCESS();
                return result_REVOKE_SPONSORSHIP_SUCCESS;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_DOES_NOT_EXIST:
                var result_REVOKE_SPONSORSHIP_DOES_NOT_EXIST = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_DOES_NOT_EXIST();
                return result_REVOKE_SPONSORSHIP_DOES_NOT_EXIST;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_NOT_SPONSOR:
                var result_REVOKE_SPONSORSHIP_NOT_SPONSOR = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_NOT_SPONSOR();
                return result_REVOKE_SPONSORSHIP_NOT_SPONSOR;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_LOW_RESERVE:
                var result_REVOKE_SPONSORSHIP_LOW_RESERVE = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_LOW_RESERVE();
                return result_REVOKE_SPONSORSHIP_LOW_RESERVE;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE:
                var result_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE();
                return result_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_MALFORMED:
                var result_REVOKE_SPONSORSHIP_MALFORMED = new RevokeSponsorshipResult_REVOKE_SPONSORSHIP_MALFORMED();
                return result_REVOKE_SPONSORSHIP_MALFORMED;
                default:
                throw new Exception($"Unknown discriminator for RevokeSponsorshipResult: {discriminator}");
            }
        }
    }
}
