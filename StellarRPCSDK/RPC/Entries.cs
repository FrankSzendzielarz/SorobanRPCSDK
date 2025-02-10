


using System.IO;
using System;

namespace Stellar.RPC
{
    public partial class Entries
    {

        private LedgerKey _ledgerKey;
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
