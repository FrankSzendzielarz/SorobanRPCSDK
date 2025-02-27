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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictReceiveResult</summary>
    public static class PathPaymentStrictReceiveResultGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictReceiveResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictReceiveResult
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictReceiveResult)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictReceiveResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSuccess));
                metaType.AddSubType(101, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveMalformed));
                metaType.AddSubType(102, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveUnderfunded));
                metaType.AddSubType(103, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNoTrust));
                metaType.AddSubType(104, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoDestination));
                metaType.AddSubType(106, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoTrust));
                metaType.AddSubType(107, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNotAuthorized));
                metaType.AddSubType(108, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveLineFull));
                metaType.AddSubType(109, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer));
                metaType.AddSubType(110, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers));
                metaType.AddSubType(111, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf));
                metaType.AddSubType(112, typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOverSendmax));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictReceiveResult</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictReceiveResult> PathPaymentStrictReceiveResultMarshaller = Marshallers.Create<Stellar.PathPaymentStrictReceiveResult>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictReceiveResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
