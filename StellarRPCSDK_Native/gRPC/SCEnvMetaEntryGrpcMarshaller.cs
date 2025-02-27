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
    /// <summary>Custom marshaller for Stellar.SCEnvMetaEntry</summary>
    public static class SCEnvMetaEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static SCEnvMetaEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCEnvMetaEntry
            if (!model.IsDefined(typeof(Stellar.SCEnvMetaEntry)))
            {
                var metaType = model.Add(typeof(Stellar.SCEnvMetaEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCEnvMetaEntry.ScEnvMetaKindInterfaceVersion));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCEnvMetaEntry</summary>
        public static readonly Marshaller<Stellar.SCEnvMetaEntry> SCEnvMetaEntryMarshaller = Marshallers.Create<Stellar.SCEnvMetaEntry>(
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
                        return Serializer.Deserialize<Stellar.SCEnvMetaEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
