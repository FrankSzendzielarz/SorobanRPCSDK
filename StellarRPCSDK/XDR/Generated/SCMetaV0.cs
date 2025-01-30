// Generated code - do not modify
// Source:

// struct SCMetaV0
// {
//     string key<>;
//     string val<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCMetaV0
    {
        private string _key;
        public string key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        private string _val;
        public string val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }

        public SCMetaV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCMetaV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMetaV0 value)
        {
            value.Validate();
            stream.WriteString(value.key);
            stream.WriteString(value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCMetaV0 Decode(XdrReader stream)
        {
            var result = new SCMetaV0();
            result.key = stream.ReadString();
            result.val = stream.ReadString();
            return result;
        }
    }
}
