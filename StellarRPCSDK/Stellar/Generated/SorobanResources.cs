// Generated code - do not modify
// Source:

// struct SorobanResources
// {   
//     // The ledger footprint of the transaction.
//     LedgerFootprint footprint;
//     // The maximum number of instructions this transaction can use
//     uint32 instructions; 
// 
//     // The maximum number of bytes this transaction can read from ledger
//     uint32 readBytes;
//     // The maximum number of bytes this transaction can write to ledger
//     uint32 writeBytes;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// The transaction will fail if it exceeds any of these limits.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SorobanResources
    {
        /// <summary>
        /// The ledger footprint of the transaction.
        /// </summary>
        [ProtoMember(1)]
        public LedgerFootprint footprint
        {
            get => _footprint;
            set
            {
                _footprint = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Footprint")]
        #endif
        private LedgerFootprint _footprint;

        /// <summary>
        /// The maximum number of instructions this transaction can use
        /// </summary>
        [ProtoMember(2)]
        public uint32 instructions
        {
            get => _instructions;
            set
            {
                _instructions = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Instructions")]
        #endif
        private uint32 _instructions;

        /// <summary>
        /// The maximum number of bytes this transaction can read from ledger
        /// </summary>
        [ProtoMember(3)]
        public uint32 readBytes
        {
            get => _readBytes;
            set
            {
                _readBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Read Bytes")]
        #endif
        private uint32 _readBytes;

        /// <summary>
        /// The maximum number of bytes this transaction can write to ledger
        /// </summary>
        [ProtoMember(4)]
        public uint32 writeBytes
        {
            get => _writeBytes;
            set
            {
                _writeBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Write Bytes")]
        #endif
        private uint32 _writeBytes;

        public SorobanResources()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanResourcesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanResources value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanResourcesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanResources DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanResourcesXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanResources value)
        {
            value.Validate();
            LedgerFootprintXdr.Encode(stream, value.footprint);
            uint32Xdr.Encode(stream, value.instructions);
            uint32Xdr.Encode(stream, value.readBytes);
            uint32Xdr.Encode(stream, value.writeBytes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanResources Decode(XdrReader stream)
        {
            var result = new SorobanResources();
            result.footprint = LedgerFootprintXdr.Decode(stream);
            result.instructions = uint32Xdr.Decode(stream);
            result.readBytes = uint32Xdr.Decode(stream);
            result.writeBytes = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
