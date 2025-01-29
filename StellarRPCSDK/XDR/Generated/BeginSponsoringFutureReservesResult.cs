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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class BeginSponsoringFutureReservesResult
    {
        public abstract BeginSponsoringFutureReservesResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS : BeginSponsoringFutureReservesResult
    {
        public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED : BeginSponsoringFutureReservesResult
    {
        public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED : BeginSponsoringFutureReservesResult
    {
        public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED;

        public override void ValidateCase() {}
    }
    public sealed partial class BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE : BeginSponsoringFutureReservesResult
    {
        public override BeginSponsoringFutureReservesResultCode Discriminator => BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE;

        public override void ValidateCase() {}
    }
    public static partial class BeginSponsoringFutureReservesResultXdr
    {
        public static void Encode(XdrWriter stream, BeginSponsoringFutureReservesResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS case_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                break;
                case BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED case_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED:
                break;
                case BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED case_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED:
                break;
                case BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE case_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE:
                break;
            }
        }
        public static BeginSponsoringFutureReservesResult Decode(XdrReader stream)
        {
            var discriminator = (BeginSponsoringFutureReservesResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS = new BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED = new BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED = new BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED;
                case BeginSponsoringFutureReservesResultCode.BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE:
                var result_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE = new BeginSponsoringFutureReservesResult_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE();
                return result_BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE;
                default:
                throw new Exception($"Unknown discriminator for BeginSponsoringFutureReservesResult: {discriminator}");
            }
        }
    }
}
