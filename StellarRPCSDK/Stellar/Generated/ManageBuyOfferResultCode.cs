// Generated code - do not modify
// Source:

// enum ManageBuyOfferResultCode
// {
//     // codes considered as "success" for the operation
//     MANAGE_BUY_OFFER_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     MANAGE_BUY_OFFER_MALFORMED = -1,     // generated offer would be invalid
//     MANAGE_BUY_OFFER_SELL_NO_TRUST = -2, // no trust line for what we're selling
//     MANAGE_BUY_OFFER_BUY_NO_TRUST = -3,  // no trust line for what we're buying
//     MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED = -4, // not authorized to sell
//     MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED = -5,  // not authorized to buy
//     MANAGE_BUY_OFFER_LINE_FULL = -6,   // can't receive more of what it's buying
//     MANAGE_BUY_OFFER_UNDERFUNDED = -7, // doesn't hold what it's trying to sell
//     MANAGE_BUY_OFFER_CROSS_SELF = -8, // would cross an offer from the same user
//     MANAGE_BUY_OFFER_SELL_NO_ISSUER = -9, // no issuer for what we're selling
//     MANAGE_BUY_OFFER_BUY_NO_ISSUER = -10, // no issuer for what we're buying
// 
//     // update errors
//     MANAGE_BUY_OFFER_NOT_FOUND =
//         -11, // offerID does not match an existing offer
// 
//     MANAGE_BUY_OFFER_LOW_RESERVE = -12 // not enough funds to create a new Offer
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ManageBuyOfferResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        MANAGE_BUY_OFFER_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        MANAGE_BUY_OFFER_MALFORMED = -1,
        /// <summary>
        /// generated offer would be invalid
        /// </summary>
        MANAGE_BUY_OFFER_SELL_NO_TRUST = -2,
        /// <summary>
        /// no trust line for what we're selling
        /// </summary>
        MANAGE_BUY_OFFER_BUY_NO_TRUST = -3,
        /// <summary>
        /// no trust line for what we're buying
        /// </summary>
        MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED = -4,
        /// <summary>
        /// not authorized to sell
        /// </summary>
        MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED = -5,
        /// <summary>
        /// not authorized to buy
        /// </summary>
        MANAGE_BUY_OFFER_LINE_FULL = -6,
        /// <summary>
        /// can't receive more of what it's buying
        /// </summary>
        MANAGE_BUY_OFFER_UNDERFUNDED = -7,
        /// <summary>
        /// doesn't hold what it's trying to sell
        /// </summary>
        MANAGE_BUY_OFFER_CROSS_SELF = -8,
        /// <summary>
        /// would cross an offer from the same user
        /// </summary>
        MANAGE_BUY_OFFER_SELL_NO_ISSUER = -9,
        /// <summary>
        /// no issuer for what we're selling
        /// </summary>
        MANAGE_BUY_OFFER_BUY_NO_ISSUER = -10,
        /// <summary>
        /// update errors
        /// </summary>
        MANAGE_BUY_OFFER_NOT_FOUND = -11,
        MANAGE_BUY_OFFER_LOW_RESERVE = -12,
    }

    public static partial class ManageBuyOfferResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageBuyOfferResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageBuyOfferResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageBuyOfferResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ManageBuyOfferResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ManageBuyOfferResultCode), value))
              throw new InvalidOperationException($"Unknown ManageBuyOfferResultCode value: {value}");
            return (ManageBuyOfferResultCode)value;
        }
    }
}
