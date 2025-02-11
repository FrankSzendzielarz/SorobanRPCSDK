// Generated code - do not modify
// Source:

// struct Auth
// {
//     int flags;
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
    public partial class Auth
    {
        public int flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Flags")]
        #endif
        private int _flags;

        public Auth()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AuthXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Auth value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AuthXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Auth value)
        {
            value.Validate();
            stream.WriteInt(value.flags);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Auth Decode(XdrReader stream)
        {
            var result = new Auth();
            result.flags = stream.ReadInt();
            return result;
        }
    }
}
