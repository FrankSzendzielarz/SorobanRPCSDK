// Generated code - do not modify
// Source:

// struct StoredDebugTransactionSet
// {
// 	StoredTransactionSet txSet;
// 	uint32 ledgerSeq;
// 	StellarValue scpValue;
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
    public partial class StoredDebugTransactionSet
    {
        [ProtoMember(1)]
        public StoredTransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Set")]
        #endif
        private StoredTransactionSet _txSet;

        [ProtoMember(2)]
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Seq")]
        #endif
        private uint32 _ledgerSeq;

        [ProtoMember(3)]
        public StellarValue scpValue
        {
            get => _scpValue;
            set
            {
                _scpValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Scp Value")]
        #endif
        private StellarValue _scpValue;

        public StoredDebugTransactionSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class StoredDebugTransactionSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StoredDebugTransactionSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StoredDebugTransactionSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static StoredDebugTransactionSet DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return StoredDebugTransactionSetXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, StoredDebugTransactionSet value)
        {
            value.Validate();
            StoredTransactionSetXdr.Encode(stream, value.txSet);
            uint32Xdr.Encode(stream, value.ledgerSeq);
            StellarValueXdr.Encode(stream, value.scpValue);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static StoredDebugTransactionSet Decode(XdrReader stream)
        {
            var result = new StoredDebugTransactionSet();
            result.txSet = StoredTransactionSetXdr.Decode(stream);
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.scpValue = StellarValueXdr.Decode(stream);
            return result;
        }
    }
}
