// Generated code - do not modify
// Source:

// struct Int256Parts {
//     int64 hi_hi;
//     uint64 hi_lo;
//     uint64 lo_hi;
//     uint64 lo_lo;
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
    /// generated code in the same order the underlying int256 sorts.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class Int256Parts
    {
        [ProtoMember(1)]
        public int64 hi_hi
        {
            get => _hi_hi;
            set
            {
                _hi_hi = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Hi_hi")]
        #endif
        private int64 _hi_hi;

        [ProtoMember(2)]
        public uint64 hi_lo
        {
            get => _hi_lo;
            set
            {
                _hi_lo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Hi_lo")]
        #endif
        private uint64 _hi_lo;

        [ProtoMember(3)]
        public uint64 lo_hi
        {
            get => _lo_hi;
            set
            {
                _lo_hi = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Lo_hi")]
        #endif
        private uint64 _lo_hi;

        [ProtoMember(4)]
        public uint64 lo_lo
        {
            get => _lo_lo;
            set
            {
                _lo_lo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Lo_lo")]
        #endif
        private uint64 _lo_lo;

        public Int256Parts()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class Int256PartsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Int256Parts value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                Int256PartsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Int256Parts value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.hi_hi);
            uint64Xdr.Encode(stream, value.hi_lo);
            uint64Xdr.Encode(stream, value.lo_hi);
            uint64Xdr.Encode(stream, value.lo_lo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Int256Parts Decode(XdrReader stream)
        {
            var result = new Int256Parts();
            result.hi_hi = int64Xdr.Decode(stream);
            result.hi_lo = uint64Xdr.Decode(stream);
            result.lo_hi = uint64Xdr.Decode(stream);
            result.lo_lo = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
