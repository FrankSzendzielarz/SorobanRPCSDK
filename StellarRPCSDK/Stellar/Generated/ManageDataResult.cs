// Generated code - do not modify
// Source:

// union ManageDataResult switch (ManageDataResultCode code)
// {
// case MANAGE_DATA_SUCCESS:
//     void;
// case MANAGE_DATA_NOT_SUPPORTED_YET:
// case MANAGE_DATA_NAME_NOT_FOUND:
// case MANAGE_DATA_LOW_RESERVE:
// case MANAGE_DATA_INVALID_NAME:
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
    [ProtoInclude(100, typeof(ManageDataSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ManageDataNotSupportedYet), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ManageDataNameNotFound), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ManageDataLowReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(ManageDataInvalidName), DataFormat = DataFormat.Default)]
    public abstract partial class ManageDataResult
    {
        public abstract ManageDataResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ManageDataResult.ManageDataSuccess")]
        public sealed partial class ManageDataSuccess : ManageDataResult
        {
            public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageDataResult.ManageDataNotSupportedYet")]
        public sealed partial class ManageDataNotSupportedYet : ManageDataResult
        {
            public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_NOT_SUPPORTED_YET;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageDataResult.ManageDataNameNotFound")]
        public sealed partial class ManageDataNameNotFound : ManageDataResult
        {
            public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_NAME_NOT_FOUND;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageDataResult.ManageDataLowReserve")]
        public sealed partial class ManageDataLowReserve : ManageDataResult
        {
            public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageDataResult.ManageDataInvalidName")]
        public sealed partial class ManageDataInvalidName : ManageDataResult
        {
            public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_INVALID_NAME;

            public override void ValidateCase() {}
        }
    }
    public static partial class ManageDataResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageDataResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageDataResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ManageDataResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ManageDataResult.ManageDataSuccess case_MANAGE_DATA_SUCCESS:
                break;
                case ManageDataResult.ManageDataNotSupportedYet case_MANAGE_DATA_NOT_SUPPORTED_YET:
                break;
                case ManageDataResult.ManageDataNameNotFound case_MANAGE_DATA_NAME_NOT_FOUND:
                break;
                case ManageDataResult.ManageDataLowReserve case_MANAGE_DATA_LOW_RESERVE:
                break;
                case ManageDataResult.ManageDataInvalidName case_MANAGE_DATA_INVALID_NAME:
                break;
            }
        }
        public static ManageDataResult Decode(XdrReader stream)
        {
            var discriminator = (ManageDataResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ManageDataResultCode.MANAGE_DATA_SUCCESS:
                var result_MANAGE_DATA_SUCCESS = new ManageDataResult.ManageDataSuccess();
                return result_MANAGE_DATA_SUCCESS;
                case ManageDataResultCode.MANAGE_DATA_NOT_SUPPORTED_YET:
                var result_MANAGE_DATA_NOT_SUPPORTED_YET = new ManageDataResult.ManageDataNotSupportedYet();
                return result_MANAGE_DATA_NOT_SUPPORTED_YET;
                case ManageDataResultCode.MANAGE_DATA_NAME_NOT_FOUND:
                var result_MANAGE_DATA_NAME_NOT_FOUND = new ManageDataResult.ManageDataNameNotFound();
                return result_MANAGE_DATA_NAME_NOT_FOUND;
                case ManageDataResultCode.MANAGE_DATA_LOW_RESERVE:
                var result_MANAGE_DATA_LOW_RESERVE = new ManageDataResult.ManageDataLowReserve();
                return result_MANAGE_DATA_LOW_RESERVE;
                case ManageDataResultCode.MANAGE_DATA_INVALID_NAME:
                var result_MANAGE_DATA_INVALID_NAME = new ManageDataResult.ManageDataInvalidName();
                return result_MANAGE_DATA_INVALID_NAME;
                default:
                throw new Exception($"Unknown discriminator for ManageDataResult: {discriminator}");
            }
        }
    }
}
