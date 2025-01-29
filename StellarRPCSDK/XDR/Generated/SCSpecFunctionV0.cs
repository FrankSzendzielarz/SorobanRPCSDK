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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecFunctionV0
    {
        private SCSymbol _name;
        public SCSymbol name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private SCSpecFunctionInputV0[] _inputs;
        public SCSpecFunctionInputV0[] inputs
        {
            get => _inputs;
            set
            {
                if (value.Length > 10)
                	throw new ArgumentException($"Cannot exceed 10 bytes");
                _inputs = value;
            }
        }

        private SCSpecTypeDef[] _outputs;
        public SCSpecTypeDef[] outputs
        {
            get => _outputs;
            set
            {
                if (value.Length > 1)
                	throw new ArgumentException($"Cannot exceed 1 bytes");
                _outputs = value;
            }
        }

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
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecFunctionV0 value)
        {
            value.Validate();
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
