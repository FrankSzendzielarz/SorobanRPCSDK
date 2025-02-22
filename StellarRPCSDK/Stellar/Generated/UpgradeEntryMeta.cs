// Generated code - do not modify
// Source:

// struct UpgradeEntryMeta
// {
//     LedgerUpgrade upgrade;
//     LedgerEntryChanges changes;
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
    /// upgrade
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class UpgradeEntryMeta
    {
        [ProtoMember(1)]
        public LedgerUpgrade upgrade
        {
            get => _upgrade;
            set
            {
                _upgrade = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Upgrade")]
        #endif
        private LedgerUpgrade _upgrade;

        [ProtoMember(2)]
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

        public UpgradeEntryMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class UpgradeEntryMetaXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(UpgradeEntryMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                UpgradeEntryMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, UpgradeEntryMeta value)
        {
            value.Validate();
            LedgerUpgradeXdr.Encode(stream, value.upgrade);
            LedgerEntryChangesXdr.Encode(stream, value.changes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static UpgradeEntryMeta Decode(XdrReader stream)
        {
            var result = new UpgradeEntryMeta();
            result.upgrade = LedgerUpgradeXdr.Decode(stream);
            result.changes = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
