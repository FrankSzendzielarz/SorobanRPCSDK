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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferBuyNoTrust</summary>
    public static class ManageSellOfferResultManageSellOfferBuyNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferBuyNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferBuyNoTrust</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust> ManageSellOfferBuyNoTrustMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
