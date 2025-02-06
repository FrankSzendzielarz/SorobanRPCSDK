// Generated code - do not modify
// Source:

// struct SCPEnvelope
// {
//     SCPStatement statement;
//     Signature signature;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPEnvelope
    {
        public SCPStatement statement
        {
            get => _statement;
            set
            {
                _statement = value;
            }
        }
        private SCPStatement _statement;

        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        private Signature _signature;

        public SCPEnvelope()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCPEnvelopeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPEnvelope value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPEnvelopeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPEnvelope value)
        {
            value.Validate();
            SCPStatementXdr.Encode(stream, value.statement);
            SignatureXdr.Encode(stream, value.signature);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPEnvelope Decode(XdrReader stream)
        {
            var result = new SCPEnvelope();
            result.statement = SCPStatementXdr.Decode(stream);
            result.signature = SignatureXdr.Decode(stream);
            return result;
        }
    }
}
