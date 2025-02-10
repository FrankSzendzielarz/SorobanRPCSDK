// Generated code - do not modify
// Source:

// union Memo switch (MemoType type)
// {
// case MEMO_NONE:
//     void;
// case MEMO_TEXT:
//     string text<28>;
// case MEMO_ID:
//     uint64 id;
// case MEMO_HASH:
//     Hash hash; // the hash of what to pull from the content server
// case MEMO_RETURN:
//     Hash retHash; // the hash of the tx you are rejecting
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class Memo
    {
        public abstract MemoType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class MemoNone : Memo
        {
            public override MemoType Discriminator => MemoType.MEMO_NONE;

            public override void ValidateCase() {}
        }
        public sealed partial class MemoText : Memo
        {
            public override MemoType Discriminator => MemoType.MEMO_TEXT;
            [MaxLength(28)]
            public string text
            {
                get => _text;
                set
                {
                    if (System.Text.Encoding.ASCII.GetByteCount(value) > 28)
                    	throw new ArgumentException($"String exceeds 28 bytes when ASCII encoded");
                    _text = value;
                }
            }
            private string _text;

            public override void ValidateCase() {}
        }
        public sealed partial class MemoId : Memo
        {
            public override MemoType Discriminator => MemoType.MEMO_ID;
            public uint64 id
            {
                get => _id;
                set
                {
                    _id = value;
                }
            }
            private uint64 _id;

            public override void ValidateCase() {}
        }
        public sealed partial class MemoHash : Memo
        {
            public override MemoType Discriminator => MemoType.MEMO_HASH;
            public Hash hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                }
            }
            private Hash _hash;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the hash of what to pull from the content server
        /// </summary>
        public sealed partial class MemoReturn : Memo
        {
            public override MemoType Discriminator => MemoType.MEMO_RETURN;
            public Hash retHash
            {
                get => _retHash;
                set
                {
                    _retHash = value;
                }
            }
            private Hash _retHash;

            public override void ValidateCase() {}
        }
    }
    public static partial class MemoXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Memo value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                MemoXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Memo value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Memo.MemoNone case_MEMO_NONE:
                break;
                case Memo.MemoText case_MEMO_TEXT:
                stream.WriteString(case_MEMO_TEXT.text);
                break;
                case Memo.MemoId case_MEMO_ID:
                uint64Xdr.Encode(stream, case_MEMO_ID.id);
                break;
                case Memo.MemoHash case_MEMO_HASH:
                HashXdr.Encode(stream, case_MEMO_HASH.hash);
                break;
                case Memo.MemoReturn case_MEMO_RETURN:
                HashXdr.Encode(stream, case_MEMO_RETURN.retHash);
                break;
            }
        }
        public static Memo Decode(XdrReader stream)
        {
            var discriminator = (MemoType)stream.ReadInt();
            switch (discriminator)
            {
                case MemoType.MEMO_NONE:
                var result_MEMO_NONE = new Memo.MemoNone();
                return result_MEMO_NONE;
                case MemoType.MEMO_TEXT:
                var result_MEMO_TEXT = new Memo.MemoText();
                result_MEMO_TEXT.text = stream.ReadString();
                return result_MEMO_TEXT;
                case MemoType.MEMO_ID:
                var result_MEMO_ID = new Memo.MemoId();
                result_MEMO_ID.id = uint64Xdr.Decode(stream);
                return result_MEMO_ID;
                case MemoType.MEMO_HASH:
                var result_MEMO_HASH = new Memo.MemoHash();
                result_MEMO_HASH.hash = HashXdr.Decode(stream);
                return result_MEMO_HASH;
                case MemoType.MEMO_RETURN:
                var result_MEMO_RETURN = new Memo.MemoReturn();
                result_MEMO_RETURN.retHash = HashXdr.Decode(stream);
                return result_MEMO_RETURN;
                default:
                throw new Exception($"Unknown discriminator for Memo: {discriminator}");
            }
        }
    }
}
