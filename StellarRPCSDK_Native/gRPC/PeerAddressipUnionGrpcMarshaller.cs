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
    /// <summary>Custom marshaller for Stellar.PeerAddress+ipUnion</summary>
    public static class PeerAddressipUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static PeerAddressipUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PeerAddress.ipUnion
            if (!model.IsDefined(typeof(Stellar.PeerAddress.ipUnion)))
            {
                var metaType = model.Add(typeof(Stellar.PeerAddress.ipUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.PeerAddress.ipUnion.IPv4));
                metaType.AddSubType(101, typeof(Stellar.PeerAddress.ipUnion.IPv6));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ipUnion</summary>
        public static readonly Marshaller<Stellar.PeerAddress.ipUnion> ipUnionMarshaller = Marshallers.Create<Stellar.PeerAddress.ipUnion>(
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
                        return Serializer.Deserialize<Stellar.PeerAddress.ipUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
