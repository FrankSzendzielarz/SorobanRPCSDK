// Generated code - do not modify
// Source:

// struct StoredDebugTransactionSet
// {
// 	StoredTransactionSet txSet;
// 	uint32 ledgerSeq;
// 	StellarValue scpValue;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class StoredDebugTransactionSet
{
    private StoredTransactionSet _txSet;
    public StoredTransactionSet txSet
    {
        get => _txSet;
        set
        {
            _txSet = value;
        }
    }

    private uint32 _ledgerSeq;
    public uint32 ledgerSeq
    {
        get => _ledgerSeq;
        set
        {
            _ledgerSeq = value;
        }
    }

    private StellarValue _scpValue;
    public StellarValue scpValue
    {
        get => _scpValue;
        set
        {
            _scpValue = value;
        }
    }

    public StoredDebugTransactionSet()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class StoredDebugTransactionSetXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, StoredDebugTransactionSet value)
    {
        value.Validate();
        StoredTransactionSetXdr.Encode(stream, value.txSet);
        uint32Xdr.Encode(stream, value.ledgerSeq);
        StellarValueXdr.Encode(stream, value.scpValue);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static StoredDebugTransactionSet Decode(XdrReader stream)
    {
        var result = new StoredDebugTransactionSet();
        result.txSet = StoredTransactionSetXdr.Decode(stream);
        result.ledgerSeq = uint32Xdr.Decode(stream);
        result.scpValue = StellarValueXdr.Decode(stream);
        return result;
    }
}
}
