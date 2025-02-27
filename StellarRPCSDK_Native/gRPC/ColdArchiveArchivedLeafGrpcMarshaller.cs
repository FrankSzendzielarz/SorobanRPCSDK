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
    /// <summary>Custom marshaller for Stellar.ColdArchiveArchivedLeaf</summary>
    public static class ColdArchiveArchivedLeafGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveArchivedLeafGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveArchivedLeaf
            if (!model.IsDefined(typeof(Stellar.ColdArchiveArchivedLeaf)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveArchivedLeaf), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "index");
                metaType.Add(2, "archivedEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ColdArchiveArchivedLeaf</summary>
        public static readonly Marshaller<Stellar.ColdArchiveArchivedLeaf> ColdArchiveArchivedLeafMarshaller = Marshallers.Create<Stellar.ColdArchiveArchivedLeaf>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveArchivedLeaf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
