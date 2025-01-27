// Generated code - do not modify
// Source:

// typedef Hash PoolID;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PoolID
    {
        private Hash _innerValue;
        public Hash InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public PoolID() { }

        public PoolID(Hash value)
        {
            InnerValue = value;
        }
    }
    public static partial class PoolIDXdr
    {
            public static void Encode(XdrWriter stream, PoolID value)
        {
            HashXdr.Encode(stream, value.InnerValue);
        }
        public static PoolID Decode(XdrReader stream)
        {
            var result = new PoolID();
            result.InnerValue = HashXdr.Decode(stream);
            return result;
        }
    }
}
