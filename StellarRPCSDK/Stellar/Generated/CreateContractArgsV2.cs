// Generated code - do not modify
// Source:

// struct CreateContractArgsV2
// {
//     ContractIDPreimage contractIDPreimage;
//     ContractExecutable executable;
//     // Arguments of the contract's constructor.
//     SCVal constructorArgs<>;
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
    public partial class CreateContractArgsV2
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

        /// <summary>
        /// Arguments of the contract's constructor.
        /// </summary>
        [ProtoMember(3, OverwriteList = true)]
        public SCVal[] constructorArgs
        {
            get => _constructorArgs;
            set
            {
                _constructorArgs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Constructor Args")]
        #endif
        private SCVal[] _constructorArgs;

        public CreateContractArgsV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class CreateContractArgsV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateContractArgsV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateContractArgsV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static CreateContractArgsV2 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return CreateContractArgsV2Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateContractArgsV2 value)
        {
            value.Validate();
            ContractIDPreimageXdr.Encode(stream, value.contractIDPreimage);
            ContractExecutableXdr.Encode(stream, value.executable);
            stream.WriteInt(value.constructorArgs.Length);
            foreach (var item in value.constructorArgs)
            {
                    SCValXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreateContractArgsV2 Decode(XdrReader stream)
        {
            var result = new CreateContractArgsV2();
            result.contractIDPreimage = ContractIDPreimageXdr.Decode(stream);
            result.executable = ContractExecutableXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.constructorArgs = new SCVal[length];
                for (var i = 0; i < length; i++)
                {
                    result.constructorArgs[i] = SCValXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
