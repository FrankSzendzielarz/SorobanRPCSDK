using Stellar.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;

namespace Stellar
{
    public partial class Transaction
    {
        /// <summary>
        /// Signs the transaction using an account and the current Network.
        /// </summary>
        /// <param name="account">The account that should sign the transaction</param>
        /// <returns></returns>
        public DecoratedSignature Sign(MuxedAccount account)
        {
            var signaturePayload = new TransactionSignaturePayload()
            {
                networkId = new Hash(Network.Current.NetworkId),
                taggedTransaction = new TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx()
                {
                    tx = this
                }
            };

            byte[] signaturePayloadBytes;
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionSignaturePayloadXdr.Encode(writer, signaturePayload);
                signaturePayloadBytes = memoryStream.ToArray();
            }

            byte[] hashedPayload = Util.Hash(signaturePayloadBytes);

            return account.SignDecorated(hashedPayload);

        }
    }
}
