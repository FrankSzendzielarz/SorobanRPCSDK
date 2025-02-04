// Generated code - do not modify
// Source:

// enum OperationResultCode
// {
//     opINNER = 0, // inner object result is valid
// 
//     opBAD_AUTH = -1,            // too few valid signatures / wrong network
//     opNO_ACCOUNT = -2,          // source account was not found
//     opNOT_SUPPORTED = -3,       // operation not supported at this time
//     opTOO_MANY_SUBENTRIES = -4, // max number of subentries already reached
//     opEXCEEDED_WORK_LIMIT = -5, // operation did too much work
//     opTOO_MANY_SPONSORING = -6  // account is sponsoring too many entries
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum OperationResultCode
    {
        opINNER = 0,
        opBAD_AUTH = -1,
        opNO_ACCOUNT = -2,
        opNOT_SUPPORTED = -3,
        opTOO_MANY_SUBENTRIES = -4,
        opEXCEEDED_WORK_LIMIT = -5,
        opTOO_MANY_SPONSORING = -6,
    }

    public static partial class OperationResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OperationResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OperationResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, OperationResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static OperationResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(OperationResultCode), value))
              throw new InvalidOperationException($"Unknown OperationResultCode value: {value}");
            return (OperationResultCode)value;
        }
    }
}
