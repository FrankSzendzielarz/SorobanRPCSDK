// Generated code - do not modify
// Source:

// struct Error
// {
//     ErrorCode code;
//     string msg<100>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Error
    {
        private ErrorCode _code;
        public ErrorCode code
        {
            get => _code;
            set
            {
                _code = value;
            }
        }

        private string _msg;
        public string msg
        {
            get => _msg;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 100)
                	throw new ArgumentException($"String exceeds 100 bytes when UTF8 encoded");
                _msg = value;
            }
        }

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
