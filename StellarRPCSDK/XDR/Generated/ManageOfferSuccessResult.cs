// Generated code - do not modify
// Source:

// struct ManageOfferSuccessResult
// {
//     // offers that got claimed while creating this offer
//     ClaimAtom offersClaimed<>;
// 
//     union switch (ManageOfferEffect effect)
//     {
//     case MANAGE_OFFER_CREATED:
//     case MANAGE_OFFER_UPDATED:
//         OfferEntry offer;
//     case MANAGE_OFFER_DELETED:
//         void;
//     }
//     offer;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ManageOfferSuccessResult
    {
        private ClaimAtom[] _offersClaimed;
        public ClaimAtom[] offersClaimed
        {
            get => _offersClaimed;
            set
            {
                _offersClaimed = value;
            }
        }

        private offerUnion _offer;
        public offerUnion offer
        {
            get => _offer;
            set
            {
                _offer = value;
            }
        }

        public ManageOfferSuccessResult()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class offerUnion
        {
            public abstract ManageOfferEffect Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class offerUnion_MANAGE_OFFER_CREATED : offerUnion
        {
            public override ManageOfferEffect Discriminator => ManageOfferEffect.MANAGE_OFFER_CREATED;
            private OfferEntry _offer;
            public OfferEntry offer
            {
                get => _offer;
                set
                {
                    _offer = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class offerUnion_MANAGE_OFFER_UPDATED : offerUnion
        {
            public override ManageOfferEffect Discriminator => ManageOfferEffect.MANAGE_OFFER_UPDATED;
            private OfferEntry _offer;
            public OfferEntry offer
            {
                get => _offer;
                set
                {
                    _offer = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class offerUnion_MANAGE_OFFER_DELETED : offerUnion
        {
            public override ManageOfferEffect Discriminator => ManageOfferEffect.MANAGE_OFFER_DELETED;

            public override void ValidateCase() {}
        }
        public static partial class offerUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(offerUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    offerUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, offerUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case offerUnion_MANAGE_OFFER_CREATED case_MANAGE_OFFER_CREATED:
                    OfferEntryXdr.Encode(stream, case_MANAGE_OFFER_CREATED.offer);
                    break;
                    case offerUnion_MANAGE_OFFER_UPDATED case_MANAGE_OFFER_UPDATED:
                    OfferEntryXdr.Encode(stream, case_MANAGE_OFFER_UPDATED.offer);
                    break;
                    case offerUnion_MANAGE_OFFER_DELETED case_MANAGE_OFFER_DELETED:
                    break;
                }
            }
            public static offerUnion Decode(XdrReader stream)
            {
                var discriminator = (ManageOfferEffect)stream.ReadInt();
                switch (discriminator)
                {
                    case ManageOfferEffect.MANAGE_OFFER_CREATED:
                    var result_MANAGE_OFFER_CREATED = new offerUnion_MANAGE_OFFER_CREATED();
                    result_MANAGE_OFFER_CREATED.offer = OfferEntryXdr.Decode(stream);
                    return result_MANAGE_OFFER_CREATED;
                    case ManageOfferEffect.MANAGE_OFFER_UPDATED:
                    var result_MANAGE_OFFER_UPDATED = new offerUnion_MANAGE_OFFER_UPDATED();
                    result_MANAGE_OFFER_UPDATED.offer = OfferEntryXdr.Decode(stream);
                    return result_MANAGE_OFFER_UPDATED;
                    case ManageOfferEffect.MANAGE_OFFER_DELETED:
                    var result_MANAGE_OFFER_DELETED = new offerUnion_MANAGE_OFFER_DELETED();
                    return result_MANAGE_OFFER_DELETED;
                    default:
                    throw new Exception($"Unknown discriminator for offerUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ManageOfferSuccessResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageOfferSuccessResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageOfferSuccessResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageOfferSuccessResult value)
        {
            value.Validate();
            stream.WriteInt(value.offersClaimed.Length);
            foreach (var item in value.offersClaimed)
            {
                    ClaimAtomXdr.Encode(stream, item);
            }
            ManageOfferSuccessResult.offerUnionXdr.Encode(stream, value.offer);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ManageOfferSuccessResult Decode(XdrReader stream)
        {
            var result = new ManageOfferSuccessResult();
            {
                var length = stream.ReadInt();
                result.offersClaimed = new ClaimAtom[length];
                for (var i = 0; i < length; i++)
                {
                    result.offersClaimed[i] = ClaimAtomXdr.Decode(stream);
                }
            }
            result.offer = ManageOfferSuccessResult.offerUnionXdr.Decode(stream);
            return result;
        }
    }
}
