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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult</summary>
    public static class PathPaymentStrictSendResultGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendSuccess));
                metaType.AddSubType(101, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendMalformed));
                metaType.AddSubType(102, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderfunded));
                metaType.AddSubType(103, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendSrcNoTrust));
                metaType.AddSubType(104, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendSrcNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination));
                metaType.AddSubType(106, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust));
                metaType.AddSubType(107, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized));
                metaType.AddSubType(108, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull));
                metaType.AddSubType(109, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoIssuer));
                metaType.AddSubType(110, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendTooFewOffers));
                metaType.AddSubType(111, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendOfferCrossSelf));
                metaType.AddSubType(112, typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PathPaymentStrictSendResult</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult> PathPaymentStrictSendResultMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
