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
    /// <summary>Custom marshaller for Stellar.RestoreFootprintResult+RestoreFootprintInsufficientRefundableFee</summary>
    public static class RestoreFootprintResultRestoreFootprintInsufficientRefundableFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static RestoreFootprintResultRestoreFootprintInsufficientRefundableFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee
            if (!model.IsDefined(typeof(Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee)))
            {
                var metaType = model.Add(typeof(Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RestoreFootprintResult+RestoreFootprintInsufficientRefundableFee</summary>
        public static readonly Marshaller<Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee> RestoreFootprintResult_RestoreFootprintInsufficientRefundableFeeMarshaller = Marshallers.Create<Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee>(
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
                        return Serializer.Deserialize<Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
