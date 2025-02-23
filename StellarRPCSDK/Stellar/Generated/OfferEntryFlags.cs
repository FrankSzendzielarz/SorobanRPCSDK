// Generated code - do not modify
// Source:

// enum OfferEntryFlags
// {
//     // an offer with this flag will not act on and take a reverse offer of equal
//     // price
//     PASSIVE_FLAG = 1
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
    public enum OfferEntryFlags
    {
        /// <summary>
        /// price
        /// </summary>
        PASSIVE_FLAG = 1,
    }

    public static partial class OfferEntryFlagsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OfferEntryFlags value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OfferEntryFlagsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static OfferEntryFlags DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return OfferEntryFlagsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, OfferEntryFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static OfferEntryFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(OfferEntryFlags), value))
              throw new InvalidOperationException($"Unknown OfferEntryFlags value: {value}");
            return (OfferEntryFlags)value;
        }
    }
}
