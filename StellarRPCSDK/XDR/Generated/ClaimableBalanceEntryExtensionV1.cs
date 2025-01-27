// Generated code - do not modify
// Source:

// struct ClaimableBalanceEntryExtensionV1
// {
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// 
//     uint32 flags; // see ClaimableBalanceFlags
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClaimableBalanceEntryExtensionV1
    {
        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        private uint32 _flags;
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }

        public ClaimableBalanceEntryExtensionV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClaimableBalanceEntryExtensionV1Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceEntryExtensionV1 value)
        {
            value.Validate();
            Xdr.Encode(stream, value.ext);
            uint32Xdr.Encode(stream, value.flags);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimableBalanceEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new ClaimableBalanceEntryExtensionV1();
            result.ext = Xdr.Decode(stream);
            result.flags = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
