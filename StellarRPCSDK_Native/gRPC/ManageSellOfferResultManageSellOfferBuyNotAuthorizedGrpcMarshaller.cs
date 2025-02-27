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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferBuyNotAuthorized</summary>
    public static class ManageSellOfferResultManageSellOfferBuyNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferBuyNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferBuyNotAuthorized</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized> ManageSellOfferBuyNotAuthorizedMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
