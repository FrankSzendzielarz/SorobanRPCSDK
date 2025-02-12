// Generated code - do not modify
// Source:

// struct SCContractInstance {
//     ContractExecutable executable;
//     SCMap* storage;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class SCContractInstance
    {
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

        public SCMap storage
        {
            get => _storage;
            set
            {
                _storage = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Storage")]
        #endif
        private SCMap _storage;

        public SCContractInstance()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCContractInstanceXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCContractInstance value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCContractInstanceXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCContractInstance value)
        {
            value.Validate();
            ContractExecutableXdr.Encode(stream, value.executable);
            if (value.storage==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                SCMapXdr.Encode(stream, value.storage);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCContractInstance Decode(XdrReader stream)
        {
            var result = new SCContractInstance();
            result.executable = ContractExecutableXdr.Decode(stream);
            if (stream.ReadInt()==1)
            {
                result.storage = SCMapXdr.Decode(stream);
            }
            return result;
        }
    }
}
