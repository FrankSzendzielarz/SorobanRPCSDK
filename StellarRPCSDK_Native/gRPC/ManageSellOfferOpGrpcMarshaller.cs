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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferOp</summary>
    public static class ManageSellOfferOpGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferOp
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferOp)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "selling");
                metaType.Add(2, "buying");
                metaType.Add(3, "amount");
                metaType.Add(4, "price");
                metaType.Add(5, "offerID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferOp</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferOp> ManageSellOfferOpMarshaller = Marshallers.Create<Stellar.ManageSellOfferOp>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
