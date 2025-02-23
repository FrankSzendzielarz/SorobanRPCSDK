// Generated code - do not modify
// Source:

// struct CreateContractArgs
// {
//     ContractIDPreimage contractIDPreimage;
//     ContractExecutable executable;
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
    public partial class CreateContractArgs
    {
        [ProtoMember(1)]
        public ContractIDPreimage contractIDPreimage
        {
            get => _contractIDPreimage;
            set
            {
                _contractIDPreimage = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Contract I D Preimage")]
        #endif
        private ContractIDPreimage _contractIDPreimage;

        [ProtoMember(2)]
        public ContractExecutable executable
        {
            get => _executable;
            set
            {
                _executable = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Executable")]
        #endif
        private ContractExecutable _executable;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateContractArgs value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateContractArgsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CreateContractArgs DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CreateContractArgsXdr.Decode(reader);
            }
        }
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
