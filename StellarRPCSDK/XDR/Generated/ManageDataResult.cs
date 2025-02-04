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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ManageDataResult
    {
        public abstract ManageDataResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ManageDataResult_MANAGE_DATA_SUCCESS : ManageDataResult
    {
        public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageDataResult_MANAGE_DATA_NOT_SUPPORTED_YET : ManageDataResult
    {
        public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_NOT_SUPPORTED_YET;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageDataResult_MANAGE_DATA_NAME_NOT_FOUND : ManageDataResult
    {
        public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_NAME_NOT_FOUND;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageDataResult_MANAGE_DATA_LOW_RESERVE : ManageDataResult
    {
        public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageDataResult_MANAGE_DATA_INVALID_NAME : ManageDataResult
    {
        public override ManageDataResultCode Discriminator => ManageDataResultCode.MANAGE_DATA_INVALID_NAME;

        public override void ValidateCase() {}
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
                case ManageDataResult_MANAGE_DATA_SUCCESS case_MANAGE_DATA_SUCCESS:
                break;
                case ManageDataResult_MANAGE_DATA_NOT_SUPPORTED_YET case_MANAGE_DATA_NOT_SUPPORTED_YET:
                break;
                case ManageDataResult_MANAGE_DATA_NAME_NOT_FOUND case_MANAGE_DATA_NAME_NOT_FOUND:
                break;
                case ManageDataResult_MANAGE_DATA_LOW_RESERVE case_MANAGE_DATA_LOW_RESERVE:
                break;
                case ManageDataResult_MANAGE_DATA_INVALID_NAME case_MANAGE_DATA_INVALID_NAME:
                break;
            }
        }
        public static ManageDataResult Decode(XdrReader stream)
        {
            var discriminator = (ManageDataResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ManageDataResultCode.MANAGE_DATA_SUCCESS:
                var result_MANAGE_DATA_SUCCESS = new ManageDataResult_MANAGE_DATA_SUCCESS();
                return result_MANAGE_DATA_SUCCESS;
                case ManageDataResultCode.MANAGE_DATA_NOT_SUPPORTED_YET:
                var result_MANAGE_DATA_NOT_SUPPORTED_YET = new ManageDataResult_MANAGE_DATA_NOT_SUPPORTED_YET();
                return result_MANAGE_DATA_NOT_SUPPORTED_YET;
                case ManageDataResultCode.MANAGE_DATA_NAME_NOT_FOUND:
                var result_MANAGE_DATA_NAME_NOT_FOUND = new ManageDataResult_MANAGE_DATA_NAME_NOT_FOUND();
                return result_MANAGE_DATA_NAME_NOT_FOUND;
                case ManageDataResultCode.MANAGE_DATA_LOW_RESERVE:
                var result_MANAGE_DATA_LOW_RESERVE = new ManageDataResult_MANAGE_DATA_LOW_RESERVE();
                return result_MANAGE_DATA_LOW_RESERVE;
                case ManageDataResultCode.MANAGE_DATA_INVALID_NAME:
                var result_MANAGE_DATA_INVALID_NAME = new ManageDataResult_MANAGE_DATA_INVALID_NAME();
                return result_MANAGE_DATA_INVALID_NAME;
                default:
                throw new Exception($"Unknown discriminator for ManageDataResult: {discriminator}");
            }
        }
    }
}
