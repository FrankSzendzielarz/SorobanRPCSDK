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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferOp</summary>
    public static class ManageBuyOfferOpGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferOp
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferOp)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "selling");
                metaType.Add(2, "buying");
                metaType.Add(3, "buyAmount");
                metaType.Add(4, "price");
                metaType.Add(5, "offerID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferOp</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferOp> ManageBuyOfferOpMarshaller = Marshallers.Create<Stellar.ManageBuyOfferOp>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
