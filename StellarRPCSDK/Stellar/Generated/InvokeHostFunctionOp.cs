// Generated code - do not modify
// Source:

// struct InvokeHostFunctionOp
// {
//     // Host function to invoke.
//     HostFunction hostFunction;
//     // Per-address authorizations for this host function.
//     SorobanAuthorizationEntry auth<>;
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
    public partial class InvokeHostFunctionOp
    {
        /// <summary>
        /// Host function to invoke.
        /// </summary>
        [ProtoMember(1)]
        public HostFunction hostFunction
        {
            get => _hostFunction;
            set
            {
                _hostFunction = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Host Function")]
        #endif
        private HostFunction _hostFunction;

        /// <summary>
        /// Per-address authorizations for this host function.
        /// </summary>
        [ProtoMember(2, OverwriteList = true)]
        public SorobanAuthorizationEntry[] auth
        {
            get => _auth;
            set
            {
                _auth = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Auth")]
        #endif
        private SorobanAuthorizationEntry[] _auth;

        public InvokeHostFunctionOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InvokeHostFunctionOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InvokeHostFunctionOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InvokeHostFunctionOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static InvokeHostFunctionOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return InvokeHostFunctionOpXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InvokeHostFunctionOp value)
        {
            value.Validate();
            HostFunctionXdr.Encode(stream, value.hostFunction);
            stream.WriteInt(value.auth.Length);
            foreach (var item in value.auth)
            {
                    SorobanAuthorizationEntryXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InvokeHostFunctionOp Decode(XdrReader stream)
        {
            var result = new InvokeHostFunctionOp();
            result.hostFunction = HostFunctionXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.auth = new SorobanAuthorizationEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.auth[i] = SorobanAuthorizationEntryXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
