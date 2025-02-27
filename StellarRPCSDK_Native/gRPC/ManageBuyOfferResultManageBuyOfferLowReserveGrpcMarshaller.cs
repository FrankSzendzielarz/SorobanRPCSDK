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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult+ManageBuyOfferLowReserve</summary>
    public static class ManageBuyOfferResultManageBuyOfferLowReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultManageBuyOfferLowReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferLowReserve</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve> ManageBuyOfferLowReserveMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
