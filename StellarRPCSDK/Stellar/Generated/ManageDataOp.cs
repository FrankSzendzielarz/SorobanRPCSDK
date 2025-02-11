// Generated code - do not modify
// Source:

// struct ManageDataOp
// {
//     string64 dataName;
//     DataValue* dataValue; // set to null to clear
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
    public partial class ManageDataOp
    {
        public string64 dataName
        {
            get => _dataName;
            set
            {
                _dataName = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Data Name")]
        #endif
        private string64 _dataName;

        public DataValue dataValue
        {
            get => _dataValue;
            set
            {
                _dataValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Data Value")]
        #endif
        private DataValue _dataValue;

        public ManageDataOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ManageDataOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageDataOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageDataOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageDataOp value)
        {
            value.Validate();
            string64Xdr.Encode(stream, value.dataName);
            if (value.dataValue==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                DataValueXdr.Encode(stream, value.dataValue);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ManageDataOp Decode(XdrReader stream)
        {
            var result = new ManageDataOp();
            result.dataName = string64Xdr.Decode(stream);
            if (stream.ReadInt()==1)
            {
                result.dataValue = DataValueXdr.Decode(stream);
            }
            return result;
        }
    }
}
