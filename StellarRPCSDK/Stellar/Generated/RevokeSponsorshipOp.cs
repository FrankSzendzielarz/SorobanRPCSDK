// Generated code - do not modify
// Source:

// union RevokeSponsorshipOp switch (RevokeSponsorshipType type)
// {
// case REVOKE_SPONSORSHIP_LEDGER_ENTRY:
//     LedgerKey ledgerKey;
// case REVOKE_SPONSORSHIP_SIGNER:
//     struct
//     {
//         AccountID accountID;
//         SignerKey signerKey;
//     } signer;
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
    [ProtoInclude(100, typeof(RevokeSponsorshipLedgerEntry), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(RevokeSponsorshipSigner), DataFormat = DataFormat.Default)]
    public abstract partial class RevokeSponsorshipOp
    {
        public abstract RevokeSponsorshipType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipOp_signerStruct")]
        public partial class signerStruct
        {
            [ProtoMember(1)]
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Account I D")]
            #endif
            private AccountID _accountID;

            [ProtoMember(2)]
            public SignerKey signerKey
            {
                get => _signerKey;
                set
                {
                    _signerKey = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signer Key")]
            #endif
            private SignerKey _signerKey;

            public signerStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class signerStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(signerStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    signerStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static signerStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return signerStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, signerStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
                SignerKeyXdr.Encode(stream, value.signerKey);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static signerStruct Decode(XdrReader stream)
            {
                var result = new signerStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                result.signerKey = SignerKeyXdr.Decode(stream);
                return result;
            }
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipOp_RevokeSponsorshipLedgerEntry")]
        public sealed partial class RevokeSponsorshipLedgerEntry : RevokeSponsorshipOp
        {
            public override RevokeSponsorshipType Discriminator => RevokeSponsorshipType.REVOKE_SPONSORSHIP_LEDGER_ENTRY;
            [ProtoMember(1)]
            public LedgerKey ledgerKey
            {
                get => _ledgerKey;
                set
                {
                    _ledgerKey = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Ledger Key")]
            #endif
            private LedgerKey _ledgerKey;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "RevokeSponsorshipOp_RevokeSponsorshipSigner")]
        public sealed partial class RevokeSponsorshipSigner : RevokeSponsorshipOp
        {
            public override RevokeSponsorshipType Discriminator => RevokeSponsorshipType.REVOKE_SPONSORSHIP_SIGNER;
            [ProtoMember(2)]
            public signerStruct signer
            {
                get => _signer;
                set
                {
                    _signer = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signer")]
            #endif
            private signerStruct _signer;

            public override void ValidateCase() {}
        }
    }
    public static partial class RevokeSponsorshipOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RevokeSponsorshipOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RevokeSponsorshipOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static RevokeSponsorshipOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return RevokeSponsorshipOpXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, RevokeSponsorshipOp value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry case_REVOKE_SPONSORSHIP_LEDGER_ENTRY:
                LedgerKeyXdr.Encode(stream, case_REVOKE_SPONSORSHIP_LEDGER_ENTRY.ledgerKey);
                break;
                case RevokeSponsorshipOp.RevokeSponsorshipSigner case_REVOKE_SPONSORSHIP_SIGNER:
                RevokeSponsorshipOp.signerStructXdr.Encode(stream, case_REVOKE_SPONSORSHIP_SIGNER.signer);
                break;
            }
        }
        public static RevokeSponsorshipOp Decode(XdrReader stream)
        {
            var discriminator = (RevokeSponsorshipType)stream.ReadInt();
            switch (discriminator)
            {
                case RevokeSponsorshipType.REVOKE_SPONSORSHIP_LEDGER_ENTRY:
                var result_REVOKE_SPONSORSHIP_LEDGER_ENTRY = new RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry();
                result_REVOKE_SPONSORSHIP_LEDGER_ENTRY.ledgerKey = LedgerKeyXdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_LEDGER_ENTRY;
                case RevokeSponsorshipType.REVOKE_SPONSORSHIP_SIGNER:
                var result_REVOKE_SPONSORSHIP_SIGNER = new RevokeSponsorshipOp.RevokeSponsorshipSigner();
                result_REVOKE_SPONSORSHIP_SIGNER.signer = RevokeSponsorshipOp.signerStructXdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_SIGNER;
                default:
                throw new Exception($"Unknown discriminator for RevokeSponsorshipOp: {discriminator}");
            }
        }
    }
}
