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
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class pledgesUnion
        {
            public abstract SCPStatementType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();
        }
        public sealed partial class pledgesUnion_SCP_ST_PREPARE : pledgesUnion
        {
            public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_PREPARE;
            private object _prepare;
            public object prepare
            {
                get => _prepare;
                set
                {
                    _prepare = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class pledgesUnion_SCP_ST_CONFIRM : pledgesUnion
        {
            public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_CONFIRM;
            private object _confirm;
            public object confirm
            {
                get => _confirm;
                set
                {
                    _confirm = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class pledgesUnion_SCP_ST_EXTERNALIZE : pledgesUnion
        {
            public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_EXTERNALIZE;
            private object _externalize;
            public object externalize
            {
                get => _externalize;
                set
                {
                    _externalize = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class pledgesUnion_SCP_ST_NOMINATE : pledgesUnion
        {
            public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_NOMINATE;
            private SCPNomination _nominate;
            public SCPNomination nominate
            {
                get => _nominate;
                set
                {
                    _nominate = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class pledgesUnionXdr
        {
            public static void Encode(XdrWriter stream, pledgesUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case pledgesUnion_SCP_ST_PREPARE case_SCP_ST_PREPARE:
                    Xdr.Encode(stream, case_SCP_ST_PREPARE.prepare);
                    break;
                    case pledgesUnion_SCP_ST_CONFIRM case_SCP_ST_CONFIRM:
                    Xdr.Encode(stream, case_SCP_ST_CONFIRM.confirm);
                    break;
                    case pledgesUnion_SCP_ST_EXTERNALIZE case_SCP_ST_EXTERNALIZE:
                    Xdr.Encode(stream, case_SCP_ST_EXTERNALIZE.externalize);
                    break;
                    case pledgesUnion_SCP_ST_NOMINATE case_SCP_ST_NOMINATE:
                    SCPNominationXdr.Encode(stream, case_SCP_ST_NOMINATE.nominate);
                    break;
                }
            }
            public static pledgesUnion Decode(XdrReader stream)
            {
                var discriminator = (SCPStatementType)stream.ReadInt();
                switch (discriminator)
                {
                    case SCP_ST_PREPARE:
                    var result_SCP_ST_PREPARE = new pledgesUnion_SCP_ST_PREPARE();
                    result_SCP_ST_PREPARE.                 = Xdr.Decode(stream);
                    return result_SCP_ST_PREPARE;
                    case SCP_ST_CONFIRM:
                    var result_SCP_ST_CONFIRM = new pledgesUnion_SCP_ST_CONFIRM();
                    result_SCP_ST_CONFIRM.                 = Xdr.Decode(stream);
                    return result_SCP_ST_CONFIRM;
                    case SCP_ST_EXTERNALIZE:
                    var result_SCP_ST_EXTERNALIZE = new pledgesUnion_SCP_ST_EXTERNALIZE();
                    result_SCP_ST_EXTERNALIZE.                 = Xdr.Decode(stream);
                    return result_SCP_ST_EXTERNALIZE;
                    case SCP_ST_NOMINATE:
                    var result_SCP_ST_NOMINATE = new pledgesUnion_SCP_ST_NOMINATE();
                    result_SCP_ST_NOMINATE.                 = SCPNominationXdr.Decode(stream);
                    return result_SCP_ST_NOMINATE;
                    default:
                    throw new Exception($"Unknown discriminator for pledgesUnion: {discriminator}");
                }
            }
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
