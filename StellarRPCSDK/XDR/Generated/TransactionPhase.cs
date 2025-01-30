// Generated code - do not modify
// Source:

// union TransactionPhase switch (int v)
// {
// case 0:
//     TxSetComponent v0Components<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class TransactionPhase
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class TransactionPhase_0 : TransactionPhase
    {
        public override int Discriminator => 0;
        private TxSetComponent[] _v0Components;
        public TxSetComponent[] v0Components
        {
            get => _v0Components;
            set
            {
                _v0Components = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class TransactionPhaseXdr
    {
        public static void Encode(XdrWriter stream, TransactionPhase value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TransactionPhase_0 case_0:
                stream.WriteInt(case_0.v0Components.Length);
                foreach (var item in case_0.v0Components)
                {
                        TxSetComponentXdr.Encode(stream, item);
                }
                break;
            }
        }
        public static TransactionPhase Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new TransactionPhase_0();
                {
                    var length = stream.ReadInt();
                    result_0.v0Components = new TxSetComponent[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_0.v0Components[i] = TxSetComponentXdr.Decode(stream);
                    }
                }
                return result_0;
                default:
                throw new Exception($"Unknown discriminator for TransactionPhase: {discriminator}");
            }
        }
    }
}
