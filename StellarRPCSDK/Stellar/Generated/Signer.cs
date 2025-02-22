// Generated code - do not modify
// Source:

// struct Signer
// {
//     SignerKey key;
//     uint32 weight; // really only need 1 byte
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
    public partial class Signer
    {
        [ProtoMember(1)]
        public SignerKey key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Key")]
        #endif
        private SignerKey _key;

        [ProtoMember(2)]
        public uint32 weight
        {
            get => _weight;
            set
            {
                _weight = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Weight")]
        #endif
        private uint32 _weight;

        public Signer()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignerXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Signer value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignerXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Signer value)
        {
            value.Validate();
            SignerKeyXdr.Encode(stream, value.key);
            uint32Xdr.Encode(stream, value.weight);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Signer Decode(XdrReader stream)
        {
            var result = new Signer();
            result.key = SignerKeyXdr.Decode(stream);
            result.weight = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
