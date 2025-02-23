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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(RevokeSponsorshipSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(RevokeSponsorshipDoesNotExist), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(RevokeSponsorshipNotSponsor), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(RevokeSponsorshipLowReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(RevokeSponsorshipOnlyTransferable), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(RevokeSponsorshipMalformed), DataFormat = DataFormat.Default)]
    public abstract partial class RevokeSponsorshipResult
    {
        public abstract RevokeSponsorshipResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipSuccess")]
        public sealed partial class RevokeSponsorshipSuccess : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipDoesNotExist")]
        public sealed partial class RevokeSponsorshipDoesNotExist : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_DOES_NOT_EXIST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipNotSponsor")]
        public sealed partial class RevokeSponsorshipNotSponsor : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_NOT_SPONSOR;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipLowReserve")]
        public sealed partial class RevokeSponsorshipLowReserve : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable")]
        public sealed partial class RevokeSponsorshipOnlyTransferable : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipResult.RevokeSponsorshipMalformed")]
        public sealed partial class RevokeSponsorshipMalformed : RevokeSponsorshipResult
        {
            public override RevokeSponsorshipResultCode Discriminator => RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_MALFORMED;

            public override void ValidateCase() {}
        }
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static RevokeSponsorshipResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return RevokeSponsorshipResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, RevokeSponsorshipResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RevokeSponsorshipResult.RevokeSponsorshipSuccess case_REVOKE_SPONSORSHIP_SUCCESS:
                break;
                case RevokeSponsorshipResult.RevokeSponsorshipDoesNotExist case_REVOKE_SPONSORSHIP_DOES_NOT_EXIST:
                break;
                case RevokeSponsorshipResult.RevokeSponsorshipNotSponsor case_REVOKE_SPONSORSHIP_NOT_SPONSOR:
                break;
                case RevokeSponsorshipResult.RevokeSponsorshipLowReserve case_REVOKE_SPONSORSHIP_LOW_RESERVE:
                break;
                case RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable case_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE:
                break;
                case RevokeSponsorshipResult.RevokeSponsorshipMalformed case_REVOKE_SPONSORSHIP_MALFORMED:
                break;
            }
        }
        public static RevokeSponsorshipResult Decode(XdrReader stream)
        {
            var discriminator = (RevokeSponsorshipResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_SUCCESS:
                var result_REVOKE_SPONSORSHIP_SUCCESS = new RevokeSponsorshipResult.RevokeSponsorshipSuccess();
                return result_REVOKE_SPONSORSHIP_SUCCESS;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_DOES_NOT_EXIST:
                var result_REVOKE_SPONSORSHIP_DOES_NOT_EXIST = new RevokeSponsorshipResult.RevokeSponsorshipDoesNotExist();
                return result_REVOKE_SPONSORSHIP_DOES_NOT_EXIST;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_NOT_SPONSOR:
                var result_REVOKE_SPONSORSHIP_NOT_SPONSOR = new RevokeSponsorshipResult.RevokeSponsorshipNotSponsor();
                return result_REVOKE_SPONSORSHIP_NOT_SPONSOR;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_LOW_RESERVE:
                var result_REVOKE_SPONSORSHIP_LOW_RESERVE = new RevokeSponsorshipResult.RevokeSponsorshipLowReserve();
                return result_REVOKE_SPONSORSHIP_LOW_RESERVE;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE:
                var result_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = new RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable();
                return result_REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE;
                case RevokeSponsorshipResultCode.REVOKE_SPONSORSHIP_MALFORMED:
                var result_REVOKE_SPONSORSHIP_MALFORMED = new RevokeSponsorshipResult.RevokeSponsorshipMalformed();
                return result_REVOKE_SPONSORSHIP_MALFORMED;
                default:
                throw new Exception($"Unknown discriminator for RevokeSponsorshipResult: {discriminator}");
            }
        }
    }
}
