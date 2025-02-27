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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion+TxinsufficientFee</summary>
    public static class TransactionResultresultUnionTxinsufficientFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionTxinsufficientFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion.TxinsufficientFee
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion.TxinsufficientFee)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion.TxinsufficientFee), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionResult+resultUnion+TxinsufficientFee</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion.TxinsufficientFee> TransactionResult_resultUnion_TxinsufficientFeeMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion.TxinsufficientFee>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion.TxinsufficientFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
