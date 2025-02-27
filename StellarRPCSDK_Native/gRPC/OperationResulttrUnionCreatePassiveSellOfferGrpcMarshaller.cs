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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+CreatePassiveSellOffer</summary>
    public static class OperationResulttrUnionCreatePassiveSellOfferGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionCreatePassiveSellOfferGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.CreatePassiveSellOffer
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.CreatePassiveSellOffer)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.CreatePassiveSellOffer), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "createPassiveSellOfferResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreatePassiveSellOffer</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.CreatePassiveSellOffer> CreatePassiveSellOfferMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.CreatePassiveSellOffer>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.CreatePassiveSellOffer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
