// Generated code - do not modify
// Source:

// struct TransactionMetaV3
// {
//     ExtensionPoint ext;
// 
//     LedgerEntryChanges txChangesBefore;  // tx level changes before operations
//                                          // are applied if any
//     OperationMeta operations<>;          // meta for each operation
//     LedgerEntryChanges txChangesAfter;   // tx level changes after operations are
//                                          // applied if any
//     SorobanTransactionMeta* sorobanMeta; // Soroban-specific meta (only for 
//                                          // Soroban transactions).
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TransactionMetaV3
{
    private ExtensionPoint _ext;
    public ExtensionPoint ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    private LedgerEntryChanges _txChangesBefore;
    public LedgerEntryChanges txChangesBefore
    {
        get => _txChangesBefore;
        set
        {
            _txChangesBefore = value;
        }
    }

    private OperationMeta[] _operations;
    public OperationMeta[] operations
    {
        get => _operations;
        set
        {
            _operations = value;
        }
    }

    private LedgerEntryChanges _txChangesAfter;
    public LedgerEntryChanges txChangesAfter
    {
        get => _txChangesAfter;
        set
        {
            _txChangesAfter = value;
        }
    }

    private SorobanTransactionMeta _sorobanMeta;
    public SorobanTransactionMeta sorobanMeta
    {
        get => _sorobanMeta;
        set
        {
            _sorobanMeta = value;
        }
    }

    public TransactionMetaV3()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TransactionMetaV3Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TransactionMetaV3 value)
    {
        value.Validate();
        ExtensionPointXdr.Encode(stream, value.ext);
        LedgerEntryChangesXdr.Encode(stream, value.txChangesBefore);
        stream.WriteInt(value.operations.Length);
        foreach (var item in value.operations)
        {
            OperationMetaXdr.Encode(stream, item);
        }
        LedgerEntryChangesXdr.Encode(stream, value.txChangesAfter);
        SorobanTransactionMetaXdr.Encode(stream, value.sorobanMeta);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TransactionMetaV3 Decode(XdrReader stream)
    {
        var result = new TransactionMetaV3();
        result.ext = ExtensionPointXdr.Decode(stream);
        result.txChangesBefore = LedgerEntryChangesXdr.Decode(stream);
        var length = stream.ReadInt();
        result.operations = new OperationMeta[length];
        for (var i = 0; i < length; i++)
        {
            result.operations[i] = OperationMetaXdr.Decode(stream);
        }
        result.txChangesAfter = LedgerEntryChangesXdr.Decode(stream);
        result.sorobanMeta = SorobanTransactionMetaXdr.Decode(stream);
        return result;
    }
}
}
