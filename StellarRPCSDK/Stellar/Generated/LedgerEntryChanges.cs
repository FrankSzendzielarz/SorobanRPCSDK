// Generated code - do not modify
// Source:

// typedef LedgerEntryChange LedgerEntryChanges<>;


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
    public partial class LedgerEntryChanges
    {
        [ProtoMember(1)]
        public LedgerEntryChange[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private LedgerEntryChange[] _innerValue;

        public LedgerEntryChanges() { }

        public LedgerEntryChanges(LedgerEntryChange[] value)
        {
            InnerValue = value;
        }
        public static implicit operator LedgerEntryChange[](LedgerEntryChanges _ledgerentrychanges) => _ledgerentrychanges.InnerValue;
        public static implicit operator LedgerEntryChanges(LedgerEntryChange[] value) => new LedgerEntryChanges(value);
    }
    public static partial class LedgerEntryChangesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerEntryChanges value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerEntryChangesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerEntryChanges value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    LedgerEntryChangeXdr.Encode(stream, item);
            }
        }
        public static LedgerEntryChanges Decode(XdrReader stream)
        {
            var result = new LedgerEntryChanges();
            {
                var length = stream.ReadInt();
                result.InnerValue = new LedgerEntryChange[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = LedgerEntryChangeXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
