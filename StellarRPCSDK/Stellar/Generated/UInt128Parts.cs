// Generated code - do not modify
// Source:

// struct UInt128Parts {
//     uint64 hi;
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

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class UInt128Parts
    {
        [ProtoMember(1)]
        public uint64 hi
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
        private uint64 _hi;

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

        public UInt128Parts()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class UInt128PartsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(UInt128Parts value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                UInt128PartsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static UInt128Parts DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return UInt128PartsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, UInt128Parts value)
        {
            value.Validate();
            uint64Xdr.Encode(stream, value.hi);
            uint64Xdr.Encode(stream, value.lo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static UInt128Parts Decode(XdrReader stream)
        {
            var result = new UInt128Parts();
            result.hi = uint64Xdr.Decode(stream);
            result.lo = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
