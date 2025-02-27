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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult+ManageBuyOfferSellNoTrust</summary>
    public static class ManageBuyOfferResultManageBuyOfferSellNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultManageBuyOfferSellNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferSellNoTrust</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust> ManageBuyOfferSellNoTrustMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
