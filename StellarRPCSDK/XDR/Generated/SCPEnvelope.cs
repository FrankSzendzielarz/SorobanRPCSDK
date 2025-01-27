// Generated code - do not modify
// Source:

// struct SCPEnvelope
// {
//     SCPStatement statement;
//     Signature signature;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPEnvelope
    {
        private SCPStatement _statement;
        public SCPStatement statement
        {
            get => _statement;
            set
            {
                _statement = value;
            }
        }

        private Signature _signature;
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }

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
