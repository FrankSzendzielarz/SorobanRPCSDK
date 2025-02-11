// Generated code - do not modify
// Source:

// union TxSetComponent switch (TxSetComponentType type)
// {
// case TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
//   struct
//   {
//     int64* baseFee;
//     TransactionEnvelope txs<>;
//   } txsMaybeDiscountedFee;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class TxSetComponent
    {
        public abstract TxSetComponentType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        public partial class txsMaybeDiscountedFeeStruct
        {
            public int64 baseFee
            {
                get => _baseFee;
                set
                {
                    _baseFee = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Base Fee")]
            #endif
            private int64 _baseFee;

            public TransactionEnvelope[] txs
            {
                get => _txs;
                set
                {
                    _txs = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Txs")]
            #endif
            private TransactionEnvelope[] _txs;

            public txsMaybeDiscountedFeeStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class txsMaybeDiscountedFeeStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(txsMaybeDiscountedFeeStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    txsMaybeDiscountedFeeStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, txsMaybeDiscountedFeeStruct value)
            {
                value.Validate();
                if (value.baseFee==null){
                	stream.WriteInt(0);
                }
                else
                {
                    stream.WriteInt(1);
                    int64Xdr.Encode(stream, value.baseFee);
                }
                stream.WriteInt(value.txs.Length);
                foreach (var item in value.txs)
                {
                        TransactionEnvelopeXdr.Encode(stream, item);
                }
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static txsMaybeDiscountedFeeStruct Decode(XdrReader stream)
            {
                var result = new txsMaybeDiscountedFeeStruct();
                if (stream.ReadInt()==1)
                {
                    result.baseFee = int64Xdr.Decode(stream);
                }
                {
                    var length = stream.ReadInt();
                    result.txs = new TransactionEnvelope[length];
                    for (var i = 0; i < length; i++)
                    {
                        result.txs[i] = TransactionEnvelopeXdr.Decode(stream);
                    }
                }
                return result;
            }
        }
        [System.Serializable]
        public sealed partial class TxsetCompTxsMaybeDiscountedFee : TxSetComponent
        {
            public override TxSetComponentType Discriminator => TxSetComponentType.TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE;
            public txsMaybeDiscountedFeeStruct txsMaybeDiscountedFee
            {
                get => _txsMaybeDiscountedFee;
                set
                {
                    _txsMaybeDiscountedFee = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Txs Maybe Discounted Fee")]
            #endif
            private txsMaybeDiscountedFeeStruct _txsMaybeDiscountedFee;

            public override void ValidateCase() {}
        }
    }
    public static partial class TxSetComponentXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TxSetComponent value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TxSetComponentXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, TxSetComponent value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TxSetComponent.TxsetCompTxsMaybeDiscountedFee case_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
                TxSetComponent.txsMaybeDiscountedFeeStructXdr.Encode(stream, case_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE.txsMaybeDiscountedFee);
                break;
            }
        }
        public static TxSetComponent Decode(XdrReader stream)
        {
            var discriminator = (TxSetComponentType)stream.ReadInt();
            switch (discriminator)
            {
                case TxSetComponentType.TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE:
                var result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE = new TxSetComponent.TxsetCompTxsMaybeDiscountedFee();
                result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE.txsMaybeDiscountedFee = TxSetComponent.txsMaybeDiscountedFeeStructXdr.Decode(stream);
                return result_TXSET_COMP_TXS_MAYBE_DISCOUNTED_FEE;
                default:
                throw new Exception($"Unknown discriminator for TxSetComponent: {discriminator}");
            }
        }
    }
}
