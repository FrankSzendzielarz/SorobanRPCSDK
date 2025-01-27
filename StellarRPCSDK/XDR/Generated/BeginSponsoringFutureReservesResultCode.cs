// Generated code - do not modify
// Source:

// enum BeginSponsoringFutureReservesResultCode
// {
//     // codes considered as "success" for the operation
//     BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED = -1,
//     BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED = -2,
//     BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE = -3
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum BeginSponsoringFutureReservesResultCode
    {
        BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS = 0,
        BEGIN_SPONSORING_FUTURE_RESERVES_MALFORMED = -1,
        BEGIN_SPONSORING_FUTURE_RESERVES_ALREADY_SPONSORED = -2,
        BEGIN_SPONSORING_FUTURE_RESERVES_RECURSIVE = -3,
    }

    public static partial class BeginSponsoringFutureReservesResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, BeginSponsoringFutureReservesResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static BeginSponsoringFutureReservesResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(BeginSponsoringFutureReservesResultCode), value))
              throw new InvalidOperationException($"Unknown BeginSponsoringFutureReservesResultCode value: {value}");
            return (BeginSponsoringFutureReservesResultCode)value;
        }
    }
