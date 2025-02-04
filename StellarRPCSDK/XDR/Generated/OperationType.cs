// Generated code - do not modify
// Source:

// enum OperationType
// {
//     CREATE_ACCOUNT = 0,
//     PAYMENT = 1,
//     PATH_PAYMENT_STRICT_RECEIVE = 2,
//     MANAGE_SELL_OFFER = 3,
//     CREATE_PASSIVE_SELL_OFFER = 4,
//     SET_OPTIONS = 5,
//     CHANGE_TRUST = 6,
//     ALLOW_TRUST = 7,
//     ACCOUNT_MERGE = 8,
//     INFLATION = 9,
//     MANAGE_DATA = 10,
//     BUMP_SEQUENCE = 11,
//     MANAGE_BUY_OFFER = 12,
//     PATH_PAYMENT_STRICT_SEND = 13,
//     CREATE_CLAIMABLE_BALANCE = 14,
//     CLAIM_CLAIMABLE_BALANCE = 15,
//     BEGIN_SPONSORING_FUTURE_RESERVES = 16,
//     END_SPONSORING_FUTURE_RESERVES = 17,
//     REVOKE_SPONSORSHIP = 18,
//     CLAWBACK = 19,
//     CLAWBACK_CLAIMABLE_BALANCE = 20,
//     SET_TRUST_LINE_FLAGS = 21,
//     LIQUIDITY_POOL_DEPOSIT = 22,
//     LIQUIDITY_POOL_WITHDRAW = 23,
//     INVOKE_HOST_FUNCTION = 24,
//     EXTEND_FOOTPRINT_TTL = 25,
//     RESTORE_FOOTPRINT = 26
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum OperationType
    {
        CREATE_ACCOUNT = 0,
        PAYMENT = 1,
        PATH_PAYMENT_STRICT_RECEIVE = 2,
        MANAGE_SELL_OFFER = 3,
        CREATE_PASSIVE_SELL_OFFER = 4,
        SET_OPTIONS = 5,
        CHANGE_TRUST = 6,
        ALLOW_TRUST = 7,
        ACCOUNT_MERGE = 8,
        INFLATION = 9,
        MANAGE_DATA = 10,
        BUMP_SEQUENCE = 11,
        MANAGE_BUY_OFFER = 12,
        PATH_PAYMENT_STRICT_SEND = 13,
        CREATE_CLAIMABLE_BALANCE = 14,
        CLAIM_CLAIMABLE_BALANCE = 15,
        BEGIN_SPONSORING_FUTURE_RESERVES = 16,
        END_SPONSORING_FUTURE_RESERVES = 17,
        REVOKE_SPONSORSHIP = 18,
        CLAWBACK = 19,
        CLAWBACK_CLAIMABLE_BALANCE = 20,
        SET_TRUST_LINE_FLAGS = 21,
        LIQUIDITY_POOL_DEPOSIT = 22,
        LIQUIDITY_POOL_WITHDRAW = 23,
        INVOKE_HOST_FUNCTION = 24,
        EXTEND_FOOTPRINT_TTL = 25,
        RESTORE_FOOTPRINT = 26,
    }

    public static partial class OperationTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OperationType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OperationTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, OperationType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static OperationType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(OperationType), value))
              throw new InvalidOperationException($"Unknown OperationType value: {value}");
            return (OperationType)value;
        }
    }
}
