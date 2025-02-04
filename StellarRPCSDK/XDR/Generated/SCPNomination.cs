// Generated code - do not modify
// Source:

// struct SCPNomination
// {
//     Hash quorumSetHash; // D
//     Value votes<>;      // X
//     Value accepted<>;   // Y
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPNomination
    {
        public Hash quorumSetHash
        {
            get => _quorumSetHash;
            set
            {
                _quorumSetHash = value;
            }
        }
        private Hash _quorumSetHash;

        /// <summary>
        /// D
        /// </summary>
        public Value[] votes
        {
            get => _votes;
            set
            {
                _votes = value;
            }
        }
        private Value[] _votes;

        /// <summary>
        /// X
        /// </summary>
        public Value[] accepted
        {
            get => _accepted;
            set
            {
                _accepted = value;
            }
        }
        private Value[] _accepted;

        public SCPNomination()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCPNominationXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPNomination value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPNominationXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPNomination value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.quorumSetHash);
            stream.WriteInt(value.votes.Length);
            foreach (var item in value.votes)
            {
                    ValueXdr.Encode(stream, item);
            }
            stream.WriteInt(value.accepted.Length);
            foreach (var item in value.accepted)
            {
                    ValueXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPNomination Decode(XdrReader stream)
        {
            var result = new SCPNomination();
            result.quorumSetHash = HashXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.votes = new Value[length];
                for (var i = 0; i < length; i++)
                {
                    result.votes[i] = ValueXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.accepted = new Value[length];
                for (var i = 0; i < length; i++)
                {
                    result.accepted[i] = ValueXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
