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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClaimPredicate
    {
        public abstract ClaimPredicateType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class ClaimPredicateUnconditional : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_UNCONDITIONAL;

            public override void ValidateCase() {}
        }
        public sealed partial class ClaimPredicateAnd : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_AND;
            [MaxLength(2)]
            public ClaimPredicate[] andPredicates
            {
                get => _andPredicates;
                set
                {
                    if (value.Length > 2)
                    	throw new ArgumentException($"Cannot exceed 2 in length");
                    _andPredicates = value;
                }
            }
            private ClaimPredicate[] _andPredicates;

            public override void ValidateCase() {}
        }
        public sealed partial class ClaimPredicateOr : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_OR;
            [MaxLength(2)]
            public ClaimPredicate[] orPredicates
            {
                get => _orPredicates;
                set
                {
                    if (value.Length > 2)
                    	throw new ArgumentException($"Cannot exceed 2 in length");
                    _orPredicates = value;
                }
            }
            private ClaimPredicate[] _orPredicates;

            public override void ValidateCase() {}
        }
        public sealed partial class ClaimPredicateNot : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_NOT;
            public ClaimPredicate notPredicate
            {
                get => _notPredicate;
                set
                {
                    _notPredicate = value;
                }
            }
            private ClaimPredicate _notPredicate;

            public override void ValidateCase() {}
        }
        public sealed partial class ClaimPredicateBeforeAbsoluteTime : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME;
            public int64 absBefore
            {
                get => _absBefore;
                set
                {
                    _absBefore = value;
                }
            }
            private int64 _absBefore;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// Predicate will be true if closeTime < absBefore
        /// </summary>
        public sealed partial class ClaimPredicateBeforeRelativeTime : ClaimPredicate
        {
            public override ClaimPredicateType Discriminator => ClaimPredicateType.CLAIM_PREDICATE_BEFORE_RELATIVE_TIME;
            public int64 relBefore
            {
                get => _relBefore;
                set
                {
                    _relBefore = value;
                }
            }
            private int64 _relBefore;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClaimPredicateXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimPredicate value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimPredicateXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ClaimPredicate value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimPredicate.ClaimPredicateUnconditional case_CLAIM_PREDICATE_UNCONDITIONAL:
                break;
                case ClaimPredicate.ClaimPredicateAnd case_CLAIM_PREDICATE_AND:
                stream.WriteInt(case_CLAIM_PREDICATE_AND.andPredicates.Length);
                foreach (var item in case_CLAIM_PREDICATE_AND.andPredicates)
                {
                        ClaimPredicateXdr.Encode(stream, item);
                }
                break;
                case ClaimPredicate.ClaimPredicateOr case_CLAIM_PREDICATE_OR:
                stream.WriteInt(case_CLAIM_PREDICATE_OR.orPredicates.Length);
                foreach (var item in case_CLAIM_PREDICATE_OR.orPredicates)
                {
                        ClaimPredicateXdr.Encode(stream, item);
                }
                break;
                case ClaimPredicate.ClaimPredicateNot case_CLAIM_PREDICATE_NOT:
                if (case_CLAIM_PREDICATE_NOT.notPredicate==null){
                	stream.WriteInt(0);
                }
                else
                {
                    stream.WriteInt(1);
                    ClaimPredicateXdr.Encode(stream, case_CLAIM_PREDICATE_NOT.notPredicate);
                }
                break;
                case ClaimPredicate.ClaimPredicateBeforeAbsoluteTime case_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                int64Xdr.Encode(stream, case_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME.absBefore);
                break;
                case ClaimPredicate.ClaimPredicateBeforeRelativeTime case_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                int64Xdr.Encode(stream, case_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME.relBefore);
                break;
            }
        }
        public static ClaimPredicate Decode(XdrReader stream)
        {
            var discriminator = (ClaimPredicateType)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimPredicateType.CLAIM_PREDICATE_UNCONDITIONAL:
                var result_CLAIM_PREDICATE_UNCONDITIONAL = new ClaimPredicate.ClaimPredicateUnconditional();
                return result_CLAIM_PREDICATE_UNCONDITIONAL;
                case ClaimPredicateType.CLAIM_PREDICATE_AND:
                var result_CLAIM_PREDICATE_AND = new ClaimPredicate.ClaimPredicateAnd();
                {
                    var length = stream.ReadInt();
                    result_CLAIM_PREDICATE_AND.andPredicates = new ClaimPredicate[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_CLAIM_PREDICATE_AND.andPredicates[i] = ClaimPredicateXdr.Decode(stream);
                    }
                }
                return result_CLAIM_PREDICATE_AND;
                case ClaimPredicateType.CLAIM_PREDICATE_OR:
                var result_CLAIM_PREDICATE_OR = new ClaimPredicate.ClaimPredicateOr();
                {
                    var length = stream.ReadInt();
                    result_CLAIM_PREDICATE_OR.orPredicates = new ClaimPredicate[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_CLAIM_PREDICATE_OR.orPredicates[i] = ClaimPredicateXdr.Decode(stream);
                    }
                }
                return result_CLAIM_PREDICATE_OR;
                case ClaimPredicateType.CLAIM_PREDICATE_NOT:
                var result_CLAIM_PREDICATE_NOT = new ClaimPredicate.ClaimPredicateNot();
                if (stream.ReadInt()==1)
                {
                    result_CLAIM_PREDICATE_NOT.notPredicate = ClaimPredicateXdr.Decode(stream);
                }
                return result_CLAIM_PREDICATE_NOT;
                case ClaimPredicateType.CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                var result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = new ClaimPredicate.ClaimPredicateBeforeAbsoluteTime();
                result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME.absBefore = int64Xdr.Decode(stream);
                return result_CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME;
                case ClaimPredicateType.CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                var result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = new ClaimPredicate.ClaimPredicateBeforeRelativeTime();
                result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME.relBefore = int64Xdr.Decode(stream);
                return result_CLAIM_PREDICATE_BEFORE_RELATIVE_TIME;
                default:
                throw new Exception($"Unknown discriminator for ClaimPredicate: {discriminator}");
            }
        }
    }
}
