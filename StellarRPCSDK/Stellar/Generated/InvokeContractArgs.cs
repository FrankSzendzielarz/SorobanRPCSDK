// Generated code - do not modify
// Source:

// struct InvokeContractArgs {
//     SCAddress contractAddress;
//     SCSymbol functionName;
//     SCVal args<>;
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
    public partial class InvokeContractArgs
    {
        [ProtoMember(1)]
        public SCAddress contractAddress
        {
            get => _contractAddress;
            set
            {
                _contractAddress = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Contract Address")]
        #endif
        private SCAddress _contractAddress;

        [ProtoMember(2)]
        public SCSymbol functionName
        {
            get => _functionName;
            set
            {
                _functionName = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Function Name")]
        #endif
        private SCSymbol _functionName;

        [ProtoMember(3, OverwriteList = true)]
        public SCVal[] args
        {
            get => _args;
            set
            {
                _args = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Args")]
        #endif
        private SCVal[] _args;

        public InvokeContractArgs()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InvokeContractArgsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InvokeContractArgs value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InvokeContractArgsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static InvokeContractArgs DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return InvokeContractArgsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InvokeContractArgs value)
        {
            value.Validate();
            SCAddressXdr.Encode(stream, value.contractAddress);
            SCSymbolXdr.Encode(stream, value.functionName);
            stream.WriteInt(value.args.Length);
            foreach (var item in value.args)
            {
                    SCValXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InvokeContractArgs Decode(XdrReader stream)
        {
            var result = new InvokeContractArgs();
            result.contractAddress = SCAddressXdr.Decode(stream);
            result.functionName = SCSymbolXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.args = new SCVal[length];
                for (var i = 0; i < length; i++)
                {
                    result.args[i] = SCValXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
