// Generated code - do not modify
// Source:

// union ExtensionPoint switch (int v)
// {
// case 0:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ExtensionPoint
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class ExtensionPoint_0 : ExtensionPoint
    {
        public override int Discriminator => 0;

        public override void ValidateCase() {}
    }
    public static partial class ExtensionPointXdr
    {
        public static void Encode(XdrWriter stream, ExtensionPoint value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ExtensionPoint_0 case_0:
                break;
            }
        }
        public static ExtensionPoint Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new ExtensionPoint_0();
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for ExtensionPoint: {discriminator}");
            }
        }
    }
}
