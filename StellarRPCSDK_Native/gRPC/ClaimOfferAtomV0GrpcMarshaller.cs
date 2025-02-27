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
    /// <summary>Custom marshaller for Stellar.ClaimOfferAtomV0</summary>
    public static class ClaimOfferAtomV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimOfferAtomV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimOfferAtomV0
            if (!model.IsDefined(typeof(Stellar.ClaimOfferAtomV0)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimOfferAtomV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sellerEd25519");
                metaType.Add(2, "offerID");
                metaType.Add(3, "assetSold");
                metaType.Add(4, "amountSold");
                metaType.Add(5, "assetBought");
                metaType.Add(6, "amountBought");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimOfferAtomV0</summary>
        public static readonly Marshaller<Stellar.ClaimOfferAtomV0> ClaimOfferAtomV0Marshaller = Marshallers.Create<Stellar.ClaimOfferAtomV0>(
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
                        return Serializer.Deserialize<Stellar.ClaimOfferAtomV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
