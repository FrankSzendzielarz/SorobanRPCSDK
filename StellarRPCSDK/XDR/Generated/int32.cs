// Generated code - do not modify
// Source:

// typedef int int32;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class int32
    {
        private int _innerValue;
        public int InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public int32() { }

        public int32(int value)
        {
            InnerValue = value;
        }
    }
    public static partial class int32Xdr
    {
        public static void Encode(XdrWriter stream, int32 value)
        {
            stream.WriteInt(value.InnerValue);
        }
        public static int32 Decode(XdrReader stream)
        {
            var result = new int32();
            result.InnerValue = stream.ReadInt();
            return result;
        }
    }
}
