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
    [ProtoInclude(100, typeof(AllowTrustSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(AllowTrustMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(AllowTrustNoTrustLine), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(AllowTrustTrustNotRequired), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(AllowTrustCantRevoke), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(AllowTrustSelfNotAllowed), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(AllowTrustLowReserve), DataFormat = DataFormat.Default)]
    public abstract partial class AllowTrustResult
    {
        public abstract AllowTrustResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustSuccess")]
        public sealed partial class AllowTrustSuccess : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustMalformed")]
        public sealed partial class AllowTrustMalformed : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustNoTrustLine")]
        public sealed partial class AllowTrustNoTrustLine : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_NO_TRUST_LINE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustTrustNotRequired")]
        public sealed partial class AllowTrustTrustNotRequired : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_TRUST_NOT_REQUIRED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustCantRevoke")]
        public sealed partial class AllowTrustCantRevoke : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_CANT_REVOKE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustSelfNotAllowed")]
        public sealed partial class AllowTrustSelfNotAllowed : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_SELF_NOT_ALLOWED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "AllowTrustResult_AllowTrustLowReserve")]
        public sealed partial class AllowTrustLowReserve : AllowTrustResult
        {
            public override AllowTrustResultCode Discriminator => AllowTrustResultCode.ALLOW_TRUST_LOW_RESERVE;

            public override void ValidateCase() {}
        }
    }
    public static partial class AllowTrustResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AllowTrustResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AllowTrustResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AllowTrustResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AllowTrustResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, AllowTrustResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AllowTrustResult.AllowTrustSuccess case_ALLOW_TRUST_SUCCESS:
                break;
                case AllowTrustResult.AllowTrustMalformed case_ALLOW_TRUST_MALFORMED:
                break;
                case AllowTrustResult.AllowTrustNoTrustLine case_ALLOW_TRUST_NO_TRUST_LINE:
                break;
                case AllowTrustResult.AllowTrustTrustNotRequired case_ALLOW_TRUST_TRUST_NOT_REQUIRED:
                break;
                case AllowTrustResult.AllowTrustCantRevoke case_ALLOW_TRUST_CANT_REVOKE:
                break;
                case AllowTrustResult.AllowTrustSelfNotAllowed case_ALLOW_TRUST_SELF_NOT_ALLOWED:
                break;
                case AllowTrustResult.AllowTrustLowReserve case_ALLOW_TRUST_LOW_RESERVE:
                break;
            }
        }
        public static AllowTrustResult Decode(XdrReader stream)
        {
            var discriminator = (AllowTrustResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case AllowTrustResultCode.ALLOW_TRUST_SUCCESS:
                var result_ALLOW_TRUST_SUCCESS = new AllowTrustResult.AllowTrustSuccess();
                return result_ALLOW_TRUST_SUCCESS;
                case AllowTrustResultCode.ALLOW_TRUST_MALFORMED:
                var result_ALLOW_TRUST_MALFORMED = new AllowTrustResult.AllowTrustMalformed();
                return result_ALLOW_TRUST_MALFORMED;
                case AllowTrustResultCode.ALLOW_TRUST_NO_TRUST_LINE:
                var result_ALLOW_TRUST_NO_TRUST_LINE = new AllowTrustResult.AllowTrustNoTrustLine();
                return result_ALLOW_TRUST_NO_TRUST_LINE;
                case AllowTrustResultCode.ALLOW_TRUST_TRUST_NOT_REQUIRED:
                var result_ALLOW_TRUST_TRUST_NOT_REQUIRED = new AllowTrustResult.AllowTrustTrustNotRequired();
                return result_ALLOW_TRUST_TRUST_NOT_REQUIRED;
                case AllowTrustResultCode.ALLOW_TRUST_CANT_REVOKE:
                var result_ALLOW_TRUST_CANT_REVOKE = new AllowTrustResult.AllowTrustCantRevoke();
                return result_ALLOW_TRUST_CANT_REVOKE;
                case AllowTrustResultCode.ALLOW_TRUST_SELF_NOT_ALLOWED:
                var result_ALLOW_TRUST_SELF_NOT_ALLOWED = new AllowTrustResult.AllowTrustSelfNotAllowed();
                return result_ALLOW_TRUST_SELF_NOT_ALLOWED;
                case AllowTrustResultCode.ALLOW_TRUST_LOW_RESERVE:
                var result_ALLOW_TRUST_LOW_RESERVE = new AllowTrustResult.AllowTrustLowReserve();
                return result_ALLOW_TRUST_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for AllowTrustResult: {discriminator}");
            }
        }
    }
}
