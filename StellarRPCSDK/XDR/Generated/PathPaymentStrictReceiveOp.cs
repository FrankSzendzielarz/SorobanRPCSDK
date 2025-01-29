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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PathPaymentStrictReceiveOp
    {
        private Asset _sendAsset;
        public Asset sendAsset
        {
            get => _sendAsset;
            set
            {
                _sendAsset = value;
            }
        }

        private int64 _sendMax;
        public int64 sendMax
        {
            get => _sendMax;
            set
            {
                _sendMax = value;
            }
        }

        private MuxedAccount _destination;
        public MuxedAccount destination
        {
            get => _destination;
            set
            {
                _destination = value;
            }
        }

        private Asset _destAsset;
        public Asset destAsset
        {
            get => _destAsset;
            set
            {
                _destAsset = value;
            }
        }

        private int64 _destAmount;
        public int64 destAmount
        {
            get => _destAmount;
            set
            {
                _destAmount = value;
            }
        }

        private Asset[] _path;
        public Asset[] path
        {
            get => _path;
            set
            {
                if (value.Length > 5)
                	throw new ArgumentException($"Cannot exceed 5 bytes");
                _path = value;
            }
        }

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
