using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class Results
    {
        private SCVal _result;
        [ProtoMember(100)]
        public SCVal Result
        {
            get
            {
                if (_result == null)
                {
                    if (Xdr != null)
                    {
                        byte[] bytes = Convert.FromBase64String(Xdr);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _result = SCValXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _result;
            }
        }

        private List<SorobanAuthorizationEntry> _sorobanAuthorisations;
        [ProtoMember(101)]
        public List<SorobanAuthorizationEntry> SorobanAuthorizations
        {
            get
            {
                if (_sorobanAuthorisations == null)
                {
                    _sorobanAuthorisations = new List<SorobanAuthorizationEntry>();
                    if (Auth != null)
                    {
                        foreach (var xdr in Auth)
                        {
                            byte[] bytes = Convert.FromBase64String(xdr);
                            using (MemoryStream stream = new MemoryStream(bytes))
                            {
                                _sorobanAuthorisations.Add(  SorobanAuthorizationEntryXdr.Decode(new XdrReader(stream)));

                            }
                        }
                    }
                }
                return _sorobanAuthorisations;
            }
        }
    }
}
