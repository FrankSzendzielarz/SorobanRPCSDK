// Generated code - do not modify
// Source:

// union BeginSponsoringFutureReservesResult switch (
//     BeginSponsoringFutureReservesResultCode code)
// {
// case BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
//     void;
// case BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED:
// case BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED:
// case BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class BeginSponsoringFutureReservesResult
    {
        public abstract BeginSponsoringFutureReservesResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class BeginSponsoringFutureReservesSuccess : BeginSponsoringFutureReservesResult
        {
            public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS;

            public override void ValidateCase() {}
        }
        public sealed partial class BeginSponsoringFutureReservesMalformed : BeginSponsoringFutureReservesResult
        {
            public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class BeginSponsoringFutureReservesAlreadySponsored : BeginSponsoringFutureReservesResult
        {
            public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED;

            public override void ValidateCase() {}
        }
        public sealed partial class BeginSponsoringFutureReservesRecursive : BeginSponsoringFutureReservesResult
        {
            public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE;

            public override void ValidateCase() {}
        }
    }
    public static partial class BeginSponsoringFutureReservesResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BeginSponsoringFutureReservesResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BeginSponsoringFutureReservesResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, BeginSponsoringFutureReservesResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess case_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                break;
                case BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesMalformed case_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED:
                break;
                case BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored case_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED:
                break;
                case BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive case_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE:
                break;
            }
        }
        public static BeginSponsoringFutureReservesResult Decode(XdrReader stream)
        {
            var discriminator = (BeginSponsoringFutureReservesResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS = new BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED = new BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesMalformed();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED = new BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE = new BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE;
                default:
                throw new Exception($"Unknown discriminator for BeginSponsoringFutureReservesResult: {discriminator}");
            }
        }
    }
}
