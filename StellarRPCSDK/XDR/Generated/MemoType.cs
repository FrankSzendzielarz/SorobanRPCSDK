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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
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
