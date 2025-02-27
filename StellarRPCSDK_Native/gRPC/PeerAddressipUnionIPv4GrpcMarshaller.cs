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
    /// <summary>Custom marshaller for Stellar.PeerAddress+ipUnion+IPv4</summary>
    public static class PeerAddressipUnionIPv4GrpcMarshaller
    {
        // Static constructor to configure type
        static PeerAddressipUnionIPv4GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PeerAddress.ipUnion.IPv4
            if (!model.IsDefined(typeof(Stellar.PeerAddress.ipUnion.IPv4)))
            {
                var metaType = model.Add(typeof(Stellar.PeerAddress.ipUnion.IPv4), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ipv4");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for IPv4</summary>
        public static readonly Marshaller<Stellar.PeerAddress.ipUnion.IPv4> IPv4Marshaller = Marshallers.Create<Stellar.PeerAddress.ipUnion.IPv4>(
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
                        return Serializer.Deserialize<Stellar.PeerAddress.ipUnion.IPv4>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
