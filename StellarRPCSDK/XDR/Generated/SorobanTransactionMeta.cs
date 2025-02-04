// Generated code - do not modify
// Source:

// struct SorobanTransactionMeta 
// {
//     SorobanTransactionMetaExt ext;
// 
//     ContractEvent events<>;             // custom events populated by the
//                                         // contracts themselves.
//     SCVal returnValue;                  // return value of the host fn invocation
// 
//     // Diagnostics events that are not hashed.
//     // This will contain all contract and diagnostic events. Even ones
//     // that were emitted in a failed contract call.
//     DiagnosticEvent diagnosticEvents<>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanTransactionMeta
    {
        private SorobanTransactionMetaExt _ext;
        public SorobanTransactionMetaExt ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        private ContractEvent[] _events;
        public ContractEvent[] events
        {
            get => _events;
            set
            {
                _events = value;
            }
        }

        private SCVal _returnValue;
        public SCVal returnValue
        {
            get => _returnValue;
            set
            {
                _returnValue = value;
            }
        }

        private DiagnosticEvent[] _diagnosticEvents;
        public DiagnosticEvent[] diagnosticEvents
        {
            get => _diagnosticEvents;
            set
            {
                _diagnosticEvents = value;
            }
        }

        public SorobanTransactionMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanTransactionMetaXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanTransactionMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanTransactionMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanTransactionMeta value)
        {
            value.Validate();
            SorobanTransactionMetaExtXdr.Encode(stream, value.ext);
            stream.WriteInt(value.events.Length);
            foreach (var item in value.events)
            {
                    ContractEventXdr.Encode(stream, item);
            }
            SCValXdr.Encode(stream, value.returnValue);
            stream.WriteInt(value.diagnosticEvents.Length);
            foreach (var item in value.diagnosticEvents)
            {
                    DiagnosticEventXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanTransactionMeta Decode(XdrReader stream)
        {
            var result = new SorobanTransactionMeta();
            result.ext = SorobanTransactionMetaExtXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.events = new ContractEvent[length];
                for (var i = 0; i < length; i++)
                {
                    result.events[i] = ContractEventXdr.Decode(stream);
                }
            }
            result.returnValue = SCValXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.diagnosticEvents = new DiagnosticEvent[length];
                for (var i = 0; i < length; i++)
                {
                    result.diagnosticEvents[i] = DiagnosticEventXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
