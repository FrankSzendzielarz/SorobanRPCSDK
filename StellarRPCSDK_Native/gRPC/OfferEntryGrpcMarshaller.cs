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
    /// <summary>Custom marshaller for Stellar.OfferEntry</summary>
    public static class OfferEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static OfferEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OfferEntry
            if (!model.IsDefined(typeof(Stellar.OfferEntry)))
            {
                var metaType = model.Add(typeof(Stellar.OfferEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sellerID");
                metaType.Add(2, "offerID");
                metaType.Add(3, "selling");
                metaType.Add(4, "buying");
                metaType.Add(5, "amount");
                metaType.Add(6, "price");
                metaType.Add(7, "flags");
                metaType.Add(8, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for OfferEntry</summary>
        public static readonly Marshaller<Stellar.OfferEntry> OfferEntryMarshaller = Marshallers.Create<Stellar.OfferEntry>(
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
                        return Serializer.Deserialize<Stellar.OfferEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
