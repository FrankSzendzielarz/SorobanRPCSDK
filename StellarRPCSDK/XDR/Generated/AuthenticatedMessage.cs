// Generated code - do not modify
// Source:

// union AuthenticatedMessage switch (uint32 v)
// {
// case 0:
//     struct
//     {
//         uint64 sequence;
//         StellarMessage message;
//         HmacSha256Mac mac;
//     } v0;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class AuthenticatedMessage
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class v0Struct
        {
            public uint64 sequence
            {
                get => _sequence;
                set
                {
                    _sequence = value;
                }
            }
            private uint64 _sequence;

            public StellarMessage message
            {
                get => _message;
                set
                {
                    _message = value;
                }
            }
            private StellarMessage _message;

            public HmacSha256Mac mac
            {
                get => _mac;
                set
                {
                    _mac = value;
                }
            }
            private HmacSha256Mac _mac;

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
                uint64Xdr.Encode(stream, value.sequence);
                StellarMessageXdr.Encode(stream, value.message);
                HmacSha256MacXdr.Encode(stream, value.mac);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static v0Struct Decode(XdrReader stream)
            {
                var result = new v0Struct();
                result.sequence = uint64Xdr.Decode(stream);
                result.message = StellarMessageXdr.Decode(stream);
                result.mac = HmacSha256MacXdr.Decode(stream);
                return result;
            }
        }
        public sealed partial class case_0 : AuthenticatedMessage
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
    public static partial class AuthenticatedMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AuthenticatedMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AuthenticatedMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, AuthenticatedMessage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AuthenticatedMessage.case_0 case_0:
                AuthenticatedMessage.v0StructXdr.Encode(stream, case_0.v0);
                break;
            }
        }
        public static AuthenticatedMessage Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new AuthenticatedMessage.case_0();
                result_0.v0 = AuthenticatedMessage.v0StructXdr.Decode(stream);
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for AuthenticatedMessage: {discriminator}");
            }
        }
    }
}
