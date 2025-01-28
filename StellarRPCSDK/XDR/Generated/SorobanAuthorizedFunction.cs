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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SorobanAuthorizedFunction
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN : SorobanAuthorizedFunction
    {
        public override int Discriminator => SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN;
        private InvokeContractArgs _contractFn;
        public InvokeContractArgs contractFn
        {
            get => _contractFn;
            set
            {
                _contractFn = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN : SorobanAuthorizedFunction
    {
        public override int Discriminator => SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN;
        private CreateContractArgs _createContractHostFn;
        public CreateContractArgs createContractHostFn
        {
            get => _createContractHostFn;
            set
            {
                _createContractHostFn = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN : SorobanAuthorizedFunction
    {
        public override int Discriminator => SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN;
        private CreateContractArgsV2 _createContractV2HostFn;
        public CreateContractArgsV2 createContractV2HostFn
        {
            get => _createContractV2HostFn;
            set
            {
                _createContractV2HostFn = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SorobanAuthorizedFunctionXdr
    {
        public static void Encode(XdrWriter stream, SorobanAuthorizedFunction value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN:
                InvokeContractArgsXdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN.contractFn);
                break;
                case SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN:
                CreateContractArgsXdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN.createContractHostFn);
                break;
                case SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN:
                CreateContractArgsV2Xdr.Encode(stream, case_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN.createContractV2HostFn);
                break;
            }
        }
        public static SorobanAuthorizedFunction Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN = new SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN.                 = InvokeContractArgsXdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CONTRACT_FN;
                case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN = new SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN.                 = CreateContractArgsXdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_HOST_FN;
                case SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN:
                var result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN = new SorobanAuthorizedFunction_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN();
                result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN.                 = CreateContractArgsV2Xdr.Decode(stream);
                return result_SOROBAN_AUTHORIZED_FUNCTION_TYPE_CREATE_CONTRACT_V2_HOST_FN;
                default:
                throw new Exception($"Unknown discriminator for SorobanAuthorizedFunction: {discriminator}");
            }
        }
    }
}
