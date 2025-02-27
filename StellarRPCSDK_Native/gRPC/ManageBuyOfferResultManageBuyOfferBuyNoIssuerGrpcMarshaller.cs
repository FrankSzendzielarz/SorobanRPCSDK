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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult+ManageBuyOfferBuyNoIssuer</summary>
    public static class ManageBuyOfferResultManageBuyOfferBuyNoIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultManageBuyOfferBuyNoIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferBuyNoIssuer</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer> ManageBuyOfferBuyNoIssuerMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
