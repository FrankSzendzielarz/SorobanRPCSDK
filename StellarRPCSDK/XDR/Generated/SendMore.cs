// Generated code - do not modify
// Source:

// struct SendMore
// {
//     uint32 numMessages;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SendMore
    {
        private uint32 _numMessages;
        public uint32 numMessages
        {
            get => _numMessages;
            set
            {
                _numMessages = value;
            }
        }

        public SendMore()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SendMoreXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SendMore value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SendMoreXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SendMore value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.numMessages);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SendMore Decode(XdrReader stream)
        {
            var result = new SendMore();
            result.numMessages = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
