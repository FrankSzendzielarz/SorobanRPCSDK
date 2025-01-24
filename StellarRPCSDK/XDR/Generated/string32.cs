// Generated code - do not modify
// Source:

// typedef string string32<32>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class string32
{
    private string[] _innerValue;
    public string[] InnerValue
    {
        get => _innerValue;
        set
        {
            if (value.Length > 32)
                throw new ArgumentException($"Cannot exceed 32 bytes");
            _innerValue = value;
        }
    }

    public string32() { }

    public string32(string[] value)
    {
        InnerValue = value;
    }
}

public static partial class string32Xdr
{
    public static void Encode(XdrWriter stream, string32 value)
    {
        stream.WriteString(value.InnerValue);
    }
    public static string32 Decode(XdrReader stream)
    {
        var result = new string32();
        result.InnerValue = stream.ReadString();
        return result;
    }
}
}
