// Generated code - do not modify
// Source:

// struct SorobanAuthorizationEntry
// {
//     SorobanCredentials credentials;
//     SorobanAuthorizedInvocation rootInvocation;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanAuthorizationEntry
    {
        public SorobanCredentials credentials
        {
            get => _credentials;
            set
            {
                _credentials = value;
            }
        }
        private SorobanCredentials _credentials;

        public SorobanAuthorizedInvocation rootInvocation
        {
            get => _rootInvocation;
            set
            {
                _rootInvocation = value;
            }
        }
        private SorobanAuthorizedInvocation _rootInvocation;

        public SorobanAuthorizationEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanAuthorizationEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanAuthorizationEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanAuthorizationEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanAuthorizationEntry value)
        {
            value.Validate();
            SorobanCredentialsXdr.Encode(stream, value.credentials);
            SorobanAuthorizedInvocationXdr.Encode(stream, value.rootInvocation);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanAuthorizationEntry Decode(XdrReader stream)
        {
            var result = new SorobanAuthorizationEntry();
            result.credentials = SorobanCredentialsXdr.Decode(stream);
            result.rootInvocation = SorobanAuthorizedInvocationXdr.Decode(stream);
            return result;
        }
    }
}
