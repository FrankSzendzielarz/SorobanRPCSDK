// Generated code - do not modify
// Source:

// union BumpSequenceResult switch (BumpSequenceResultCode code)
// {
// case BUMP_SEQUENCE_SUCCESS:
//     void;
// case BUMP_SEQUENCE_BAD_SEQ:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class BumpSequenceResult
    {
        public abstract BumpSequenceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class BumpSequenceResult_BUMP_SEQUENCE_SUCCESS : BumpSequenceResult
    {
        public override BumpSequenceResultCode Discriminator => BumpSequenceResultCode.BUMP_SEQUENCE_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class BumpSequenceResult_BUMP_SEQUENCE_BAD_SEQ : BumpSequenceResult
    {
        public override BumpSequenceResultCode Discriminator => BumpSequenceResultCode.BUMP_SEQUENCE_BAD_SEQ;

        public override void ValidateCase() {}
    }
    public static partial class BumpSequenceResultXdr
    {
        public static void Encode(XdrWriter stream, BumpSequenceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case BumpSequenceResult_BUMP_SEQUENCE_SUCCESS case_BUMP_SEQUENCE_SUCCESS:
                break;
                case BumpSequenceResult_BUMP_SEQUENCE_BAD_SEQ case_BUMP_SEQUENCE_BAD_SEQ:
                break;
            }
        }
        public static BumpSequenceResult Decode(XdrReader stream)
        {
            var discriminator = (BumpSequenceResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case BumpSequenceResultCode.BUMP_SEQUENCE_SUCCESS:
                var result_BUMP_SEQUENCE_SUCCESS = new BumpSequenceResult_BUMP_SEQUENCE_SUCCESS();
                return result_BUMP_SEQUENCE_SUCCESS;
                case BumpSequenceResultCode.BUMP_SEQUENCE_BAD_SEQ:
                var result_BUMP_SEQUENCE_BAD_SEQ = new BumpSequenceResult_BUMP_SEQUENCE_BAD_SEQ();
                return result_BUMP_SEQUENCE_BAD_SEQ;
                default:
                throw new Exception($"Unknown discriminator for BumpSequenceResult: {discriminator}");
            }
        }
    }
}
