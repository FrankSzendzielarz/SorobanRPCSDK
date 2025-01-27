// Generated code - do not modify
// Source:

// enum OfferEntryFlags
// {
//     // an offer with this flag will not act on and take a reverse offer of equal
//     // price
//     PASSIVE_FLAG = 1
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum OfferEntryFlags
    {
        PASSIVE_FLAG = 1,
    }

    public static partial class OfferEntryFlagsXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, OfferEntryFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static OfferEntryFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(OfferEntryFlags), value))
              throw new InvalidOperationException($"Unknown OfferEntryFlags value: {value}");
            return (OfferEntryFlags)value;
        }
    }
