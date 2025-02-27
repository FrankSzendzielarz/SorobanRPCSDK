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
    /// <summary>Custom marshaller for Stellar.Hello</summary>
    public static class HelloGrpcMarshaller
    {
        // Static constructor to configure type
        static HelloGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Hello
            if (!model.IsDefined(typeof(Stellar.Hello)))
            {
                var metaType = model.Add(typeof(Stellar.Hello), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerVersion");
                metaType.Add(2, "overlayVersion");
                metaType.Add(3, "overlayMinVersion");
                metaType.Add(4, "networkID");
                metaType.Add(5, "versionStr");
                metaType.Add(6, "listeningPort");
                metaType.Add(7, "peerID");
                metaType.Add(8, "cert");
                metaType.Add(9, "nonce");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Hello</summary>
        public static readonly Marshaller<Stellar.Hello> HelloMarshaller = Marshallers.Create<Stellar.Hello>(
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
                        return Serializer.Deserialize<Stellar.Hello>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
