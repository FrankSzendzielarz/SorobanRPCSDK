// Generated code - do not modify
// Source:

// struct TimeSlicedSurveyStartCollectingMessage
// {
//     NodeID surveyorID;
//     uint32 nonce;
//     uint32 ledgerNum;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TimeSlicedSurveyStartCollectingMessage
{
    private NodeID _surveyorID;
    public NodeID surveyorID
    {
        get => _surveyorID;
        set
        {
            _surveyorID = value;
        }
    }

    private uint32 _nonce;
    public uint32 nonce
    {
        get => _nonce;
        set
        {
            _nonce = value;
        }
    }

    private uint32 _ledgerNum;
    public uint32 ledgerNum
    {
        get => _ledgerNum;
        set
        {
            _ledgerNum = value;
        }
    }

    public TimeSlicedSurveyStartCollectingMessage()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TimeSlicedSurveyStartCollectingMessageXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TimeSlicedSurveyStartCollectingMessage value)
    {
        value.Validate();
        NodeIDXdr.Encode(stream, value.surveyorID);
        uint32Xdr.Encode(stream, value.nonce);
        uint32Xdr.Encode(stream, value.ledgerNum);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TimeSlicedSurveyStartCollectingMessage Decode(XdrReader stream)
    {
        var result = new TimeSlicedSurveyStartCollectingMessage();
        result.surveyorID = NodeIDXdr.Decode(stream);
        result.nonce = uint32Xdr.Decode(stream);
        result.ledgerNum = uint32Xdr.Decode(stream);
        return result;
    }
}
}
