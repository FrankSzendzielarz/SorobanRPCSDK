// Generated code - do not modify
// Source:

// enum ManageOfferEffect
// {
//     MANAGE_OFFER_CREATED = 0,
//     MANAGE_OFFER_UPDATED = 1,
//     MANAGE_OFFER_DELETED = 2
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum ManageOfferEffect
{
    MANAGE_OFFER_CREATED = 0,
    MANAGE_OFFER_UPDATED = 1,
    MANAGE_OFFER_DELETED = 2,
}

public static partial class ManageOfferEffectXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, ManageOfferEffect value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static ManageOfferEffect Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(ManageOfferEffect), value))
            throw new InvalidOperationException($"Unknown ManageOfferEffect value: {value}");
        return (ManageOfferEffect)value;
    }
}
}
