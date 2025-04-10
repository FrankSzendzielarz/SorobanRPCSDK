// Generated code - do not modify
// Source:

// struct TTLEntry {
//     // Hash of the LedgerKey that is associated with this TTLEntry
//     Hash keyHash;
//     uint32 liveUntilLedgerSeq;
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
    public partial class TTLEntry
    {
        /// <summary>
        /// Hash of the LedgerKey that is associated with this TTLEntry
        /// </summary>
        [ProtoMember(1)]
        public Hash keyHash
        {
            get => _keyHash;
            set
            {
                _keyHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Key Hash")]
        #endif
        private Hash _keyHash;

        [ProtoMember(2)]
        public uint32 liveUntilLedgerSeq
        {
            get => _liveUntilLedgerSeq;
            set
            {
                _liveUntilLedgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Live Until Ledger Seq")]
        #endif
        private uint32 _liveUntilLedgerSeq;

        public TTLEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TTLEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TTLEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TTLEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TTLEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TTLEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TTLEntry value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.keyHash);
            uint32Xdr.Encode(stream, value.liveUntilLedgerSeq);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TTLEntry Decode(XdrReader stream)
        {
            var result = new TTLEntry();
            result.keyHash = HashXdr.Decode(stream);
            result.liveUntilLedgerSeq = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
