// Generated code - do not modify
// Source:

// typedef SCVal SCVec<>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCVec
    {
        public SCVal[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private SCVal[] _innerValue;

        public SCVec() { }

        public SCVec(SCVal[] value)
        {
            InnerValue = value;
        }
        public static implicit operator SCVal[](SCVec _scvec) => _scvec.InnerValue;
        public static implicit operator SCVec(SCVal[] value) => new SCVec(value);
    }
    public static partial class SCVecXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCVec value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCVecXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            {
                var length = stream.ReadInt();
                result.InnerValue = new SCVal[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = SCValXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
