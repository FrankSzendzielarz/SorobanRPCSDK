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
    /// <summary>Custom marshaller for Stellar.UpgradeEntryMeta</summary>
    public static class UpgradeEntryMetaGrpcMarshaller
    {
        // Static constructor to configure type
        static UpgradeEntryMetaGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.UpgradeEntryMeta
            if (!model.IsDefined(typeof(Stellar.UpgradeEntryMeta)))
            {
                var metaType = model.Add(typeof(Stellar.UpgradeEntryMeta), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "upgrade");
                metaType.Add(2, "changes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for UpgradeEntryMeta</summary>
        public static readonly Marshaller<Stellar.UpgradeEntryMeta> UpgradeEntryMetaMarshaller = Marshallers.Create<Stellar.UpgradeEntryMeta>(
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
                        return Serializer.Deserialize<Stellar.UpgradeEntryMeta>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
