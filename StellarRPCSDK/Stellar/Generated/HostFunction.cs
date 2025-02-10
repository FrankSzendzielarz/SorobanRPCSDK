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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class HostFunction
    {
        public abstract HostFunctionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class HostFunctionTypeInvokeContract : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_INVOKE_CONTRACT;
            public InvokeContractArgs invokeContract
            {
                get => _invokeContract;
                set
                {
                    _invokeContract = value;
                }
            }
            private InvokeContractArgs _invokeContract;

            public override void ValidateCase() {}
        }
        public sealed partial class HostFunctionTypeCreateContract : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT;
            public CreateContractArgs createContract
            {
                get => _createContract;
                set
                {
                    _createContract = value;
                }
            }
            private CreateContractArgs _createContract;

            public override void ValidateCase() {}
        }
        public sealed partial class HostFunctionTypeUploadContractWasm : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM;
            public byte[] wasm
            {
                get => _wasm;
                set
                {
                    _wasm = value;
                }
            }
            private byte[] _wasm;

            public override void ValidateCase() {}
        }
        public sealed partial class HostFunctionTypeCreateContractV2 : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2;
            public CreateContractArgsV2 createContractV2
            {
                get => _createContractV2;
                set
                {
                    _createContractV2 = value;
                }
            }
            private CreateContractArgsV2 _createContractV2;

            public override void ValidateCase() {}
        }
    }
    public static partial class HostFunctionXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HostFunction value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HostFunctionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, HostFunction value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HostFunction.HostFunctionTypeInvokeContract case_HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                InvokeContractArgsXdr.Encode(stream, case_HOST_FUNCTION_TYPE_INVOKE_CONTRACT.invokeContract);
                break;
                case HostFunction.HostFunctionTypeCreateContract case_HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                CreateContractArgsXdr.Encode(stream, case_HOST_FUNCTION_TYPE_CREATE_CONTRACT.createContract);
                break;
                case HostFunction.HostFunctionTypeUploadContractWasm case_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                stream.WriteOpaque(case_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM.wasm);
                break;
                case HostFunction.HostFunctionTypeCreateContractV2 case_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2:
                CreateContractArgsV2Xdr.Encode(stream, case_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2.createContractV2);
                break;
            }
        }
        public static HostFunction Decode(XdrReader stream)
        {
            var discriminator = (HostFunctionType)stream.ReadInt();
            switch (discriminator)
            {
                case HostFunctionType.HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                var result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT = new HostFunction.HostFunctionTypeInvokeContract();
                result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT.invokeContract = InvokeContractArgsXdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_INVOKE_CONTRACT;
                case HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                var result_HOST_FUNCTION_TYPE_CREATE_CONTRACT = new HostFunction.HostFunctionTypeCreateContract();
                result_HOST_FUNCTION_TYPE_CREATE_CONTRACT.createContract = CreateContractArgsXdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_CREATE_CONTRACT;
                case HostFunctionType.HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                var result_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = new HostFunction.HostFunctionTypeUploadContractWasm();
                result_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM.wasm = stream.ReadOpaque();
                return result_HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM;
                case HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2:
                var result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = new HostFunction.HostFunctionTypeCreateContractV2();
                result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2.createContractV2 = CreateContractArgsV2Xdr.Decode(stream);
                return result_HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2;
                default:
                throw new Exception($"Unknown discriminator for HostFunction: {discriminator}");
            }
        }
    }
}
