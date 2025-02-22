// Generated code - do not modify
// Source:

// struct SorobanAuthorizationEntry
// {
//     SorobanCredentials credentials;
//     SorobanAuthorizedInvocation rootInvocation;
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
    public partial class SorobanAuthorizationEntry
    {
        [ProtoMember(1)]
        public SorobanCredentials credentials
        {
            get => _credentials;
            set
            {
                _credentials = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Credentials")]
        #endif
        private SorobanCredentials _credentials;

        [ProtoMember(2)]
        public SorobanAuthorizedInvocation rootInvocation
        {
            get => _rootInvocation;
            set
            {
                _rootInvocation = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Root Invocation")]
        #endif
        private SorobanAuthorizedInvocation _rootInvocation;

        public SorobanAuthorizationEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanAuthorizationEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanAuthorizationEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanAuthorizationEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanAuthorizationEntry value)
        {
            value.Validate();
            SorobanCredentialsXdr.Encode(stream, value.credentials);
            SorobanAuthorizedInvocationXdr.Encode(stream, value.rootInvocation);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanAuthorizationEntry Decode(XdrReader stream)
        {
            var result = new SorobanAuthorizationEntry();
            result.credentials = SorobanCredentialsXdr.Decode(stream);
            result.rootInvocation = SorobanAuthorizedInvocationXdr.Decode(stream);
            return result;
        }
    }
}
