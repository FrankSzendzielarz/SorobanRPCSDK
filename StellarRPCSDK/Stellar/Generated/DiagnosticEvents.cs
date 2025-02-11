// Generated code - do not modify
// Source:

// typedef DiagnosticEvent DiagnosticEvents<>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class DiagnosticEvents
    {
        public DiagnosticEvent[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Inner Value")]
        #endif
        private DiagnosticEvent[] _innerValue;

        public DiagnosticEvents() { }

        public DiagnosticEvents(DiagnosticEvent[] value)
        {
            InnerValue = value;
        }
        public static implicit operator DiagnosticEvent[](DiagnosticEvents _diagnosticevents) => _diagnosticevents.InnerValue;
        public static implicit operator DiagnosticEvents(DiagnosticEvent[] value) => new DiagnosticEvents(value);
    }
    public static partial class DiagnosticEventsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DiagnosticEvents value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DiagnosticEventsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, DiagnosticEvents value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    DiagnosticEventXdr.Encode(stream, item);
            }
        }
        public static DiagnosticEvents Decode(XdrReader stream)
        {
            var result = new DiagnosticEvents();
            {
                var length = stream.ReadInt();
                result.InnerValue = new DiagnosticEvent[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = DiagnosticEventXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
