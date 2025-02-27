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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferSuccess</summary>
    public static class ManageSellOfferResultManageSellOfferSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferSuccess
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferSuccess), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "success");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferSuccess</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferSuccess> ManageSellOfferSuccessMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferSuccess>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
