// Generated code - do not modify
// Source:

// union CreateClaimableBalanceResult switch (
//     CreateClaimableBalanceResultCode code)
// {
// case CREATE_CLAIMABLE_BALANCE_SUCCESS:
//     ClaimableBalanceID balanceID;
// case CREATE_CLAIMABLE_BALANCE_MALFORMED:
// case CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
// case CREATE_CLAIMABLE_BALANCE_NO_TRUST:
// case CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
// case CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
//     void;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class CreateClaimableBalanceResult
{
    public abstract CreateClaimableBalanceResultCode Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_SUCCESS : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_SUCCESS;
    private ClaimableBalanceID _balanceID;
    public ClaimableBalanceID balanceID
    {
        get => _balanceID;
        set
        {
            _balanceID = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_MALFORMED : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_MALFORMED;

    public override void ValidateCase() {}
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_LOW_RESERVE;

    public override void ValidateCase() {}
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NO_TRUST : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_NO_TRUST;

    public override void ValidateCase() {}
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED;

    public override void ValidateCase() {}
}

public sealed partial class CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED : CreateClaimableBalanceResult
{
    public override CreateClaimableBalanceResultCode Discriminator => CREATE_CLAIMABLE_BALANCE_UNDERFUNDED;

    public override void ValidateCase() {}
}

public static partial class CreateClaimableBalanceResultXdr
{
    public static void Encode(XdrWriter stream, CreateClaimableBalanceResult value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_SUCCESS case_CREATE_CLAIMABLE_BALANCE_SUCCESS:
                ClaimableBalanceIDXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE_SUCCESS.balanceID);
                break;
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_MALFORMED case_CREATE_CLAIMABLE_BALANCE_MALFORMED:
                break;
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE case_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
                break;
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NO_TRUST case_CREATE_CLAIMABLE_BALANCE_NO_TRUST:
                break;
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED case_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                break;
            case CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED case_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
                break;
        }
    }
    public static CreateClaimableBalanceResult Decode(XdrReader stream)
    {
        var discriminator = (CreateClaimableBalanceResultCode)stream.ReadInt();
        switch (discriminator)
        {
            case CREATE_CLAIMABLE_BALANCE_SUCCESS:
                var result_CREATE_CLAIMABLE_BALANCE_SUCCESS = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_SUCCESS();
                result_CREATE_CLAIMABLE_BALANCE_SUCCESS.balanceID = ClaimableBalanceIDXdr.Decode(stream);
                return result_CREATE_CLAIMABLE_BALANCE_SUCCESS;
            case CREATE_CLAIMABLE_BALANCE_MALFORMED:
                var result_CREATE_CLAIMABLE_BALANCE_MALFORMED = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_MALFORMED();
                return result_CREATE_CLAIMABLE_BALANCE_MALFORMED;
            case CREATE_CLAIMABLE_BALANCE_LOW_RESERVE:
                var result_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE();
                return result_CREATE_CLAIMABLE_BALANCE_LOW_RESERVE;
            case CREATE_CLAIMABLE_BALANCE_NO_TRUST:
                var result_CREATE_CLAIMABLE_BALANCE_NO_TRUST = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NO_TRUST();
                return result_CREATE_CLAIMABLE_BALANCE_NO_TRUST;
            case CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                var result_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED();
                return result_CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED;
            case CREATE_CLAIMABLE_BALANCE_UNDERFUNDED:
                var result_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = new CreateClaimableBalanceResult_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED();
                return result_CREATE_CLAIMABLE_BALANCE_UNDERFUNDED;
            default:
                throw new Exception($"Unknown discriminator for CreateClaimableBalanceResult: {discriminator}");
        }
    }
}
}
