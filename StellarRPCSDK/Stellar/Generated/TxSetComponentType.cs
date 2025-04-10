// Generated code - do not modify
// Source:

// enum TxSetComponentType
// {
//   // txs with effective fee <= bid derived from a base fee (if any).
//   // If base fee is not specified, no discount is applied.
//   TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE = 0
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
    public enum TxSetComponentType
    {
        /// <summary>
        /// If base fee is not specified, no discount is applied.
        /// </summary>
        TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE = 0,
    }

    public static partial class TxSetComponentTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TxSetComponentType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TxSetComponentTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TxSetComponentType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TxSetComponentTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, TxSetComponentType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static TxSetComponentType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(TxSetComponentType), value))
              throw new InvalidOperationException($"Unknown TxSetComponentType value: {value}");
            return (TxSetComponentType)value;
        }
    }
}
