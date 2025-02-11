// Generated code - do not modify
// Source:

// struct BeginSponsoringFutureReservesOp
// {
//     AccountID sponsoredID;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class BeginSponsoringFutureReservesOp
    {
        public AccountID sponsoredID
        {
            get => _sponsoredID;
            set
            {
                _sponsoredID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Sponsored I D")]
        #endif
        private AccountID _sponsoredID;

        public BeginSponsoringFutureReservesOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class BeginSponsoringFutureReservesOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BeginSponsoringFutureReservesOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BeginSponsoringFutureReservesOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, BeginSponsoringFutureReservesOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.sponsoredID);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static BeginSponsoringFutureReservesOp Decode(XdrReader stream)
        {
            var result = new BeginSponsoringFutureReservesOp();
            result.sponsoredID = AccountIDXdr.Decode(stream);
            return result;
        }
    }
}
