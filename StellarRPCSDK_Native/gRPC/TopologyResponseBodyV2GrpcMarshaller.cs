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
    /// <summary>Custom marshaller for Stellar.TopologyResponseBodyV2</summary>
    public static class TopologyResponseBodyV2GrpcMarshaller
    {
        // Static constructor to configure type
        static TopologyResponseBodyV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TopologyResponseBodyV2
            if (!model.IsDefined(typeof(Stellar.TopologyResponseBodyV2)))
            {
                var metaType = model.Add(typeof(Stellar.TopologyResponseBodyV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "inboundPeers");
                metaType.Add(2, "outboundPeers");
                metaType.Add(3, "nodeData");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TopologyResponseBodyV2</summary>
        public static readonly Marshaller<Stellar.TopologyResponseBodyV2> TopologyResponseBodyV2Marshaller = Marshallers.Create<Stellar.TopologyResponseBodyV2>(
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
                        return Serializer.Deserialize<Stellar.TopologyResponseBodyV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
