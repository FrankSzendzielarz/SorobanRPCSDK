// Generated code - do not modify
// Source:

// typedef SCMapEntry SCMap<>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCMap
    {
        private SCMapEntry[] _innerValue;
        public SCMapEntry[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SCMap() { }

        public SCMap(SCMapEntry[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class SCMapXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCMap value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCMapXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCMap value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    SCMapEntryXdr.Encode(stream, item);
            }
        }
        public static SCMap Decode(XdrReader stream)
        {
            var result = new SCMap();
            {
                var length = stream.ReadInt();
                result.InnerValue = new SCMapEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = SCMapEntryXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
