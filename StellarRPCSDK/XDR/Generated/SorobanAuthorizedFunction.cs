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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SorobanAuthorizedFunction
    {
        public abstract SorobanAuthorizedFunctionType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class SorobanAuthorizedFunctionTypeContractFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN;
            public InvokeContractArgs contractFn
            {
                get => _contractFn;
                set
                {
                    _contractFn = value;
                }
            }
            private InvokeContractArgs _contractFn;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// (protocol 22+).
        /// </summary>
        public sealed partial class SorobanAuthorizedFunctionTypeCreateContractHostFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN;
            public CreateContractArgs createContractHostFn
            {
                get => _createContractHostFn;
                set
                {
                    _createContractHostFn = value;
                }
            }
            private CreateContractArgs _createContractHostFn;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// contract constructor arguments.
        /// </summary>
        public sealed partial class SorobanAuthorizedFunctionTypeCreateContractV2HostFn : SorobanAuthorizedFunction
        {
            public override SorobanAuthorizedFunctionType Discriminator => SorobanAuthorizedFunctionType.SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN;
            public CreateContractArgsV2 createContractV2HostFn
            {
                get => _createContractV2HostFn;
                set
                {
                    _createContractV2HostFn = value;
                }
            }
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
