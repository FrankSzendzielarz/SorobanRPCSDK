// Generated code - do not modify
// Source:

// enum MemoType
// {
//     MEMO_NONE = 0,
//     MEMO_TEXT = 1,
//     MEMO_ID = 2,
//     MEMO_HASH = 3,
//     MEMO_RETURN = 4
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public enum MemoType
    {
        MEMO_NONE = 0,
        MEMO_TEXT = 1,
        MEMO_ID = 2,
        MEMO_HASH = 3,
        MEMO_RETURN = 4,
    }

    public static partial class MemoTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(MemoType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                MemoTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, MemoType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static MemoType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(MemoType), value))
              throw new InvalidOperationException($"Unknown MemoType value: {value}");
            return (MemoType)value;
        }
    }
}
