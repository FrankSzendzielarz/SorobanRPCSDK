// Generated code - do not modify
// Source:

// enum ClaimAtomType
// {
//     CLAIM_ATOM_TYPE_V0 = 0,
//     CLAIM_ATOM_TYPE_ORDER_BOOK = 1,
//     CLAIM_ATOM_TYPE_LIQUIDITY_POOL = 2
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
    public enum ClaimAtomType
    {
        CLAIM_ATOM_TYPE_V0 = 0,
        CLAIM_ATOM_TYPE_ORDER_BOOK = 1,
        CLAIM_ATOM_TYPE_LIQUIDITY_POOL = 2,
    }

    public static partial class ClaimAtomTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimAtomType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimAtomTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ClaimAtomType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClaimAtomTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimAtomType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimAtomType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimAtomType), value))
              throw new InvalidOperationException($"Unknown ClaimAtomType value: {value}");
            return (ClaimAtomType)value;
        }
    }
}
