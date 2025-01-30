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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PeerAddress
    {
        private ipUnion _ip;
        public ipUnion ip
        {
            get => _ip;
            set
            {
                _ip = value;
            }
        }

        private uint32 _port;
        public uint32 port
        {
            get => _port;
            set
            {
                _port = value;
            }
        }

        private uint32 _numFailures;
        public uint32 numFailures
        {
            get => _numFailures;
            set
            {
                _numFailures = value;
            }
        }

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

        }
        public sealed partial class ipUnion_IPv4 : ipUnion
        {
            public override IPAddrType Discriminator => IPAddrType.IPv4;

            public override void ValidateCase() {}
        }
        public sealed partial class ipUnion_IPv6 : ipUnion
        {
            public override IPAddrType Discriminator => IPAddrType.IPv6;

            public override void ValidateCase() {}
        }
        public static partial class ipUnionXdr
        {
            public static void Encode(XdrWriter stream, ipUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case ipUnion_IPv4 case_IPv4:
                    break;
                    case ipUnion_IPv6 case_IPv6:
                    break;
                }
            }
            public static ipUnion Decode(XdrReader stream)
            {
                var discriminator = (IPAddrType)stream.ReadInt();
                switch (discriminator)
                {
                    case IPAddrType.IPv4:
                    var result_IPv4 = new ipUnion_IPv4();
                    return result_IPv4;
                    case IPAddrType.IPv6:
                    var result_IPv6 = new ipUnion_IPv6();
                    return result_IPv6;
                    default:
                    throw new Exception($"Unknown discriminator for ipUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class PeerAddressXdr
    {
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
