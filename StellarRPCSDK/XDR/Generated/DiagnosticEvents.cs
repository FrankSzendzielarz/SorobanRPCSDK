// Generated code - do not modify
// Source:

// typedef DiagnosticEvent DiagnosticEvents<>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class DiagnosticEvents
{
    private DiagnosticEvent[] _innerValue;
    public DiagnosticEvent[] InnerValue
    {
        get => _innerValue;
        set
        {
            _innerValue = value;
        }
    }

    public DiagnosticEvents() { }

    public DiagnosticEvents(DiagnosticEvent[] value)
    {
        InnerValue = value;
    }
}

public static partial class DiagnosticEventsXdr
{
    public static void Encode(XdrWriter stream, DiagnosticEvents value)
    {
        stream.WriteInt(value.InnerValue.Length);
        foreach (var item in value.InnerValue)
        {
            DiagnosticEventXdr.Encode(stream, item);
        }
    }
    public static DiagnosticEvents Decode(XdrReader stream)
    {
        var result = new DiagnosticEvents();
        var length = stream.ReadInt();
        result.InnerValue = new DiagnosticEvent[length];
        for (var i = 0; i < length; i++)
        {
            result.InnerValue[i] = DiagnosticEventXdr.Decode(stream);
        }
        return result;
    }
}
}
