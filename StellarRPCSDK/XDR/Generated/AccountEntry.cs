// Generated code - do not modify
// Source:

// struct AccountEntry
// {
//     AccountID accountID;      // master public key for this account
//     int64 balance;            // in stroops
//     SequenceNumber seqNum;    // last sequence number used for this account
//     uint32 numSubEntries;     // number of sub-entries this account has
//                               // drives the reserve
//     AccountID* inflationDest; // Account to vote for during inflation
//     uint32 flags;             // see AccountFlags
// 
//     string32 homeDomain; // can be used for reverse federation and memo lookup
// 
//     // fields used for signatures
//     // thresholds stores unsigned bytes: [weight of master|low|medium|high]
//     Thresholds thresholds;
// 
//     Signer signers<MAX_SIGNERS>; // possible signers for this account
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         AccountEntryExtensionV1 v1;
//     }
//     ext;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountEntry
    {
        private AccountID _accountID;
        public AccountID accountID
        {
            get => _accountID;
            set
            {
                _accountID = value;
            }
        }

        private int64 _balance;
        public int64 balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        private SequenceNumber _seqNum;
        public SequenceNumber seqNum
        {
            get => _seqNum;
            set
            {
                _seqNum = value;
            }
        }

        private uint32 _numSubEntries;
        public uint32 numSubEntries
        {
            get => _numSubEntries;
            set
            {
                _numSubEntries = value;
            }
        }

        private AccountID _inflationDest;
        public AccountID inflationDest
        {
            get => _inflationDest;
            set
            {
                _inflationDest = value;
            }
        }

        private uint32 _flags;
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }

        private string32 _homeDomain;
        public string32 homeDomain
        {
            get => _homeDomain;
            set
            {
                _homeDomain = value;
            }
        }

        private Thresholds _thresholds;
        public Thresholds thresholds
        {
            get => _thresholds;
            set
            {
                _thresholds = value;
            }
        }

        private Signer[] _signers;
        public Signer[] signers
        {
            get => _signers;
            set
            {
                _signers = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public AccountEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private AccountEntryExtensionV1 _v1;
            public AccountEntryExtensionV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
                    AccountEntryExtensionV1Xdr.Encode(stream, case_1.v1);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.v1 = AccountEntryExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class AccountEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountEntry value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.accountID);
            int64Xdr.Encode(stream, value.balance);
            SequenceNumberXdr.Encode(stream, value.seqNum);
            uint32Xdr.Encode(stream, value.numSubEntries);
            if (value.inflationDest==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                AccountIDXdr.Encode(stream, value.inflationDest);
            }
            uint32Xdr.Encode(stream, value.flags);
            string32Xdr.Encode(stream, value.homeDomain);
            ThresholdsXdr.Encode(stream, value.thresholds);
            stream.WriteInt(value.signers.Length);
            foreach (var item in value.signers)
            {
                    SignerXdr.Encode(stream, item);
            }
            AccountEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntry Decode(XdrReader stream)
        {
            var result = new AccountEntry();
            result.accountID = AccountIDXdr.Decode(stream);
            result.balance = int64Xdr.Decode(stream);
            result.seqNum = SequenceNumberXdr.Decode(stream);
            result.numSubEntries = uint32Xdr.Decode(stream);
            if (stream.ReadInt()==1)
            {
                result.inflationDest = AccountIDXdr.Decode(stream);
            }
            result.flags = uint32Xdr.Decode(stream);
            result.homeDomain = string32Xdr.Decode(stream);
            result.thresholds = ThresholdsXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.signers = new Signer[length];
                for (var i = 0; i < length; i++)
                {
                    result.signers[i] = SignerXdr.Decode(stream);
                }
            }
            result.ext = AccountEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
