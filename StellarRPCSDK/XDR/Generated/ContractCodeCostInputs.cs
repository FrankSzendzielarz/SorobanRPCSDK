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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractCodeCostInputs
    {
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private ExtensionPoint _ext;

        public uint32 nInstructions
        {
            get => _nInstructions;
            set
            {
                _nInstructions = value;
            }
        }
        private uint32 _nInstructions;

        public uint32 nFunctions
        {
            get => _nFunctions;
            set
            {
                _nFunctions = value;
            }
        }
        private uint32 _nFunctions;

        public uint32 nGlobals
        {
            get => _nGlobals;
            set
            {
                _nGlobals = value;
            }
        }
        private uint32 _nGlobals;

        public uint32 nTableEntries
        {
            get => _nTableEntries;
            set
            {
                _nTableEntries = value;
            }
        }
        private uint32 _nTableEntries;

        public uint32 nTypes
        {
            get => _nTypes;
            set
            {
                _nTypes = value;
            }
        }
        private uint32 _nTypes;

        public uint32 nDataSegments
        {
            get => _nDataSegments;
            set
            {
                _nDataSegments = value;
            }
        }
        private uint32 _nDataSegments;

        public uint32 nElemSegments
        {
            get => _nElemSegments;
            set
            {
                _nElemSegments = value;
            }
        }
        private uint32 _nElemSegments;

        public uint32 nImports
        {
            get => _nImports;
            set
            {
                _nImports = value;
            }
        }
        private uint32 _nImports;

        public uint32 nExports
        {
            get => _nExports;
            set
            {
                _nExports = value;
            }
        }
        private uint32 _nExports;

        public uint32 nDataSegmentBytes
        {
            get => _nDataSegmentBytes;
            set
            {
                _nDataSegmentBytes = value;
            }
        }
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
