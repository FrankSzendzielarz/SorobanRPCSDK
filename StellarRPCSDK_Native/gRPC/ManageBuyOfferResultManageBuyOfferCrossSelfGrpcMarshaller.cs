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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult+ManageBuyOfferCrossSelf</summary>
    public static class ManageBuyOfferResultManageBuyOfferCrossSelfGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultManageBuyOfferCrossSelfGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferCrossSelf</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf> ManageBuyOfferCrossSelfMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
