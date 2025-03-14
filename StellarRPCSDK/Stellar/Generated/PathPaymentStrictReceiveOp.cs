// Generated code - do not modify
// Source:

// struct PathPaymentStrictReceiveOp
// {
//     Asset sendAsset; // asset we pay with
//     int64 sendMax;   // the maximum amount of sendAsset to
//                      // send (excluding fees).
//                      // The operation will fail if can't be met
// 
//     MuxedAccount destination; // recipient of the payment
//     Asset destAsset;          // what they end up with
//     int64 destAmount;         // amount they end up with
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
    public partial class PathPaymentStrictReceiveOp
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
        public int64 sendMax
        {
            get => _sendMax;
            set
            {
                _sendMax = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Send Max")]
        #endif
        private int64 _sendMax;

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
        public int64 destAmount
        {
            get => _destAmount;
            set
            {
                _destAmount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Dest Amount")]
        #endif
        private int64 _destAmount;

        [ProtoMember(6, OverwriteList = true)]
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

        public PathPaymentStrictReceiveOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (path.Length > 5)
            	throw new InvalidOperationException($"path cannot exceed 5 elements");
        }
    }
    public static partial class PathPaymentStrictReceiveOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PathPaymentStrictReceiveOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PathPaymentStrictReceiveOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PathPaymentStrictReceiveOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PathPaymentStrictReceiveOpXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PathPaymentStrictReceiveOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.sendAsset);
            int64Xdr.Encode(stream, value.sendMax);
            MuxedAccountXdr.Encode(stream, value.destination);
            AssetXdr.Encode(stream, value.destAsset);
            int64Xdr.Encode(stream, value.destAmount);
            stream.WriteInt(value.path.Length);
            foreach (var item in value.path)
            {
                    AssetXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PathPaymentStrictReceiveOp Decode(XdrReader stream)
        {
            var result = new PathPaymentStrictReceiveOp();
            result.sendAsset = AssetXdr.Decode(stream);
            result.sendMax = int64Xdr.Decode(stream);
            result.destination = MuxedAccountXdr.Decode(stream);
            result.destAsset = AssetXdr.Decode(stream);
            result.destAmount = int64Xdr.Decode(stream);
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
