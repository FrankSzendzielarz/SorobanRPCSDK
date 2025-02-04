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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class Memo
    {
        public abstract MemoType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class Memo_MEMO_NONE : Memo
    {
        public override MemoType Discriminator => MemoType.MEMO_NONE;

        public override void ValidateCase() {}
    }
    public sealed partial class Memo_MEMO_TEXT : Memo
    {
        public override MemoType Discriminator => MemoType.MEMO_TEXT;
        private string _text;
        public string text
        {
            get => _text;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 28)
                	throw new ArgumentException($"String exceeds 28 bytes when UTF8 encoded");
                _text = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class Memo_MEMO_ID : Memo
    {
        public override MemoType Discriminator => MemoType.MEMO_ID;
        private uint64 _id;
        public uint64 id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class Memo_MEMO_HASH : Memo
    {
        public override MemoType Discriminator => MemoType.MEMO_HASH;
        private Hash _hash;
        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class Memo_MEMO_RETURN : Memo
    {
        public override MemoType Discriminator => MemoType.MEMO_RETURN;
        private Hash _retHash;
        public Hash retHash
        {
            get => _retHash;
            set
            {
                _retHash = value;
            }
        }

        public override void ValidateCase() {}
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
                case Memo_MEMO_NONE case_MEMO_NONE:
                break;
                case Memo_MEMO_TEXT case_MEMO_TEXT:
                break;
                case Memo_MEMO_ID case_MEMO_ID:
                uint64Xdr.Encode(stream, case_MEMO_ID.id);
                break;
                case Memo_MEMO_HASH case_MEMO_HASH:
                HashXdr.Encode(stream, case_MEMO_HASH.hash);
                break;
                case Memo_MEMO_RETURN case_MEMO_RETURN:
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
                var result_MEMO_NONE = new Memo_MEMO_NONE();
                return result_MEMO_NONE;
                case MemoType.MEMO_TEXT:
                var result_MEMO_TEXT = new Memo_MEMO_TEXT();
                return result_MEMO_TEXT;
                case MemoType.MEMO_ID:
                var result_MEMO_ID = new Memo_MEMO_ID();
                result_MEMO_ID.id = uint64Xdr.Decode(stream);
                return result_MEMO_ID;
                case MemoType.MEMO_HASH:
                var result_MEMO_HASH = new Memo_MEMO_HASH();
                result_MEMO_HASH.hash = HashXdr.Decode(stream);
                return result_MEMO_HASH;
                case MemoType.MEMO_RETURN:
                var result_MEMO_RETURN = new Memo_MEMO_RETURN();
                result_MEMO_RETURN.retHash = HashXdr.Decode(stream);
                return result_MEMO_RETURN;
                default:
                throw new Exception($"Unknown discriminator for Memo: {discriminator}");
            }
        }
    }
}
