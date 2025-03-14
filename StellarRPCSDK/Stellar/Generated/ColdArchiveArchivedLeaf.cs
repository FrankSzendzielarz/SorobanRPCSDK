// Generated code - do not modify
// Source:

// struct ColdArchiveArchivedLeaf
// {
//     uint32 index;
//     LedgerEntry archivedEntry;
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
    public partial class ColdArchiveArchivedLeaf
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
        public LedgerEntry archivedEntry
        {
            get => _archivedEntry;
            set
            {
                _archivedEntry = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Archived Entry")]
        #endif
        private LedgerEntry _archivedEntry;

        public ColdArchiveArchivedLeaf()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ColdArchiveArchivedLeafXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveArchivedLeaf value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveArchivedLeafXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ColdArchiveArchivedLeaf DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ColdArchiveArchivedLeafXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveArchivedLeaf value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.index);
            LedgerEntryXdr.Encode(stream, value.archivedEntry);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ColdArchiveArchivedLeaf Decode(XdrReader stream)
        {
            var result = new ColdArchiveArchivedLeaf();
            result.index = uint32Xdr.Decode(stream);
            result.archivedEntry = LedgerEntryXdr.Decode(stream);
            return result;
        }
    }
}
