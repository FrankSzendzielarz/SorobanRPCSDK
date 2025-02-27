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
    /// <summary>Custom marshaller for Stellar.ManageOfferSuccessResult+offerUnion+ManageOfferDeleted</summary>
    public static class ManageOfferSuccessResultofferUnionManageOfferDeletedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageOfferSuccessResultofferUnionManageOfferDeletedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted
            if (!model.IsDefined(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted)))
            {
                var metaType = model.Add(typeof(Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageOfferDeleted</summary>
        public static readonly Marshaller<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted> ManageOfferDeletedMarshaller = Marshallers.Create<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted>(
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
                        return Serializer.Deserialize<Stellar.ManageOfferSuccessResult.offerUnion.ManageOfferDeleted>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
