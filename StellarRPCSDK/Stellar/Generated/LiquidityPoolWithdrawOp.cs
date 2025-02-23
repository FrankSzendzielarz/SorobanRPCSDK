// Generated code - do not modify
// Source:

// struct LiquidityPoolWithdrawOp
// {
//     PoolID liquidityPoolID;
//     int64 amount;     // amount of pool shares to withdraw
//     int64 minAmountA; // minimum amount of first asset to withdraw
//     int64 minAmountB; // minimum amount of second asset to withdraw
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
    public partial class LiquidityPoolWithdrawOp
    {
        [ProtoMember(1)]
        public PoolID liquidityPoolID
        {
            get => _liquidityPoolID;
            set
            {
                _liquidityPoolID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Liquidity Pool I D")]
        #endif
        private PoolID _liquidityPoolID;

        [ProtoMember(2)]
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Amount")]
        #endif
        private int64 _amount;

        /// <summary>
        /// amount of pool shares to withdraw
        /// </summary>
        [ProtoMember(3)]
        public int64 minAmountA
        {
            get => _minAmountA;
            set
            {
                _minAmountA = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Amount A")]
        #endif
        private int64 _minAmountA;

        /// <summary>
        /// minimum amount of first asset to withdraw
        /// </summary>
        [ProtoMember(4)]
        public int64 minAmountB
        {
            get => _minAmountB;
            set
            {
                _minAmountB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Amount B")]
        #endif
        private int64 _minAmountB;

        public LiquidityPoolWithdrawOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LiquidityPoolWithdrawOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolWithdrawOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolWithdrawOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolWithdrawOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolWithdrawOpXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolWithdrawOp value)
        {
            value.Validate();
            PoolIDXdr.Encode(stream, value.liquidityPoolID);
            int64Xdr.Encode(stream, value.amount);
            int64Xdr.Encode(stream, value.minAmountA);
            int64Xdr.Encode(stream, value.minAmountB);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LiquidityPoolWithdrawOp Decode(XdrReader stream)
        {
            var result = new LiquidityPoolWithdrawOp();
            result.liquidityPoolID = PoolIDXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.minAmountA = int64Xdr.Decode(stream);
            result.minAmountB = int64Xdr.Decode(stream);
            return result;
        }
    }
}
