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
    /// <summary>Custom marshaller for Stellar.SCMapEntry</summary>
    public static class SCMapEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static SCMapEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCMapEntry
            if (!model.IsDefined(typeof(Stellar.SCMapEntry)))
            {
                var metaType = model.Add(typeof(Stellar.SCMapEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "key");
                metaType.Add(2, "val");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCMapEntry</summary>
        public static readonly Marshaller<Stellar.SCMapEntry> SCMapEntryMarshaller = Marshallers.Create<Stellar.SCMapEntry>(
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
                        return Serializer.Deserialize<Stellar.SCMapEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
