// Generated code - do not modify
// Source:

// struct Price
// {
//     int32 n; // numerator
//     int32 d; // denominator
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
    /// price in fractional representation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class Price
    {
        [ProtoMember(1)]
        public int32 n
        {
            get => _n;
            set
            {
                _n = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N")]
        #endif
        private int32 _n;

        /// <summary>
        /// numerator
        /// </summary>
        [ProtoMember(2)]
        public int32 d
        {
            get => _d;
            set
            {
                _d = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"D")]
        #endif
        private int32 _d;

        public Price()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PriceXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Price value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PriceXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Price DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PriceXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Price value)
        {
            value.Validate();
            int32Xdr.Encode(stream, value.n);
            int32Xdr.Encode(stream, value.d);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Price Decode(XdrReader stream)
        {
            var result = new Price();
            result.n = int32Xdr.Decode(stream);
            result.d = int32Xdr.Decode(stream);
            return result;
        }
    }
}
