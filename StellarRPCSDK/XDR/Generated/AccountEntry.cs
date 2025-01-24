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

namespace stellar {

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

    private string _homeDomain;
    public string homeDomain
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

    private object _ext;
    public object ext
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
        AccountIDXdr.Encode(stream, value.inflationDest);
        uint32Xdr.Encode(stream, value.flags);
        stream.WriteString(value.homeDomain);
        ThresholdsXdr.Encode(stream, value.thresholds);
        stream.WriteInt(value.signers.Length);
        foreach (var item in value.signers)
        {
            SignerXdr.Encode(stream, item);
        }
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static AccountEntry Decode(XdrReader stream)
    {
        var result = new AccountEntry();
        result.accountID = AccountIDXdr.Decode(stream);
        result.balance = int64Xdr.Decode(stream);
        result.seqNum = SequenceNumberXdr.Decode(stream);
        result.numSubEntries = uint32Xdr.Decode(stream);
        result.inflationDest = AccountIDXdr.Decode(stream);
        result.flags = uint32Xdr.Decode(stream);
        result.homeDomain = stream.ReadString();
        result.thresholds = ThresholdsXdr.Decode(stream);
        var length = stream.ReadInt();
        result.signers = new Signer[length];
        for (var i = 0; i < length; i++)
        {
            result.signers[i] = SignerXdr.Decode(stream);
        }
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
