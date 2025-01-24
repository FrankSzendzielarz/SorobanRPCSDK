// Generated code - do not modify
// Source:

// struct SCPStatement
// {
//     NodeID nodeID;    // v
//     uint64 slotIndex; // i
// 
//     union switch (SCPStatementType type)
//     {
//     case SCP_ST_PREPARE:
//         struct
//         {
//             Hash quorumSetHash;       // D
//             SCPBallot ballot;         // b
//             SCPBallot* prepared;      // p
//             SCPBallot* preparedPrime; // p'
//             uint32 nC;                // c.n
//             uint32 nH;                // h.n
//         } prepare;
//     case SCP_ST_CONFIRM:
//         struct
//         {
//             SCPBallot ballot;   // b
//             uint32 nPrepared;   // p.n
//             uint32 nCommit;     // c.n
//             uint32 nH;          // h.n
//             Hash quorumSetHash; // D
//         } confirm;
//     case SCP_ST_EXTERNALIZE:
//         struct
//         {
//             SCPBallot commit;         // c
//             uint32 nH;                // h.n
//             Hash commitQuorumSetHash; // D used before EXTERNALIZE
//         } externalize;
//     case SCP_ST_NOMINATE:
//         SCPNomination nominate;
//     }
//     pledges;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCPStatement
{
    private NodeID _nodeID;
    public NodeID nodeID
    {
        get => _nodeID;
        set
        {
            _nodeID = value;
        }
    }

    private uint64 _slotIndex;
    public uint64 slotIndex
    {
        get => _slotIndex;
        set
        {
            _slotIndex = value;
        }
    }

    private object _pledges;
    public object pledges
    {
        get => _pledges;
        set
        {
            _pledges = value;
        }
    }

    public SCPStatement()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SCPStatementXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCPStatement value)
    {
        value.Validate();
        NodeIDXdr.Encode(stream, value.nodeID);
        uint64Xdr.Encode(stream, value.slotIndex);
        Xdr.Encode(stream, value.pledges);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCPStatement Decode(XdrReader stream)
    {
        var result = new SCPStatement();
        result.nodeID = NodeIDXdr.Decode(stream);
        result.slotIndex = uint64Xdr.Decode(stream);
        result.pledges = Xdr.Decode(stream);
        return result;
    }
}
}
