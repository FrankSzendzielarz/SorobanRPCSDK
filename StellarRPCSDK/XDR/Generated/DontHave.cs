// Generated code - do not modify
// Source:

// struct DontHave
// {
//     MessageType type;
//     uint256 reqHash;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DontHave
    {
        public MessageType type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        private MessageType _type;

        public uint256 reqHash
        {
            get => _reqHash;
            set
            {
                _reqHash = value;
            }
        }
        private uint256 _reqHash;

        public DontHave()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class DontHaveXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DontHave value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DontHaveXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, DontHave value)
        {
            value.Validate();
            MessageTypeXdr.Encode(stream, value.type);
            uint256Xdr.Encode(stream, value.reqHash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static DontHave Decode(XdrReader stream)
        {
            var result = new DontHave();
            result.type = MessageTypeXdr.Decode(stream);
            result.reqHash = uint256Xdr.Decode(stream);
            return result;
        }
    }
}
