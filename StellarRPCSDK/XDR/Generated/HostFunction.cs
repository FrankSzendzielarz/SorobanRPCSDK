// Generated code - do not modify
// Source:

// union HostFunction switch (HostFunctionType type)
// {
// case HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
//     InvokeContractArgs invokeContract;
// case HOST_FUNCTION_TYPE_CREATE_CONTRACT:
//     CreateContractArgs createContract;
// case HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
//     opaque wasm<>;
// case HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2:
//     CreateContractArgsV2 createContractV2;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class HostFunction
    {
        public abstract HostFunctionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class HostFunction_HOST_FUNCTION_TYPE_INVOKE_CONTRACT : HostFunction
    {
        public override HostFunctionType Discriminator => HOST_FUNCTION_TYPE_INVOKE_CONTRACT;
        private InvokeContractArgs _invokeContract;
        public InvokeContractArgs invokeContract
        {
            get => _invokeContract;
            set
            {
                _invokeContract = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT : HostFunction
    {
        public override HostFunctionType Discriminator => HOST_FUNCTION_TYPE_CREATE_CONTRACT;
        private CreateContractArgs _createContract;
        public CreateContractArgs createContract
        {
            get => _createContract;
            set
            {
                _createContract = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HostFunction_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM : HostFunction
    {
        public override HostFunctionType Discriminator => HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM;

        public override void ValidateCase() {}
    }
    public sealed partial class HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 : HostFunction
    {
        public override HostFunctionType Discriminator => HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2;
        private CreateContractArgsV2 _createContractV2;
        public CreateContractArgsV2 createContractV2
        {
            get => _createContractV2;
            set
            {
                _createContractV2 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class HostFunctionXdr
    {
        public static void Encode(XdrWriter stream, HostFunction value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HostFunction_HOST_FUNCTION_TYPE_INVOKE_CONTRACT case_HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                InvokeContractArgsXdr.Encode(stream, case_HOST_FUNCTION_TYPE_INVOKE_CONTRACT.invokeContract);
                break;
                case HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT case_HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                CreateContractArgsXdr.Encode(stream, case_HOST_FUNCTION_TYPE_CREATE_CONTRACT.createContract);
                break;
                case HostFunction_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM case_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                break;
                case HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 case_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2:
                CreateContractArgsV2Xdr.Encode(stream, case_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2.createContractV2);
                break;
            }
        }
        public static HostFunction Decode(XdrReader stream)
        {
            var discriminator = (HostFunctionType)stream.ReadInt();
            switch (discriminator)
            {
                case HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                var result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT = new HostFunction_HOST_FUNCTION_TYPE_INVOKE_CONTRACT();
                result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT.                 = InvokeContractArgsXdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT;
                case HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                var result_HOST_FUNCTION_TYPE_CREATE_CONTRACT = new HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT();
                result_HOST_FUNCTION_TYPE_CREATE_CONTRACT.                 = CreateContractArgsXdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_CREATE_CONTRACT;
                case HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                var result_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = new HostFunction_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM();
                return result_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM;
                case HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2:
                var result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = new HostFunction_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2();
                result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2.                 = CreateContractArgsV2Xdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2;
                default:
                throw new Exception($"Unknown discriminator for HostFunction: {discriminator}");
            }
        }
    }
}
