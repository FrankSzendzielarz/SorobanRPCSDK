// Generated code - do not modify
// Source:

// typedef AccountID* SponsorshipDescriptor;


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
    public partial class SponsorshipDescriptor
    {
        [ProtoMember(1)]
        public AccountID InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private AccountID _innerValue;

        public SponsorshipDescriptor() { }

        public SponsorshipDescriptor(AccountID value)
        {
            InnerValue = value;
        }
        public static implicit operator AccountID(SponsorshipDescriptor _sponsorshipdescriptor) => _sponsorshipdescriptor.InnerValue;
        public static implicit operator SponsorshipDescriptor(AccountID value) => new SponsorshipDescriptor(value);
    }
    public static partial class SponsorshipDescriptorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SponsorshipDescriptor value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SponsorshipDescriptorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SponsorshipDescriptor DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SponsorshipDescriptorXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SponsorshipDescriptor value)
        {
            if (value.InnerValue==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                AccountIDXdr.Encode(stream, value.InnerValue);
            }
        }
        public static SponsorshipDescriptor Decode(XdrReader stream)
        {
            var result = new SponsorshipDescriptor();
            if (stream.ReadInt()==1)
            {
                result.InnerValue = AccountIDXdr.Decode(stream);
            }
            return result;
        }
    }
}
