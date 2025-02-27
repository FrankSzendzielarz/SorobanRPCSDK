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
    /// <summary>Custom marshaller for Stellar.PeerAddress</summary>
    public static class PeerAddressGrpcMarshaller
    {
        // Static constructor to configure type
        static PeerAddressGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PeerAddress
            if (!model.IsDefined(typeof(Stellar.PeerAddress)))
            {
                var metaType = model.Add(typeof(Stellar.PeerAddress), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ip");
                metaType.Add(2, "port");
                metaType.Add(3, "numFailures");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PeerAddress</summary>
        public static readonly Marshaller<Stellar.PeerAddress> PeerAddressMarshaller = Marshallers.Create<Stellar.PeerAddress>(
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
                        return Serializer.Deserialize<Stellar.PeerAddress>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
