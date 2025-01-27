// Generated code - do not modify
// Source:

// struct LedgerFootprint
// {
//     LedgerKey readOnly<>;
//     LedgerKey readWrite<>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerFootprint
    {
        private LedgerKey[] _readOnly;
        public LedgerKey[] readOnly
        {
            get => _readOnly;
            set
            {
                _readOnly = value;
            }
        }

        private LedgerKey[] _readWrite;
        public LedgerKey[] readWrite
        {
            get => _readWrite;
            set
            {
                _readWrite = value;
            }
        }

        public LedgerFootprint()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerFootprintXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerFootprint value)
        {
            value.Validate();
            stream.WriteInt(value.readOnly.Length);
            foreach (var item in value.readOnly)
            {
                    LedgerKeyXdr.Encode(stream, item);
            }
            stream.WriteInt(value.readWrite.Length);
            foreach (var item in value.readWrite)
            {
                    LedgerKeyXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerFootprint Decode(XdrReader stream)
        {
            var result = new LedgerFootprint();
            var length = stream.ReadInt();
            result.readOnly = new LedgerKey[length];
            for (var i = 0; i < length; i++)
            {
                result.readOnly[i] = LedgerKeyXdr.Decode(stream);
            }
            var length = stream.ReadInt();
            result.readWrite = new LedgerKey[length];
            for (var i = 0; i < length; i++)
            {
                result.readWrite[i] = LedgerKeyXdr.Decode(stream);
            }
            return result;
        }
    }
}
