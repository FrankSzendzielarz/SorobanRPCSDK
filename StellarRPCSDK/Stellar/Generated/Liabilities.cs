// Generated code - do not modify
// Source:

// struct Liabilities
// {
//     int64 buying;
//     int64 selling;
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
    public partial class Liabilities
    {
        [ProtoMember(1)]
        public int64 buying
        {
            get => _buying;
            set
            {
                _buying = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Buying")]
        #endif
        private int64 _buying;

        [ProtoMember(2)]
        public int64 selling
        {
            get => _selling;
            set
            {
                _selling = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Selling")]
        #endif
        private int64 _selling;

        public Liabilities()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LiabilitiesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Liabilities value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiabilitiesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Liabilities DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiabilitiesXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Liabilities value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.buying);
            int64Xdr.Encode(stream, value.selling);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Liabilities Decode(XdrReader stream)
        {
            var result = new Liabilities();
            result.buying = int64Xdr.Decode(stream);
            result.selling = int64Xdr.Decode(stream);
            return result;
        }
    }
}
