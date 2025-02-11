// Generated code - do not modify
// Source:

// union PersistedSCPState switch (int v)
// {
// case 0:
// 	PersistedSCPStateV0 v0;
// case 1:
// 	PersistedSCPStateV1 v1;
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
    public abstract partial class PersistedSCPState
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class case_0 : PersistedSCPState
        {
            public override int Discriminator => 0;
            public PersistedSCPStateV0 v0
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
            private PersistedSCPStateV0 _v0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class case_1 : PersistedSCPState
        {
            public override int Discriminator => 1;
            public PersistedSCPStateV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"V1")]
            #endif
            private PersistedSCPStateV1 _v1;

            public override void ValidateCase() {}
        }
    }
    public static partial class PersistedSCPStateXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PersistedSCPState value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PersistedSCPStateXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, PersistedSCPState value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PersistedSCPState.case_0 case_0:
                PersistedSCPStateV0Xdr.Encode(stream, case_0.v0);
                break;
                case PersistedSCPState.case_1 case_1:
                PersistedSCPStateV1Xdr.Encode(stream, case_1.v1);
                break;
            }
        }
        public static PersistedSCPState Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new PersistedSCPState.case_0();
                result_0.v0 = PersistedSCPStateV0Xdr.Decode(stream);
                return result_0;
                case 1:
                var result_1 = new PersistedSCPState.case_1();
                result_1.v1 = PersistedSCPStateV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for PersistedSCPState: {discriminator}");
            }
        }
    }
}
