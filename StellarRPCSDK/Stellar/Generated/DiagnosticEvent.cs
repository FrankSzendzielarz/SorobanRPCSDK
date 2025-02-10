// Generated code - do not modify
// Source:

// struct DiagnosticEvent
// {
//     bool inSuccessfulContractCall;
//     ContractEvent event;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DiagnosticEvent
    {
        public bool inSuccessfulContractCall
        {
            get => _inSuccessfulContractCall;
            set
            {
                _inSuccessfulContractCall = value;
            }
        }
        private bool _inSuccessfulContractCall;

        public ContractEvent _event
        {
            get => __event;
            set
            {
                __event = value;
            }
        }
        private ContractEvent __event;

        public DiagnosticEvent()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class DiagnosticEventXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DiagnosticEvent value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DiagnosticEventXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, DiagnosticEvent value)
        {
            value.Validate();
            stream.WriteInt(value.inSuccessfulContractCall ? 1 : 0);
            ContractEventXdr.Encode(stream, value._event);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static DiagnosticEvent Decode(XdrReader stream)
        {
            var result = new DiagnosticEvent();
            result.inSuccessfulContractCall = stream.ReadInt() != 0;
            result._event = ContractEventXdr.Decode(stream);
            return result;
        }
    }
}
