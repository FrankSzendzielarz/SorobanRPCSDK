// Generated code - do not modify
// Source:

// struct ColdArchiveDeletedLeaf
// {
//     uint32 index;
//     LedgerKey deletedKey;
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
    public partial class ColdArchiveDeletedLeaf
    {
        [ProtoMember(1)]
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
        	[SerializeReference]
        	[InspectorName(@"Index")]
        #endif
        private uint32 _index;

        [ProtoMember(2)]
        public LedgerKey deletedKey
        {
            get => _deletedKey;
            set
            {
                _deletedKey = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Deleted Key")]
        #endif
        private LedgerKey _deletedKey;

        public ColdArchiveDeletedLeaf()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveDeletedLeafXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveDeletedLeaf value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveDeletedLeafXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ColdArchiveDeletedLeaf DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ColdArchiveDeletedLeafXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveDeletedLeaf value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            LedgerKeyXdr.Encode(stream, value.deletedKey);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveDeletedLeaf Decode(XdrReader stream)
        {
            var result = new ColdArchiveDeletedLeaf();
            result.index = uint32Xdr.Decode(stream);
            result.deletedKey = LedgerKeyXdr.Decode(stream);
            return result;
        }
    }
}
