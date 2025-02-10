using System;
using System.Collections.Generic;
using System.Text;

namespace Stellar
{
    public class MuxedAccount 
    {
        private MuxedAccount() { }
        public ulong Id { get; private set; }
        public KeyPair Key { get; private set; }
        public MuxedAccount(KeyPair keyPair, ulong id)
        {
            Id = id;
            Key = keyPair;
        }
        /// <summary>
        ///     Get the MuxedAccount address, starting with M.
        /// </summary>
        public string Address => StrKey.EncodeStellarMuxedAccount(MuxedAccount);

        /// <summary>
        ///     Get the MuxedAccount account id, starting with M.
        /// </summary>
        public string AccountId => Address;

        /// <summary>
        ///     Return the signing key for the muxed account.
        /// </summary>
        public KeyPair SigningKey => Key;

    }
}
