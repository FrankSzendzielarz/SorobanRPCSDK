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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SCPStatement
    {
        [ProtoMember(1)]
        public NodeID nodeID
        {
            get => _nodeID;
            set
            {
                _nodeID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Node I D")]
        #endif
        private NodeID _nodeID;

        /// <summary>
        /// v
        /// </summary>
        [ProtoMember(2)]
        public uint64 slotIndex
        {
            get => _slotIndex;
            set
            {
                _slotIndex = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Slot Index")]
        #endif
        private uint64 _slotIndex;

        [ProtoMember(3)]
        public pledgesUnion pledges
        {
            get => _pledges;
            set
            {
                _pledges = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Pledges")]
        #endif
        private pledgesUnion _pledges;

        public SCPStatement()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "SCPStatement.pledgesUnion")]
        [ProtoInclude(100, typeof(ScpStPrepare), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(ScpStConfirm), DataFormat = DataFormat.Default)]
        [ProtoInclude(102, typeof(ScpStExternalize), DataFormat = DataFormat.Default)]
        [ProtoInclude(103, typeof(ScpStNominate), DataFormat = DataFormat.Default)]
        public abstract partial class pledgesUnion
        {
            public abstract SCPStatementType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.prepareStruct")]
            public partial class prepareStruct
            {
                [ProtoMember(1)]
                public Hash quorumSetHash
                {
                    get => _quorumSetHash;
                    set
                    {
                        _quorumSetHash = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Quorum Set Hash")]
                #endif
                private Hash _quorumSetHash;

                /// <summary>
                /// D
                /// </summary>
                [ProtoMember(2)]
                public SCPBallot ballot
                {
                    get => _ballot;
                    set
                    {
                        _ballot = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Ballot")]
                #endif
                private SCPBallot _ballot;

                /// <summary>
                /// b
                /// </summary>
                [ProtoMember(3)]
                public SCPBallot prepared
                {
                    get => _prepared;
                    set
                    {
                        _prepared = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Prepared")]
                #endif
                private SCPBallot _prepared;

                /// <summary>
                /// p
                /// </summary>
                [ProtoMember(4)]
                public SCPBallot preparedPrime
                {
                    get => _preparedPrime;
                    set
                    {
                        _preparedPrime = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Prepared Prime")]
                #endif
                private SCPBallot _preparedPrime;

                /// <summary>
                /// p'
                /// </summary>
                [ProtoMember(5)]
                public uint32 nC
                {
                    get => _nC;
                    set
                    {
                        _nC = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N C")]
                #endif
                private uint32 _nC;

                /// <summary>
                /// c.n
                /// </summary>
                [ProtoMember(6)]
                public uint32 nH
                {
                    get => _nH;
                    set
                    {
                        _nH = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N H")]
                #endif
                private uint32 _nH;

                public prepareStruct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class prepareStructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(prepareStruct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        prepareStructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static prepareStruct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return prepareStructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, prepareStruct value)
                {
                    value.Validate();
                    HashXdr.Encode(stream, value.quorumSetHash);
                    SCPBallotXdr.Encode(stream, value.ballot);
                    if (value.prepared==null){
                    	stream.WriteInt(0);
                    }
                    else
                    {
                        stream.WriteInt(1);
                        SCPBallotXdr.Encode(stream, value.prepared);
                    }
                    if (value.preparedPrime==null){
                    	stream.WriteInt(0);
                    }
                    else
                    {
                        stream.WriteInt(1);
                        SCPBallotXdr.Encode(stream, value.preparedPrime);
                    }
                    uint32Xdr.Encode(stream, value.nC);
                    uint32Xdr.Encode(stream, value.nH);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static prepareStruct Decode(XdrReader stream)
                {
                    var result = new prepareStruct();
                    result.quorumSetHash = HashXdr.Decode(stream);
                    result.ballot = SCPBallotXdr.Decode(stream);
                    if (stream.ReadInt()==1)
                    {
                        result.prepared = SCPBallotXdr.Decode(stream);
                    }
                    if (stream.ReadInt()==1)
                    {
                        result.preparedPrime = SCPBallotXdr.Decode(stream);
                    }
                    result.nC = uint32Xdr.Decode(stream);
                    result.nH = uint32Xdr.Decode(stream);
                    return result;
                }
            }
            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.confirmStruct")]
            public partial class confirmStruct
            {
                [ProtoMember(1)]
                public SCPBallot ballot
                {
                    get => _ballot;
                    set
                    {
                        _ballot = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Ballot")]
                #endif
                private SCPBallot _ballot;

                /// <summary>
                /// b
                /// </summary>
                [ProtoMember(2)]
                public uint32 nPrepared
                {
                    get => _nPrepared;
                    set
                    {
                        _nPrepared = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N Prepared")]
                #endif
                private uint32 _nPrepared;

                /// <summary>
                /// p.n
                /// </summary>
                [ProtoMember(3)]
                public uint32 nCommit
                {
                    get => _nCommit;
                    set
                    {
                        _nCommit = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N Commit")]
                #endif
                private uint32 _nCommit;

                /// <summary>
                /// c.n
                /// </summary>
                [ProtoMember(4)]
                public uint32 nH
                {
                    get => _nH;
                    set
                    {
                        _nH = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N H")]
                #endif
                private uint32 _nH;

                /// <summary>
                /// h.n
                /// </summary>
                [ProtoMember(5)]
                public Hash quorumSetHash
                {
                    get => _quorumSetHash;
                    set
                    {
                        _quorumSetHash = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Quorum Set Hash")]
                #endif
                private Hash _quorumSetHash;

                public confirmStruct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class confirmStructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(confirmStruct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        confirmStructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static confirmStruct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return confirmStructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, confirmStruct value)
                {
                    value.Validate();
                    SCPBallotXdr.Encode(stream, value.ballot);
                    uint32Xdr.Encode(stream, value.nPrepared);
                    uint32Xdr.Encode(stream, value.nCommit);
                    uint32Xdr.Encode(stream, value.nH);
                    HashXdr.Encode(stream, value.quorumSetHash);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static confirmStruct Decode(XdrReader stream)
                {
                    var result = new confirmStruct();
                    result.ballot = SCPBallotXdr.Decode(stream);
                    result.nPrepared = uint32Xdr.Decode(stream);
                    result.nCommit = uint32Xdr.Decode(stream);
                    result.nH = uint32Xdr.Decode(stream);
                    result.quorumSetHash = HashXdr.Decode(stream);
                    return result;
                }
            }
            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.externalizeStruct")]
            public partial class externalizeStruct
            {
                [ProtoMember(1)]
                public SCPBallot commit
                {
                    get => _commit;
                    set
                    {
                        _commit = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Commit")]
                #endif
                private SCPBallot _commit;

                /// <summary>
                /// c
                /// </summary>
                [ProtoMember(2)]
                public uint32 nH
                {
                    get => _nH;
                    set
                    {
                        _nH = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"N H")]
                #endif
                private uint32 _nH;

                /// <summary>
                /// h.n
                /// </summary>
                [ProtoMember(3)]
                public Hash commitQuorumSetHash
                {
                    get => _commitQuorumSetHash;
                    set
                    {
                        _commitQuorumSetHash = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Commit Quorum Set Hash")]
                #endif
                private Hash _commitQuorumSetHash;

                public externalizeStruct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class externalizeStructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(externalizeStruct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        externalizeStructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static externalizeStruct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return externalizeStructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, externalizeStruct value)
                {
                    value.Validate();
                    SCPBallotXdr.Encode(stream, value.commit);
                    uint32Xdr.Encode(stream, value.nH);
                    HashXdr.Encode(stream, value.commitQuorumSetHash);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static externalizeStruct Decode(XdrReader stream)
                {
                    var result = new externalizeStruct();
                    result.commit = SCPBallotXdr.Decode(stream);
                    result.nH = uint32Xdr.Decode(stream);
                    result.commitQuorumSetHash = HashXdr.Decode(stream);
                    return result;
                }
            }
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.ScpStPrepare")]
            public sealed partial class ScpStPrepare : pledgesUnion
            {
                public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_PREPARE;
                [ProtoMember(1)]
                public prepareStruct prepare
                {
                    get => _prepare;
                    set
                    {
                        _prepare = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Prepare")]
                #endif
                private prepareStruct _prepare;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.ScpStConfirm")]
            public sealed partial class ScpStConfirm : pledgesUnion
            {
                public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_CONFIRM;
                [ProtoMember(2)]
                public confirmStruct confirm
                {
                    get => _confirm;
                    set
                    {
                        _confirm = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Confirm")]
                #endif
                private confirmStruct _confirm;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.ScpStExternalize")]
            public sealed partial class ScpStExternalize : pledgesUnion
            {
                public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_EXTERNALIZE;
                [ProtoMember(3)]
                public externalizeStruct externalize
                {
                    get => _externalize;
                    set
                    {
                        _externalize = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Externalize")]
                #endif
                private externalizeStruct _externalize;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "SCPStatement.pledgesUnion.ScpStNominate")]
            public sealed partial class ScpStNominate : pledgesUnion
            {
                public override SCPStatementType Discriminator => SCPStatementType.SCP_ST_NOMINATE;
                [ProtoMember(4)]
                public SCPNomination nominate
                {
                    get => _nominate;
                    set
                    {
                        _nominate = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Nominate")]
                #endif
                private SCPNomination _nominate;

                public override void ValidateCase() {}
            }
        }
        public static partial class pledgesUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(pledgesUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    pledgesUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static pledgesUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return pledgesUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, pledgesUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case pledgesUnion.ScpStPrepare case_SCP_ST_PREPARE:
                    pledgesUnion.prepareStructXdr.Encode(stream, case_SCP_ST_PREPARE.prepare);
                    break;
                    case pledgesUnion.ScpStConfirm case_SCP_ST_CONFIRM:
                    pledgesUnion.confirmStructXdr.Encode(stream, case_SCP_ST_CONFIRM.confirm);
                    break;
                    case pledgesUnion.ScpStExternalize case_SCP_ST_EXTERNALIZE:
                    pledgesUnion.externalizeStructXdr.Encode(stream, case_SCP_ST_EXTERNALIZE.externalize);
                    break;
                    case pledgesUnion.ScpStNominate case_SCP_ST_NOMINATE:
                    SCPNominationXdr.Encode(stream, case_SCP_ST_NOMINATE.nominate);
                    break;
                }
            }
            public static pledgesUnion Decode(XdrReader stream)
            {
                var discriminator = (SCPStatementType)stream.ReadInt();
                switch (discriminator)
                {
                    case SCPStatementType.SCP_ST_PREPARE:
                    var result_SCP_ST_PREPARE = new pledgesUnion.ScpStPrepare();
                    result_SCP_ST_PREPARE.prepare = pledgesUnion.prepareStructXdr.Decode(stream);
                    return result_SCP_ST_PREPARE;
                    case SCPStatementType.SCP_ST_CONFIRM:
                    var result_SCP_ST_CONFIRM = new pledgesUnion.ScpStConfirm();
                    result_SCP_ST_CONFIRM.confirm = pledgesUnion.confirmStructXdr.Decode(stream);
                    return result_SCP_ST_CONFIRM;
                    case SCPStatementType.SCP_ST_EXTERNALIZE:
                    var result_SCP_ST_EXTERNALIZE = new pledgesUnion.ScpStExternalize();
                    result_SCP_ST_EXTERNALIZE.externalize = pledgesUnion.externalizeStructXdr.Decode(stream);
                    return result_SCP_ST_EXTERNALIZE;
                    case SCPStatementType.SCP_ST_NOMINATE:
                    var result_SCP_ST_NOMINATE = new pledgesUnion.ScpStNominate();
                    result_SCP_ST_NOMINATE.nominate = SCPNominationXdr.Decode(stream);
                    return result_SCP_ST_NOMINATE;
                    default:
                    throw new Exception($"Unknown discriminator for pledgesUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class SCPStatementXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPStatement value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPStatementXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCPStatement DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCPStatementXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPStatement value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.nodeID);
            uint64Xdr.Encode(stream, value.slotIndex);
            SCPStatement.pledgesUnionXdr.Encode(stream, value.pledges);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPStatement Decode(XdrReader stream)
        {
            var result = new SCPStatement();
            result.nodeID = NodeIDXdr.Decode(stream);
            result.slotIndex = uint64Xdr.Decode(stream);
            result.pledges = SCPStatement.pledgesUnionXdr.Decode(stream);
            return result;
        }
    }
}
