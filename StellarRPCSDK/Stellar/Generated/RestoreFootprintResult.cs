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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(RestoreFootprintSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(RestoreFootprintMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(RestoreFootprintResourceLimitExceeded), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(RestoreFootprintInsufficientRefundableFee), DataFormat = DataFormat.Default)]
    public abstract partial class RestoreFootprintResult
    {
        public abstract RestoreFootprintResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "RestoreFootprintResult_RestoreFootprintSuccess")]
        public sealed partial class RestoreFootprintSuccess : RestoreFootprintResult
        {
            public override RestoreFootprintResultCode Discriminator => RestoreFootprintResultCode.RESTORE_FOOTPRINT_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RestoreFootprintResult_RestoreFootprintMalformed")]
        public sealed partial class RestoreFootprintMalformed : RestoreFootprintResult
        {
            public override RestoreFootprintResultCode Discriminator => RestoreFootprintResultCode.RESTORE_FOOTPRINT_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RestoreFootprintResult_RestoreFootprintResourceLimitExceeded")]
        public sealed partial class RestoreFootprintResourceLimitExceeded : RestoreFootprintResult
        {
            public override RestoreFootprintResultCode Discriminator => RestoreFootprintResultCode.RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RestoreFootprintResult_RestoreFootprintInsufficientRefundableFee")]
        public sealed partial class RestoreFootprintInsufficientRefundableFee : RestoreFootprintResult
        {
            public override RestoreFootprintResultCode Discriminator => RestoreFootprintResultCode.RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE;

            public override void ValidateCase() {}
        }
    }
    public static partial class RestoreFootprintResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RestoreFootprintResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RestoreFootprintResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static RestoreFootprintResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return RestoreFootprintResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, RestoreFootprintResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RestoreFootprintResult.RestoreFootprintSuccess case_RESTORE_FOOTPRINT_SUCCESS:
                break;
                case RestoreFootprintResult.RestoreFootprintMalformed case_RESTORE_FOOTPRINT_MALFORMED:
                break;
                case RestoreFootprintResult.RestoreFootprintResourceLimitExceeded case_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED:
                break;
                case RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee case_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static RestoreFootprintResult Decode(XdrReader stream)
        {
            var discriminator = (RestoreFootprintResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case RestoreFootprintResultCode.RESTORE_FOOTPRINT_SUCCESS:
                var result_RESTORE_FOOTPRINT_SUCCESS = new RestoreFootprintResult.RestoreFootprintSuccess();
                return result_RESTORE_FOOTPRINT_SUCCESS;
                case RestoreFootprintResultCode.RESTORE_FOOTPRINT_MALFORMED:
                var result_RESTORE_FOOTPRINT_MALFORMED = new RestoreFootprintResult.RestoreFootprintMalformed();
                return result_RESTORE_FOOTPRINT_MALFORMED;
                case RestoreFootprintResultCode.RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED:
                var result_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED = new RestoreFootprintResult.RestoreFootprintResourceLimitExceeded();
                return result_RESTORE_FOOTPRINT_RESOURCE_LIMIT_EXCEEDED;
                case RestoreFootprintResultCode.RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE:
                var result_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE = new RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee();
                return result_RESTORE_FOOTPRINT_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for RestoreFootprintResult: {discriminator}");
            }
        }
    }
}
