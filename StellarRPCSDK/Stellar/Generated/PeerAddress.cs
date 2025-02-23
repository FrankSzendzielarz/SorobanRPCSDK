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
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class PeerAddress
    {
        [ProtoMember(1)]
        public ipUnion ip
        {
            get => _ip;
            set
            {
                _ip = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ip")]
        #endif
        private ipUnion _ip;

        [ProtoMember(2)]
        public uint32 port
        {
            get => _port;
            set
            {
                _port = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Port")]
        #endif
        private uint32 _port;

        [ProtoMember(3)]
        public uint32 numFailures
        {
            get => _numFailures;
            set
            {
                _numFailures = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Num Failures")]
        #endif
        private uint32 _numFailures;

        public PeerAddress()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "PeerAddress_ipUnion")]
        [ProtoInclude(100, typeof(IPv4), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(IPv6), DataFormat = DataFormat.Default)]
        public abstract partial class ipUnion
        {
            public abstract IPAddrType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "PeerAddress_ipUnion_IPv4")]
            public sealed partial class IPv4 : ipUnion
            {
                public override IPAddrType Discriminator => IPAddrType.IPv4;
                [ProtoMember(1, OverwriteList = true)]
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
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Ipv4")]
                #endif
                private byte[] _ipv4 = new byte[4];

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "PeerAddress_ipUnion_IPv6")]
            public sealed partial class IPv6 : ipUnion
            {
                public override IPAddrType Discriminator => IPAddrType.IPv6;
                [ProtoMember(2, OverwriteList = true)]
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
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Ipv6")]
                #endif
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static ipUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return ipUnionXdr.Decode(reader);
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PeerAddress DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PeerAddressXdr.Decode(reader);
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
