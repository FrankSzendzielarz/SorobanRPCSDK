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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxinsufficientFee</summary>
    public static class InnerTransactionResultresultUnionTxinsufficientFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxinsufficientFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxinsufficientFee</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee> InnerTransactionResult_resultUnion_TxinsufficientFeeMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
