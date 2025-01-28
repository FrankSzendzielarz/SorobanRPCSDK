// Generated code - do not modify
// Source:

// enum RevokeSponsorshipType
// {
//     REVOKE_SPONSORSHIP_LEDGER_ENTRY = 0,
//     REVOKE_SPONSORSHIP_SIGNER = 1
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum RevokeSponsorshipType
    {
        REVOKE_SPONSORSHIP_LEDGER_ENTRY = 0,
        REVOKE_SPONSORSHIP_SIGNER = 1,
    }

    public static partial class RevokeSponsorshipTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, RevokeSponsorshipType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static RevokeSponsorshipType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(RevokeSponsorshipType), value))
              throw new InvalidOperationException($"Unknown RevokeSponsorshipType value: {value}");
            return (RevokeSponsorshipType)value;
        }
    }
}
