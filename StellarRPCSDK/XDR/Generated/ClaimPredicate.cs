// Generated code - do not modify
// Source:

// union ClaimPredicate switch (ClaimPredicateType type)
// {
// case CLAIM_PREDICATE_UNCONDITIONAL:
//     void;
// case CLAIM_PREDICATE_AND:
//     ClaimPredicate andPredicates<2>;
// case CLAIM_PREDICATE_OR:
//     ClaimPredicate orPredicates<2>;
// case CLAIM_PREDICATE_NOT:
//     ClaimPredicate* notPredicate;
// case CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
//     int64 absBefore; // Predicate will be true if closeTime < absBefore
// case CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
//     int64 relBefore; // Seconds since closeTime of the ledger in which the
//                      // ClaimableBalanceEntry was created
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class ClaimPredicate
{
    public abstract ClaimPredicateType Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_UNCONDITIONAL : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_UNCONDITIONAL;

    public override void ValidateCase() {}
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_AND : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_AND;
    private ClaimPredicate[] _andPredicates;
    public ClaimPredicate[] andPredicates
    {
        get => _andPredicates;
        set
        {
            if (value.Length > 2)
                throw new ArgumentException($"Cannot exceed 2 bytes");
            _andPredicates = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_OR : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_OR;
    private ClaimPredicate[] _orPredicates;
    public ClaimPredicate[] orPredicates
    {
        get => _orPredicates;
        set
        {
            if (value.Length > 2)
                throw new ArgumentException($"Cannot exceed 2 bytes");
            _orPredicates = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_NOT : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_NOT;
    private ClaimPredicate _notPredicate;
    public ClaimPredicate notPredicate
    {
        get => _notPredicate;
        set
        {
            _notPredicate = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME;
    private int64 _absBefore;
    public int64 absBefore
    {
        get => _absBefore;
        set
        {
            _absBefore = value;
        }
    }

    public override void ValidateCase() {}
}

public sealed partial class ClaimPredicate_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME : ClaimPredicate
{
    public override ClaimPredicateType Discriminator => CLAIM_PREDICATE_BEFORE_RELATIVE_TIME;
    private int64 _relBefore;
    public int64 relBefore
    {
        get => _relBefore;
        set
        {
            _relBefore = value;
        }
    }

    public override void ValidateCase() {}
}

public static partial class ClaimPredicateXdr
{
    public static void Encode(XdrWriter stream, ClaimPredicate value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case ClaimPredicate_CLAIM_PREDICATE_UNCONDITIONAL case_CLAIM_PREDICATE_UNCONDITIONAL:
                break;
            case ClaimPredicate_CLAIM_PREDICATE_AND case_CLAIM_PREDICATE_AND:
                stream.WriteInt(case_CLAIM_PREDICATE_AND.andPredicates.Length);
                foreach (var item in case_CLAIM_PREDICATE_AND.andPredicates)
                {
                    ClaimPredicateXdr.Encode(stream, item);
                }
                break;
            case ClaimPredicate_CLAIM_PREDICATE_OR case_CLAIM_PREDICATE_OR:
                stream.WriteInt(case_CLAIM_PREDICATE_OR.orPredicates.Length);
                foreach (var item in case_CLAIM_PREDICATE_OR.orPredicates)
                {
                    ClaimPredicateXdr.Encode(stream, item);
                }
                break;
            case ClaimPredicate_CLAIM_PREDICATE_NOT case_CLAIM_PREDICATE_NOT:
                ClaimPredicateXdr.Encode(stream, case_CLAIM_PREDICATE_NOT.notPredicate);
                break;
            case ClaimPredicate_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME case_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                int64Xdr.Encode(stream, case_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME.absBefore);
                break;
            case ClaimPredicate_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME case_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                int64Xdr.Encode(stream, case_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME.relBefore);
                break;
        }
    }
    public static ClaimPredicate Decode(XdrReader stream)
    {
        var discriminator = (ClaimPredicateType)stream.ReadInt();
        switch (discriminator)
        {
            case CLAIM_PREDICATE_UNCONDITIONAL:
                var result_CLAIM_PREDICATE_UNCONDITIONAL = new ClaimPredicate_CLAIM_PREDICATE_UNCONDITIONAL();
                return result_CLAIM_PREDICATE_UNCONDITIONAL;
            case CLAIM_PREDICATE_AND:
                var result_CLAIM_PREDICATE_AND = new ClaimPredicate_CLAIM_PREDICATE_AND();
                var length = stream.ReadInt();
                result_CLAIM_PREDICATE_AND.andPredicates = new ClaimPredicate[length];
                for (var i = 0; i < length; i++)
                {
                    result_CLAIM_PREDICATE_AND.andPredicates[i] = ClaimPredicateXdr.Decode(stream);
                }
                return result_CLAIM_PREDICATE_AND;
            case CLAIM_PREDICATE_OR:
                var result_CLAIM_PREDICATE_OR = new ClaimPredicate_CLAIM_PREDICATE_OR();
                var length = stream.ReadInt();
                result_CLAIM_PREDICATE_OR.orPredicates = new ClaimPredicate[length];
                for (var i = 0; i < length; i++)
                {
                    result_CLAIM_PREDICATE_OR.orPredicates[i] = ClaimPredicateXdr.Decode(stream);
                }
                return result_CLAIM_PREDICATE_OR;
            case CLAIM_PREDICATE_NOT:
                var result_CLAIM_PREDICATE_NOT = new ClaimPredicate_CLAIM_PREDICATE_NOT();
                result_CLAIM_PREDICATE_NOT.notPredicate = ClaimPredicateXdr.Decode(stream);
                return result_CLAIM_PREDICATE_NOT;
            case CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                var result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = new ClaimPredicate_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME();
                result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME.absBefore = int64Xdr.Decode(stream);
                return result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME;
            case CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                var result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = new ClaimPredicate_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME();
                result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME.relBefore = int64Xdr.Decode(stream);
                return result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME;
            default:
                throw new Exception($"Unknown discriminator for ClaimPredicate: {discriminator}");
        }
    }
}
}
