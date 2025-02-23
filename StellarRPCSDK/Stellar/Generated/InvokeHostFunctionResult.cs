// Generated code - do not modify
// Source:

// union InvokeHostFunctionResult switch (InvokeHostFunctionResultCode code)
// {
// case INVOKE_HOST_FUNCTION_SUCCESS:
//     Hash success; // sha256(InvokeHostFunctionSuccessPreImage)
// case INVOKE_HOST_FUNCTION_MALFORMED:
// case INVOKE_HOST_FUNCTION_TRAPPED:
// case INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED:
// case INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED:
// case INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE:
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
    [ProtoInclude(100, typeof(InvokeHostFunctionSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(InvokeHostFunctionMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(InvokeHostFunctionTrapped), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(InvokeHostFunctionResourceLimitExceeded), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(InvokeHostFunctionEntryArchived), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(InvokeHostFunctionInsufficientRefundableFee), DataFormat = DataFormat.Default)]
    public abstract partial class InvokeHostFunctionResult
    {
        public abstract InvokeHostFunctionResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionSuccess")]
        public sealed partial class InvokeHostFunctionSuccess : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_SUCCESS;
            [ProtoMember(1)]
            public Hash success
            {
                get => _success;
                set
                {
                    _success = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Success")]
            #endif
            private Hash _success;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// sha256(InvokeHostFunctionSuccessPreImage)
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionMalformed")]
        public sealed partial class InvokeHostFunctionMalformed : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_MALFORMED;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// sha256(InvokeHostFunctionSuccessPreImage)
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionTrapped")]
        public sealed partial class InvokeHostFunctionTrapped : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_TRAPPED;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// sha256(InvokeHostFunctionSuccessPreImage)
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionResourceLimitExceeded")]
        public sealed partial class InvokeHostFunctionResourceLimitExceeded : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// sha256(InvokeHostFunctionSuccessPreImage)
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionEntryArchived")]
        public sealed partial class InvokeHostFunctionEntryArchived : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// sha256(InvokeHostFunctionSuccessPreImage)
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "InvokeHostFunctionResult_InvokeHostFunctionInsufficientRefundableFee")]
        public sealed partial class InvokeHostFunctionInsufficientRefundableFee : InvokeHostFunctionResult
        {
            public override InvokeHostFunctionResultCode Discriminator => InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE;

            public override void ValidateCase() {}
        }
    }
    public static partial class InvokeHostFunctionResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InvokeHostFunctionResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InvokeHostFunctionResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static InvokeHostFunctionResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return InvokeHostFunctionResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, InvokeHostFunctionResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case InvokeHostFunctionResult.InvokeHostFunctionSuccess case_INVOKE_HOST_FUNCTION_SUCCESS:
                HashXdr.Encode(stream, case_INVOKE_HOST_FUNCTION_SUCCESS.success);
                break;
                case InvokeHostFunctionResult.InvokeHostFunctionMalformed case_INVOKE_HOST_FUNCTION_MALFORMED:
                break;
                case InvokeHostFunctionResult.InvokeHostFunctionTrapped case_INVOKE_HOST_FUNCTION_TRAPPED:
                break;
                case InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded case_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED:
                break;
                case InvokeHostFunctionResult.InvokeHostFunctionEntryArchived case_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED:
                break;
                case InvokeHostFunctionResult.InvokeHostFunctionInsufficientRefundableFee case_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static InvokeHostFunctionResult Decode(XdrReader stream)
        {
            var discriminator = (InvokeHostFunctionResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_SUCCESS:
                var result_INVOKE_HOST_FUNCTION_SUCCESS = new InvokeHostFunctionResult.InvokeHostFunctionSuccess();
                result_INVOKE_HOST_FUNCTION_SUCCESS.success = HashXdr.Decode(stream);
                return result_INVOKE_HOST_FUNCTION_SUCCESS;
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_MALFORMED:
                var result_INVOKE_HOST_FUNCTION_MALFORMED = new InvokeHostFunctionResult.InvokeHostFunctionMalformed();
                return result_INVOKE_HOST_FUNCTION_MALFORMED;
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_TRAPPED:
                var result_INVOKE_HOST_FUNCTION_TRAPPED = new InvokeHostFunctionResult.InvokeHostFunctionTrapped();
                return result_INVOKE_HOST_FUNCTION_TRAPPED;
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED:
                var result_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED = new InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded();
                return result_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED;
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED:
                var result_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED = new InvokeHostFunctionResult.InvokeHostFunctionEntryArchived();
                return result_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED;
                case InvokeHostFunctionResultCode.INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE:
                var result_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE = new InvokeHostFunctionResult.InvokeHostFunctionInsufficientRefundableFee();
                return result_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for InvokeHostFunctionResult: {discriminator}");
            }
        }
    }
}
