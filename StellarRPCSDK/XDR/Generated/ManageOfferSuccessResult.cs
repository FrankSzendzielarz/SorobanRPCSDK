// Generated code - do not modify
// Source:

// struct ManageOfferSuccessResult
// {
//     // offers that got claimed while creating this offer
//     ClaimAtom offersClaimed<>;
// 
//     union switch (ManageOfferEffect effect)
//     {
//     case MANAGE_OFFER_CREATED:
//     case MANAGE_OFFER_UPDATED:
//         OfferEntry offer;
//     case MANAGE_OFFER_DELETED:
//         void;
//     }
//     offer;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ManageOfferSuccessResult
{
    private ClaimAtom[] _offersClaimed;
    public ClaimAtom[] offersClaimed
    {
        get => _offersClaimed;
        set
        {
            _offersClaimed = value;
        }
    }

    private object _offer;
    public object offer
    {
        get => _offer;
        set
        {
            _offer = value;
        }
    }

    public ManageOfferSuccessResult()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ManageOfferSuccessResultXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ManageOfferSuccessResult value)
    {
        value.Validate();
        stream.WriteInt(value.offersClaimed.Length);
        foreach (var item in value.offersClaimed)
        {
            ClaimAtomXdr.Encode(stream, item);
        }
        Xdr.Encode(stream, value.offer);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ManageOfferSuccessResult Decode(XdrReader stream)
    {
        var result = new ManageOfferSuccessResult();
        var length = stream.ReadInt();
        result.offersClaimed = new ClaimAtom[length];
        for (var i = 0; i < length; i++)
        {
            result.offersClaimed[i] = ClaimAtomXdr.Decode(stream);
        }
        result.offer = Xdr.Decode(stream);
        return result;
    }
}
}
