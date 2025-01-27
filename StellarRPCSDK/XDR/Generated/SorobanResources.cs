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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanResources
    {
        private LedgerFootprint _footprint;
        public LedgerFootprint footprint
        {
            get => _footprint;
            set
            {
                _footprint = value;
            }
        }

        private uint32 _instructions;
        public uint32 instructions
        {
            get => _instructions;
            set
            {
                _instructions = value;
            }
        }

        private uint32 _readBytes;
        public uint32 readBytes
        {
            get => _readBytes;
            set
            {
                _readBytes = value;
            }
        }

        private uint32 _writeBytes;
        public uint32 writeBytes
        {
            get => _writeBytes;
            set
            {
                _writeBytes = value;
            }
        }

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
