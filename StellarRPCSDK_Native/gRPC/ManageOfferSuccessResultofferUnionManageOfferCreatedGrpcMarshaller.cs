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
    /// <summary>Custom marshaller for Stellar.ManageOfferSuccessResult+offerUnion+ManageOfferCreated</summary>
    public static class ManageOfferSuccessResultofferUnionManageOfferCreatedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageOfferSuccessResultofferUnionManageOfferCreatedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated
            if (!model.IsDefined(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated)))
            {
                var metaType = model.Add(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "offer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ManageOfferSuccessResult+offerUnion+ManageOfferCreated</summary>
        public static readonly Marshaller<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated> ManageOfferSuccessResult_offerUnion_ManageOfferCreatedMarshaller = Marshallers.Create<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated>(
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
                        return Serializer.Deserialize<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
