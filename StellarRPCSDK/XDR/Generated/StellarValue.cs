// Generated code - do not modify
// Source:

// struct StellarValue
// {
//     Hash txSetHash;      // transaction set to apply to previous ledger
//     TimePoint closeTime; // network close time
// 
//     // upgrades to apply to the previous ledger (usually empty)
//     // this is a vector of encoded 'LedgerUpgrade' so that nodes can drop
//     // unknown steps during consensus if needed.
//     // see notes below on 'LedgerUpgrade' for more detail
//     // max size is dictated by number of upgrade types (+ room for future)
//     UpgradeType upgrades<6>;
// 
//     // reserved for future use
//     union switch (StellarValueType v)
//     {
//     case STELLAR_VALUE_BASIC:
//         void;
//     case STELLAR_VALUE_SIGNED:
//         LedgerCloseValueSignature lcValueSignature;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class StellarValue
    {
        private Hash _txSetHash;
        public Hash txSetHash
        {
            get => _txSetHash;
            set
            {
                _txSetHash = value;
            }
        }

        private TimePoint _closeTime;
        public TimePoint closeTime
        {
            get => _closeTime;
            set
            {
                _closeTime = value;
            }
        }

        private UpgradeType[] _upgrades;
        public UpgradeType[] upgrades
        {
            get => _upgrades;
            set
            {
                if (value.Length > 6)
                	throw new ArgumentException($"Cannot exceed 6 bytes");
                _upgrades = value;
            }
        }

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public StellarValue()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (upgrades.Length > 6)
            	throw new InvalidOperationException($"upgrades cannot exceed 6 elements");
        }
    }
    public static partial class StellarValueXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, StellarValue value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.txSetHash);
            TimePointXdr.Encode(stream, value.closeTime);
            stream.WriteInt(value.upgrades.Length);
            foreach (var item in value.upgrades)
            {
                    UpgradeTypeXdr.Encode(stream, item);
            }
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static StellarValue Decode(XdrReader stream)
        {
            var result = new StellarValue();
            result.txSetHash = HashXdr.Decode(stream);
            result.closeTime = TimePointXdr.Decode(stream);
            var length = stream.ReadInt();
            result.upgrades = new UpgradeType[length];
            for (var i = 0; i < length; i++)
            {
                result.upgrades[i] = UpgradeTypeXdr.Decode(stream);
            }
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
