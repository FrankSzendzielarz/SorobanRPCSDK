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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictReceiveResult+PathPaymentStrictReceiveTooFewOffers</summary>
    public static class PathPaymentStrictReceiveResultPathPaymentStrictReceiveTooFewOffersGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictReceiveResultPathPaymentStrictReceiveTooFewOffersGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictReceiveTooFewOffers</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers> PathPaymentStrictReceiveTooFewOffersMarshaller = Marshallers.Create<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
