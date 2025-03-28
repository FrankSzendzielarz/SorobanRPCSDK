// Generated code - do not modify
// Source:

// struct SendMoreExtended
// {
//     uint32 numMessages;
//     uint32 numBytes;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SendMoreExtended
    {
        [ProtoMember(1)]
        public uint32 numMessages
        {
            get => _numMessages;
            set
            {
                _numMessages = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Num Messages")]
        #endif
        private uint32 _numMessages;

        [ProtoMember(2)]
        public uint32 numBytes
        {
            get => _numBytes;
            set
            {
                _numBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Num Bytes")]
        #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SendMoreExtended DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SendMoreExtendedXdr.Decode(reader);
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
