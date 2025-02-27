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
    /// <summary>Custom marshaller for Stellar.ManageSellOfferResult</summary>
    public static class ManageSellOfferResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageSellOfferResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageSellOfferResult
            if (!model.IsDefined(typeof(Stellar.ManageSellOfferResult)))
            {
                var metaType = model.Add(typeof(Stellar.ManageSellOfferResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ManageSellOfferResult.ManageSellOfferSuccess));
                metaType.AddSubType(101, typeof(Stellar.ManageSellOfferResult.ManageSellOfferMalformed));
                metaType.AddSubType(102, typeof(Stellar.ManageSellOfferResult.ManageSellOfferSellNoTrust));
                metaType.AddSubType(103, typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoTrust));
                metaType.AddSubType(104, typeof(Stellar.ManageSellOfferResult.ManageSellOfferSellNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNotAuthorized));
                metaType.AddSubType(106, typeof(Stellar.ManageSellOfferResult.ManageSellOfferLineFull));
                metaType.AddSubType(107, typeof(Stellar.ManageSellOfferResult.ManageSellOfferUnderfunded));
                metaType.AddSubType(108, typeof(Stellar.ManageSellOfferResult.ManageSellOfferCrossSelf));
                metaType.AddSubType(109, typeof(Stellar.ManageSellOfferResult.ManageSellOfferSellNoIssuer));
                metaType.AddSubType(110, typeof(Stellar.ManageSellOfferResult.ManageSellOfferBuyNoIssuer));
                metaType.AddSubType(111, typeof(Stellar.ManageSellOfferResult.ManageSellOfferNotFound));
                metaType.AddSubType(112, typeof(Stellar.ManageSellOfferResult.ManageSellOfferLowReserve));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageSellOfferResult</summary>
        public static readonly Marshaller<Stellar.ManageSellOfferResult> ManageSellOfferResultMarshaller = Marshallers.Create<Stellar.ManageSellOfferResult>(
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
                        return Serializer.Deserialize<Stellar.ManageSellOfferResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
