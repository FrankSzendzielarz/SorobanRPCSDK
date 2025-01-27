// Generated code - do not modify
// Source:

// struct DataEntry
// {
//     AccountID accountID; // account this data belongs to
//     string64 dataName;
//     DataValue dataValue;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class DataEntry
    {
        private AccountID _accountID;
        public AccountID accountID
        {
            get => _accountID;
            set
            {
                _accountID = value;
            }
        }

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

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public DataEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class DataEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, DataEntry value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.accountID);
            stream.WriteString(value.dataName);
            DataValueXdr.Encode(stream, value.dataValue);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static DataEntry Decode(XdrReader stream)
        {
            var result = new DataEntry();
            result.accountID = AccountIDXdr.Decode(stream);
            result.dataName = stream.ReadString();
            result.dataValue = DataValueXdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
