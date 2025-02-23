// Generated code - do not modify
// Source:

// union EndSponsoringFutureReservesResult switch (
//     EndSponsoringFutureReservesResultCode code)
// {
// case END_SPONSORING_FUTURE_RESERVES_SUCCESS:
//     void;
// case END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED:
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
    [ProtoInclude(100, typeof(EndSponsoringFutureReservesSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(EndSponsoringFutureReservesNotSponsored), DataFormat = DataFormat.Default)]
    public abstract partial class EndSponsoringFutureReservesResult
    {
        public abstract EndSponsoringFutureReservesResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess")]
        public sealed partial class EndSponsoringFutureReservesSuccess : EndSponsoringFutureReservesResult
        {
            public override EndSponsoringFutureReservesResultCode Discriminator => EndSponsoringFutureReservesResultCode.END_SPONSORING_FUTURE_RESERVES_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored")]
        public sealed partial class EndSponsoringFutureReservesNotSponsored : EndSponsoringFutureReservesResult
        {
            public override EndSponsoringFutureReservesResultCode Discriminator => EndSponsoringFutureReservesResultCode.END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED;

            public override void ValidateCase() {}
        }
    }
    public static partial class EndSponsoringFutureReservesResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EndSponsoringFutureReservesResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EndSponsoringFutureReservesResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static EndSponsoringFutureReservesResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return EndSponsoringFutureReservesResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, EndSponsoringFutureReservesResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess case_END_SPONSORING_FUTURE_RESERVES_SUCCESS:
                break;
                case EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored case_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED:
                break;
            }
        }
        public static EndSponsoringFutureReservesResult Decode(XdrReader stream)
        {
            var discriminator = (EndSponsoringFutureReservesResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case EndSponsoringFutureReservesResultCode.END_SPONSORING_FUTURE_RESERVES_SUCCESS:
                var result_END_SPONSORING_FUTURE_RESERVES_SUCCESS = new EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess();
                return result_END_SPONSORING_FUTURE_RESERVES_SUCCESS;
                case EndSponsoringFutureReservesResultCode.END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED:
                var result_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED = new EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored();
                return result_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED;
                default:
                throw new Exception($"Unknown discriminator for EndSponsoringFutureReservesResult: {discriminator}");
            }
        }
    }
}
