// Generated code - do not modify
// Source:

// struct LedgerFootprint
// {
//     LedgerKey readOnly<>;
//     LedgerKey readWrite<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// Ledger key sets touched by a smart contract transaction.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class LedgerFootprint
    {
        public LedgerKey[] readOnly
        {
            get => _readOnly;
            set
            {
                _readOnly = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Read Only")]
        #endif
        private LedgerKey[] _readOnly;

        public LedgerKey[] readWrite
        {
            get => _readWrite;
            set
            {
                _readWrite = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Read Write")]
        #endif
        private LedgerKey[] _readWrite;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerFootprint value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerFootprintXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            {
                var length = stream.ReadInt();
                result.readOnly = new LedgerKey[length];
                for (var i = 0; i < length; i++)
                {
                    result.readOnly[i] = LedgerKeyXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.readWrite = new LedgerKey[length];
                for (var i = 0; i < length; i++)
                {
                    result.readWrite[i] = LedgerKeyXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
