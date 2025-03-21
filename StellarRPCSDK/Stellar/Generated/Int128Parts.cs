// Generated code - do not modify
// Source:

// struct Int128Parts {
//     int64 hi;
//     uint64 lo;
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
    /// generated code in the same order the underlying int128 sorts.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class Int128Parts
    {
        [ProtoMember(1)]
        public int64 hi
        {
            get => _hi;
            set
            {
                _hi = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Hi")]
        #endif
        private int64 _hi;

        [ProtoMember(2)]
        public uint64 lo
        {
            get => _lo;
            set
            {
                _lo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Lo")]
        #endif
        private uint64 _lo;

        public Int128Parts()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class Int128PartsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Int128Parts value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                Int128PartsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Int128Parts DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return Int128PartsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Int128Parts value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.hi);
            uint64Xdr.Encode(stream, value.lo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Int128Parts Decode(XdrReader stream)
        {
            var result = new Int128Parts();
            result.hi = int64Xdr.Decode(stream);
            result.lo = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
