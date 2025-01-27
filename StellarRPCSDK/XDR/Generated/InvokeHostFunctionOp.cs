// Generated code - do not modify
// Source:

// struct InvokeHostFunctionOp
// {
//     // Host function to invoke.
//     HostFunction hostFunction;
//     // Per-address authorizations for this host function.
//     SorobanAuthorizationEntry auth<>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class InvokeHostFunctionOp
    {
        private HostFunction _hostFunction;
        public HostFunction hostFunction
        {
            get => _hostFunction;
            set
            {
                _hostFunction = value;
            }
        }

        private SorobanAuthorizationEntry[] _auth;
        public SorobanAuthorizationEntry[] auth
        {
            get => _auth;
            set
            {
                _auth = value;
            }
        }

        public InvokeHostFunctionOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InvokeHostFunctionOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InvokeHostFunctionOp value)
        {
            value.Validate();
            HostFunctionXdr.Encode(stream, value.hostFunction);
            stream.WriteInt(value.auth.Length);
            foreach (var item in value.auth)
            {
                    SorobanAuthorizationEntryXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InvokeHostFunctionOp Decode(XdrReader stream)
        {
            var result = new InvokeHostFunctionOp();
            result.hostFunction = HostFunctionXdr.Decode(stream);
            var length = stream.ReadInt();
            result.auth = new SorobanAuthorizationEntry[length];
            for (var i = 0; i < length; i++)
            {
                result.auth[i] = SorobanAuthorizationEntryXdr.Decode(stream);
            }
            return result;
        }
    }
}
