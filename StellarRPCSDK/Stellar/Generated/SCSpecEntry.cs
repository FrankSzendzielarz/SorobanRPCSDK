// Generated code - do not modify
// Source:

// union SCSpecEntry switch (SCSpecEntryKind kind)
// {
// case SC_SPEC_ENTRY_FUNCTION_V0:
//     SCSpecFunctionV0 functionV0;
// case SC_SPEC_ENTRY_UDT_STRUCT_V0:
//     SCSpecUDTStructV0 udtStructV0;
// case SC_SPEC_ENTRY_UDT_UNION_V0:
//     SCSpecUDTUnionV0 udtUnionV0;
// case SC_SPEC_ENTRY_UDT_ENUM_V0:
//     SCSpecUDTEnumV0 udtEnumV0;
// case SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0:
//     SCSpecUDTErrorEnumV0 udtErrorEnumV0;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCSpecEntry
    {
        public abstract SCSpecEntryKind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class ScSpecEntryFunctionV0 : SCSpecEntry
        {
            public override SCSpecEntryKind Discriminator => SCSpecEntryKind.SC_SPEC_ENTRY_FUNCTION_V0;
            public SCSpecFunctionV0 functionV0
            {
                get => _functionV0;
                set
                {
                    _functionV0 = value;
                }
            }
            private SCSpecFunctionV0 _functionV0;

            public override void ValidateCase() {}
        }
        public sealed partial class ScSpecEntryUdtStructV0 : SCSpecEntry
        {
            public override SCSpecEntryKind Discriminator => SCSpecEntryKind.SC_SPEC_ENTRY_UDT_STRUCT_V0;
            public SCSpecUDTStructV0 udtStructV0
            {
                get => _udtStructV0;
                set
                {
                    _udtStructV0 = value;
                }
            }
            private SCSpecUDTStructV0 _udtStructV0;

            public override void ValidateCase() {}
        }
        public sealed partial class ScSpecEntryUdtUnionV0 : SCSpecEntry
        {
            public override SCSpecEntryKind Discriminator => SCSpecEntryKind.SC_SPEC_ENTRY_UDT_UNION_V0;
            public SCSpecUDTUnionV0 udtUnionV0
            {
                get => _udtUnionV0;
                set
                {
                    _udtUnionV0 = value;
                }
            }
            private SCSpecUDTUnionV0 _udtUnionV0;

            public override void ValidateCase() {}
        }
        public sealed partial class ScSpecEntryUdtEnumV0 : SCSpecEntry
        {
            public override SCSpecEntryKind Discriminator => SCSpecEntryKind.SC_SPEC_ENTRY_UDT_ENUM_V0;
            public SCSpecUDTEnumV0 udtEnumV0
            {
                get => _udtEnumV0;
                set
                {
                    _udtEnumV0 = value;
                }
            }
            private SCSpecUDTEnumV0 _udtEnumV0;

            public override void ValidateCase() {}
        }
        public sealed partial class ScSpecEntryUdtErrorEnumV0 : SCSpecEntry
        {
            public override SCSpecEntryKind Discriminator => SCSpecEntryKind.SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0;
            public SCSpecUDTErrorEnumV0 udtErrorEnumV0
            {
                get => _udtErrorEnumV0;
                set
                {
                    _udtErrorEnumV0 = value;
                }
            }
            private SCSpecUDTErrorEnumV0 _udtErrorEnumV0;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCSpecEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCSpecEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCSpecEntry.ScSpecEntryFunctionV0 case_SC_SPEC_ENTRY_FUNCTION_V0:
                SCSpecFunctionV0Xdr.Encode(stream, case_SC_SPEC_ENTRY_FUNCTION_V0.functionV0);
                break;
                case SCSpecEntry.ScSpecEntryUdtStructV0 case_SC_SPEC_ENTRY_UDT_STRUCT_V0:
                SCSpecUDTStructV0Xdr.Encode(stream, case_SC_SPEC_ENTRY_UDT_STRUCT_V0.udtStructV0);
                break;
                case SCSpecEntry.ScSpecEntryUdtUnionV0 case_SC_SPEC_ENTRY_UDT_UNION_V0:
                SCSpecUDTUnionV0Xdr.Encode(stream, case_SC_SPEC_ENTRY_UDT_UNION_V0.udtUnionV0);
                break;
                case SCSpecEntry.ScSpecEntryUdtEnumV0 case_SC_SPEC_ENTRY_UDT_ENUM_V0:
                SCSpecUDTEnumV0Xdr.Encode(stream, case_SC_SPEC_ENTRY_UDT_ENUM_V0.udtEnumV0);
                break;
                case SCSpecEntry.ScSpecEntryUdtErrorEnumV0 case_SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0:
                SCSpecUDTErrorEnumV0Xdr.Encode(stream, case_SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0.udtErrorEnumV0);
                break;
            }
        }
        public static SCSpecEntry Decode(XdrReader stream)
        {
            var discriminator = (SCSpecEntryKind)stream.ReadInt();
            switch (discriminator)
            {
                case SCSpecEntryKind.SC_SPEC_ENTRY_FUNCTION_V0:
                var result_SC_SPEC_ENTRY_FUNCTION_V0 = new SCSpecEntry.ScSpecEntryFunctionV0();
                result_SC_SPEC_ENTRY_FUNCTION_V0.functionV0 = SCSpecFunctionV0Xdr.Decode(stream);
                return result_SC_SPEC_ENTRY_FUNCTION_V0;
                case SCSpecEntryKind.SC_SPEC_ENTRY_UDT_STRUCT_V0:
                var result_SC_SPEC_ENTRY_UDT_STRUCT_V0 = new SCSpecEntry.ScSpecEntryUdtStructV0();
                result_SC_SPEC_ENTRY_UDT_STRUCT_V0.udtStructV0 = SCSpecUDTStructV0Xdr.Decode(stream);
                return result_SC_SPEC_ENTRY_UDT_STRUCT_V0;
                case SCSpecEntryKind.SC_SPEC_ENTRY_UDT_UNION_V0:
                var result_SC_SPEC_ENTRY_UDT_UNION_V0 = new SCSpecEntry.ScSpecEntryUdtUnionV0();
                result_SC_SPEC_ENTRY_UDT_UNION_V0.udtUnionV0 = SCSpecUDTUnionV0Xdr.Decode(stream);
                return result_SC_SPEC_ENTRY_UDT_UNION_V0;
                case SCSpecEntryKind.SC_SPEC_ENTRY_UDT_ENUM_V0:
                var result_SC_SPEC_ENTRY_UDT_ENUM_V0 = new SCSpecEntry.ScSpecEntryUdtEnumV0();
                result_SC_SPEC_ENTRY_UDT_ENUM_V0.udtEnumV0 = SCSpecUDTEnumV0Xdr.Decode(stream);
                return result_SC_SPEC_ENTRY_UDT_ENUM_V0;
                case SCSpecEntryKind.SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0:
                var result_SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0 = new SCSpecEntry.ScSpecEntryUdtErrorEnumV0();
                result_SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0.udtErrorEnumV0 = SCSpecUDTErrorEnumV0Xdr.Decode(stream);
                return result_SC_SPEC_ENTRY_UDT_ERROR_ENUM_V0;
                default:
                throw new Exception($"Unknown discriminator for SCSpecEntry: {discriminator}");
            }
        }
    }
}
