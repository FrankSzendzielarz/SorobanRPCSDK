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
    /// <summary>Custom marshaller for Stellar.ManageOfferSuccessResult</summary>
    public static class ManageOfferSuccessResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageOfferSuccessResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageOfferSuccessResult
            if (!model.IsDefined(typeof(Stellar.ManageOfferSuccessResult)))
            {
                var metaType = model.Add(typeof(Stellar.ManageOfferSuccessResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "offersClaimed");
                metaType.Add(2, "offer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageOfferSuccessResult</summary>
        public static readonly Marshaller<Stellar.ManageOfferSuccessResult> ManageOfferSuccessResultMarshaller = Marshallers.Create<Stellar.ManageOfferSuccessResult>(
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
                        return Serializer.Deserialize<Stellar.ManageOfferSuccessResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
