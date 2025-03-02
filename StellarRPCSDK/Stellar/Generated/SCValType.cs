// Generated code - do not modify
// Source:

// enum SCValType
// {
//     SCV_BOOL = 0,
//     SCV_VOID = 1,
//     SCV_ERROR = 2,
// 
//     // 32 bits is the smallest type in WASM or XDR; no need for u8/u16.
//     SCV_U32 = 3,
//     SCV_I32 = 4,
// 
//     // 64 bits is naturally supported by both WASM and XDR also.
//     SCV_U64 = 5,
//     SCV_I64 = 6,
// 
//     // Time-related u64 subtypes with their own functions and formatting.
//     SCV_TIMEPOINT = 7,
//     SCV_DURATION = 8,
// 
//     // 128 bits is naturally supported by Rust and we use it for Soroban
//     // fixed-point arithmetic prices / balances / similar "quantities". These
//     // are represented in XDR as a pair of 2 u64s.
//     SCV_U128 = 9,
//     SCV_I128 = 10,
// 
//     // 256 bits is the size of sha256 output, ed25519 keys, and the EVM machine
//     // word, so for interop use we include this even though it requires a small
//     // amount of Rust guest and/or host library code.
//     SCV_U256 = 11,
//     SCV_I256 = 12,
// 
//     // Bytes come in 3 flavors, 2 of which have meaningfully different
//     // formatting and validity-checking / domain-restriction.
//     SCV_BYTES = 13,
//     SCV_STRING = 14,
//     SCV_SYMBOL = 15,
// 
//     // Vecs and maps are just polymorphic containers of other ScVals.
//     SCV_VEC = 16,
//     SCV_MAP = 17,
// 
//     // Address is the universal identifier for contracts and classic
//     // accounts.
//     SCV_ADDRESS = 18,
// 
//     // The following are the internal SCVal variants that are not
//     // exposed to the contracts. 
//     SCV_CONTRACT_INSTANCE = 19,
// 
//     // SCV_LEDGER_KEY_CONTRACT_INSTANCE and SCV_LEDGER_KEY_NONCE are unique
//     // symbolic SCVals used as the key for ledger entries for a contract's
//     // instance and an address' nonce, respectively.
//     SCV_LEDGER_KEY_CONTRACT_INSTANCE = 20,
//     SCV_LEDGER_KEY_NONCE = 21
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum SCValType
    {
        SCV_BOOL = 0,
        SCV_VOID = 1,
        SCV_ERROR = 2,
        /// <summary>
        /// 32 bits is the smallest type in WASM or XDR; no need for u8/u16.
        /// </summary>
        SCV_U32 = 3,
        SCV_I32 = 4,
        /// <summary>
        /// 64 bits is naturally supported by both WASM and XDR also.
        /// </summary>
        SCV_U64 = 5,
        SCV_I64 = 6,
        /// <summary>
        /// Time-related u64 subtypes with their own functions and formatting.
        /// </summary>
        SCV_TIMEPOINT = 7,
        SCV_DURATION = 8,
        /// <summary>
        /// are represented in XDR as a pair of 2 u64s.
        /// </summary>
        SCV_U128 = 9,
        SCV_I128 = 10,
        /// <summary>
        /// amount of Rust guest and/or host library code.
        /// </summary>
        SCV_U256 = 11,
        SCV_I256 = 12,
        /// <summary>
        /// formatting and validity-checking / domain-restriction.
        /// </summary>
        SCV_BYTES = 13,
        SCV_STRING = 14,
        SCV_SYMBOL = 15,
        /// <summary>
        /// Vecs and maps are just polymorphic containers of other ScVals.
        /// </summary>
        SCV_VEC = 16,
        SCV_MAP = 17,
        /// <summary>
        /// accounts.
        /// </summary>
        SCV_ADDRESS = 18,
        /// <summary>
        /// exposed to the contracts.
        /// </summary>
        SCV_CONTRACT_INSTANCE = 19,
        /// <summary>
        /// instance and an address' nonce, respectively.
        /// </summary>
        SCV_LEDGER_KEY_CONTRACT_INSTANCE = 20,
        SCV_LEDGER_KEY_NONCE = 21,
    }

    public static partial class SCValTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCValType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCValTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCValType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCValTypeXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCValType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SCValType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SCValType), value))
              throw new InvalidOperationException($"Unknown SCValType value: {value}");
            return (SCValType)value;
        }
    }
}
