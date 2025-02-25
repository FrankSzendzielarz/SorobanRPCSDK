


using System.IO;
using System;
using ProtoBuf;

namespace Stellar.RPC
{
    public partial class Entries
    {

        private LedgerKey _ledgerKey;
        [ProtoMember(100)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public LedgerKey LedgerKey
        {
            get
            {
                if (_ledgerKey == null)
                {
                    byte[] bytes = Convert.FromBase64String(Key);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        _ledgerKey = LedgerKeyXdr.Decode(new XdrReader(stream));
                    }
                }
                return _ledgerKey;
            }
        }

        private LedgerEntry.dataUnion _ledgerEntryData;
        [ProtoMember(101)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public LedgerEntry.dataUnion LedgerEntryData
        {
            get
            {
                if (_ledgerEntryData == null)
                {
                    byte[] bytes = Convert.FromBase64String(Xdr);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        _ledgerEntryData = LedgerEntry.dataUnionXdr.Decode(new XdrReader(stream));
                        
                    }
                }
                return _ledgerEntryData;
            }

        }
        
     
    }
}
