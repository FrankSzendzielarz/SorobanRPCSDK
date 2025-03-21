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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxbadSeq</summary>
    public static class InnerTransactionResultresultUnionTxbadSeqGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxbadSeqGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxbadSeq
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSeq)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSeq), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxbadSeq</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxbadSeq> InnerTransactionResult_resultUnion_TxbadSeqMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxbadSeq>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxbadSeq>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
