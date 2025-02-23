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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SorobanTransactionMeta
    {
        [ProtoMember(1)]
        public SorobanTransactionMetaExt ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private SorobanTransactionMetaExt _ext;

        [ProtoMember(2, OverwriteList = true)]
        public ContractEvent[] events
        {
            get => _events;
            set
            {
                _events = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Events")]
        #endif
        private ContractEvent[] _events;

        /// <summary>
        /// contracts themselves.
        /// </summary>
        [ProtoMember(3)]
        public SCVal returnValue
        {
            get => _returnValue;
            set
            {
                _returnValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Return Value")]
        #endif
        private SCVal _returnValue;

        /// <summary>
        /// that were emitted in a failed contract call.
        /// </summary>
        [ProtoMember(4, OverwriteList = true)]
        public DiagnosticEvent[] diagnosticEvents
        {
            get => _diagnosticEvents;
            set
            {
                _diagnosticEvents = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Diagnostic Events")]
        #endif
        private DiagnosticEvent[] _diagnosticEvents;

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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanTransactionMeta DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanTransactionMetaXdr.Decode(reader);
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
