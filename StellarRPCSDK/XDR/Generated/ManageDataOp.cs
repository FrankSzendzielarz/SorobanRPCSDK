// Generated code - do not modify
// Source:

// struct ManageDataOp
// {
//     string64 dataName;
//     DataValue* dataValue; // set to null to clear
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ManageDataOp
    {
        private string _dataName;
        public string dataName
        {
            get => _dataName;
            set
            {
                _dataName = value;
            }
        }

        private DataValue _dataValue;
        public DataValue dataValue
        {
            get => _dataValue;
            set
            {
                _dataValue = value;
            }
        }

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
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageDataOp value)
        {
            value.Validate();
            stream.WriteString(value.dataName);
            DataValueXdr.Encode(stream, value.dataValue);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ManageDataOp Decode(XdrReader stream)
        {
            var result = new ManageDataOp();
            result.dataName = stream.ReadString();
            result.dataValue = DataValueXdr.Decode(stream);
            return result;
        }
    }
}
