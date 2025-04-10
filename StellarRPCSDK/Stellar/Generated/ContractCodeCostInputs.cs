// Generated code - do not modify
// Source:

// struct ContractCodeCostInputs {
//     ExtensionPoint ext;
//     uint32 nInstructions;
//     uint32 nFunctions;
//     uint32 nGlobals;
//     uint32 nTableEntries;
//     uint32 nTypes;
//     uint32 nDataSegments;
//     uint32 nElemSegments;
//     uint32 nImports;
//     uint32 nExports;
//     uint32 nDataSegmentBytes;
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
    public partial class ContractCodeCostInputs
    {
        [ProtoMember(1)]
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private ExtensionPoint _ext;

        [ProtoMember(2)]
        public uint32 nInstructions
        {
            get => _nInstructions;
            set
            {
                _nInstructions = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Instructions")]
        #endif
        private uint32 _nInstructions;

        [ProtoMember(3)]
        public uint32 nFunctions
        {
            get => _nFunctions;
            set
            {
                _nFunctions = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Functions")]
        #endif
        private uint32 _nFunctions;

        [ProtoMember(4)]
        public uint32 nGlobals
        {
            get => _nGlobals;
            set
            {
                _nGlobals = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Globals")]
        #endif
        private uint32 _nGlobals;

        [ProtoMember(5)]
        public uint32 nTableEntries
        {
            get => _nTableEntries;
            set
            {
                _nTableEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Table Entries")]
        #endif
        private uint32 _nTableEntries;

        [ProtoMember(6)]
        public uint32 nTypes
        {
            get => _nTypes;
            set
            {
                _nTypes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Types")]
        #endif
        private uint32 _nTypes;

        [ProtoMember(7)]
        public uint32 nDataSegments
        {
            get => _nDataSegments;
            set
            {
                _nDataSegments = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Data Segments")]
        #endif
        private uint32 _nDataSegments;

        [ProtoMember(8)]
        public uint32 nElemSegments
        {
            get => _nElemSegments;
            set
            {
                _nElemSegments = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Elem Segments")]
        #endif
        private uint32 _nElemSegments;

        [ProtoMember(9)]
        public uint32 nImports
        {
            get => _nImports;
            set
            {
                _nImports = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Imports")]
        #endif
        private uint32 _nImports;

        [ProtoMember(10)]
        public uint32 nExports
        {
            get => _nExports;
            set
            {
                _nExports = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Exports")]
        #endif
        private uint32 _nExports;

        [ProtoMember(11)]
        public uint32 nDataSegmentBytes
        {
            get => _nDataSegmentBytes;
            set
            {
                _nDataSegmentBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"N Data Segment Bytes")]
        #endif
        private uint32 _nDataSegmentBytes;

        public ContractCodeCostInputs()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ContractCodeCostInputsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractCodeCostInputs value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractCodeCostInputsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractCodeCostInputs DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractCodeCostInputsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCodeCostInputs value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            uint32Xdr.Encode(stream, value.nInstructions);
            uint32Xdr.Encode(stream, value.nFunctions);
            uint32Xdr.Encode(stream, value.nGlobals);
            uint32Xdr.Encode(stream, value.nTableEntries);
            uint32Xdr.Encode(stream, value.nTypes);
            uint32Xdr.Encode(stream, value.nDataSegments);
            uint32Xdr.Encode(stream, value.nElemSegments);
            uint32Xdr.Encode(stream, value.nImports);
            uint32Xdr.Encode(stream, value.nExports);
            uint32Xdr.Encode(stream, value.nDataSegmentBytes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractCodeCostInputs Decode(XdrReader stream)
        {
            var result = new ContractCodeCostInputs();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.nInstructions = uint32Xdr.Decode(stream);
            result.nFunctions = uint32Xdr.Decode(stream);
            result.nGlobals = uint32Xdr.Decode(stream);
            result.nTableEntries = uint32Xdr.Decode(stream);
            result.nTypes = uint32Xdr.Decode(stream);
            result.nDataSegments = uint32Xdr.Decode(stream);
            result.nElemSegments = uint32Xdr.Decode(stream);
            result.nImports = uint32Xdr.Decode(stream);
            result.nExports = uint32Xdr.Decode(stream);
            result.nDataSegmentBytes = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
