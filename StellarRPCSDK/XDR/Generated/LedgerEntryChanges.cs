// Generated code - do not modify
// Source:

// typedef LedgerEntryChange LedgerEntryChanges<>;


using System;

namespace stellar {

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
