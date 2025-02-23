// Generated code - do not modify
// Source:

// union SorobanAuthorizedFunction switch (SorobanAuthorizedFunctionType type)
// {
// case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN:
//     InvokeContractArgs contractFn;
// // This variant of auth payload for creating new contract instances
// // doesn't allow specifying the constructor arguments, creating contracts
// // with constructors that take arguments is only possible by authorizing
// // `SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN` 
// // (protocol 22+).
// case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN:
//     CreateContractArgs createContractHostFn;
// // This variant of auth payload for creating new contract instances
// // is only accepted in and after protocol 22. It allows authorizing the
// // contract constructor arguments.
// case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN:
//     CreateContractArgsV2 createContractV2HostFn;
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
    [ProtoInclude(100, typeof(SorobanAuthorizedFunctionTypeContractFn), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(SorobanAuthorizedFunctionTypeCreateContractHostFn), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(SorobanAuthorizedFunctionTypeCreateContractV2HostFn), DataFormat = DataFormat.Default)]
    public abstract partial class SorobanAuthorizedFunction
    {
        public abstract SorobanAuthorizedFunctionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeContractFn")]
        public sealed partial class SorobanAuthorizedFunctionTypeContractFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN;
            [ProtoMember(1)]
            public InvokeContractArgs contractFn
            {
                get => _contractFn;
                set
                {
                    _contractFn = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Fn")]
            #endif
            private InvokeContractArgs _contractFn;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// (protocol 22+).
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn")]
        public sealed partial class SorobanAuthorizedFunctionTypeCreateContractHostFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN;
            [ProtoMember(2)]
            public CreateContractArgs createContractHostFn
            {
                get => _createContractHostFn;
                set
                {
                    _createContractHostFn = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Create Contract Host Fn")]
            #endif
            private CreateContractArgs _createContractHostFn;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// contract constructor arguments.
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn")]
        public sealed partial class SorobanAuthorizedFunctionTypeCreateContractV2HostFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN;
            [ProtoMember(3)]
            public CreateContractArgsV2 createContractV2HostFn
            {
                get => _createContractV2HostFn;
                set
                {
                    _createContractV2HostFn = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Create Contract V2 Host Fn")]
            #endif
            private CreateContractArgsV2 _createContractV2HostFn;

            public override void ValidateCase() {}
        }
    }
    public static partial class SorobanAuthorizedFunctionXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanAuthorizedFunction value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanAuthorizedFunctionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanAuthorizedFunction DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanAuthorizedFunctionXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SorobanAuthorizedFunction value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeContractFn case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN:
                InvokeContractArgsXdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN.contractFn);
                break;
                case SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN:
                CreateContractArgsXdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN.createContractHostFn);
                break;
                case SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN:
                CreateContractArgsV2Xdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN.createContractV2HostFn);
                break;
            }
        }
        public static SorobanAuthorizedFunction Decode(XdrReader stream)
        {
            var discriminator = (SorobanAuthorizedFunctionType)stream.ReadInt();
            switch (discriminator)
            {
                case SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN = new SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeContractFn();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN.contractFn = InvokeContractArgsXdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN;
                case SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN = new SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN.createContractHostFn = CreateContractArgsXdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN;
                case SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN = new SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN.createContractV2HostFn = CreateContractArgsV2Xdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN;
                default:
                throw new Exception($"Unknown discriminator for SorobanAuthorizedFunction: {discriminator}");
            }
        }
    }
}
