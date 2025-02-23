// Generated code - do not modify
// Source:

// struct FeeBumpTransactionEnvelope
// {
//     FeeBumpTransaction tx;
//     /* Each decorated signature is a signature over the SHA256 hash of
//      * a TransactionSignaturePayload */
//     DecoratedSignature signatures<20>;
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
    public partial class FeeBumpTransactionEnvelope
    {
        [ProtoMember(1)]
        public FeeBumpTransaction tx
        {
            get => _tx;
            set
            {
                _tx = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx")]
        #endif
        private FeeBumpTransaction _tx;

        [ProtoMember(2)]
        [MaxLength(20)]
        public DecoratedSignature[] signatures
        {
            get => _signatures;
            set
            {
                if (value.Length > 20)
                	throw new ArgumentException($"Cannot exceed 20 in length");
                _signatures = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Signatures")]
        #endif
        private DecoratedSignature[] _signatures;

        public FeeBumpTransactionEnvelope()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (signatures.Length > 20)
            	throw new InvalidOperationException($"signatures cannot exceed 20 elements");
        }
    }
    public static partial class FeeBumpTransactionEnvelopeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(FeeBumpTransactionEnvelope value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                FeeBumpTransactionEnvelopeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static FeeBumpTransactionEnvelope DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return FeeBumpTransactionEnvelopeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FeeBumpTransactionEnvelope value)
        {
            value.Validate();
            FeeBumpTransactionXdr.Encode(stream, value.tx);
            stream.WriteInt(value.signatures.Length);
            foreach (var item in value.signatures)
            {
                    DecoratedSignatureXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FeeBumpTransactionEnvelope Decode(XdrReader stream)
        {
            var result = new FeeBumpTransactionEnvelope();
            result.tx = FeeBumpTransactionXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.signatures = new DecoratedSignature[length];
                for (var i = 0; i < length; i++)
                {
                    result.signatures[i] = DecoratedSignatureXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
