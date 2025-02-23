using Chaos.NaCl;
using dotnetstandard_bip32;
using ProtoBuf;
using Stellar.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using static Stellar.Transaction_ProtoWrapper;

namespace Stellar
{
    [ServiceContract]
    public interface IMuxedAccount_ProtoWrapper
    {
        MuxedAccount_ProtoWrapper.BoolResult CanSign(MuxedAccount account);
        MuxedAccount.KeyTypeEd25519 CreateKeyTypeEd25519(MuxedAccount_ProtoWrapper.CreateEd25519Param param);
        MuxedAccount.KeyTypeMuxedEd25519 CreateKeyTypeMuxedEd25519(MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param param);
        MuxedAccount_ProtoWrapper.StringResult GetAccountId(MuxedAccount account);
        MuxedAccount_ProtoWrapper.StringResult GetAddress(MuxedAccount account);
        MuxedAccount_ProtoWrapper.ByteArrayWrapper GetPrivateKey(MuxedAccount account);
        MuxedAccount_ProtoWrapper.ByteArrayWrapper GetPublicKey(MuxedAccount account);
        MuxedAccount_ProtoWrapper.StringResult GetSecretSeed(MuxedAccount account);
        MuxedAccount_ProtoWrapper.ByteArrayWrapper GetSeedBytes(MuxedAccount account);
        MuxedAccount_ProtoWrapper.ByteArrayWrapper Sign(MuxedAccount_ProtoWrapper.SignMessage message);
        MuxedAccount_ProtoWrapper.BoolResult Verify(MuxedAccount_ProtoWrapper.VerifyMessage message);

        MuxedAccount.KeyTypeEd25519 FromSecretSeed(MuxedAccount_ProtoWrapper.StringParam seedString);
        MuxedAccount.KeyTypeEd25519 FromSecretSeedBytes(MuxedAccount_ProtoWrapper.ByteArrayWrapper seedBytes);
        MuxedAccount.KeyTypeEd25519 FromAccountId(MuxedAccount_ProtoWrapper.StringParam accountId);
        MuxedAccount.KeyTypeEd25519 FromPublicKey(MuxedAccount_ProtoWrapper.ByteArrayWrapper publicKey);
        MuxedAccount.KeyTypeEd25519 FromBIP39Seed(MuxedAccount_ProtoWrapper.BIP39SeedParam param);
        MuxedAccount.KeyTypeEd25519 FromBIP39SeedBytes(MuxedAccount_ProtoWrapper.BIP39SeedBytesParam param);
        MuxedAccount.KeyTypeEd25519 Random();
    }


    public class MuxedAccount_ProtoWrapper : IMuxedAccount_ProtoWrapper
    {
        [ProtoContract]
        public class ByteArrayWrapper
        {
            [ProtoMember(1)]
            public byte[] Value { get; set; }
        }

        [ProtoContract]
        public class StringResult
        {
            [ProtoMember(1)]
            public string Value { get; set; }
        }
        [ProtoContract]
        public class StringParam
        {
            [ProtoMember(1)]
            public string Value { get; set; }
        }

        [ProtoContract]
        public class BIP39SeedParam
        {
            [ProtoMember(1)]
            public string Seed { get; set; }
            [ProtoMember(2)]
            public uint AccountIndex { get; set; }
        }

        [ProtoContract]
        public class BIP39SeedBytesParam
        {
            [ProtoMember(1)]
            public byte[] SeedBytes { get; set; }
            [ProtoMember(2)]
            public uint AccountIndex { get; set; }
        }


        [ProtoContract]
        public class BoolResult
        {
            [ProtoMember(1)]
            public bool Value { get; set; }
        }

        [ProtoContract]
        public class SignMessage
        {
            [ProtoMember(1)]
            public MuxedAccount Account { get; set; }
            [ProtoMember(2)]
            public ByteArrayWrapper Data { get; set; }
        }

        [ProtoContract]
        public class VerifyMessage
        {
            [ProtoMember(1)]
            public MuxedAccount Account { get; set; }
            [ProtoMember(2)]
            public ByteArrayWrapper Data { get; set; }
            [ProtoMember(3)]
            public ByteArrayWrapper Signature { get; set; }
        }

        [ProtoContract]
        public class CreateEd25519Param
        {
            [ProtoMember(1)]
            public ByteArrayWrapper PublicKey { get; set; }
            [ProtoMember(2)]
            public ByteArrayWrapper Seed { get; set; }
        }

        [ProtoContract]
        public class CreateMuxedEd25519Param
        {
            [ProtoMember(1)]
            public ByteArrayWrapper PublicKey { get; set; }
            [ProtoMember(2)]
            public ByteArrayWrapper Seed { get; set; }
            [ProtoMember(3)]
            public ulong Id { get; set; }
        }

        // Instance methods
        [OperationContract]
        public ByteArrayWrapper GetPublicKey(MuxedAccount account)
        {
            return new ByteArrayWrapper { Value = account.PublicKey };
        }

        [OperationContract]
        public ByteArrayWrapper GetPrivateKey(MuxedAccount account)
        {
            return new ByteArrayWrapper { Value = account.PrivateKey };
        }

        [OperationContract]
        public ByteArrayWrapper GetSeedBytes(MuxedAccount account)
        {
            return new ByteArrayWrapper { Value = account.SeedBytes };
        }

        [OperationContract]
        public StringResult GetSecretSeed(MuxedAccount account)
        {
            return new StringResult { Value = account.SecretSeed };
        }

        [OperationContract]
        public StringResult GetAccountId(MuxedAccount account)
        {
            return new StringResult { Value = account.AccountId };
        }

        [OperationContract]
        public StringResult GetAddress(MuxedAccount account)
        {
            return new StringResult { Value = account.Address };
        }

        [OperationContract]
        public BoolResult CanSign(MuxedAccount account)
        {
            return new BoolResult { Value = account.CanSign() };
        }

        [OperationContract]
        public ByteArrayWrapper Sign(SignMessage message)
        {
            return new ByteArrayWrapper { Value = message.Account.Sign(message.Data.Value) };
        }

        [OperationContract]
        public BoolResult Verify(VerifyMessage message)
        {
            return new BoolResult { Value = message.Account.Verify(message.Data.Value, message.Signature.Value) };
        }

        // Factory methods for subtypes
        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 CreateKeyTypeEd25519(CreateEd25519Param param)
        {
            return new MuxedAccount.KeyTypeEd25519(param.PublicKey?.Value, param.Seed?.Value);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeMuxedEd25519 CreateKeyTypeMuxedEd25519(CreateMuxedEd25519Param param)
        {
            return new MuxedAccount.KeyTypeMuxedEd25519(param.PublicKey?.Value, param.Seed?.Value, param.Id);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromSecretSeed(StringParam seedString)
        {
            return MuxedAccount.FromSecretSeed(seedString.Value);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromSecretSeedBytes(ByteArrayWrapper seedBytes)
        {
            return MuxedAccount.FromSecretSeed(seedBytes.Value);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromAccountId(StringParam accountId)
        {
            var result = MuxedAccount.FromAccountId(accountId.Value);
            return result;
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromPublicKey(ByteArrayWrapper publicKey)
        {
            return MuxedAccount.FromPublicKey(publicKey.Value);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromBIP39Seed(BIP39SeedParam param)
        {
            return MuxedAccount.FromBIP39Seed(param.Seed, param.AccountIndex);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 FromBIP39SeedBytes(BIP39SeedBytesParam param)
        {
            return MuxedAccount.FromBIP39Seed(param.SeedBytes, param.AccountIndex);
        }

        [OperationContract]
        public MuxedAccount.KeyTypeEd25519 Random()
        {
            return MuxedAccount.Random();
        }
    }



    /// <summary>
    /// Muxed Account
    /// </summary>
    public partial class MuxedAccount : IEquatable<MuxedAccount>
    {

        private byte[] _secretKey;
        private byte[] _seed;

        public abstract byte[] PublicKey { get; }

 
        public sealed partial class KeyTypeEd25519 : MuxedAccount
        {
            public KeyTypeEd25519() { }
            public KeyTypeEd25519(byte[] publicKey, byte[] seed)
            {
                _seed = seed;
                if (publicKey == null)
                {
                    if (seed != null) Ed25519.KeyPairFromSeed(out publicKey, out _secretKey, _seed);
                }
                ed25519 = publicKey;
            }

            public override byte[] PublicKey => ed25519;

            public override bool Equals(MuxedAccount other)
            {

                if (!(other is KeyTypeMuxedEd25519))
                {
                    return false;
                }
                if (SeedBytes != null && other.SeedBytes == null)
                {
                    return false;
                }
                if (SeedBytes == null && other.SeedBytes != null)
                {
                    return false;
                }
                return PublicKey.SequenceEqual(other.PublicKey);
           
            }
        }

    
        public sealed partial class KeyTypeMuxedEd25519 : MuxedAccount
        {
            public KeyTypeMuxedEd25519() { }
            public KeyTypeMuxedEd25519(byte[] publicKey, byte[] seed, ulong id)
            {
                _seed = seed;
                if (publicKey == null)
                {
                    if (seed != null) Ed25519.KeyPairFromSeed(out publicKey, out _secretKey, _seed);
                }
                med25519 = new med25519Struct() { ed25519= publicKey,id= id };
            }

            public override byte[] PublicKey => med25519.ed25519;
            public override bool Equals(MuxedAccount other)
            {
                
                if (!(other is  KeyTypeMuxedEd25519))
                {
                    return false;
                }
                if (SeedBytes != null && other.SeedBytes == null)
                {
                    return false;
                }
                if (SeedBytes == null && other.SeedBytes != null)
                {
                    return false;
                }
                if (!PublicKey.SequenceEqual(other.PublicKey))
                {
                    return false;
                }
                return this.med25519.id == (other as KeyTypeMuxedEd25519).med25519.id;
                
            }
        }



        /// <summary>
        ///     The private key.
        /// </summary>
        
        public byte[] PrivateKey { get { return _secretKey; } }

        /// <summary>
        ///     The bytes of the Secret Seed
        /// </summary>

        public byte[] SeedBytes {  get { return _seed; } }

        /// <summary>
        ///     SecretSeed
        /// </summary>
        public string SecretSeed => SeedBytes != null ? StrKey.EncodeStellarSecretSeed(SeedBytes) : null;

    

        /// <summary>
        ///     To XDR Public Key
        /// </summary>
        public PublicKey.PublicKeyTypeEd25519 XdrPublicKey => new PublicKey.PublicKeyTypeEd25519()
        {
            ed25519 = PublicKey
        };

        /// <summary>
        ///     XDR Signer Key
        /// </summary>
        public SignerKey XdrSignerKey => new SignerKey.SignerKeyTypeEd25519()
        {
            ed25519 = PublicKey
        };

        /// <summary>
        ///     The public key.
        /// </summary>


        /// <summary>
        ///     AccountId in StrKey encoding
        /// </summary>
        public string AccountId => StrKey.EncodeStellarAccountId(PublicKey);

        /// <summary>
        ///     Address in encoded form
        /// </summary>
        public string Address => StrKey.EncodeStellarMuxedAccount(this);

        public abstract bool Equals(MuxedAccount other);
      
        /// <summary>
        ///     Returns true if this Keypair is capable of signing
        /// </summary>
        /// <returns></returns>
        public bool CanSign()
        {
            return _secretKey != null;
        }

        /// <summary>
        ///     Creates a new Stellar KeyPair from a StrKey encoded Stellar secret seed.
        /// </summary>
        /// <param name="seed">eed Char array containing StrKey encoded Stellar secret seed.</param>
        /// <returns>
        ///     <see cref="AccountID" />
        /// </returns>
        public static KeyTypeEd25519 FromSecretSeed(string seed)
        {
            var bytes = StrKey.DecodeStellarSecretSeed(seed);
            return FromSecretSeed(bytes);
        }

        /// <summary>
        ///     Creates a new Stellar keypair from a raw 32 byte secret seed.
        /// </summary>
        /// <param name="seed">seed The 32 byte secret seed.</param>
        /// <returns>
        ///     <see cref="AccountID" />
        /// </returns>

        public static KeyTypeEd25519 FromSecretSeed(byte[] seed)
        {
            return new KeyTypeEd25519(null, seed);
        }

        /// <summary>
        ///     Creates a new Stellar KeyPair from a StrKey encoded Stellar account ID.
        /// </summary>
        /// <param name="accountId">accountId The StrKey encoded Stellar account ID.</param>
        /// <returns>
        ///     <see cref="AccountID" />
        /// </returns>
        public static KeyTypeEd25519 FromAccountId(string accountId)
        {
            var decoded = StrKey.DecodeStellarAccountId(accountId);
            return FromPublicKey(decoded);
        }

        public static KeyTypeEd25519 FromBIP39Seed(string seed, uint accountIndex)
        {
            var bip32 = new BIP32();

            var path = $"m/44'/148'/{accountIndex}'";
            return FromSecretSeed(bip32.DerivePath(path, seed).Key);
        }

        public static KeyTypeEd25519 FromBIP39Seed(byte[] seedBytes, uint accountIndex)
        {
            var seed = seedBytes.ToStringHex();
            return FromBIP39Seed(seed, accountIndex);
        }

        /// <summary>
        ///     Creates a new Stellar keypair from a 32 byte address.
        /// </summary>
        /// <param name="publicKey">publicKey The 32 byte public key.</param>
        /// <returns>
        ///     <see cref="AccountID" />
        /// </returns>
        public static KeyTypeEd25519 FromPublicKey(byte[] publicKey)
        {
            return new KeyTypeEd25519(publicKey, null);
        }

        /// <summary>
        ///     Generates a random Stellar keypair.
        /// </summary>
        /// <returns>a random Stellar keypair</returns>
        public static KeyTypeEd25519 Random()
        {
            var b = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(b);
            }

            return FromSecretSeed(b);
        }

        /// <summary>
        ///     Sign the provided data with the key pair's private key.
        /// </summary>
        /// <param name="data">The data to sign.</param>
        /// <returns>signed bytes, null if the private key for this keypair is null.</returns>
        public byte[] Sign(byte[] data)
        {
            if (_secretKey == null)
            {
                throw new Exception(
                    "KeyPair does not contain secret key. Use KeyPair.fromSecretSeed method to create a new KeyPair with a secret key.");
            }

            return Ed25519.Sign(data, _secretKey); //SignatureAlgorithm.Ed25519.Sign(_secretKey, data);
        }

        /// <summary>
        ///     Sign a message and return an XDR Decorated Signature
        /// </summary>
        /// <param name="message">Message bytes</param>
        public DecoratedSignature SignDecorated(byte[] message)
        {
            var rawSig = Sign(message);

            return new DecoratedSignature
            {
                hint = new SignatureHint(SignatureHint.InnerValue),
                signature = new Signature(rawSig),
            };
        }
        /// <summary>
        ///     XDR Signature Hint
        /// </summary>
        public SignatureHint SignatureHint
        {
            get
            {
                AccountID accountId = new AccountID(XdrPublicKey);
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    AccountIDXdr.Encode(writer, accountId);
                    var hintBytes = memoryStream.ToArray();
                    var length = hintBytes.Length;
                    var signatureHintBytes = hintBytes.Skip(length - 4).Take(4).ToArray();
                    var signatureHint = new SignatureHint(signatureHintBytes);
                    return signatureHint;
                }
            }
        }


        /// <summary>
        ///     Sign the provided payload data for payload signer where the input is the data being signed.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>
        ///     <see cref="DecoratedSignature" />
        /// </returns>
        //public DecoratedSignature SignPayloadDecorated(byte[] signerPayload)
        //{
        //    var payloadSignature = SignDecorated(signerPayload);

        //    var hint = new byte[4];

        //    //Copy the last four bytes of the payload into the new hint
        //    if (signerPayload.Length >= hint.Length)
        //    {
        //        Array.Copy(signerPayload, signerPayload.Length - hint.Length, hint, 0, hint.Length);
        //    }
        //    else
        //    {
        //        Array.Copy(signerPayload, 0, hint, 0, signerPayload.Length);
        //    }

        //    //XOR the new hint with this key pair's public key hint
        //    for (var i = 0; i < hint.Length; i++)
        //    {
        //        hint[i] ^= payloadSignature.Hint.InnerValue[i];
        //    }
        //    payloadSignature.Hint.InnerValue = hint;
        //    return payloadSignature;
        //}

        /// <summary>
        ///     Verify the provided data and signature match this key pair's public key.
        /// </summary>
        /// <param name="data">The data that was signed.</param>
        /// <param name="signature">The signature.</param>
        /// <returns>True if they match, false otherwise.</returns>
        public bool Verify(byte[] data, byte[] signature)
        {
            try
            {
                return Ed25519.Verify(signature, data, PublicKey);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///     Verify the provided data and signature match this key pair's public key.
        /// </summary>
        /// <param name="data">The data that was signed.</param>
        /// <param name="signature">The signature.</param>
        /// <returns>True if they match, false otherwise.</returns>
        public bool Verify(byte[] data, Signature signature)
        {
            return Verify(data, signature.InnerValue);
        }
    }


}
