// Generated code - do not modify
// Source:

// struct CreateContractArgs
// {
//     ContractIDPreimage contractIDPreimage;
//     ContractExecutable executable;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class CreateContractArgs
    {
        private ContractIDPreimage _contractIDPreimage;
        public ContractIDPreimage contractIDPreimage
        {
            get => _contractIDPreimage;
            set
            {
                _contractIDPreimage = value;
            }
        }

        private ContractExecutable _executable;
        public ContractExecutable executable
        {
            get => _executable;
            set
            {
                _executable = value;
            }
        }

        public CreateContractArgs()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class CreateContractArgsXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateContractArgs value)
        {
            value.Validate();
            ContractIDPreimageXdr.Encode(stream, value.contractIDPreimage);
            ContractExecutableXdr.Encode(stream, value.executable);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreateContractArgs Decode(XdrReader stream)
        {
            var result = new CreateContractArgs();
            result.contractIDPreimage = ContractIDPreimageXdr.Decode(stream);
            result.executable = ContractExecutableXdr.Decode(stream);
            return result;
        }
    }
}
