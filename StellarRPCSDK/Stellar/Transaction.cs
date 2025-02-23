using ProtoBuf;
using Stellar.Utilities;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Stellar
{
    [ServiceContract]
    public interface ITransaction_ProtoWrapper
    {
        Transaction Clone(Transaction_ProtoWrapper.CloneParam param);
        Transaction_ProtoWrapper.BoolResult IsSoroban(Transaction_ProtoWrapper.IsSorobanParam param);
        Transaction_ProtoWrapper.BoolResult IsSorobanInvocation(Transaction_ProtoWrapper.IsSorobanParam param);
        DecoratedSignature Sign(Transaction_ProtoWrapper.SignParam param);
    }

 
    public class Transaction_ProtoWrapper : ITransaction_ProtoWrapper
    {
        [ProtoContract]
        public class BoolResult
        {
            [ProtoMember(1)]
            public bool Value { get; set; }
        }

        [ProtoContract]
        public class SignParam
        {
            [ProtoMember(1)]
            public Transaction Transaction { get; set; }
            [ProtoMember(2)]
            public MuxedAccount Account { get; set; }
        }

        [ProtoContract]
        public class CloneParam
        {
            [ProtoMember(1)]
            public Transaction Transaction { get; set; }
        }

        [ProtoContract]
        public class IsSorobanParam
        {
            [ProtoMember(1)]
            public Transaction Transaction { get; set; }
        }

        // Instance methods
        [OperationContract]
        public DecoratedSignature Sign(SignParam param)
        {
            return param.Transaction.Sign(param.Account);
        }

        [OperationContract]
        public Transaction Clone(CloneParam param)
        {
            return param.Transaction.Clone();
        }

        [OperationContract]
        public BoolResult IsSoroban(IsSorobanParam param)
        {
            return new BoolResult { Value = param.Transaction.IsSoroban() };
        }

        [OperationContract]
        public BoolResult IsSorobanInvocation(IsSorobanParam param)
        {
            return new BoolResult { Value = param.Transaction.IsSorobanInvocation() };
        }
    }

    public partial class Transaction
    {

        public Transaction Clone()
        {
            Transaction clone;
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionXdr.Encode(writer, this);
                memoryStream.Position = 0;
                clone = TransactionXdr.Decode(new XdrReader(memoryStream));
            }
            return clone;
        }

        public bool IsSoroban()
        {
            return
            (
                operations != null &&
                operations.Count() == 1 &&
                (
                    (operations[0]?.body is Operation.bodyUnion.InvokeHostFunction) ||
                    (operations[0]?.body is Operation.bodyUnion.ExtendFootprintTtl) ||
                    (operations[0]?.body is Operation.bodyUnion.RestoreFootprint)
                )
            );
        }
        public bool IsSorobanInvocation()
        {
            return
                operations != null &&
                operations.Count() == 1 &&
                operations[0]?.body is Operation.bodyUnion.InvokeHostFunction;
        }


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
