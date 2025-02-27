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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion+TxmissingOperation</summary>
    public static class TransactionResultresultUnionTxmissingOperationGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionTxmissingOperationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion.TxmissingOperation
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion.TxmissingOperation)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion.TxmissingOperation), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionResult+resultUnion+TxmissingOperation</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion.TxmissingOperation> TransactionResult_resultUnion_TxmissingOperationMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion.TxmissingOperation>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion.TxmissingOperation>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
