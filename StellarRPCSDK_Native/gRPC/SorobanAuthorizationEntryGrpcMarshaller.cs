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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizationEntry</summary>
    public static class SorobanAuthorizationEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizationEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizationEntry
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizationEntry)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizationEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "credentials");
                metaType.Add(2, "rootInvocation");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAuthorizationEntry</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizationEntry> SorobanAuthorizationEntryMarshaller = Marshallers.Create<Stellar.SorobanAuthorizationEntry>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizationEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
