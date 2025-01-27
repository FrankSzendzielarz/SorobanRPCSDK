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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class InvokeHostFunctionResult
    {
        public abstract InvokeHostFunctionResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_SUCCESS : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_SUCCESS;
        private Hash _success;
        public Hash success
        {
            get => _success;
            set
            {
                _success = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_MALFORMED : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_TRAPPED : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_TRAPPED;

        public override void ValidateCase() {}
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED;

        public override void ValidateCase() {}
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED;

        public override void ValidateCase() {}
    }
    public sealed partial class InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE : InvokeHostFunctionResult
    {
        public override InvokeHostFunctionResultCode Discriminator => INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE;

        public override void ValidateCase() {}
    }
    public static partial class InvokeHostFunctionResultXdr
    {
        public static void Encode(XdrWriter stream, InvokeHostFunctionResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_SUCCESS case_INVOKE_HOST_FUNCTION_SUCCESS:
                HashXdr.Encode(stream, case_INVOKE_HOST_FUNCTION_SUCCESS.success);
                break;
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_MALFORMED case_INVOKE_HOST_FUNCTION_MALFORMED:
                break;
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_TRAPPED case_INVOKE_HOST_FUNCTION_TRAPPED:
                break;
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED case_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED:
                break;
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED case_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED:
                break;
                case InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE case_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE:
                break;
            }
        }
        public static InvokeHostFunctionResult Decode(XdrReader stream)
        {
            var discriminator = (InvokeHostFunctionResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case INVOKE_HOST_FUNCTION_SUCCESS:
                var result_INVOKE_HOST_FUNCTION_SUCCESS = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_SUCCESS();
                result_INVOKE_HOST_FUNCTION_SUCCESS.                 = HashXdr.Decode(stream);
                return result_INVOKE_HOST_FUNCTION_SUCCESS;
                case INVOKE_HOST_FUNCTION_MALFORMED:
                var result_INVOKE_HOST_FUNCTION_MALFORMED = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_MALFORMED();
                return result_INVOKE_HOST_FUNCTION_MALFORMED;
                case INVOKE_HOST_FUNCTION_TRAPPED:
                var result_INVOKE_HOST_FUNCTION_TRAPPED = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_TRAPPED();
                return result_INVOKE_HOST_FUNCTION_TRAPPED;
                case INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED:
                var result_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED();
                return result_INVOKE_HOST_FUNCTION_RESOURCE_LIMIT_EXCEEDED;
                case INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED:
                var result_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED();
                return result_INVOKE_HOST_FUNCTION_ENTRY_ARCHIVED;
                case INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE:
                var result_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE = new InvokeHostFunctionResult_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE();
                return result_INVOKE_HOST_FUNCTION_INSUFFICIENT_REFUNDABLE_FEE;
                default:
                throw new Exception($"Unknown discriminator for InvokeHostFunctionResult: {discriminator}");
            }
        }
    }
}
