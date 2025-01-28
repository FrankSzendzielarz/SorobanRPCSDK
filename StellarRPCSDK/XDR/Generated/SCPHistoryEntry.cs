// Generated code - do not modify
// Source:

// union SCPHistoryEntry switch (int v)
// {
// case 0:
//     SCPHistoryEntryV0 v0;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCPHistoryEntry
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCPHistoryEntry_0 : SCPHistoryEntry
    {
        public override int Discriminator => int.0;
        private SCPHistoryEntryV0 _v0;
        public SCPHistoryEntryV0 v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCPHistoryEntryXdr
    {
        public static void Encode(XdrWriter stream, SCPHistoryEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCPHistoryEntry_0 case_0:
                SCPHistoryEntryV0Xdr.Encode(stream, case_0.v0);
                break;
            }
        }
        public static SCPHistoryEntry Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new SCPHistoryEntry_0();
                result_0.                 = SCPHistoryEntryV0Xdr.Decode(stream);
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for SCPHistoryEntry: {discriminator}");
            }
        }
    }
}
