// Generated code - do not modify
// Source:

// union ExtensionPoint switch (int v)
// {
// case 0:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// extend a structure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ExtensionPoint
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class case_0 : ExtensionPoint
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
    }
    public static partial class ExtensionPointXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ExtensionPoint value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ExtensionPointXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ExtensionPoint value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ExtensionPoint.case_0 case_0:
                break;
            }
        }
        public static ExtensionPoint Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new ExtensionPoint.case_0();
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for ExtensionPoint: {discriminator}");
            }
        }
    }
}
