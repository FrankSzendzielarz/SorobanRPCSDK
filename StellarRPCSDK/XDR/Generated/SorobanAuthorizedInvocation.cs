// Generated code - do not modify
// Source:

// struct SorobanAuthorizedInvocation
// {
//     SorobanAuthorizedFunction function;
//     SorobanAuthorizedInvocation subInvocations<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanAuthorizedInvocation
    {
        private SorobanAuthorizedFunction _function;
        public SorobanAuthorizedFunction function
        {
            get => _function;
            set
            {
                _function = value;
            }
        }

        private SorobanAuthorizedInvocation[] _subInvocations;
        public SorobanAuthorizedInvocation[] subInvocations
        {
            get => _subInvocations;
            set
            {
                _subInvocations = value;
            }
        }

        public SorobanAuthorizedInvocation()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanAuthorizedInvocationXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanAuthorizedInvocation value)
        {
            value.Validate();
            SorobanAuthorizedFunctionXdr.Encode(stream, value.function);
            stream.WriteInt(value.subInvocations.Length);
            foreach (var item in value.subInvocations)
            {
                    SorobanAuthorizedInvocationXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanAuthorizedInvocation Decode(XdrReader stream)
        {
            var result = new SorobanAuthorizedInvocation();
            result.function = SorobanAuthorizedFunctionXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.subInvocations = new SorobanAuthorizedInvocation[length];
                for (var i = 0; i < length; i++)
                {
                    result.subInvocations[i] = SorobanAuthorizedInvocationXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
