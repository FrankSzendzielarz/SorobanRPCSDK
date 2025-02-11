// Generated code - do not modify
// Source:

// union SCMetaEntry switch (SCMetaKind kind)
// {
// case SC_META_V0:
//     SCMetaV0 v0;
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
    public abstract partial class SCMetaEntry
    {
        public abstract SCMetaKind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ScMetaV0 : SCMetaEntry
        {
            public override SCMetaKind Discriminator => SCMetaKind.SC_META_V0;
            public SCMetaV0 v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"V0")]
            #endif
            private SCMetaV0 _v0;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCMetaEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCMetaEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCMetaEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCMetaEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCMetaEntry.ScMetaV0 case_SC_META_V0:
                SCMetaV0Xdr.Encode(stream, case_SC_META_V0.v0);
                break;
            }
        }
        public static SCMetaEntry Decode(XdrReader stream)
        {
            var discriminator = (SCMetaKind)stream.ReadInt();
            switch (discriminator)
            {
                case SCMetaKind.SC_META_V0:
                var result_SC_META_V0 = new SCMetaEntry.ScMetaV0();
                result_SC_META_V0.v0 = SCMetaV0Xdr.Decode(stream);
                return result_SC_META_V0;
                default:
                throw new Exception($"Unknown discriminator for SCMetaEntry: {discriminator}");
            }
        }
    }
}
