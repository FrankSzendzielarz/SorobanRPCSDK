// Generated code - do not modify
// Source:

// struct LedgerHeaderHistoryEntry
// {
//     Hash hash;
//     LedgerHeader header;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerHeaderHistoryEntry
    {
        private Hash _hash;
        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }

        private LedgerHeader _header;
        public LedgerHeader header
        {
            get => _header;
            set
            {
                _header = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public LedgerHeaderHistoryEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LedgerHeaderHistoryEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerHeaderHistoryEntry value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.hash);
            LedgerHeaderXdr.Encode(stream, value.header);
            LedgerHeaderHistoryEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerHeaderHistoryEntry Decode(XdrReader stream)
        {
            var result = new LedgerHeaderHistoryEntry();
            result.hash = HashXdr.Decode(stream);
            result.header = LedgerHeaderXdr.Decode(stream);
            result.ext = LedgerHeaderHistoryEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
