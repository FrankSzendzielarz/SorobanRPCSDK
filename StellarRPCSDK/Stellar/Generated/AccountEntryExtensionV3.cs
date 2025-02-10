// Generated code - do not modify
// Source:

// struct AccountEntryExtensionV3
// {
//     // We can use this to add more fields, or because it is first, to
//     // change AccountEntryExtensionV3 into a union.
//     ExtensionPoint ext;
// 
//     // Ledger number at which `seqNum` took on its present value.
//     uint32 seqLedger;
// 
//     // Time at which `seqNum` took on its present value.
//     TimePoint seqTime;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountEntryExtensionV3
    {
        /// <summary>
        /// change AccountEntryExtensionV3 into a union.
        /// </summary>
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private ExtensionPoint _ext;

        /// <summary>
        /// Ledger number at which `seqNum` took on its present value.
        /// </summary>
        public uint32 seqLedger
        {
            get => _seqLedger;
            set
            {
                _seqLedger = value;
            }
        }
        private uint32 _seqLedger;

        /// <summary>
        /// Time at which `seqNum` took on its present value.
        /// </summary>
        public TimePoint seqTime
        {
            get => _seqTime;
            set
            {
                _seqTime = value;
            }
        }
        private TimePoint _seqTime;

        public AccountEntryExtensionV3()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AccountEntryExtensionV3Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountEntryExtensionV3 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountEntryExtensionV3Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountEntryExtensionV3 value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            uint32Xdr.Encode(stream, value.seqLedger);
            TimePointXdr.Encode(stream, value.seqTime);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntryExtensionV3 Decode(XdrReader stream)
        {
            var result = new AccountEntryExtensionV3();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.seqLedger = uint32Xdr.Decode(stream);
            result.seqTime = TimePointXdr.Decode(stream);
            return result;
        }
    }
}
