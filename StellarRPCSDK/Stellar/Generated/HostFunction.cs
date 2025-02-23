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
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(HostFunctionTypeInvokeContract), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(HostFunctionTypeCreateContract), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(HostFunctionTypeUploadContractWasm), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(HostFunctionTypeCreateContractV2), DataFormat = DataFormat.Default)]
    public abstract partial class HostFunction
    {
        public abstract HostFunctionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "HostFunction.HostFunctionTypeInvokeContract")]
        public sealed partial class HostFunctionTypeInvokeContract : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_INVOKE_CONTRACT;
            [ProtoMember(1)]
            public InvokeContractArgs invokeContract
            {
                get => _invokeContract;
                set
                {
                    _invokeContract = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Invoke Contract")]
            #endif
            private InvokeContractArgs _invokeContract;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HostFunction.HostFunctionTypeCreateContract")]
        public sealed partial class HostFunctionTypeCreateContract : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT;
            [ProtoMember(2)]
            public CreateContractArgs createContract
            {
                get => _createContract;
                set
                {
                    _createContract = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Create Contract")]
            #endif
            private CreateContractArgs _createContract;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HostFunction.HostFunctionTypeUploadContractWasm")]
        public sealed partial class HostFunctionTypeUploadContractWasm : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM;
            [ProtoMember(3)]
            public byte[] wasm
            {
                get => _wasm;
                set
                {
                    _wasm = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Wasm")]
            #endif
            private byte[] _wasm;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HostFunction.HostFunctionTypeCreateContractV2")]
        public sealed partial class HostFunctionTypeCreateContractV2 : HostFunction
        {
            public override HostFunctionType Discriminator => HostFunctionType.HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2;
            [ProtoMember(4)]
            public CreateContractArgsV2 createContractV2
            {
                get => _createContractV2;
                set
                {
                    _createContractV2 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Create Contract V2")]
            #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static HostFunction DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return HostFunctionXdr.Decode(reader);
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
