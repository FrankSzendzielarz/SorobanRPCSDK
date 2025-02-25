using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class StateChanges
    {
        private LedgerEntry _before;
        [ProtoMember(100)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public LedgerEntry LedgerBefore
        {
            get
            {
                if (_before == null)
                {
                    if (Before != null)
                    {
                        byte[] bytes = Convert.FromBase64String(Before);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _before = LedgerEntryXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _before;
            }
        }

        private LedgerEntry _after;
        [ProtoMember(101)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public LedgerEntry LedgerAfter
        {
            get
            {
                if (_after == null)
                {
                    if (After != null)
                    {
                        byte[] bytes = Convert.FromBase64String(After);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _after = LedgerEntryXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _after;
            }
        }
    }
}
