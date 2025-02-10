// Generated code - do not modify
// Source:

// struct SorobanTransactionData
// {
//     ExtensionPoint ext;
//     SorobanResources resources;
//     // Amount of the transaction `fee` allocated to the Soroban resource fees.
//     // The fraction of `resourceFee` corresponding to `resources` specified 
//     // above is *not* refundable (i.e. fees for instructions, ledger I/O), as
//     // well as fees for the transaction size.
//     // The remaining part of the fee is refundable and the charged value is
//     // based on the actual consumption of refundable resources (events, ledger
//     // rent bumps).
//     // The `inclusionFee` used for prioritization of the transaction is defined
//     // as `tx.fee - resourceFee`.
//     int64 resourceFee;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    /// <summary>
    /// The transaction extension for Soroban.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanTransactionData
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

        public SorobanResources resources
        {
            get => _resources;
            set
            {
                _resources = value;
            }
        }
        private SorobanResources _resources;

        /// <summary>
        /// as `tx.fee - resourceFee`.
        /// </summary>
        public int64 resourceFee
        {
            get => _resourceFee;
            set
            {
                _resourceFee = value;
            }
        }
        private int64 _resourceFee;

        public SorobanTransactionData()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanTransactionDataXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanTransactionData value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanTransactionDataXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanTransactionData value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            SorobanResourcesXdr.Encode(stream, value.resources);
            int64Xdr.Encode(stream, value.resourceFee);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanTransactionData Decode(XdrReader stream)
        {
            var result = new SorobanTransactionData();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.resources = SorobanResourcesXdr.Decode(stream);
            result.resourceFee = int64Xdr.Decode(stream);
            return result;
        }
    }
}
