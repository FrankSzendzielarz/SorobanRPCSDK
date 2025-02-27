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
    /// <summary>Custom marshaller for Stellar.ManageOfferSuccessResult+offerUnion+ManageOfferUpdated</summary>
    public static class ManageOfferSuccessResultofferUnionManageOfferUpdatedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageOfferSuccessResultofferUnionManageOfferUpdatedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated
            if (!model.IsDefined(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated)))
            {
                var metaType = model.Add(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "offer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageOfferUpdated</summary>
        public static readonly Marshaller<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated> ManageOfferUpdatedMarshaller = Marshallers.Create<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated>(
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
                        return Serializer.Deserialize<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
