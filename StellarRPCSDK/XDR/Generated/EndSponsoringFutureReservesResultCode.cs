// Generated code - do not modify
// Source:

// enum EndSponsoringFutureReservesResultCode
// {
//     // codes considered as "success" for the operation
//     END_SPONSORING_FUTURE_RESERVES_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED = -1
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum EndSponsoringFutureReservesResultCode
    {
        END_SPONSORING_FUTURE_RESERVES_SUCCESS = 0,
        END_SPONSORING_FUTURE_RESERVES_NOT_SPONSORED = -1,
    }

    public static partial class EndSponsoringFutureReservesResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EndSponsoringFutureReservesResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EndSponsoringFutureReservesResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, EndSponsoringFutureReservesResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static EndSponsoringFutureReservesResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(EndSponsoringFutureReservesResultCode), value))
              throw new InvalidOperationException($"Unknown EndSponsoringFutureReservesResultCode value: {value}");
            return (EndSponsoringFutureReservesResultCode)value;
        }
    }
}
