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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult+ManageSellOfferUnderfunded</summary>
    public static class ManageSellOfferResultManageSellOfferUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultManageSellOfferUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferUnderfunded</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded> ManageSellOfferUnderfundedMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
