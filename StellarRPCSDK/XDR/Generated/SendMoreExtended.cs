// Generated code - do not modify
// Source:

// struct SendMoreExtended
// {
//     uint32 numMessages;
//     uint32 numBytes;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SendMoreExtended
    {
        public uint32 numMessages
        {
            get => _numMessages;
            set
            {
                _numMessages = value;
            }
        }
        private uint32 _numMessages;

        public uint32 numBytes
        {
            get => _numBytes;
            set
            {
                _numBytes = value;
            }
        }
        private uint32 _numBytes;

        public SendMoreExtended()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SendMoreExtendedXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SendMoreExtended value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SendMoreExtendedXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SendMoreExtended value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.numMessages);
            uint32Xdr.Encode(stream, value.numBytes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SendMoreExtended Decode(XdrReader stream)
        {
            var result = new SendMoreExtended();
            result.numMessages = uint32Xdr.Decode(stream);
            result.numBytes = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
