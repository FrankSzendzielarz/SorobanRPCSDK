// Generated code - do not modify
// Source:

// struct SCSpecFunctionV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     SCSymbol name;
//     SCSpecFunctionInputV0 inputs<10>;
//     SCSpecTypeDef outputs<1>;
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
    public partial class SCSpecFunctionV0
    {
        [ProtoMember(1)]
        [MaxLength(1024)]
        public string doc
        {
            get => _doc;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > Constants.SC_SPEC_DOC_LIMIT)
                	throw new ArgumentException($"String exceeds Constants.SC_SPEC_DOC_LIMIT bytes when ASCII encoded");
                _doc = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Doc")]
        #endif
        private string _doc;

        [ProtoMember(2)]
        public SCSymbol name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Name")]
        #endif
        private SCSymbol _name;

        [ProtoMember(3)]
        [MaxLength(10)]
        public SCSpecFunctionInputV0[] inputs
        {
            get => _inputs;
            set
            {
                if (value.Length > 10)
                	throw new ArgumentException($"Cannot exceed 10 in length");
                _inputs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inputs")]
        #endif
        private SCSpecFunctionInputV0[] _inputs;

        [ProtoMember(4)]
        [MaxLength(1)]
        public SCSpecTypeDef[] outputs
        {
            get => _outputs;
            set
            {
                if (value.Length > 1)
                	throw new ArgumentException($"Cannot exceed 1 in length");
                _outputs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Outputs")]
        #endif
        private SCSpecTypeDef[] _outputs;

        public SCSpecFunctionV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (inputs.Length > 10)
            	throw new InvalidOperationException($"inputs cannot exceed 10 elements");
            if (outputs.Length > 1)
            	throw new InvalidOperationException($"outputs cannot exceed 1 elements");
        }
    }
    public static partial class SCSpecFunctionV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecFunctionV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecFunctionV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecFunctionV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecFunctionV0Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecFunctionV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            SCSymbolXdr.Encode(stream, value.name);
            stream.WriteInt(value.inputs.Length);
            foreach (var item in value.inputs)
            {
                    SCSpecFunctionInputV0Xdr.Encode(stream, item);
            }
            stream.WriteInt(value.outputs.Length);
            foreach (var item in value.outputs)
            {
                    SCSpecTypeDefXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecFunctionV0 Decode(XdrReader stream)
        {
            var result = new SCSpecFunctionV0();
            result.doc = stream.ReadString();
            result.name = SCSymbolXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.inputs = new SCSpecFunctionInputV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.inputs[i] = SCSpecFunctionInputV0Xdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.outputs = new SCSpecTypeDef[length];
                for (var i = 0; i < length; i++)
                {
                    result.outputs[i] = SCSpecTypeDefXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
