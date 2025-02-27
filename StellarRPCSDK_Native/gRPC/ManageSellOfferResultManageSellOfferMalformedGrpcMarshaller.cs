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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferMalformed</summary>
    public static class ManageSellOfferResultManageSellOfferMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferMalformed
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ManageSellOfferResult+ManageSellOfferMalformed</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferMalformed> ManageSellOfferResult_ManageSellOfferMalformedMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferMalformed>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
