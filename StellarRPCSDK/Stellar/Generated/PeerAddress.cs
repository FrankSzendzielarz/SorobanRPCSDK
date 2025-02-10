// Generated code - do not modify
// Source:

// struct PeerAddress
// {
//     union switch (IPAddrType type)
//     {
//     case IPv4:
//         opaque ipv4[4];
//     case IPv6:
//         opaque ipv6[16];
//     }
//     ip;
//     uint32 port;
//     uint32 numFailures;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PeerAddress
    {
        public ipUnion ip
        {
            get => _ip;
            set
            {
                _ip = value;
            }
        }
        private ipUnion _ip;

        public uint32 port
        {
            get => _port;
            set
            {
                _port = value;
            }
        }
        private uint32 _port;

        public uint32 numFailures
        {
            get => _numFailures;
            set
            {
                _numFailures = value;
            }
        }
        private uint32 _numFailures;

        public PeerAddress()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class ipUnion
        {
            public abstract IPAddrType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class IPv4 : ipUnion
            {
                public override IPAddrType Discriminator => IPAddrType.IPv4;
                [MinLength(4)]
                [MaxLength(4)]
                public byte[] ipv4
                {
                    get => _ipv4;
                    set
                    {
                        if (value.Length != 4)
                        	throw new ArgumentException($"Must be exactly 4 in length");
                        _ipv4 = value;
                    }
                }
                private byte[] _ipv4 = new byte[4];

                public override void ValidateCase() {}
            }
            public sealed partial class IPv6 : ipUnion
            {
                public override IPAddrType Discriminator => IPAddrType.IPv6;
                [MinLength(16)]
                [MaxLength(16)]
                public byte[] ipv6
                {
                    get => _ipv6;
                    set
                    {
                        if (value.Length != 16)
                        	throw new ArgumentException($"Must be exactly 16 in length");
                        _ipv6 = value;
                    }
                }
                private byte[] _ipv6 = new byte[16];

                public override void ValidateCase() {}
            }
        }
        public static partial class ipUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(ipUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    ipUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, ipUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case ipUnion.IPv4 case_IPv4:
                    stream.WriteFixedOpaque(case_IPv4.ipv4);
                    break;
                    case ipUnion.IPv6 case_IPv6:
                    stream.WriteFixedOpaque(case_IPv6.ipv6);
                    break;
                }
            }
            public static ipUnion Decode(XdrReader stream)
            {
                var discriminator = (IPAddrType)stream.ReadInt();
                switch (discriminator)
                {
                    case IPAddrType.IPv4:
                    var result_IPv4 = new ipUnion.IPv4();
                    stream.ReadFixedOpaque(result_IPv4.ipv4);
                    return result_IPv4;
                    case IPAddrType.IPv6:
                    var result_IPv6 = new ipUnion.IPv6();
                    stream.ReadFixedOpaque(result_IPv6.ipv6);
                    return result_IPv6;
                    default:
                    throw new Exception($"Unknown discriminator for ipUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class PeerAddressXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PeerAddress value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PeerAddressXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PeerAddress value)
        {
            value.Validate();
            PeerAddress.ipUnionXdr.Encode(stream, value.ip);
            uint32Xdr.Encode(stream, value.port);
            uint32Xdr.Encode(stream, value.numFailures);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PeerAddress Decode(XdrReader stream)
        {
            var result = new PeerAddress();
            result.ip = PeerAddress.ipUnionXdr.Decode(stream);
            result.port = uint32Xdr.Decode(stream);
            result.numFailures = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
