// Generated code - do not modify
// Source:

// union RestoreFootprintResult switch (RestoreFootprintResultCode code)
// {
// case RESTORE_FOOTPRINT_SUCCESS:
//     void;
// case RESTORE_FOOTPRINT_MALFORMED:
// case RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED:
// case RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class RestoreFootprintResult
    {
        public abstract RestoreFootprintResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class RestoreFootprintResult_RESTORE_FOOTPRINT_SUCCESS : RestoreFootprintResult
    {
        public override RestoreFootprintResultCode Discriminator => RESTORE_FOOTPRINT_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class RestoreFootprintResult_RESTORE_FOOTPRINT_MALFORMED : RestoreFootprintResult
    {
        public override RestoreFootprintResultCode Discriminator => RESTORE_FOOTPRINT_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class RestoreFootprintResult_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED : RestoreFootprintResult
    {
        public override RestoreFootprintResultCode Discriminator => RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED;

        public override void ValidateCase() {}
    }
    public sealed partial class RestoreFootprintResult_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE : RestoreFootprintResult
    {
        public override RestoreFootprintResultCode Discriminator => RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE;

        public override void ValidateCase() {}
    }
    public static partial class RestoreFootprintResultXdr
    {
        public static void Encode(XdrWriter stream, RestoreFootprintResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RestoreFootprintResult_RESTORE_FOOTPRINT_SUCCESS case_RESTORE_FOOTPRINT_SUCCESS:
                break;
                case RestoreFootprintResult_RESTORE_FOOTPRINT_MALFORMED case_RESTORE_FOOTPRINT_MALFORMED:
                break;
                case RestoreFootprintResult_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED case_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED:
                break;
                case RestoreFootprintResult_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE case_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static RestoreFootprintResult Decode(XdrReader stream)
        {
            var discriminator = (RestoreFootprintResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case RESTORE_FOOTPRINT_SUCCESS:
                var result_RESTORE_FOOTPRINT_SUCCESS = new RestoreFootprintResult_RESTORE_FOOTPRINT_SUCCESS();
                return result_RESTORE_FOOTPRINT_SUCCESS;
                case RESTORE_FOOTPRINT_MALFORMED:
                var result_RESTORE_FOOTPRINT_MALFORMED = new RestoreFootprintResult_RESTORE_FOOTPRINT_MALFORMED();
                return result_RESTORE_FOOTPRINT_MALFORMED;
                case RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED:
                var result_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED = new RestoreFootprintResult_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED();
                return result_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED;
                case RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE:
                var result_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE = new RestoreFootprintResult_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE();
                return result_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for RestoreFootprintResult: {discriminator}");
            }
        }
    }
}
