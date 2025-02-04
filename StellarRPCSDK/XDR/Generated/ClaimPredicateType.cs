// Generated code - do not modify
// Source:

// enum ClaimPredicateType
// {
//     CLAIM_PREDICATE_UNCONDITIONAL = 0,
//     CLAIM_PREDICATE_AND = 1,
//     CLAIM_PREDICATE_OR = 2,
//     CLAIM_PREDICATE_NOT = 3,
//     CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = 4,
//     CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = 5
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClaimPredicateType
    {
        CLAIM_PREDICATE_UNCONDITIONAL = 0,
        CLAIM_PREDICATE_AND = 1,
        CLAIM_PREDICATE_OR = 2,
        CLAIM_PREDICATE_NOT = 3,
        CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = 4,
        CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = 5,
    }

    public static partial class ClaimPredicateTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimPredicateType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimPredicateTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimPredicateType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimPredicateType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimPredicateType), value))
              throw new InvalidOperationException($"Unknown ClaimPredicateType value: {value}");
            return (ClaimPredicateType)value;
        }
    }
}
