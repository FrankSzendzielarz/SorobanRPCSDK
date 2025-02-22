// Generated code - do not modify
// Source:

// struct InvokeHostFunctionSuccessPreImage
// {
//     SCVal returnValue;
//     ContractEvent events<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// This is in Stellar-ledger.x to due to a circular dependency
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class InvokeHostFunctionSuccessPreImage
    {
        [ProtoMember(1)]
        public SCVal returnValue
        {
            get => _returnValue;
            set
            {
                _returnValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Return Value")]
        #endif
        private SCVal _returnValue;

        [ProtoMember(2)]
        public ContractEvent[] events
        {
            get => _events;
            set
            {
                _events = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Events")]
        #endif
        private ContractEvent[] _events;

        public InvokeHostFunctionSuccessPreImage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InvokeHostFunctionSuccessPreImageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InvokeHostFunctionSuccessPreImage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InvokeHostFunctionSuccessPreImageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InvokeHostFunctionSuccessPreImage value)
        {
            value.Validate();
            SCValXdr.Encode(stream, value.returnValue);
            stream.WriteInt(value.events.Length);
            foreach (var item in value.events)
            {
                    ContractEventXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InvokeHostFunctionSuccessPreImage Decode(XdrReader stream)
        {
            var result = new InvokeHostFunctionSuccessPreImage();
            result.returnValue = SCValXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.events = new ContractEvent[length];
                for (var i = 0; i < length; i++)
                {
                    result.events[i] = ContractEventXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
