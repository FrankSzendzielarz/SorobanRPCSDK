// Generated code - do not modify
// Source:

// union SCError switch (SCErrorType type)
// {
// case SCE_CONTRACT:
//     uint32 contractCode;
// case SCE_WASM_VM:
// case SCE_CONTEXT:
// case SCE_STORAGE:
// case SCE_OBJECT:
// case SCE_CRYPTO:
// case SCE_EVENTS:
// case SCE_BUDGET:
// case SCE_VALUE:
// case SCE_AUTH:
//     SCErrorCode code;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class SCError
{
    public abstract SCErrorType Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class SCError_SCE_CONTRACT : SCError
{
    public override SCErrorType Discriminator => SCE_CONTRACT;
    private uint32 _contractCode;
    public uint32 contractCode
    {
        get => _contractCode;
        set
        {
            _contractCode = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_WASM_VM : SCError
{
    public override SCErrorType Discriminator => SCE_WASM_VM;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_CONTEXT : SCError
{
    public override SCErrorType Discriminator => SCE_CONTEXT;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_STORAGE : SCError
{
    public override SCErrorType Discriminator => SCE_STORAGE;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_OBJECT : SCError
{
    public override SCErrorType Discriminator => SCE_OBJECT;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_CRYPTO : SCError
{
    public override SCErrorType Discriminator => SCE_CRYPTO;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_EVENTS : SCError
{
    public override SCErrorType Discriminator => SCE_EVENTS;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_BUDGET : SCError
{
    public override SCErrorType Discriminator => SCE_BUDGET;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_VALUE : SCError
{
    public override SCErrorType Discriminator => SCE_VALUE;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class SCError_SCE_AUTH : SCError
{
    public override SCErrorType Discriminator => SCE_AUTH;
    private SCErrorCode _code;
    public SCErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public override void ValidateCase() {}
}

public static partial class SCErrorXdr
{
    public static void Encode(XdrWriter stream, SCError value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case SCError_SCE_CONTRACT case_SCE_CONTRACT:
                uint32Xdr.Encode(stream, case_SCE_CONTRACT.contractCode);
                break;
            case SCError_SCE_WASM_VM case_SCE_WASM_VM:
                SCErrorCodeXdr.Encode(stream, case_SCE_WASM_VM.code);
                break;
            case SCError_SCE_CONTEXT case_SCE_CONTEXT:
                SCErrorCodeXdr.Encode(stream, case_SCE_CONTEXT.code);
                break;
            case SCError_SCE_STORAGE case_SCE_STORAGE:
                SCErrorCodeXdr.Encode(stream, case_SCE_STORAGE.code);
                break;
            case SCError_SCE_OBJECT case_SCE_OBJECT:
                SCErrorCodeXdr.Encode(stream, case_SCE_OBJECT.code);
                break;
            case SCError_SCE_CRYPTO case_SCE_CRYPTO:
                SCErrorCodeXdr.Encode(stream, case_SCE_CRYPTO.code);
                break;
            case SCError_SCE_EVENTS case_SCE_EVENTS:
                SCErrorCodeXdr.Encode(stream, case_SCE_EVENTS.code);
                break;
            case SCError_SCE_BUDGET case_SCE_BUDGET:
                SCErrorCodeXdr.Encode(stream, case_SCE_BUDGET.code);
                break;
            case SCError_SCE_VALUE case_SCE_VALUE:
                SCErrorCodeXdr.Encode(stream, case_SCE_VALUE.code);
                break;
            case SCError_SCE_AUTH case_SCE_AUTH:
                SCErrorCodeXdr.Encode(stream, case_SCE_AUTH.code);
                break;
        }
    }
    public static SCError Decode(XdrReader stream)
    {
        var discriminator = (SCErrorType)stream.ReadInt();
        switch (discriminator)
        {
            case SCE_CONTRACT:
                var result_SCE_CONTRACT = new SCError_SCE_CONTRACT();
                result_SCE_CONTRACT.contractCode = uint32Xdr.Decode(stream);
                return result_SCE_CONTRACT;
            case SCE_WASM_VM:
                var result_SCE_WASM_VM = new SCError_SCE_WASM_VM();
                result_SCE_WASM_VM.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_WASM_VM;
            case SCE_CONTEXT:
                var result_SCE_CONTEXT = new SCError_SCE_CONTEXT();
                result_SCE_CONTEXT.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_CONTEXT;
            case SCE_STORAGE:
                var result_SCE_STORAGE = new SCError_SCE_STORAGE();
                result_SCE_STORAGE.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_STORAGE;
            case SCE_OBJECT:
                var result_SCE_OBJECT = new SCError_SCE_OBJECT();
                result_SCE_OBJECT.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_OBJECT;
            case SCE_CRYPTO:
                var result_SCE_CRYPTO = new SCError_SCE_CRYPTO();
                result_SCE_CRYPTO.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_CRYPTO;
            case SCE_EVENTS:
                var result_SCE_EVENTS = new SCError_SCE_EVENTS();
                result_SCE_EVENTS.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_EVENTS;
            case SCE_BUDGET:
                var result_SCE_BUDGET = new SCError_SCE_BUDGET();
                result_SCE_BUDGET.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_BUDGET;
            case SCE_VALUE:
                var result_SCE_VALUE = new SCError_SCE_VALUE();
                result_SCE_VALUE.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_VALUE;
            case SCE_AUTH:
                var result_SCE_AUTH = new SCError_SCE_AUTH();
                result_SCE_AUTH.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_AUTH;
            default:
                throw new Exception($"Unknown discriminator for SCError: {discriminator}");
        }
    }
}
}
