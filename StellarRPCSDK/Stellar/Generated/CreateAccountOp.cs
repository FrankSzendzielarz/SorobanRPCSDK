// Generated code - do not modify
// Source:

// struct CreateAccountOp
// {
//     AccountID destination; // account to create
//     int64 startingBalance; // amount they end up with
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
    public partial class CreateAccountOp
    {
        [ProtoMember(1)]
        public AccountID destination
        {
            get => _destination;
            set
            {
                _destination = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Destination")]
        #endif
        private AccountID _destination;

        /// <summary>
        /// account to create
        /// </summary>
        [ProtoMember(2)]
        public int64 startingBalance
        {
            get => _startingBalance;
            set
            {
                _startingBalance = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Starting Balance")]
        #endif
        private int64 _startingBalance;

        public CreateAccountOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class CreateAccountOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateAccountOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateAccountOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateAccountOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.destination);
            int64Xdr.Encode(stream, value.startingBalance);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreateAccountOp Decode(XdrReader stream)
        {
            var result = new CreateAccountOp();
            result.destination = AccountIDXdr.Decode(stream);
            result.startingBalance = int64Xdr.Decode(stream);
            return result;
        }
    }
}
