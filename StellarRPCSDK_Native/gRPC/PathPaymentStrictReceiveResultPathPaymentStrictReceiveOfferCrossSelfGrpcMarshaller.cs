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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictReceiveResult+PathPaymentStrictReceiveOfferCrossSelf</summary>
    public static class PathPaymentStrictReceiveResultPathPaymentStrictReceiveOfferCrossSelfGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictReceiveResultPathPaymentStrictReceiveOfferCrossSelfGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictReceiveOfferCrossSelf</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf> PathPaymentStrictReceiveOfferCrossSelfMarshaller = Marshallers.Create<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
