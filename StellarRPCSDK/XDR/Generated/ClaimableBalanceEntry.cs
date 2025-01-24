// Generated code - do not modify
// Source:

// struct ClaimableBalanceEntry
// {
//     // Unique identifier for this ClaimableBalanceEntry
//     ClaimableBalanceID balanceID;
// 
//     // List of claimants with associated predicate
//     Claimant claimants<10>;
// 
//     // Any asset including native
//     Asset asset;
// 
//     // Amount of asset
//     int64 amount;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         ClaimableBalanceEntryExtensionV1 v1;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ClaimableBalanceEntry
{
    private ClaimableBalanceID _balanceID;
    public ClaimableBalanceID balanceID
    {
        get => _balanceID;
        set
        {
            _balanceID = value;
        }
    }

    private Claimant[] _claimants;
    public Claimant[] claimants
    {
        get => _claimants;
        set
        {
            if (value.Length > 10)
                throw new ArgumentException($"Cannot exceed 10 bytes");
            _claimants = value;
        }
    }

    private Asset _asset;
    public Asset asset
    {
        get => _asset;
        set
        {
            _asset = value;
        }
    }

    private int64 _amount;
    public int64 amount
    {
        get => _amount;
        set
        {
            _amount = value;
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

    public ClaimableBalanceEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
        if (claimants.Length > 10)
            throw new InvalidOperationException($"claimants cannot exceed 10 elements");
    }
}

public static partial class ClaimableBalanceEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ClaimableBalanceEntry value)
    {
        value.Validate();
        ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
        stream.WriteInt(value.claimants.Length);
        foreach (var item in value.claimants)
        {
            ClaimantXdr.Encode(stream, item);
        }
        AssetXdr.Encode(stream, value.asset);
        int64Xdr.Encode(stream, value.amount);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ClaimableBalanceEntry Decode(XdrReader stream)
    {
        var result = new ClaimableBalanceEntry();
        result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
        var length = stream.ReadInt();
        result.claimants = new Claimant[length];
        for (var i = 0; i < length; i++)
        {
            result.claimants[i] = ClaimantXdr.Decode(stream);
        }
        result.asset = AssetXdr.Decode(stream);
        result.amount = int64Xdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
