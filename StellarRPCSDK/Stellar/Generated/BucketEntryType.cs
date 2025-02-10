// Generated code - do not modify
// Source:

// enum BucketEntryType
// {
//     METAENTRY =
//         -1, // At-and-after protocol 11: bucket metadata, should come first.
//     LIVEENTRY = 0, // Before protocol 11: created-or-updated;
//                    // At-and-after protocol 11: only updated.
//     DEADENTRY = 1,
//     INITENTRY = 2 // At-and-after protocol 11: only created.
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    /// <summary>
    /// Entries used to define the bucket list
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum BucketEntryType
    {
        METAENTRY = -1,
        /// <summary>
        /// At-and-after protocol 11: bucket metadata, should come first.
        /// </summary>
        LIVEENTRY = 0,
        /// <summary>
        /// At-and-after protocol 11: only updated.
        /// </summary>
        DEADENTRY = 1,
        INITENTRY = 2,
    }

    public static partial class BucketEntryTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BucketEntryType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BucketEntryTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, BucketEntryType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static BucketEntryType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(BucketEntryType), value))
              throw new InvalidOperationException($"Unknown BucketEntryType value: {value}");
            return (BucketEntryType)value;
        }
    }
}
