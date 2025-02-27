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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResult</summary>
    public static class ManageBuyOfferResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResult
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResult)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSuccess));
                metaType.AddSubType(101, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferMalformed));
                metaType.AddSubType(102, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoTrust));
                metaType.AddSubType(103, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoTrust));
                metaType.AddSubType(104, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSellNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized));
                metaType.AddSubType(106, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferLineFull));
                metaType.AddSubType(107, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferUnderfunded));
                metaType.AddSubType(108, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferCrossSelf));
                metaType.AddSubType(109, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferSellNoIssuer));
                metaType.AddSubType(110, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer));
                metaType.AddSubType(111, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferNotFound));
                metaType.AddSubType(112, typeof(Stellar.ManageBuyOfferResult.ManageBuyOfferLowReserve));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferResult</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResult> ManageBuyOfferResultMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResult>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
