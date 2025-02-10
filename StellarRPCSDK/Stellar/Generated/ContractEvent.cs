// Generated code - do not modify
// Source:

// struct ContractEvent
// {
//     // We can use this to add more fields, or because it
//     // is first, to change ContractEvent into a union.
//     ExtensionPoint ext;
// 
//     Hash* contractID;
//     ContractEventType type;
// 
//     union switch (int v)
//     {
//     case 0:
//         struct
//         {
//             SCVal topics<>;
//             SCVal data;
//         } v0;
//     }
//     body;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractEvent
    {
        /// <summary>
        /// is first, to change ContractEvent into a union.
        /// </summary>
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private ExtensionPoint _ext;

        public Hash contractID
        {
            get => _contractID;
            set
            {
                _contractID = value;
            }
        }
        private Hash _contractID;

        public ContractEventType type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        private ContractEventType _type;

        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }
        private bodyUnion _body;

        public ContractEvent()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class bodyUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            public partial class v0Struct
            {
                public SCVal[] topics
                {
                    get => _topics;
                    set
                    {
                        _topics = value;
                    }
                }
                private SCVal[] _topics;

                public SCVal data
                {
                    get => _data;
                    set
                    {
                        _data = value;
                    }
                }
                private SCVal _data;

                public v0Struct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class v0StructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(v0Struct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        v0StructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, v0Struct value)
                {
                    value.Validate();
                    stream.WriteInt(value.topics.Length);
                    foreach (var item in value.topics)
                    {
                            SCValXdr.Encode(stream, item);
                    }
                    SCValXdr.Encode(stream, value.data);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static v0Struct Decode(XdrReader stream)
                {
                    var result = new v0Struct();
                    {
                        var length = stream.ReadInt();
                        result.topics = new SCVal[length];
                        for (var i = 0; i < length; i++)
                        {
                            result.topics[i] = SCValXdr.Decode(stream);
                        }
                    }
                    result.data = SCValXdr.Decode(stream);
                    return result;
                }
            }
            public sealed partial class case_0 : bodyUnion
            {
                public override int Discriminator => 0;
                public v0Struct v0
                {
                    get => _v0;
                    set
                    {
                        _v0 = value;
                    }
                }
                private v0Struct _v0;

                public override void ValidateCase() {}
            }
        }
        public static partial class bodyUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(bodyUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    bodyUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion.case_0 case_0:
                    bodyUnion.v0StructXdr.Encode(stream, case_0.v0);
                    break;
                }
            }
            public static bodyUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new bodyUnion.case_0();
                    result_0.v0 = bodyUnion.v0StructXdr.Decode(stream);
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for bodyUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ContractEventXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractEvent value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractEventXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractEvent value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            if (value.contractID==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                HashXdr.Encode(stream, value.contractID);
            }
            ContractEventTypeXdr.Encode(stream, value.type);
            ContractEvent.bodyUnionXdr.Encode(stream, value.body);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractEvent Decode(XdrReader stream)
        {
            var result = new ContractEvent();
            result.ext = ExtensionPointXdr.Decode(stream);
            if (stream.ReadInt()==1)
            {
                result.contractID = HashXdr.Decode(stream);
            }
            result.type = ContractEventTypeXdr.Decode(stream);
            result.body = ContractEvent.bodyUnionXdr.Decode(stream);
            return result;
        }
    }
}
