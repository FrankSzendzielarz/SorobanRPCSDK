// Generated code - do not modify
// Source:

// union InflationResult switch (InflationResultCode code)
// {
// case INFLATION_SUCCESS:
//     InflationPayout payouts<>;
// case INFLATION_NOT_TIME:
//     void;
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
    [ProtoInclude(100, typeof(InflationSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(InflationNotTime), DataFormat = DataFormat.Default)]
    public abstract partial class InflationResult
    {
        public abstract InflationResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "InflationResult_InflationSuccess")]
        public sealed partial class InflationSuccess : InflationResult
        {
            public override InflationResultCode Discriminator => InflationResultCode.INFLATION_SUCCESS;
            [ProtoMember(1, OverwriteList = true)]
            public InflationPayout[] payouts
            {
                get => _payouts;
                set
                {
                    _payouts = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Payouts")]
            #endif
            private InflationPayout[] _payouts;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "InflationResult_InflationNotTime")]
        public sealed partial class InflationNotTime : InflationResult
        {
            public override InflationResultCode Discriminator => InflationResultCode.INFLATION_NOT_TIME;

            public override void ValidateCase() {}
        }
    }
    public static partial class InflationResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InflationResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InflationResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static InflationResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return InflationResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, InflationResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case InflationResult.InflationSuccess case_INFLATION_SUCCESS:
                stream.WriteInt(case_INFLATION_SUCCESS.payouts.Length);
                foreach (var item in case_INFLATION_SUCCESS.payouts)
                {
                        InflationPayoutXdr.Encode(stream, item);
                }
                break;
                case InflationResult.InflationNotTime case_INFLATION_NOT_TIME:
                break;
            }
        }
        public static InflationResult Decode(XdrReader stream)
        {
            var discriminator = (InflationResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case InflationResultCode.INFLATION_SUCCESS:
                var result_INFLATION_SUCCESS = new InflationResult.InflationSuccess();
                {
                    var length = stream.ReadInt();
                    result_INFLATION_SUCCESS.payouts = new InflationPayout[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_INFLATION_SUCCESS.payouts[i] = InflationPayoutXdr.Decode(stream);
                    }
                }
                return result_INFLATION_SUCCESS;
                case InflationResultCode.INFLATION_NOT_TIME:
                var result_INFLATION_NOT_TIME = new InflationResult.InflationNotTime();
                return result_INFLATION_NOT_TIME;
                default:
                throw new Exception($"Unknown discriminator for InflationResult: {discriminator}");
            }
        }
    }
}
