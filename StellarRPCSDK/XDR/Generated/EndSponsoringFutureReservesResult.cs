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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class EndSponsoringFutureReservesResult
    {
        public abstract EndSponsoringFutureReservesResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_SUCCESS : EndSponsoringFutureReservesResult
    {
        public override EndSponsoringFutureReservesResultCode Discriminator => END_SPONSORING_FUTURE_RESERVES_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED : EndSponsoringFutureReservesResult
    {
        public override EndSponsoringFutureReservesResultCode Discriminator => END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED;

        public override void ValidateCase() {}
    }
    public static partial class EndSponsoringFutureReservesResultXdr
    {
        public static void Encode(XdrWriter stream, EndSponsoringFutureReservesResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_SUCCESS case_END_SPONSORING_FUTURE_RESERVES_SUCCESS:
                break;
                case EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED case_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED:
                break;
            }
        }
        public static EndSponsoringFutureReservesResult Decode(XdrReader stream)
        {
            var discriminator = (EndSponsoringFutureReservesResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case END_SPONSORING_FUTURE_RESERVES_SUCCESS:
                var result_END_SPONSORING_FUTURE_RESERVES_SUCCESS = new EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_SUCCESS();
                return result_END_SPONSORING_FUTURE_RESERVES_SUCCESS;
                case END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED:
                var result_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED = new EndSponsoringFutureReservesResult_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED();
                return result_END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED;
                default:
                throw new Exception($"Unknown discriminator for EndSponsoringFutureReservesResult: {discriminator}");
            }
        }
    }
}
