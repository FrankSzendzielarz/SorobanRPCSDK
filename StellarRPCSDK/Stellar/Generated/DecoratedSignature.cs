// Generated code - do not modify
// Source:

// struct DecoratedSignature
// {
//     SignatureHint hint;  // last 4 bytes of the public key, used as a hint
//     Signature signature; // actual signature
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
    public partial class DecoratedSignature
    {
        [ProtoMember(1)]
        public SignatureHint hint
        {
            get => _hint;
            set
            {
                _hint = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Hint")]
        #endif
        private SignatureHint _hint;

        /// <summary>
        /// last 4 bytes of the public key, used as a hint
        /// </summary>
        [ProtoMember(2)]
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Signature")]
        #endif
        private Signature _signature;

        public DecoratedSignature()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class DecoratedSignatureXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DecoratedSignature value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DecoratedSignatureXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static DecoratedSignature DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return DecoratedSignatureXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, DecoratedSignature value)
        {
            value.Validate();
            SignatureHintXdr.Encode(stream, value.hint);
            SignatureXdr.Encode(stream, value.signature);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static DecoratedSignature Decode(XdrReader stream)
        {
            var result = new DecoratedSignature();
            result.hint = SignatureHintXdr.Decode(stream);
            result.signature = SignatureXdr.Decode(stream);
            return result;
        }
    }
}
