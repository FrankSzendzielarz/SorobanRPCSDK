// Generated code - do not modify
// Source:

// enum SCErrorType
// {
//     SCE_CONTRACT = 0,          // Contract-specific, user-defined codes.
//     SCE_WASM_VM = 1,           // Errors while interpreting WASM bytecode.
//     SCE_CONTEXT = 2,           // Errors in the contract's host context.
//     SCE_STORAGE = 3,           // Errors accessing host storage.
//     SCE_OBJECT = 4,            // Errors working with host objects.
//     SCE_CRYPTO = 5,            // Errors in cryptographic operations.
//     SCE_EVENTS = 6,            // Errors while emitting events.
//     SCE_BUDGET = 7,            // Errors relating to budget limits.
//     SCE_VALUE = 8,             // Errors working with host values or SCVals.
//     SCE_AUTH = 9               // Errors from the authentication subsystem.
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
    public enum SCErrorType
    {
        SCE_CONTRACT = 0,
        /// <summary>
        /// Contract-specific, user-defined codes.
        /// </summary>
        SCE_WASM_VM = 1,
        /// <summary>
        /// Errors while interpreting WASM bytecode.
        /// </summary>
        SCE_CONTEXT = 2,
        /// <summary>
        /// Errors in the contract's host context.
        /// </summary>
        SCE_STORAGE = 3,
        /// <summary>
        /// Errors accessing host storage.
        /// </summary>
        SCE_OBJECT = 4,
        /// <summary>
        /// Errors working with host objects.
        /// </summary>
        SCE_CRYPTO = 5,
        /// <summary>
        /// Errors in cryptographic operations.
        /// </summary>
        SCE_EVENTS = 6,
        /// <summary>
        /// Errors while emitting events.
        /// </summary>
        SCE_BUDGET = 7,
        /// <summary>
        /// Errors relating to budget limits.
        /// </summary>
        SCE_VALUE = 8,
        /// <summary>
        /// Errors working with host values or SCVals.
        /// </summary>
        SCE_AUTH = 9,
    }

    public static partial class SCErrorTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCErrorType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCErrorTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCErrorType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCErrorTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCErrorType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCErrorType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCErrorType), value))
              throw new InvalidOperationException($"Unknown SCErrorType value: {value}");
            return (SCErrorType)value;
        }
    }
}
