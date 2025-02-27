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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+ManageBuyOffer</summary>
    public static class OperationResulttrUnionManageBuyOfferGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionManageBuyOfferGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.ManageBuyOffer
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.ManageBuyOffer)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.ManageBuyOffer), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(13, "manageBuyOfferResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion+ManageBuyOffer</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.ManageBuyOffer> OperationResult_trUnion_ManageBuyOfferMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.ManageBuyOffer>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.ManageBuyOffer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
