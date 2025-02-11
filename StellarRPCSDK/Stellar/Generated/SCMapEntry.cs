// Generated code - do not modify
// Source:

// struct SCMapEntry
// {
//     SCVal key;
//     SCVal val;
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
    public partial class SCMapEntry
    {
        public SCVal key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Key")]
        #endif
        private SCVal _key;

        public SCVal val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Val")]
        #endif
        private SCVal _val;

        public SCMapEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCMapEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCMapEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCMapEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMapEntry value)
        {
            value.Validate();
            SCValXdr.Encode(stream, value.key);
            SCValXdr.Encode(stream, value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCMapEntry Decode(XdrReader stream)
        {
            var result = new SCMapEntry();
            result.key = SCValXdr.Decode(stream);
            result.val = SCValXdr.Decode(stream);
            return result;
        }
    }
}
