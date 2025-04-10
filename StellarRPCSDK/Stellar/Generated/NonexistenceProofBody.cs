// Generated code - do not modify
// Source:

// struct NonexistenceProofBody
// {
//     ColdArchiveBucketEntry entriesToProve<>;
// 
//     // Vector of vectors, where proofLevels[level]
//     // contains all HashNodes that correspond with that level
//     ProofLevel proofLevels<>;
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
    public partial class NonexistenceProofBody
    {
        [ProtoMember(1, OverwriteList = true)]
        public ColdArchiveBucketEntry[] entriesToProve
        {
            get => _entriesToProve;
            set
            {
                _entriesToProve = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Entries To Prove")]
        #endif
        private ColdArchiveBucketEntry[] _entriesToProve;

        /// <summary>
        /// contains all HashNodes that correspond with that level
        /// </summary>
        [ProtoMember(2, OverwriteList = true)]
        public ProofLevel[] proofLevels
        {
            get => _proofLevels;
            set
            {
                _proofLevels = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Proof Levels")]
        #endif
        private ProofLevel[] _proofLevels;

        public NonexistenceProofBody()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class NonexistenceProofBodyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(NonexistenceProofBody value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                NonexistenceProofBodyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static NonexistenceProofBody DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return NonexistenceProofBodyXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, NonexistenceProofBody value)
        {
            value.Validate();
            stream.WriteInt(value.entriesToProve.Length);
            foreach (var item in value.entriesToProve)
            {
                    ColdArchiveBucketEntryXdr.Encode(stream, item);
            }
            stream.WriteInt(value.proofLevels.Length);
            foreach (var item in value.proofLevels)
            {
                    ProofLevelXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static NonexistenceProofBody Decode(XdrReader stream)
        {
            var result = new NonexistenceProofBody();
            {
                var length = stream.ReadInt();
                result.entriesToProve = new ColdArchiveBucketEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.entriesToProve[i] = ColdArchiveBucketEntryXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.proofLevels = new ProofLevel[length];
                for (var i = 0; i < length; i++)
                {
                    result.proofLevels[i] = ProofLevelXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
