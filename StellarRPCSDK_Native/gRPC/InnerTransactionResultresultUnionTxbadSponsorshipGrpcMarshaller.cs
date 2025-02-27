// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxbadSponsorship</summary>
    public static class InnerTransactionResultresultUnionTxbadSponsorshipGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxbadSponsorshipGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxbadSponsorship</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship> InnerTransactionResult_resultUnion_TxbadSponsorshipMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
