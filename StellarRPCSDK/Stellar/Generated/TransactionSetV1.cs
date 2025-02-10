// Generated code - do not modify
// Source:

// struct TransactionSetV1
// {
//     Hash previousLedgerHash;
//     TransactionPhase phases<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionSetV1
    {
        public Hash previousLedgerHash
        {
            get => _previousLedgerHash;
            set
            {
                _previousLedgerHash = value;
            }
        }
        private Hash _previousLedgerHash;

        public TransactionPhase[] phases
        {
            get => _phases;
            set
            {
                _phases = value;
            }
        }
        private TransactionPhase[] _phases;

        public TransactionSetV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionSetV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionSetV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionSetV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionSetV1 value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.previousLedgerHash);
            stream.WriteInt(value.phases.Length);
            foreach (var item in value.phases)
            {
                    TransactionPhaseXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionSetV1 Decode(XdrReader stream)
        {
            var result = new TransactionSetV1();
            result.previousLedgerHash = HashXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.phases = new TransactionPhase[length];
                for (var i = 0; i < length; i++)
                {
                    result.phases[i] = TransactionPhaseXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
