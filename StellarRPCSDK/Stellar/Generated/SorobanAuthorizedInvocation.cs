// Generated code - do not modify
// Source:

// struct SorobanAuthorizedInvocation
// {
//     SorobanAuthorizedFunction function;
//     SorobanAuthorizedInvocation subInvocations<>;
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
    public partial class SorobanAuthorizedInvocation
    {
        [ProtoMember(1)]
        public SorobanAuthorizedFunction function
        {
            get => _function;
            set
            {
                _function = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Function")]
        #endif
        private SorobanAuthorizedFunction _function;

        [ProtoMember(2, OverwriteList = true)]
        public SorobanAuthorizedInvocation[] subInvocations
        {
            get => _subInvocations;
            set
            {
                _subInvocations = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Sub Invocations")]
        #endif
        private SorobanAuthorizedInvocation[] _subInvocations;

        public SorobanAuthorizedInvocation()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanAuthorizedInvocationXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanAuthorizedInvocation value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanAuthorizedInvocationXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanAuthorizedInvocation DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanAuthorizedInvocationXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanAuthorizedInvocation value)
        {
            value.Validate();
            SorobanAuthorizedFunctionXdr.Encode(stream, value.function);
            stream.WriteInt(value.subInvocations.Length);
            foreach (var item in value.subInvocations)
            {
                    SorobanAuthorizedInvocationXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanAuthorizedInvocation Decode(XdrReader stream)
        {
            var result = new SorobanAuthorizedInvocation();
            result.function = SorobanAuthorizedFunctionXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.subInvocations = new SorobanAuthorizedInvocation[length];
                for (var i = 0; i < length; i++)
                {
                    result.subInvocations[i] = SorobanAuthorizedInvocationXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
