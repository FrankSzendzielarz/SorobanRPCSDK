// Generated code - do not modify
// Source:

// struct LedgerBounds
// {
//     uint32 minLedger;
//     uint32 maxLedger; // 0 here means no maxLedger
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class LedgerBounds
    {
        public uint32 minLedger
        {
            get => _minLedger;
            set
            {
                _minLedger = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Ledger")]
        #endif
        private uint32 _minLedger;

        public uint32 maxLedger
        {
            get => _maxLedger;
            set
            {
                _maxLedger = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Ledger")]
        #endif
        private uint32 _maxLedger;

        public LedgerBounds()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerBoundsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerBounds value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerBoundsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerBounds value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.minLedger);
            uint32Xdr.Encode(stream, value.maxLedger);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerBounds Decode(XdrReader stream)
        {
            var result = new LedgerBounds();
            result.minLedger = uint32Xdr.Decode(stream);
            result.maxLedger = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
