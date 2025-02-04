// Generated code - do not modify
// Source:

// enum ContractCostType {
//     // Cost of running 1 wasm instruction
//     WasmInsnExec = 0,
//     // Cost of allocating a slice of memory (in bytes)
//     MemAlloc = 1,
//     // Cost of copying a slice of bytes into a pre-allocated memory
//     MemCpy = 2,
//     // Cost of comparing two slices of memory
//     MemCmp = 3,
//     // Cost of a host function dispatch, not including the actual work done by
//     // the function nor the cost of VM invocation machinary
//     DispatchHostFunction = 4,
//     // Cost of visiting a host object from the host object storage. Exists to 
//     // make sure some baseline cost coverage, i.e. repeatly visiting objects
//     // by the guest will always incur some charges.
//     VisitObject = 5,
//     // Cost of serializing an xdr object to bytes
//     ValSer = 6,
//     // Cost of deserializing an xdr object from bytes
//     ValDeser = 7,
//     // Cost of computing the sha256 hash from bytes
//     ComputeSha256Hash = 8,
//     // Cost of computing the ed25519 pubkey from bytes
//     ComputeEd25519PubKey = 9,
//     // Cost of verifying ed25519 signature of a payload.
//     VerifyEd25519Sig = 10,
//     // Cost of instantiation a VM from wasm bytes code.
//     VmInstantiation = 11,
//     // Cost of instantiation a VM from a cached state.
//     VmCachedInstantiation = 12,
//     // Cost of invoking a function on the VM. If the function is a host function,
//     // additional cost will be covered by `DispatchHostFunction`.
//     InvokeVmFunction = 13,
//     // Cost of computing a keccak256 hash from bytes.
//     ComputeKeccak256Hash = 14,
//     // Cost of decoding an ECDSA signature computed from a 256-bit prime modulus
//     // curve (e.g. secp256k1 and secp256r1)
//     DecodeEcdsaCurve256Sig = 15,
//     // Cost of recovering an ECDSA secp256k1 key from a signature.
//     RecoverEcdsaSecp256k1Key = 16,
//     // Cost of int256 addition (`+`) and subtraction (`-`) operations
//     Int256AddSub = 17,
//     // Cost of int256 multiplication (`*`) operation
//     Int256Mul = 18,
//     // Cost of int256 division (`/`) operation
//     Int256Div = 19,
//     // Cost of int256 power (`exp`) operation
//     Int256Pow = 20,
//     // Cost of int256 shift (`shl`, `shr`) operation
//     Int256Shift = 21,
//     // Cost of drawing random bytes using a ChaCha20 PRNG
//     ChaCha20DrawBytes = 22,
// 
//     // Cost of parsing wasm bytes that only encode instructions.
//     ParseWasmInstructions = 23,
//     // Cost of parsing a known number of wasm functions.
//     ParseWasmFunctions = 24,
//     // Cost of parsing a known number of wasm globals.
//     ParseWasmGlobals = 25,
//     // Cost of parsing a known number of wasm table entries.
//     ParseWasmTableEntries = 26,
//     // Cost of parsing a known number of wasm types.
//     ParseWasmTypes = 27,
//     // Cost of parsing a known number of wasm data segments.
//     ParseWasmDataSegments = 28,
//     // Cost of parsing a known number of wasm element segments.
//     ParseWasmElemSegments = 29,
//     // Cost of parsing a known number of wasm imports.
//     ParseWasmImports = 30,
//     // Cost of parsing a known number of wasm exports.
//     ParseWasmExports = 31,
//     // Cost of parsing a known number of data segment bytes.
//     ParseWasmDataSegmentBytes = 32,
// 
//     // Cost of instantiating wasm bytes that only encode instructions.
//     InstantiateWasmInstructions = 33,
//     // Cost of instantiating a known number of wasm functions.
//     InstantiateWasmFunctions = 34,
//     // Cost of instantiating a known number of wasm globals.
//     InstantiateWasmGlobals = 35,
//     // Cost of instantiating a known number of wasm table entries.
//     InstantiateWasmTableEntries = 36,
//     // Cost of instantiating a known number of wasm types.
//     InstantiateWasmTypes = 37,
//     // Cost of instantiating a known number of wasm data segments.
//     InstantiateWasmDataSegments = 38,
//     // Cost of instantiating a known number of wasm element segments.
//     InstantiateWasmElemSegments = 39,
//     // Cost of instantiating a known number of wasm imports.
//     InstantiateWasmImports = 40,
//     // Cost of instantiating a known number of wasm exports.
//     InstantiateWasmExports = 41,
//     // Cost of instantiating a known number of data segment bytes.
//     InstantiateWasmDataSegmentBytes = 42,
// 
//     // Cost of decoding a bytes array representing an uncompressed SEC-1 encoded
//     // point on a 256-bit elliptic curve
//     Sec1DecodePointUncompressed = 43,
//     // Cost of verifying an ECDSA Secp256r1 signature
//     VerifyEcdsaSecp256r1Sig = 44,
// 
//     // Cost of encoding a BLS12-381 Fp (base field element)
//     Bls12381EncodeFp = 45,
//     // Cost of decoding a BLS12-381 Fp (base field element)
//     Bls12381DecodeFp = 46,
//     // Cost of checking a G1 point lies on the curve
//     Bls12381G1CheckPointOnCurve = 47,
//     // Cost of checking a G1 point belongs to the correct subgroup
//     Bls12381G1CheckPointInSubgroup = 48,
//     // Cost of checking a G2 point lies on the curve
//     Bls12381G2CheckPointOnCurve = 49,
//     // Cost of checking a G2 point belongs to the correct subgroup
//     Bls12381G2CheckPointInSubgroup = 50,
//     // Cost of converting a BLS12-381 G1 point from projective to affine coordinates
//     Bls12381G1ProjectiveToAffine = 51,
//     // Cost of converting a BLS12-381 G2 point from projective to affine coordinates
//     Bls12381G2ProjectiveToAffine = 52,
//     // Cost of performing BLS12-381 G1 point addition
//     Bls12381G1Add = 53,
//     // Cost of performing BLS12-381 G1 scalar multiplication
//     Bls12381G1Mul = 54,
//     // Cost of performing BLS12-381 G1 multi-scalar multiplication (MSM)
//     Bls12381G1Msm = 55,
//     // Cost of mapping a BLS12-381 Fp field element to a G1 point
//     Bls12381MapFpToG1 = 56,
//     // Cost of hashing to a BLS12-381 G1 point
//     Bls12381HashToG1 = 57,
//     // Cost of performing BLS12-381 G2 point addition
//     Bls12381G2Add = 58,
//     // Cost of performing BLS12-381 G2 scalar multiplication
//     Bls12381G2Mul = 59,
//     // Cost of performing BLS12-381 G2 multi-scalar multiplication (MSM)
//     Bls12381G2Msm = 60,
//     // Cost of mapping a BLS12-381 Fp2 field element to a G2 point
//     Bls12381MapFp2ToG2 = 61,
//     // Cost of hashing to a BLS12-381 G2 point
//     Bls12381HashToG2 = 62,
//     // Cost of performing BLS12-381 pairing operation
//     Bls12381Pairing = 63,
//     // Cost of converting a BLS12-381 scalar element from U256
//     Bls12381FrFromU256 = 64,
//     // Cost of converting a BLS12-381 scalar element to U256
//     Bls12381FrToU256 = 65,
//     // Cost of performing BLS12-381 scalar element addition/subtraction
//     Bls12381FrAddSub = 66,
//     // Cost of performing BLS12-381 scalar element multiplication
//     Bls12381FrMul = 67,
//     // Cost of performing BLS12-381 scalar element exponentiation
//     Bls12381FrPow = 68,
//     // Cost of performing BLS12-381 scalar element inversion
//     Bls12381FrInv = 69
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ContractCostType
    {
        /// <summary>
        /// Cost of running 1 wasm instruction
        /// </summary>
        WasmInsnExec = 0,
        /// <summary>
        /// Cost of allocating a slice of memory (in bytes)
        /// </summary>
        MemAlloc = 1,
        /// <summary>
        /// Cost of copying a slice of bytes into a pre-allocated memory
        /// </summary>
        MemCpy = 2,
        /// <summary>
        /// Cost of comparing two slices of memory
        /// </summary>
        MemCmp = 3,
        /// <summary>
        /// the function nor the cost of VM invocation machinary
        /// </summary>
        DispatchHostFunction = 4,
        /// <summary>
        /// by the guest will always incur some charges.
        /// </summary>
        VisitObject = 5,
        /// <summary>
        /// Cost of serializing an xdr object to bytes
        /// </summary>
        ValSer = 6,
        /// <summary>
        /// Cost of deserializing an xdr object from bytes
        /// </summary>
        ValDeser = 7,
        /// <summary>
        /// Cost of computing the sha256 hash from bytes
        /// </summary>
        ComputeSha256Hash = 8,
        /// <summary>
        /// Cost of computing the ed25519 pubkey from bytes
        /// </summary>
        ComputeEd25519PubKey = 9,
        /// <summary>
        /// Cost of verifying ed25519 signature of a payload.
        /// </summary>
        VerifyEd25519Sig = 10,
        /// <summary>
        /// Cost of instantiation a VM from wasm bytes code.
        /// </summary>
        VmInstantiation = 11,
        /// <summary>
        /// Cost of instantiation a VM from a cached state.
        /// </summary>
        VmCachedInstantiation = 12,
        /// <summary>
        /// additional cost will be covered by `DispatchHostFunction`.
        /// </summary>
        InvokeVmFunction = 13,
        /// <summary>
        /// Cost of computing a keccak256 hash from bytes.
        /// </summary>
        ComputeKeccak256Hash = 14,
        /// <summary>
        /// curve (e.g. secp256k1 and secp256r1)
        /// </summary>
        DecodeEcdsaCurve256Sig = 15,
        /// <summary>
        /// Cost of recovering an ECDSA secp256k1 key from a signature.
        /// </summary>
        RecoverEcdsaSecp256k1Key = 16,
        /// <summary>
        /// Cost of int256 addition (`+`) and subtraction (`-`) operations
        /// </summary>
        Int256AddSub = 17,
        /// <summary>
        /// Cost of int256 multiplication (`*`) operation
        /// </summary>
        Int256Mul = 18,
        /// <summary>
        /// Cost of int256 division (`/`) operation
        /// </summary>
        Int256Div = 19,
        /// <summary>
        /// Cost of int256 power (`exp`) operation
        /// </summary>
        Int256Pow = 20,
        /// <summary>
        /// Cost of int256 shift (`shl`, `shr`) operation
        /// </summary>
        Int256Shift = 21,
        /// <summary>
        /// Cost of drawing random bytes using a ChaCha20 PRNG
        /// </summary>
        ChaCha20DrawBytes = 22,
        /// <summary>
        /// Cost of parsing wasm bytes that only encode instructions.
        /// </summary>
        ParseWasmInstructions = 23,
        /// <summary>
        /// Cost of parsing a known number of wasm functions.
        /// </summary>
        ParseWasmFunctions = 24,
        /// <summary>
        /// Cost of parsing a known number of wasm globals.
        /// </summary>
        ParseWasmGlobals = 25,
        /// <summary>
        /// Cost of parsing a known number of wasm table entries.
        /// </summary>
        ParseWasmTableEntries = 26,
        /// <summary>
        /// Cost of parsing a known number of wasm types.
        /// </summary>
        ParseWasmTypes = 27,
        /// <summary>
        /// Cost of parsing a known number of wasm data segments.
        /// </summary>
        ParseWasmDataSegments = 28,
        /// <summary>
        /// Cost of parsing a known number of wasm element segments.
        /// </summary>
        ParseWasmElemSegments = 29,
        /// <summary>
        /// Cost of parsing a known number of wasm imports.
        /// </summary>
        ParseWasmImports = 30,
        /// <summary>
        /// Cost of parsing a known number of wasm exports.
        /// </summary>
        ParseWasmExports = 31,
        /// <summary>
        /// Cost of parsing a known number of data segment bytes.
        /// </summary>
        ParseWasmDataSegmentBytes = 32,
        /// <summary>
        /// Cost of instantiating wasm bytes that only encode instructions.
        /// </summary>
        InstantiateWasmInstructions = 33,
        /// <summary>
        /// Cost of instantiating a known number of wasm functions.
        /// </summary>
        InstantiateWasmFunctions = 34,
        /// <summary>
        /// Cost of instantiating a known number of wasm globals.
        /// </summary>
        InstantiateWasmGlobals = 35,
        /// <summary>
        /// Cost of instantiating a known number of wasm table entries.
        /// </summary>
        InstantiateWasmTableEntries = 36,
        /// <summary>
        /// Cost of instantiating a known number of wasm types.
        /// </summary>
        InstantiateWasmTypes = 37,
        /// <summary>
        /// Cost of instantiating a known number of wasm data segments.
        /// </summary>
        InstantiateWasmDataSegments = 38,
        /// <summary>
        /// Cost of instantiating a known number of wasm element segments.
        /// </summary>
        InstantiateWasmElemSegments = 39,
        /// <summary>
        /// Cost of instantiating a known number of wasm imports.
        /// </summary>
        InstantiateWasmImports = 40,
        /// <summary>
        /// Cost of instantiating a known number of wasm exports.
        /// </summary>
        InstantiateWasmExports = 41,
        /// <summary>
        /// Cost of instantiating a known number of data segment bytes.
        /// </summary>
        InstantiateWasmDataSegmentBytes = 42,
        /// <summary>
        /// point on a 256-bit elliptic curve
        /// </summary>
        Sec1DecodePointUncompressed = 43,
        /// <summary>
        /// Cost of verifying an ECDSA Secp256r1 signature
        /// </summary>
        VerifyEcdsaSecp256r1Sig = 44,
        /// <summary>
        /// Cost of encoding a BLS12-381 Fp (base field element)
        /// </summary>
        Bls12381EncodeFp = 45,
        /// <summary>
        /// Cost of decoding a BLS12-381 Fp (base field element)
        /// </summary>
        Bls12381DecodeFp = 46,
        /// <summary>
        /// Cost of checking a G1 point lies on the curve
        /// </summary>
        Bls12381G1CheckPointOnCurve = 47,
        /// <summary>
        /// Cost of checking a G1 point belongs to the correct subgroup
        /// </summary>
        Bls12381G1CheckPointInSubgroup = 48,
        /// <summary>
        /// Cost of checking a G2 point lies on the curve
        /// </summary>
        Bls12381G2CheckPointOnCurve = 49,
        /// <summary>
        /// Cost of checking a G2 point belongs to the correct subgroup
        /// </summary>
        Bls12381G2CheckPointInSubgroup = 50,
        /// <summary>
        /// Cost of converting a BLS12-381 G1 point from projective to affine coordinates
        /// </summary>
        Bls12381G1ProjectiveToAffine = 51,
        /// <summary>
        /// Cost of converting a BLS12-381 G2 point from projective to affine coordinates
        /// </summary>
        Bls12381G2ProjectiveToAffine = 52,
        /// <summary>
        /// Cost of performing BLS12-381 G1 point addition
        /// </summary>
        Bls12381G1Add = 53,
        /// <summary>
        /// Cost of performing BLS12-381 G1 scalar multiplication
        /// </summary>
        Bls12381G1Mul = 54,
        /// <summary>
        /// Cost of performing BLS12-381 G1 multi-scalar multiplication (MSM)
        /// </summary>
        Bls12381G1Msm = 55,
        /// <summary>
        /// Cost of mapping a BLS12-381 Fp field element to a G1 point
        /// </summary>
        Bls12381MapFpToG1 = 56,
        /// <summary>
        /// Cost of hashing to a BLS12-381 G1 point
        /// </summary>
        Bls12381HashToG1 = 57,
        /// <summary>
        /// Cost of performing BLS12-381 G2 point addition
        /// </summary>
        Bls12381G2Add = 58,
        /// <summary>
        /// Cost of performing BLS12-381 G2 scalar multiplication
        /// </summary>
        Bls12381G2Mul = 59,
        /// <summary>
        /// Cost of performing BLS12-381 G2 multi-scalar multiplication (MSM)
        /// </summary>
        Bls12381G2Msm = 60,
        /// <summary>
        /// Cost of mapping a BLS12-381 Fp2 field element to a G2 point
        /// </summary>
        Bls12381MapFp2ToG2 = 61,
        /// <summary>
        /// Cost of hashing to a BLS12-381 G2 point
        /// </summary>
        Bls12381HashToG2 = 62,
        /// <summary>
        /// Cost of performing BLS12-381 pairing operation
        /// </summary>
        Bls12381Pairing = 63,
        /// <summary>
        /// Cost of converting a BLS12-381 scalar element from U256
        /// </summary>
        Bls12381FrFromU256 = 64,
        /// <summary>
        /// Cost of converting a BLS12-381 scalar element to U256
        /// </summary>
        Bls12381FrToU256 = 65,
        /// <summary>
        /// Cost of performing BLS12-381 scalar element addition/subtraction
        /// </summary>
        Bls12381FrAddSub = 66,
        /// <summary>
        /// Cost of performing BLS12-381 scalar element multiplication
        /// </summary>
        Bls12381FrMul = 67,
        /// <summary>
        /// Cost of performing BLS12-381 scalar element exponentiation
        /// </summary>
        Bls12381FrPow = 68,
        /// <summary>
        /// Cost of performing BLS12-381 scalar element inversion
        /// </summary>
        Bls12381FrInv = 69,
    }

    public static partial class ContractCostTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractCostType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractCostTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCostType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ContractCostType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ContractCostType), value))
              throw new InvalidOperationException($"Unknown ContractCostType value: {value}");
            return (ContractCostType)value;
        }
    }
}
