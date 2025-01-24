// Generated code - do not modify
// Source:

// union ClawbackResult switch (ClawbackResultCode code)
// {
// case CLAWBACK_SUCCESS:
//     void;
// case CLAWBACK_MALFORMED:
// case CLAWBACK_NOT_CLAWBACK_ENABLED:
// case CLAWBACK_NO_TRUST:
// case CLAWBACK_UNDERFUNDED:
//     void;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class ClawbackResult
{
    public abstract ClawbackResultCode Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class ClawbackResult_CLAWBACK_SUCCESS : ClawbackResult
{
    public override ClawbackResultCode Discriminator => CLAWBACK_SUCCESS;

    public override void ValidateCase() {}
}

public sealed partial class ClawbackResult_CLAWBACK_MALFORMED : ClawbackResult
{
    public override ClawbackResultCode Discriminator => CLAWBACK_MALFORMED;

    public override void ValidateCase() {}
}

public sealed partial class ClawbackResult_CLAWBACK_NOT_CLAWBACK_ENABLED : ClawbackResult
{
    public override ClawbackResultCode Discriminator => CLAWBACK_NOT_CLAWBACK_ENABLED;

    public override void ValidateCase() {}
}

public sealed partial class ClawbackResult_CLAWBACK_NO_TRUST : ClawbackResult
{
    public override ClawbackResultCode Discriminator => CLAWBACK_NO_TRUST;

    public override void ValidateCase() {}
}

public sealed partial class ClawbackResult_CLAWBACK_UNDERFUNDED : ClawbackResult
{
    public override ClawbackResultCode Discriminator => CLAWBACK_UNDERFUNDED;

    public override void ValidateCase() {}
}

public static partial class ClawbackResultXdr
{
    public static void Encode(XdrWriter stream, ClawbackResult value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case ClawbackResult_CLAWBACK_SUCCESS case_CLAWBACK_SUCCESS:
                break;
            case ClawbackResult_CLAWBACK_MALFORMED case_CLAWBACK_MALFORMED:
                break;
            case ClawbackResult_CLAWBACK_NOT_CLAWBACK_ENABLED case_CLAWBACK_NOT_CLAWBACK_ENABLED:
                break;
            case ClawbackResult_CLAWBACK_NO_TRUST case_CLAWBACK_NO_TRUST:
                break;
            case ClawbackResult_CLAWBACK_UNDERFUNDED case_CLAWBACK_UNDERFUNDED:
                break;
        }
    }
    public static ClawbackResult Decode(XdrReader stream)
    {
        var discriminator = (ClawbackResultCode)stream.ReadInt();
        switch (discriminator)
        {
            case CLAWBACK_SUCCESS:
                var result_CLAWBACK_SUCCESS = new ClawbackResult_CLAWBACK_SUCCESS();
                return result_CLAWBACK_SUCCESS;
            case CLAWBACK_MALFORMED:
                var result_CLAWBACK_MALFORMED = new ClawbackResult_CLAWBACK_MALFORMED();
                return result_CLAWBACK_MALFORMED;
            case CLAWBACK_NOT_CLAWBACK_ENABLED:
                var result_CLAWBACK_NOT_CLAWBACK_ENABLED = new ClawbackResult_CLAWBACK_NOT_CLAWBACK_ENABLED();
                return result_CLAWBACK_NOT_CLAWBACK_ENABLED;
            case CLAWBACK_NO_TRUST:
                var result_CLAWBACK_NO_TRUST = new ClawbackResult_CLAWBACK_NO_TRUST();
                return result_CLAWBACK_NO_TRUST;
            case CLAWBACK_UNDERFUNDED:
                var result_CLAWBACK_UNDERFUNDED = new ClawbackResult_CLAWBACK_UNDERFUNDED();
                return result_CLAWBACK_UNDERFUNDED;
            default:
                throw new Exception($"Unknown discriminator for ClawbackResult: {discriminator}");
        }
    }
}
}
