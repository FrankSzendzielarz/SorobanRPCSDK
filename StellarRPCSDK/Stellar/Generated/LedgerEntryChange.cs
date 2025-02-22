// Generated code - do not modify
// Source:

// union LedgerEntryChange switch (LedgerEntryChangeType type)
// {
// case LEDGER_ENTRY_CREATED:
//     LedgerEntry created;
// case LEDGER_ENTRY_UPDATED:
//     LedgerEntry updated;
// case LEDGER_ENTRY_REMOVED:
//     LedgerKey removed;
// case LEDGER_ENTRY_STATE:
//     LedgerEntry state;
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
    [ProtoInclude(100, typeof(LedgerEntryCreated), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(LedgerEntryUpdated), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(LedgerEntryRemoved), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(LedgerEntryState), DataFormat = DataFormat.Default)]
    public abstract partial class LedgerEntryChange
    {
        public abstract LedgerEntryChangeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "LedgerEntryChange.LedgerEntryCreated")]
        public sealed partial class LedgerEntryCreated : LedgerEntryChange
        {
            public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_CREATED;
            [ProtoMember(1)]
            public LedgerEntry created
            {
                get => _created;
                set
                {
                    _created = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Created")]
            #endif
            private LedgerEntry _created;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LedgerEntryChange.LedgerEntryUpdated")]
        public sealed partial class LedgerEntryUpdated : LedgerEntryChange
        {
            public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_UPDATED;
            [ProtoMember(2)]
            public LedgerEntry updated
            {
                get => _updated;
                set
                {
                    _updated = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Updated")]
            #endif
            private LedgerEntry _updated;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LedgerEntryChange.LedgerEntryRemoved")]
        public sealed partial class LedgerEntryRemoved : LedgerEntryChange
        {
            public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_REMOVED;
            [ProtoMember(3)]
            public LedgerKey removed
            {
                get => _removed;
                set
                {
                    _removed = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Removed")]
            #endif
            private LedgerKey _removed;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LedgerEntryChange.LedgerEntryState")]
        public sealed partial class LedgerEntryState : LedgerEntryChange
        {
            public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_STATE;
            [ProtoMember(4)]
            public LedgerEntry state
            {
                get => _state;
                set
                {
                    _state = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"State")]
            #endif
            private LedgerEntry _state;

            public override void ValidateCase() {}
        }
    }
    public static partial class LedgerEntryChangeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerEntryChange value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerEntryChangeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerEntryChange value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerEntryChange.LedgerEntryCreated case_LEDGER_ENTRY_CREATED:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_CREATED.created);
                break;
                case LedgerEntryChange.LedgerEntryUpdated case_LEDGER_ENTRY_UPDATED:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_UPDATED.updated);
                break;
                case LedgerEntryChange.LedgerEntryRemoved case_LEDGER_ENTRY_REMOVED:
                LedgerKeyXdr.Encode(stream, case_LEDGER_ENTRY_REMOVED.removed);
                break;
                case LedgerEntryChange.LedgerEntryState case_LEDGER_ENTRY_STATE:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_STATE.state);
                break;
            }
        }
        public static LedgerEntryChange Decode(XdrReader stream)
        {
            var discriminator = (LedgerEntryChangeType)stream.ReadInt();
            switch (discriminator)
            {
                case LedgerEntryChangeType.LEDGER_ENTRY_CREATED:
                var result_LEDGER_ENTRY_CREATED = new LedgerEntryChange.LedgerEntryCreated();
                result_LEDGER_ENTRY_CREATED.created = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_CREATED;
                case LedgerEntryChangeType.LEDGER_ENTRY_UPDATED:
                var result_LEDGER_ENTRY_UPDATED = new LedgerEntryChange.LedgerEntryUpdated();
                result_LEDGER_ENTRY_UPDATED.updated = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_UPDATED;
                case LedgerEntryChangeType.LEDGER_ENTRY_REMOVED:
                var result_LEDGER_ENTRY_REMOVED = new LedgerEntryChange.LedgerEntryRemoved();
                result_LEDGER_ENTRY_REMOVED.removed = LedgerKeyXdr.Decode(stream);
                return result_LEDGER_ENTRY_REMOVED;
                case LedgerEntryChangeType.LEDGER_ENTRY_STATE:
                var result_LEDGER_ENTRY_STATE = new LedgerEntryChange.LedgerEntryState();
                result_LEDGER_ENTRY_STATE.state = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_STATE;
                default:
                throw new Exception($"Unknown discriminator for LedgerEntryChange: {discriminator}");
            }
        }
    }
}
