// Generated code - do not modify
// Source:

// typedef LedgerEntryChange LedgerEntryChanges<>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerEntryChanges
    {
        private LedgerEntryChange[] _innerValue;
        public LedgerEntryChange[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public LedgerEntryChanges() { }

        public LedgerEntryChanges(LedgerEntryChange[] value)
        {
            InnerValue = value;
        }
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
