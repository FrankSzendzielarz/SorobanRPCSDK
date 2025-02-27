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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult+ManageBuyOfferBuyNotAuthorized</summary>
    public static class ManageBuyOfferResultManageBuyOfferBuyNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultManageBuyOfferBuyNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferBuyNotAuthorized</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized> ManageBuyOfferBuyNotAuthorizedMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
