// Generated code - do not modify
// Source:

// union TransactionPhase switch (int v)
// {
// case 0:
//     TxSetComponent v0Components<>;
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
    [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
    public abstract partial class TransactionPhase
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "TransactionPhase_case_0")]
        public sealed partial class case_0 : TransactionPhase
        {
            public override int Discriminator => 0;
            [ProtoMember(1, OverwriteList = true)]
            public TxSetComponent[] v0Components
            {
                get => _v0Components;
                set
                {
                    _v0Components = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V0 Components")]
            #endif
            private TxSetComponent[] _v0Components;

            public override void ValidateCase() {}
        }
    }
    public static partial class TransactionPhaseXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionPhase value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionPhaseXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionPhase DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionPhaseXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, TransactionPhase value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TransactionPhase.case_0 case_0:
                stream.WriteInt(case_0.v0Components.Length);
                foreach (var item in case_0.v0Components)
                {
                        TxSetComponentXdr.Encode(stream, item);
                }
                break;
            }
        }
        public static TransactionPhase Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new TransactionPhase.case_0();
                {
                    var length = stream.ReadInt();
                    result_0.v0Components = new TxSetComponent[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_0.v0Components[i] = TxSetComponentXdr.Decode(stream);
                    }
                }
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for TransactionPhase: {discriminator}");
            }
        }
    }
}
