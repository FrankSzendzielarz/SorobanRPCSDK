// Generated code - do not modify
// Source:

// enum BumpSequenceResultCode
// {
//     // codes considered as "success" for the operation
//     BUMP_SEQUENCE_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     BUMP_SEQUENCE_BAD_SEQ = -1 // `bumpTo` is not within bounds
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum BumpSequenceResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        BUMP_SEQUENCE_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        BUMP_SEQUENCE_BAD_SEQ = -1,
    }

    public static partial class BumpSequenceResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BumpSequenceResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BumpSequenceResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, BumpSequenceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static BumpSequenceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(BumpSequenceResultCode), value))
              throw new InvalidOperationException($"Unknown BumpSequenceResultCode value: {value}");
            return (BumpSequenceResultCode)value;
        }
    }
}
