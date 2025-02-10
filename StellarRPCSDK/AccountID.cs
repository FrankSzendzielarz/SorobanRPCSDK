

using Chaos.NaCl;
using dotnetstandard_bip32;
using System;
using System.Linq;
using System.Security.Cryptography;


namespace Stellar.XDR
{
    /// <summary>
    ///  
    /// </summary>
    public partial class AccountID : IEquatable<AccountID>
    {

        private readonly byte[] _secretKey;
        private readonly byte[] _seed;



        /// <summary>
        /// Creates a new Keypair instance from secret.
        /// </summary>
        public AccountID(byte[] publicKey, byte[] seed)
        {
            _seed = seed;
            if (publicKey == null)
            {
                if (seed != null) Ed25519.KeyPairFromSeed(out publicKey, out _secretKey, _seed);

            }
            InnerValue = new PublicKey.PublicKeyTypeEd25519() { ed25519 = publicKey };
        }

        /// <summary>
        ///     The private key.
        /// </summary>
        public byte[] PrivateKey => _secretKey;

        /// <summary>
        ///     The bytes of the Secret Seed
        /// </summary>
        public byte[] SeedBytes { get { return _seed; } }

        /// <summary>
        ///     SecretSeed
        /// </summary>
        public string SecretSeed => SeedBytes != null ? StrKey.EncodeStellarSecretSeed(SeedBytes) : null;

        /// <summary>
        ///     XDR Signature Hint
        /// </summary>
        //public SignatureHint SignatureHint
        //{
        //    get
        //    {
        //        var stream = new XdrDataOutputStream();
        //        var accountId = new AccountID(XdrPublicKey);
        //        AccountID.Encode(stream, accountId);
        //        var bytes = stream.ToArray();
        //        var length = bytes.Length;
        //        var signatureHintBytes = bytes.Skip(length - 4).Take(4).ToArray();

        //        var signatureHint = new SignatureHint(signatureHintBytes);
        //        return signatureHint;
        //    }
        //}

        /// <summary>
        ///     To XDR Public Key
        /// </summary>
        public XDR.PublicKey.PublicKeyTypeEd25519 XdrPublicKey => new XDR.PublicKey.PublicKeyTypeEd25519()
        {
            ed25519 = PublicKey
        };

        /// <summary>
        ///     XDR Signer Key
        /// </summary>
        public XDR.SignerKey XdrSignerKey => new XDR.SignerKey.SignerKeyTypeEd25519()
        {
            ed25519 = PublicKey
        };
       
        /// <summary>
        ///     The public key.
        /// </summary>
        public byte[] PublicKey => (InnerValue as PublicKey.PublicKeyTypeEd25519)?.ed25519 ;

        /// <summary>
        ///     AccountId in StrKey encoding
        /// </summary>
        public string AccountId => StrKey.EncodeStellarAccountId(PublicKey);

        /// <summary>
        ///     Address in encoded form
        /// </summary>
        public string Address => StrKey.EncodeCheck(StrKey.VersionByte.ACCOUNT_ID, PublicKey);

        /// <summary>
        ///     The signing key.
        /// </summary>
        public AccountID SigningKey => this;

        /// <summary>
        ///     XDR MuxedAccount
        /// </summary>
        public XDR.MuxedAccount MuxedAccount => new XDR.MuxedAccount.KeyTypeEd25519()
        {
            ed25519 = PublicKey
        };



        public bool Equals(AccountID other)
        {
            if (other == null)
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
        public static AccountID FromSecretSeed(string seed)
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
        public static AccountID FromSecretSeed(byte[] seed)
        {
            return new AccountID(null, seed);
        }

        /// <summary>
        ///     Creates a new Stellar KeyPair from a StrKey encoded Stellar account ID.
        /// </summary>
        /// <param name="accountId">accountId The StrKey encoded Stellar account ID.</param>
        /// <returns>
        ///     <see cref="AccountID" />
        /// </returns>
        public static AccountID FromAccountId(string accountId)
        {
            var decoded = StrKey.DecodeStellarAccountId(accountId);
            return FromPublicKey(decoded);
        }

        public static AccountID FromBIP39Seed(string seed, uint accountIndex)
        {
            var bip32 = new BIP32();

            var path = $"m/44'/148'/{accountIndex}'";
            return FromSecretSeed(bip32.DerivePath(path, seed).Key);
        }

        public static AccountID FromBIP39Seed(byte[] seedBytes, uint accountIndex)
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
        public static AccountID FromPublicKey(byte[] publicKey)
        {
            return new AccountID(publicKey,null);
        }

        /// <summary>
        ///     Generates a random Stellar keypair.
        /// </summary>
        /// <returns>a random Stellar keypair</returns>
        public static AccountID Random()
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
        /// <param name="message"></param>
        /// <returns>
        ///     <see cref="DecoratedSignature" />
        /// </returns>
        //public DecoratedSignature SignDecorated(byte[] message)
        //{
        //    var rawSig = Sign(message);

        //    return new DecoratedSignature
        //    {
        //        Hint = new SignatureHint(SignatureHint.InnerValue),
        //        Signature = new Signature(rawSig),
        //    };
        //}

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
        //public bool Verify(byte[] data, byte[] signature)
        //{
        //    try
        //    {
        //        return Ed25519.Verify(signature, data, _publicKey);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        /// <summary>
        ///     Verify the provided data and signature match this key pair's public key.
        /// </summary>
        /// <param name="data">The data that was signed.</param>
        /// <param name="signature">The signature.</param>
        /// <returns>True if they match, false otherwise.</returns>
        //public bool Verify(byte[] data, Signature signature)
        //{
        //    return Verify(data, signature.InnerValue);
        //}
    }
}
