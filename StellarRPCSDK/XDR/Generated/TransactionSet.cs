// Generated code - do not modify
// Source:

// struct TransactionSet
// {
//     Hash previousLedgerHash;
//     TransactionEnvelope txs<>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TransactionSet
{
    private Hash _previousLedgerHash;
    public Hash previousLedgerHash
    {
        get => _previousLedgerHash;
        set
        {
            _previousLedgerHash = value;
        }
    }

    private TransactionEnvelope[] _txs;
    public TransactionEnvelope[] txs
    {
        get => _txs;
        set
        {
            _txs = value;
        }
    }

    public TransactionSet()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TransactionSetXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TransactionSet value)
    {
        value.Validate();
        HashXdr.Encode(stream, value.previousLedgerHash);
        stream.WriteInt(value.txs.Length);
        foreach (var item in value.txs)
        {
            TransactionEnvelopeXdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TransactionSet Decode(XdrReader stream)
    {
        var result = new TransactionSet();
        result.previousLedgerHash = HashXdr.Decode(stream);
        var length = stream.ReadInt();
        result.txs = new TransactionEnvelope[length];
        for (var i = 0; i < length; i++)
        {
            result.txs[i] = TransactionEnvelopeXdr.Decode(stream);
        }
        return result;
    }
}
}
