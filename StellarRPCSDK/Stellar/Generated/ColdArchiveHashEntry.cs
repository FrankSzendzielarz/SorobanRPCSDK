// Generated code - do not modify
// Source:

// struct ColdArchiveHashEntry
// {
//     uint32 index;
//     uint32 level;
//     Hash hash;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ColdArchiveHashEntry
    {
        public uint32 index
        {
            get => _index;
            set
            {
                _index = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Index")]
        #endif
        private uint32 _index;

        public uint32 level
        {
            get => _level;
            set
            {
                _level = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Level")]
        #endif
        private uint32 _level;

        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Hash")]
        #endif
        private Hash _hash;

        public ColdArchiveHashEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveHashEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveHashEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveHashEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveHashEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            uint32Xdr.Encode(stream, value.level);
            HashXdr.Encode(stream, value.hash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveHashEntry Decode(XdrReader stream)
        {
            var result = new ColdArchiveHashEntry();
            result.index = uint32Xdr.Decode(stream);
            result.level = uint32Xdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            return result;
        }
    }
}
