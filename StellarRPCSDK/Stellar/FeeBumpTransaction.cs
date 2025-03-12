using ProtoBuf;
using Stellar.Utilities;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Stellar
{
    [ServiceContract]
    public interface IFeeBumpTransaction_ProtoWrapper
    {
   
        DecoratedSignature Sign(FeeBumpTransaction_ProtoWrapper.SignParam param);
    }

 
    public class FeeBumpTransaction_ProtoWrapper : IFeeBumpTransaction_ProtoWrapper
    {
       

        [ProtoContract]
        public class SignParam
        {
            [ProtoMember(1)]
            public FeeBumpTransaction Transaction { get; set; }
            [ProtoMember(2)]
            public MuxedAccount Account { get; set; }
        }

        // Instance methods
        [OperationContract]
        public DecoratedSignature Sign(SignParam param)
        {
            return param.Transaction.Sign(param.Account);
        }

     
    }

    public partial class FeeBumpTransaction
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
                taggedTransaction = new TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump()
                {
                    feeBump = this
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
