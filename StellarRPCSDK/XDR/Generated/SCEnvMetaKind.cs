// Generated code - do not modify
// Source:

// enum SCEnvMetaKind
// {
//     SC_ENV_META_KIND_INTERFACE_VERSION = 0
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SCEnvMetaKind
    {
        SC_ENV_META_KIND_INTERFACE_VERSION = 0,
    }

    public static partial class SCEnvMetaKindXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCEnvMetaKind value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCEnvMetaKind Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCEnvMetaKind), value))
              throw new InvalidOperationException($"Unknown SCEnvMetaKind value: {value}");
            return (SCEnvMetaKind)value;
        }
    }
}
