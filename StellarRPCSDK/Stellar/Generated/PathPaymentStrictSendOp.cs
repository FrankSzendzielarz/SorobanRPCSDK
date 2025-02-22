// Generated code - do not modify
// Source:

// struct PathPaymentStrictSendOp
// {
//     Asset sendAsset;  // asset we pay with
//     int64 sendAmount; // amount of sendAsset to send (excluding fees)
// 
//     MuxedAccount destination; // recipient of the payment
//     Asset destAsset;          // what they end up with
//     int64 destMin;            // the minimum amount of dest asset to
//                               // be received
//                               // The operation will fail if it can't be met
// 
//     Asset path<5>; // additional hops it must go through to get there
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
    public partial class PathPaymentStrictSendOp
    {
        [ProtoMember(1)]
        public Asset sendAsset
        {
            get => _sendAsset;
            set
            {
                _sendAsset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Send Asset")]
        #endif
        private Asset _sendAsset;

        /// <summary>
        /// asset we pay with
        /// </summary>
        [ProtoMember(2)]
        public int64 sendAmount
        {
            get => _sendAmount;
            set
            {
                _sendAmount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Send Amount")]
        #endif
        private int64 _sendAmount;

        [ProtoMember(3)]
        public MuxedAccount destination
        {
            get => _destination;
            set
            {
                _destination = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Destination")]
        #endif
        private MuxedAccount _destination;

        /// <summary>
        /// recipient of the payment
        /// </summary>
        [ProtoMember(4)]
        public Asset destAsset
        {
            get => _destAsset;
            set
            {
                _destAsset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Dest Asset")]
        #endif
        private Asset _destAsset;

        /// <summary>
        /// what they end up with
        /// </summary>
        [ProtoMember(5)]
        public int64 destMin
        {
            get => _destMin;
            set
            {
                _destMin = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Dest Min")]
        #endif
        private int64 _destMin;

        [ProtoMember(6)]
        [MaxLength(5)]
        public Asset[] path
        {
            get => _path;
            set
            {
                if (value.Length > 5)
                	throw new ArgumentException($"Cannot exceed 5 in length");
                _path = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Path")]
        #endif
        private Asset[] _path;

        public PathPaymentStrictSendOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (path.Length > 5)
            	throw new InvalidOperationException($"path cannot exceed 5 elements");
        }
    }
    public static partial class PathPaymentStrictSendOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PathPaymentStrictSendOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PathPaymentStrictSendOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PathPaymentStrictSendOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.sendAsset);
            int64Xdr.Encode(stream, value.sendAmount);
            MuxedAccountXdr.Encode(stream, value.destination);
            AssetXdr.Encode(stream, value.destAsset);
            int64Xdr.Encode(stream, value.destMin);
            stream.WriteInt(value.path.Length);
            foreach (var item in value.path)
            {
                    AssetXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PathPaymentStrictSendOp Decode(XdrReader stream)
        {
            var result = new PathPaymentStrictSendOp();
            result.sendAsset = AssetXdr.Decode(stream);
            result.sendAmount = int64Xdr.Decode(stream);
            result.destination = MuxedAccountXdr.Decode(stream);
            result.destAsset = AssetXdr.Decode(stream);
            result.destMin = int64Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.path = new Asset[length];
                for (var i = 0; i < length; i++)
                {
                    result.path[i] = AssetXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
