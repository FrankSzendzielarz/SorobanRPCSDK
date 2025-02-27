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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferLineFull</summary>
    public static class ManageSellOfferResultManageSellOfferLineFullGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferLineFullGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferLineFull
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferLineFull)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferLineFull), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferLineFull</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferLineFull> ManageSellOfferLineFullMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferLineFull>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferLineFull>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
