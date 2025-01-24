// Generated code - do not modify
// Source:

// struct LedgerEntry
// {
//     uint32 lastModifiedLedgerSeq; // ledger the LedgerEntry was last changed
// 
//     union switch (LedgerEntryType type)
//     {
//     case ACCOUNT:
//         AccountEntry account;
//     case TRUSTLINE:
//         TrustLineEntry trustLine;
//     case OFFER:
//         OfferEntry offer;
//     case DATA:
//         DataEntry data;
//     case CLAIMABLE_BALANCE:
//         ClaimableBalanceEntry claimableBalance;
//     case LIQUIDITY_POOL:
//         LiquidityPoolEntry liquidityPool;
//     case CONTRACT_DATA:
//         ContractDataEntry contractData;
//     case CONTRACT_CODE:
//         ContractCodeEntry contractCode;
//     case CONFIG_SETTING:
//         ConfigSettingEntry configSetting;
//     case TTL:
//         TTLEntry ttl;
//     }
//     data;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         LedgerEntryExtensionV1 v1;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class LedgerEntry
{
    private uint32 _lastModifiedLedgerSeq;
    public uint32 lastModifiedLedgerSeq
    {
        get => _lastModifiedLedgerSeq;
        set
        {
            _lastModifiedLedgerSeq = value;
        }
    }

    private object _data;
    public object data
    {
        get => _data;
        set
        {
            _data = value;
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

    public LedgerEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class LedgerEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, LedgerEntry value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.lastModifiedLedgerSeq);
        Xdr.Encode(stream, value.data);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static LedgerEntry Decode(XdrReader stream)
    {
        var result = new LedgerEntry();
        result.lastModifiedLedgerSeq = uint32Xdr.Decode(stream);
        result.data = Xdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
