// Generated code - do not modify
// Source:

// enum ManageOfferEffect
// {
//     MANAGE_OFFER_CREATED = 0,
//     MANAGE_OFFER_UPDATED = 1,
//     MANAGE_OFFER_DELETED = 2
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
    public enum ManageOfferEffect
    {
        MANAGE_OFFER_CREATED = 0,
        MANAGE_OFFER_UPDATED = 1,
        MANAGE_OFFER_DELETED = 2,
    }

    public static partial class ManageOfferEffectXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageOfferEffect value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageOfferEffectXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ManageOfferEffect DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ManageOfferEffectXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageOfferEffect value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ManageOfferEffect Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ManageOfferEffect), value))
              throw new InvalidOperationException($"Unknown ManageOfferEffect value: {value}");
            return (ManageOfferEffect)value;
        }
    }
}
