// Generated code - do not modify
// Source:

// struct TransactionResultSet
// {
//     TransactionResultPair results<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// TransactionResultSet is used to recover results between ledgers
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TransactionResultSet
    {
        [ProtoMember(1, OverwriteList = true)]
        public TransactionResultPair[] results
        {
            get => _results;
            set
            {
                _results = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Results")]
        #endif
        private TransactionResultPair[] _results;

        public TransactionResultSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionResultSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionResultSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionResultSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionResultSet DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionResultSetXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResultSet value)
        {
            value.Validate();
            stream.WriteInt(value.results.Length);
            foreach (var item in value.results)
            {
                    TransactionResultPairXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionResultSet Decode(XdrReader stream)
        {
            var result = new TransactionResultSet();
            {
                var length = stream.ReadInt();
                result.results = new TransactionResultPair[length];
                for (var i = 0; i < length; i++)
                {
                    result.results[i] = TransactionResultPairXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
