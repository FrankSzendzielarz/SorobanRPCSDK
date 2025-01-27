// Generated code - do not modify
// Source:

// enum SCMetaKind
// {
//     SC_META_V0 = 0
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCMetaKind
    {
        SC_META_V0 = 0,
    }

    public static partial class SCMetaKindXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMetaKind value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCMetaKind Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCMetaKind), value))
              throw new InvalidOperationException($"Unknown SCMetaKind value: {value}");
            return (SCMetaKind)value;
        }
    }
