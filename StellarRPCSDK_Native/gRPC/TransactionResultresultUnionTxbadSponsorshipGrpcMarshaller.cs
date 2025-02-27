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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion+TxbadSponsorship</summary>
    public static class TransactionResultresultUnionTxbadSponsorshipGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionTxbadSponsorshipGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion.TxbadSponsorship
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion.TxbadSponsorship)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion.TxbadSponsorship), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TxbadSponsorship</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion.TxbadSponsorship> TxbadSponsorshipMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion.TxbadSponsorship>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion.TxbadSponsorship>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
