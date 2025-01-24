// Generated code - do not modify
// Source:

// union ManageSellOfferResult switch (ManageSellOfferResultCode code)
// {
// case MANAGE_SELL_OFFER_SUCCESS:
//     ManageOfferSuccessResult success;
// case MANAGE_SELL_OFFER_MALFORMED:
// case MANAGE_SELL_OFFER_SELL_NO_TRUST:
// case MANAGE_SELL_OFFER_BUY_NO_TRUST:
// case MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
// case MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
// case MANAGE_SELL_OFFER_LINE_FULL:
// case MANAGE_SELL_OFFER_UNDERFUNDED:
// case MANAGE_SELL_OFFER_CROSS_SELF:
// case MANAGE_SELL_OFFER_SELL_NO_ISSUER:
// case MANAGE_SELL_OFFER_BUY_NO_ISSUER:
// case MANAGE_SELL_OFFER_NOT_FOUND:
// case MANAGE_SELL_OFFER_LOW_RESERVE:
//     void;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class ManageSellOfferResult
{
    public abstract ManageSellOfferResultCode Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_SUCCESS : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_SUCCESS;
    private ManageOfferSuccessResult _success;
    public ManageOfferSuccessResult success
    {
        get => _success;
        set
        {
            _success = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_MALFORMED : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_MALFORMED;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_TRUST : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_SELL_NO_TRUST;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_TRUST : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_BUY_NO_TRUST;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_LINE_FULL : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_LINE_FULL;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_UNDERFUNDED : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_UNDERFUNDED;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_CROSS_SELF : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_CROSS_SELF;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_ISSUER : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_SELL_NO_ISSUER;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_ISSUER : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_BUY_NO_ISSUER;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_NOT_FOUND : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_NOT_FOUND;

    public override void ValidateCase() {}
}

public sealed partial class ManageSellOfferResult_MANAGE_SELL_OFFER_LOW_RESERVE : ManageSellOfferResult
{
    public override ManageSellOfferResultCode Discriminator => MANAGE_SELL_OFFER_LOW_RESERVE;

    public override void ValidateCase() {}
}

public static partial class ManageSellOfferResultXdr
{
    public static void Encode(XdrWriter stream, ManageSellOfferResult value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case ManageSellOfferResult_MANAGE_SELL_OFFER_SUCCESS case_MANAGE_SELL_OFFER_SUCCESS:
                ManageOfferSuccessResultXdr.Encode(stream, case_MANAGE_SELL_OFFER_SUCCESS.success);
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_MALFORMED case_MANAGE_SELL_OFFER_MALFORMED:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_TRUST case_MANAGE_SELL_OFFER_SELL_NO_TRUST:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_TRUST case_MANAGE_SELL_OFFER_BUY_NO_TRUST:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED case_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED case_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_LINE_FULL case_MANAGE_SELL_OFFER_LINE_FULL:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_UNDERFUNDED case_MANAGE_SELL_OFFER_UNDERFUNDED:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_CROSS_SELF case_MANAGE_SELL_OFFER_CROSS_SELF:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_ISSUER case_MANAGE_SELL_OFFER_SELL_NO_ISSUER:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_ISSUER case_MANAGE_SELL_OFFER_BUY_NO_ISSUER:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_NOT_FOUND case_MANAGE_SELL_OFFER_NOT_FOUND:
                break;
            case ManageSellOfferResult_MANAGE_SELL_OFFER_LOW_RESERVE case_MANAGE_SELL_OFFER_LOW_RESERVE:
                break;
        }
    }
    public static ManageSellOfferResult Decode(XdrReader stream)
    {
        var discriminator = (ManageSellOfferResultCode)stream.ReadInt();
        switch (discriminator)
        {
            case MANAGE_SELL_OFFER_SUCCESS:
                var result_MANAGE_SELL_OFFER_SUCCESS = new ManageSellOfferResult_MANAGE_SELL_OFFER_SUCCESS();
                result_MANAGE_SELL_OFFER_SUCCESS.success = ManageOfferSuccessResultXdr.Decode(stream);
                return result_MANAGE_SELL_OFFER_SUCCESS;
            case MANAGE_SELL_OFFER_MALFORMED:
                var result_MANAGE_SELL_OFFER_MALFORMED = new ManageSellOfferResult_MANAGE_SELL_OFFER_MALFORMED();
                return result_MANAGE_SELL_OFFER_MALFORMED;
            case MANAGE_SELL_OFFER_SELL_NO_TRUST:
                var result_MANAGE_SELL_OFFER_SELL_NO_TRUST = new ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_TRUST();
                return result_MANAGE_SELL_OFFER_SELL_NO_TRUST;
            case MANAGE_SELL_OFFER_BUY_NO_TRUST:
                var result_MANAGE_SELL_OFFER_BUY_NO_TRUST = new ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_TRUST();
                return result_MANAGE_SELL_OFFER_BUY_NO_TRUST;
            case MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
                var result_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED = new ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED();
                return result_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED;
            case MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
                var result_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED = new ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED();
                return result_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED;
            case MANAGE_SELL_OFFER_LINE_FULL:
                var result_MANAGE_SELL_OFFER_LINE_FULL = new ManageSellOfferResult_MANAGE_SELL_OFFER_LINE_FULL();
                return result_MANAGE_SELL_OFFER_LINE_FULL;
            case MANAGE_SELL_OFFER_UNDERFUNDED:
                var result_MANAGE_SELL_OFFER_UNDERFUNDED = new ManageSellOfferResult_MANAGE_SELL_OFFER_UNDERFUNDED();
                return result_MANAGE_SELL_OFFER_UNDERFUNDED;
            case MANAGE_SELL_OFFER_CROSS_SELF:
                var result_MANAGE_SELL_OFFER_CROSS_SELF = new ManageSellOfferResult_MANAGE_SELL_OFFER_CROSS_SELF();
                return result_MANAGE_SELL_OFFER_CROSS_SELF;
            case MANAGE_SELL_OFFER_SELL_NO_ISSUER:
                var result_MANAGE_SELL_OFFER_SELL_NO_ISSUER = new ManageSellOfferResult_MANAGE_SELL_OFFER_SELL_NO_ISSUER();
                return result_MANAGE_SELL_OFFER_SELL_NO_ISSUER;
            case MANAGE_SELL_OFFER_BUY_NO_ISSUER:
                var result_MANAGE_SELL_OFFER_BUY_NO_ISSUER = new ManageSellOfferResult_MANAGE_SELL_OFFER_BUY_NO_ISSUER();
                return result_MANAGE_SELL_OFFER_BUY_NO_ISSUER;
            case MANAGE_SELL_OFFER_NOT_FOUND:
                var result_MANAGE_SELL_OFFER_NOT_FOUND = new ManageSellOfferResult_MANAGE_SELL_OFFER_NOT_FOUND();
                return result_MANAGE_SELL_OFFER_NOT_FOUND;
            case MANAGE_SELL_OFFER_LOW_RESERVE:
                var result_MANAGE_SELL_OFFER_LOW_RESERVE = new ManageSellOfferResult_MANAGE_SELL_OFFER_LOW_RESERVE();
                return result_MANAGE_SELL_OFFER_LOW_RESERVE;
            default:
                throw new Exception($"Unknown discriminator for ManageSellOfferResult: {discriminator}");
        }
    }
}
}
