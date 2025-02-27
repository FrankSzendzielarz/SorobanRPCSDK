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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxinsufficientBalance</summary>
    public static class InnerTransactionResultresultUnionTxinsufficientBalanceGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxinsufficientBalanceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxinsufficientBalance</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance> InnerTransactionResult_resultUnion_TxinsufficientBalanceMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
