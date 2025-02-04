// Generated code - do not modify
// Source:

// union ExtendFootprintTTLResult switch (ExtendFootprintTTLResultCode code)
// {
// case EXTEND_FOOTPRINT_TTL_SUCCESS:
//     void;
// case EXTEND_FOOTPRINT_TTL_MALFORMED:
// case EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED:
// case EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE:
//     void;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ExtendFootprintTTLResult
    {
        public abstract ExtendFootprintTTLResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class ExtendFootprintTtlSuccess : ExtendFootprintTTLResult
        {
            public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_SUCCESS;

            public override void ValidateCase() {}
        }
        public sealed partial class ExtendFootprintTtlMalformed : ExtendFootprintTTLResult
        {
            public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_MALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class ExtendFootprintTtlResourceLimitExceeded : ExtendFootprintTTLResult
        {
            public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED;

            public override void ValidateCase() {}
        }
        public sealed partial class ExtendFootprintTtlInsufficientRefundableFee : ExtendFootprintTTLResult
        {
            public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE;

            public override void ValidateCase() {}
        }
    }
    public static partial class ExtendFootprintTTLResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ExtendFootprintTTLResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ExtendFootprintTTLResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ExtendFootprintTTLResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ExtendFootprintTTLResult.ExtendFootprintTtlSuccess case_EXTEND_FOOTPRINT_TTL_SUCCESS:
                break;
                case ExtendFootprintTTLResult.ExtendFootprintTtlMalformed case_EXTEND_FOOTPRINT_TTL_MALFORMED:
                break;
                case ExtendFootprintTTLResult.ExtendFootprintTtlResourceLimitExceeded case_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED:
                break;
                case ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee case_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static ExtendFootprintTTLResult Decode(XdrReader stream)
        {
            var discriminator = (ExtendFootprintTTLResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_SUCCESS:
                var result_EXTEND_FOOTPRINT_TTL_SUCCESS = new ExtendFootprintTTLResult.ExtendFootprintTtlSuccess();
                return result_EXTEND_FOOTPRINT_TTL_SUCCESS;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_MALFORMED:
                var result_EXTEND_FOOTPRINT_TTL_MALFORMED = new ExtendFootprintTTLResult.ExtendFootprintTtlMalformed();
                return result_EXTEND_FOOTPRINT_TTL_MALFORMED;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED:
                var result_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED = new ExtendFootprintTTLResult.ExtendFootprintTtlResourceLimitExceeded();
                return result_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE:
                var result_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE = new ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee();
                return result_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for ExtendFootprintTTLResult: {discriminator}");
            }
        }
    }
}
