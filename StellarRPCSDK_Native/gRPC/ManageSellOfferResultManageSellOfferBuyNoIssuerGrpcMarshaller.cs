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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferBuyNoIssuer</summary>
    public static class ManageSellOfferResultManageSellOfferBuyNoIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferBuyNoIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferBuyNoIssuer</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer> ManageSellOfferBuyNoIssuerMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
