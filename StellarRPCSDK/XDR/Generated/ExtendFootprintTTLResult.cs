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

    }
    public sealed partial class ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_SUCCESS : ExtendFootprintTTLResult
    {
        public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_MALFORMED : ExtendFootprintTTLResult
    {
        public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED : ExtendFootprintTTLResult
    {
        public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED;

        public override void ValidateCase() {}
    }
    public sealed partial class ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE : ExtendFootprintTTLResult
    {
        public override ExtendFootprintTTLResultCode Discriminator => ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE;

        public override void ValidateCase() {}
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
                case ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_SUCCESS case_EXTEND_FOOTPRINT_TTL_SUCCESS:
                break;
                case ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_MALFORMED case_EXTEND_FOOTPRINT_TTL_MALFORMED:
                break;
                case ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED case_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED:
                break;
                case ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE case_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static ExtendFootprintTTLResult Decode(XdrReader stream)
        {
            var discriminator = (ExtendFootprintTTLResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_SUCCESS:
                var result_EXTEND_FOOTPRINT_TTL_SUCCESS = new ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_SUCCESS();
                return result_EXTEND_FOOTPRINT_TTL_SUCCESS;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_MALFORMED:
                var result_EXTEND_FOOTPRINT_TTL_MALFORMED = new ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_MALFORMED();
                return result_EXTEND_FOOTPRINT_TTL_MALFORMED;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED:
                var result_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED = new ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED();
                return result_EXTEND_FOOTPRINT_TTL_RESOURCE_LIMIT_EXCEEDED;
                case ExtendFootprintTTLResultCode.EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE:
                var result_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE = new ExtendFootprintTTLResult_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE();
                return result_EXTEND_FOOTPRINT_TTL_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for ExtendFootprintTTLResult: {discriminator}");
            }
        }
    }
}
