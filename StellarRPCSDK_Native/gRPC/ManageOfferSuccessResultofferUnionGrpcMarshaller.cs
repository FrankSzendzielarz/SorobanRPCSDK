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
    /// <summary>Custom marshaller for Stellar.ManageOfferSuccessResult+offerUnion</summary>
    public static class ManageOfferSuccessResultofferUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageOfferSuccessResultofferUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageOfferSuccessResult.offerUnion
            if (!model.IsDefined(typeof(Stellar.ManageOfferSuccessResult.offerUnion)))
            {
                var metaType = model.Add(typeof(Stellar.ManageOfferSuccessResult.offerUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferCreated));
                metaType.AddSubType(101, typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferUpdated));
                metaType.AddSubType(102, typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ManageOfferSuccessResult+offerUnion</summary>
        public static readonly Marshaller<Stellar.ManageOfferSuccessResult.offerUnion> ManageOfferSuccessResult_offerUnionMarshaller = Marshallers.Create<Stellar.ManageOfferSuccessResult.offerUnion>(
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
                        return Serializer.Deserialize<Stellar.ManageOfferSuccessResult.offerUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
