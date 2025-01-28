// Generated code - do not modify
// Source:

// union SCEnvMetaEntry switch (SCEnvMetaKind kind)
// {
// case SC_ENV_META_KIND_INTERFACE_VERSION:
//     struct {
//         uint32 protocol;
//         uint32 preRelease;
//     } interfaceVersion;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCEnvMetaEntry
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION : SCEnvMetaEntry
    {
        public override int Discriminator => SC_ENV_META_KIND_INTERFACE_VERSION;
        private object _interfaceVersion;
        public object interfaceVersion
        {
            get => _interfaceVersion;
            set
            {
                _interfaceVersion = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCEnvMetaEntryXdr
    {
        public static void Encode(XdrWriter stream, SCEnvMetaEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION case_SC_ENV_META_KIND_INTERFACE_VERSION:
                Xdr.Encode(stream, case_SC_ENV_META_KIND_INTERFACE_VERSION.interfaceVersion);
                break;
            }
        }
        public static SCEnvMetaEntry Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case SC_ENV_META_KIND_INTERFACE_VERSION:
                var result_SC_ENV_META_KIND_INTERFACE_VERSION = new SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION();
                result_SC_ENV_META_KIND_INTERFACE_VERSION.                 = Xdr.Decode(stream);
                return result_SC_ENV_META_KIND_INTERFACE_VERSION;
                default:
                throw new Exception($"Unknown discriminator for SCEnvMetaEntry: {discriminator}");
            }
        }
    }
}
