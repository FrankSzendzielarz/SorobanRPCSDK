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
    /// <summary>Custom marshaller for Stellar.ExtendFootprintTTLResult+ExtendFootprintTtlInsufficientRefundableFee</summary>
    public static class ExtendFootprintTTLResultExtendFootprintTtlInsufficientRefundableFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static ExtendFootprintTTLResultExtendFootprintTtlInsufficientRefundableFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee
            if (!model.IsDefined(typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee)))
            {
                var metaType = model.Add(typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ExtendFootprintTTLResult+ExtendFootprintTtlInsufficientRefundableFee</summary>
        public static readonly Marshaller<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee> ExtendFootprintTTLResult_ExtendFootprintTtlInsufficientRefundableFeeMarshaller = Marshallers.Create<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee>(
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
                        return Serializer.Deserialize<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
