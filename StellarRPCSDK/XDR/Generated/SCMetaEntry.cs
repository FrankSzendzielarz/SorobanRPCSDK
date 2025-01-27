// Generated code - do not modify
// Source:

// union SCMetaEntry switch (SCMetaKind kind)
// {
// case SC_META_V0:
//     SCMetaV0 v0;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCMetaEntry
    {
        public abstract SCMetaKind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCMetaEntry_SC_META_V0 : SCMetaEntry
    {
        public override SCMetaKind Discriminator => SC_META_V0;
        private SCMetaV0 _v0;
        public SCMetaV0 v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCMetaEntryXdr
    {
        public static void Encode(XdrWriter stream, SCMetaEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCMetaEntry_SC_META_V0 case_SC_META_V0:
                SCMetaV0Xdr.Encode(stream, case_SC_META_V0.v0);
                break;
            }
        }
        public static SCMetaEntry Decode(XdrReader stream)
        {
            var discriminator = (SCMetaKind)stream.ReadInt();
            switch (discriminator)
            {
                case SC_META_V0:
                var result_SC_META_V0 = new SCMetaEntry_SC_META_V0();
                result_SC_META_V0.                 = SCMetaV0Xdr.Decode(stream);
                return result_SC_META_V0;
                default:
                throw new Exception($"Unknown discriminator for SCMetaEntry: {discriminator}");
            }
        }
    }
}
