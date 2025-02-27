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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferCrossSelf</summary>
    public static class ManageSellOfferResultManageSellOfferCrossSelfGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferCrossSelfGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ManageSellOfferResult+ManageSellOfferCrossSelf</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf> ManageSellOfferResult_ManageSellOfferCrossSelfMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
