// Generated code - do not modify
// Source:

// union SetTrustLineFlagsResult switch (SetTrustLineFlagsResultCode code)
// {
// case SET_TRUST_LINE_FLAGS_SUCCESS:
//     void;
// case SET_TRUST_LINE_FLAGS_MALFORMED:
// case SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
// case SET_TRUST_LINE_FLAGS_CANT_REVOKE:
// case SET_TRUST_LINE_FLAGS_INVALID_STATE:
// case SET_TRUST_LINE_FLAGS_LOW_RESERVE:
//     void;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class SetTrustLineFlagsResult
{
    public abstract SetTrustLineFlagsResultCode Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_SUCCESS : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_SUCCESS;

    public override void ValidateCase() {}
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_MALFORMED : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_MALFORMED;

    public override void ValidateCase() {}
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_NO_TRUST_LINE;

    public override void ValidateCase() {}
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_CANT_REVOKE : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_CANT_REVOKE;

    public override void ValidateCase() {}
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_INVALID_STATE : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_INVALID_STATE;

    public override void ValidateCase() {}
}

public sealed partial class SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_LOW_RESERVE : SetTrustLineFlagsResult
{
    public override SetTrustLineFlagsResultCode Discriminator => SET_TRUST_LINE_FLAGS_LOW_RESERVE;

    public override void ValidateCase() {}
}

public static partial class SetTrustLineFlagsResultXdr
{
    public static void Encode(XdrWriter stream, SetTrustLineFlagsResult value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_SUCCESS case_SET_TRUST_LINE_FLAGS_SUCCESS:
                break;
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_MALFORMED case_SET_TRUST_LINE_FLAGS_MALFORMED:
                break;
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE case_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
                break;
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_CANT_REVOKE case_SET_TRUST_LINE_FLAGS_CANT_REVOKE:
                break;
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_INVALID_STATE case_SET_TRUST_LINE_FLAGS_INVALID_STATE:
                break;
            case SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_LOW_RESERVE case_SET_TRUST_LINE_FLAGS_LOW_RESERVE:
                break;
        }
    }
    public static SetTrustLineFlagsResult Decode(XdrReader stream)
    {
        var discriminator = (SetTrustLineFlagsResultCode)stream.ReadInt();
        switch (discriminator)
        {
            case SET_TRUST_LINE_FLAGS_SUCCESS:
                var result_SET_TRUST_LINE_FLAGS_SUCCESS = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_SUCCESS();
                return result_SET_TRUST_LINE_FLAGS_SUCCESS;
            case SET_TRUST_LINE_FLAGS_MALFORMED:
                var result_SET_TRUST_LINE_FLAGS_MALFORMED = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_MALFORMED();
                return result_SET_TRUST_LINE_FLAGS_MALFORMED;
            case SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
                var result_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE();
                return result_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE;
            case SET_TRUST_LINE_FLAGS_CANT_REVOKE:
                var result_SET_TRUST_LINE_FLAGS_CANT_REVOKE = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_CANT_REVOKE();
                return result_SET_TRUST_LINE_FLAGS_CANT_REVOKE;
            case SET_TRUST_LINE_FLAGS_INVALID_STATE:
                var result_SET_TRUST_LINE_FLAGS_INVALID_STATE = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_INVALID_STATE();
                return result_SET_TRUST_LINE_FLAGS_INVALID_STATE;
            case SET_TRUST_LINE_FLAGS_LOW_RESERVE:
                var result_SET_TRUST_LINE_FLAGS_LOW_RESERVE = new SetTrustLineFlagsResult_SET_TRUST_LINE_FLAGS_LOW_RESERVE();
                return result_SET_TRUST_LINE_FLAGS_LOW_RESERVE;
            default:
                throw new Exception($"Unknown discriminator for SetTrustLineFlagsResult: {discriminator}");
        }
    }
}
}
