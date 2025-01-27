// Generated code - do not modify
// Source:

// typedef SCVal SCVec<>;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCVec
    {
        private SCVal[] _innerValue;
        public SCVal[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SCVec() { }

        public SCVec(SCVal[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class SCVecXdr
    {
            public static void Encode(XdrWriter stream, SCVec value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    SCValXdr.Encode(stream, item);
            }
        }
        public static SCVec Decode(XdrReader stream)
        {
            var result = new SCVec();
            var length = stream.ReadInt();
            result.InnerValue = new SCVal[length];
            for (var i = 0; i < length; i++)
            {
                result.InnerValue[i] = SCValXdr.Decode(stream);
            }
            return result;
        }
    }
}
