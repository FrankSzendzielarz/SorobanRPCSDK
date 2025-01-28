// Generated code - do not modify
// Source:

// union InflationResult switch (InflationResultCode code)
// {
// case INFLATION_SUCCESS:
//     InflationPayout payouts<>;
// case INFLATION_NOT_TIME:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class InflationResult
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class InflationResult_INFLATION_SUCCESS : InflationResult
    {
        public override int Discriminator => INFLATION_SUCCESS;
        private InflationPayout[] _payouts;
        public InflationPayout[] payouts
        {
            get => _payouts;
            set
            {
                _payouts = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class InflationResult_INFLATION_NOT_TIME : InflationResult
    {
        public override int Discriminator => INFLATION_NOT_TIME;

        public override void ValidateCase() {}
    }
    public static partial class InflationResultXdr
    {
        public static void Encode(XdrWriter stream, InflationResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case InflationResult_INFLATION_SUCCESS case_INFLATION_SUCCESS:
                stream.WriteInt(case_INFLATION_SUCCESS.payouts.Length);
                foreach (var item in case_INFLATION_SUCCESS.payouts)
                {
                        InflationPayoutXdr.Encode(stream, item);
                }
                break;
                case InflationResult_INFLATION_NOT_TIME case_INFLATION_NOT_TIME:
                break;
            }
        }
        public static InflationResult Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case INFLATION_SUCCESS:
                var result_INFLATION_SUCCESS = new InflationResult_INFLATION_SUCCESS();
                var length = stream.ReadInt();
                result_INFLATION_SUCCESS.                 = new InflationPayout[length];
                for (var i = 0; i < length; i++)
                {
                    result_INFLATION_SUCCESS.                [i] = InflationPayoutXdr.Decode(stream);
                }
                return result_INFLATION_SUCCESS;
                case INFLATION_NOT_TIME:
                var result_INFLATION_NOT_TIME = new InflationResult_INFLATION_NOT_TIME();
                return result_INFLATION_NOT_TIME;
                default:
                throw new Exception($"Unknown discriminator for InflationResult: {discriminator}");
            }
        }
    }
}
