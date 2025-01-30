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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PersistedSCPState
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class PersistedSCPState_0 : PersistedSCPState
    {
        public override int Discriminator => 0;
        private PersistedSCPStateV0 _v0;
        public PersistedSCPStateV0 v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class PersistedSCPState_1 : PersistedSCPState
    {
        public override int Discriminator => 1;
        private PersistedSCPStateV1 _v1;
        public PersistedSCPStateV1 v1
        {
            get => _v1;
            set
            {
                _v1 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class PersistedSCPStateXdr
    {
        public static void Encode(XdrWriter stream, PersistedSCPState value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PersistedSCPState_0 case_0:
                PersistedSCPStateV0Xdr.Encode(stream, case_0.v0);
                break;
                case PersistedSCPState_1 case_1:
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
                var result_0 = new PersistedSCPState_0();
                result_0.v0 = PersistedSCPStateV0Xdr.Decode(stream);
                return result_0;
                case 1:
                var result_1 = new PersistedSCPState_1();
                result_1.v1 = PersistedSCPStateV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for PersistedSCPState: {discriminator}");
            }
        }
    }
}
