// Generated code - do not modify
// Source:

// struct SignedSurveyRequestMessage
// {
//     Signature requestSignature;
//     SurveyRequestMessage request;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SignedSurveyRequestMessage
{
    private Signature _requestSignature;
    public Signature requestSignature
    {
        get => _requestSignature;
        set
        {
            _requestSignature = value;
        }
    }

    private SurveyRequestMessage _request;
    public SurveyRequestMessage request
    {
        get => _request;
        set
        {
            _request = value;
        }
    }

    public SignedSurveyRequestMessage()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SignedSurveyRequestMessageXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SignedSurveyRequestMessage value)
    {
        value.Validate();
        SignatureXdr.Encode(stream, value.requestSignature);
        SurveyRequestMessageXdr.Encode(stream, value.request);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SignedSurveyRequestMessage Decode(XdrReader stream)
    {
        var result = new SignedSurveyRequestMessage();
        result.requestSignature = SignatureXdr.Decode(stream);
        result.request = SurveyRequestMessageXdr.Decode(stream);
        return result;
    }
}
}
