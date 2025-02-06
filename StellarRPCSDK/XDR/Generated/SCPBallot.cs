// Generated code - do not modify
// Source:

// struct SCPBallot
// {
//     uint32 counter; // n
//     Value value;    // x
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPBallot
    {
        public uint32 counter
        {
            get => _counter;
            set
            {
                _counter = value;
            }
        }
        private uint32 _counter;

        /// <summary>
        /// n
        /// </summary>
        public Value value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }
        private Value _value;

        public SCPBallot()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCPBallotXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPBallot value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPBallotXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPBallot value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.counter);
            ValueXdr.Encode(stream, value.value);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPBallot Decode(XdrReader stream)
        {
            var result = new SCPBallot();
            result.counter = uint32Xdr.Decode(stream);
            result.value = ValueXdr.Decode(stream);
            return result;
        }
    }
}
