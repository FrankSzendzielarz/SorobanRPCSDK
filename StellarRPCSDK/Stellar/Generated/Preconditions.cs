// Generated code - do not modify
// Source:

// union Preconditions switch (PreconditionType type)
// {
// case PRECOND_NONE:
//     void;
// case PRECOND_TIME:
//     TimeBounds timeBounds;
// case PRECOND_V2:
//     PreconditionsV2 v2;
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
    public abstract partial class Preconditions
    {
        public abstract PreconditionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class PrecondNone : Preconditions
        {
            public override PreconditionType Discriminator => PreconditionType.PRECOND_NONE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class PrecondTime : Preconditions
        {
            public override PreconditionType Discriminator => PreconditionType.PRECOND_TIME;
            public TimeBounds timeBounds
            {
                get => _timeBounds;
                set
                {
                    _timeBounds = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Time Bounds")]
            #endif
            private TimeBounds _timeBounds;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class PrecondV2 : Preconditions
        {
            public override PreconditionType Discriminator => PreconditionType.PRECOND_V2;
            public PreconditionsV2 v2
            {
                get => _v2;
                set
                {
                    _v2 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V2")]
            #endif
            private PreconditionsV2 _v2;

            public override void ValidateCase() {}
        }
    }
    public static partial class PreconditionsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Preconditions value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PreconditionsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Preconditions value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Preconditions.PrecondNone case_PRECOND_NONE:
                break;
                case Preconditions.PrecondTime case_PRECOND_TIME:
                TimeBoundsXdr.Encode(stream, case_PRECOND_TIME.timeBounds);
                break;
                case Preconditions.PrecondV2 case_PRECOND_V2:
                PreconditionsV2Xdr.Encode(stream, case_PRECOND_V2.v2);
                break;
            }
        }
        public static Preconditions Decode(XdrReader stream)
        {
            var discriminator = (PreconditionType)stream.ReadInt();
            switch (discriminator)
            {
                case PreconditionType.PRECOND_NONE:
                var result_PRECOND_NONE = new Preconditions.PrecondNone();
                return result_PRECOND_NONE;
                case PreconditionType.PRECOND_TIME:
                var result_PRECOND_TIME = new Preconditions.PrecondTime();
                result_PRECOND_TIME.timeBounds = TimeBoundsXdr.Decode(stream);
                return result_PRECOND_TIME;
                case PreconditionType.PRECOND_V2:
                var result_PRECOND_V2 = new Preconditions.PrecondV2();
                result_PRECOND_V2.v2 = PreconditionsV2Xdr.Decode(stream);
                return result_PRECOND_V2;
                default:
                throw new Exception($"Unknown discriminator for Preconditions: {discriminator}");
            }
        }
    }
}
