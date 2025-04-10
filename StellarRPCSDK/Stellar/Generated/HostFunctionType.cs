// Generated code - do not modify
// Source:

// enum HostFunctionType
// {
//     HOST_FUNCTION_TYPE_INVOKE_CONTRACT = 0,
//     HOST_FUNCTION_TYPE_CREATE_CONTRACT = 1,
//     HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = 2,
//     HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = 3
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
    public enum HostFunctionType
    {
        HOST_FUNCTION_TYPE_INVOKE_CONTRACT = 0,
        HOST_FUNCTION_TYPE_CREATE_CONTRACT = 1,
        HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM = 2,
        HOST_FUNCTION_TYPE_CREATE_CONTRACT_V2 = 3,
    }

    public static partial class HostFunctionTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HostFunctionType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HostFunctionTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static HostFunctionType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return HostFunctionTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, HostFunctionType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static HostFunctionType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(HostFunctionType), value))
              throw new InvalidOperationException($"Unknown HostFunctionType value: {value}");
            return (HostFunctionType)value;
        }
    }
}
