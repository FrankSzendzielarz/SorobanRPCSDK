// Generated code - do not modify
// Source:

// struct Error
// {
//     ErrorCode code;
//     string msg<100>;
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
    public partial class Error
    {
        public ErrorCode code
        {
            get => _code;
            set
            {
                _code = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Code")]
        #endif
        private ErrorCode _code;

        [MaxLength(100)]
        public string msg
        {
            get => _msg;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 100)
                	throw new ArgumentException($"String exceeds 100 bytes when ASCII encoded");
                _msg = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Msg")]
        #endif
        private string _msg;

        public Error()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ErrorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Error value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ErrorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Error value)
        {
            value.Validate();
            ErrorCodeXdr.Encode(stream, value.code);
            stream.WriteString(value.msg);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Error Decode(XdrReader stream)
        {
            var result = new Error();
            result.code = ErrorCodeXdr.Decode(stream);
            result.msg = stream.ReadString();
            return result;
        }
    }
}
