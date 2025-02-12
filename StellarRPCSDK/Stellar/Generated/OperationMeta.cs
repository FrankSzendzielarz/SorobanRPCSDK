// Generated code - do not modify
// Source:

// struct OperationMeta
// {
//     LedgerEntryChanges changes;
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
    public partial class OperationMeta
    {
        public LedgerEntryChanges changes
        {
            get => _changes;
            set
            {
                _changes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Changes")]
        #endif
        private LedgerEntryChanges _changes;

        public OperationMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class OperationMetaXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OperationMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OperationMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, OperationMeta value)
        {
            value.Validate();
            LedgerEntryChangesXdr.Encode(stream, value.changes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static OperationMeta Decode(XdrReader stream)
        {
            var result = new OperationMeta();
            result.changes = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
