// Generated code - do not modify
// Source:

// enum ManageDataResultCode
// {
//     // codes considered as "success" for the operation
//     MANAGE_DATA_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     MANAGE_DATA_NOT_SUPPORTED_YET =
//         -1, // The network hasn't moved to this protocol change yet
//     MANAGE_DATA_NAME_NOT_FOUND =
//         -2, // Trying to remove a Data Entry that isn't there
//     MANAGE_DATA_LOW_RESERVE = -3, // not enough funds to create a new Data Entry
//     MANAGE_DATA_INVALID_NAME = -4 // Name not a valid string
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public enum ManageDataResultCode
{
    MANAGE_DATA_SUCCESS = 0,
    MANAGE_DATA_NOT_SUPPORTED_YET = -1,
    MANAGE_DATA_NAME_NOT_FOUND = -2,
    MANAGE_DATA_LOW_RESERVE = -3,
    MANAGE_DATA_INVALID_NAME = -4,
}

public static partial class ManageDataResultCodeXdr
{
    /// <summary>Encodes enum value to XDR stream</summary>
    public static void Encode(XdrWriter stream, ManageDataResultCode value)
    {
       stream.WriteInt((int)value);
    }

    /// <summary>Decodes enum value from XDR stream</summary>
    public static ManageDataResultCode Decode(XdrReader stream)
    {
        var value = stream.ReadInt();
        if (!Enum.IsDefined(typeof(ManageDataResultCode), value))
            throw new InvalidOperationException($"Unknown ManageDataResultCode value: {value}");
        return (ManageDataResultCode)value;
    }
}
}
