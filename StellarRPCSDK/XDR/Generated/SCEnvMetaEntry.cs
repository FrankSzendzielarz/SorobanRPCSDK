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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCEnvMetaEntry
    {
        public abstract SCEnvMetaKind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class interfaceVersionStruct
        {
            private uint32 _protocol;
            public uint32 protocol
            {
                get => _protocol;
                set
                {
                    _protocol = value;
                }
            }

            private uint32 _preRelease;
            public uint32 preRelease
            {
                get => _preRelease;
                set
                {
                    _preRelease = value;
                }
            }

            public interfaceVersionStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class interfaceVersionStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(interfaceVersionStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    interfaceVersionStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, interfaceVersionStruct value)
            {
                value.Validate();
                uint32Xdr.Encode(stream, value.protocol);
                uint32Xdr.Encode(stream, value.preRelease);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static interfaceVersionStruct Decode(XdrReader stream)
            {
                var result = new interfaceVersionStruct();
                result.protocol = uint32Xdr.Decode(stream);
                result.preRelease = uint32Xdr.Decode(stream);
                return result;
            }
        }
    }
    public sealed partial class SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION : SCEnvMetaEntry
    {
        public override SCEnvMetaKind Discriminator => SCEnvMetaKind.SC_ENV_META_KIND_INTERFACE_VERSION;
        private interfaceVersionStruct _interfaceVersion;
        public interfaceVersionStruct interfaceVersion
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCEnvMetaEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCEnvMetaEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCEnvMetaEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION case_SC_ENV_META_KIND_INTERFACE_VERSION:
                SCEnvMetaEntry.interfaceVersionStructXdr.Encode(stream, case_SC_ENV_META_KIND_INTERFACE_VERSION.interfaceVersion);
                break;
            }
        }
        public static SCEnvMetaEntry Decode(XdrReader stream)
        {
            var discriminator = (SCEnvMetaKind)stream.ReadInt();
            switch (discriminator)
            {
                case SCEnvMetaKind.SC_ENV_META_KIND_INTERFACE_VERSION:
                var result_SC_ENV_META_KIND_INTERFACE_VERSION = new SCEnvMetaEntry_SC_ENV_META_KIND_INTERFACE_VERSION();
                result_SC_ENV_META_KIND_INTERFACE_VERSION.interfaceVersion = SCEnvMetaEntry.interfaceVersionStructXdr.Decode(stream);
                return result_SC_ENV_META_KIND_INTERFACE_VERSION;
                default:
                throw new Exception($"Unknown discriminator for SCEnvMetaEntry: {discriminator}");
            }
        }
    }
}
