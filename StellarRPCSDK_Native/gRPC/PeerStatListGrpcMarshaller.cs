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
    /// <summary>Custom marshaller for Stellar.PeerStatList</summary>
    public static class PeerStatListGrpcMarshaller
    {
        // Static constructor to configure type
        static PeerStatListGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PeerStatList
            if (!model.IsDefined(typeof(Stellar.PeerStatList)))
            {
                var metaType = model.Add(typeof(Stellar.PeerStatList), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "InnerValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PeerStatList</summary>
        public static readonly Marshaller<Stellar.PeerStatList> PeerStatListMarshaller = Marshallers.Create<Stellar.PeerStatList>(
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
                        return Serializer.Deserialize<Stellar.PeerStatList>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
