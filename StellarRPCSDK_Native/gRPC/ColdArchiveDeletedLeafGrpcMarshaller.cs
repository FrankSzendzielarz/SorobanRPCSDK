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
    /// <summary>Custom marshaller for Stellar.ColdArchiveDeletedLeaf</summary>
    public static class ColdArchiveDeletedLeafGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveDeletedLeafGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveDeletedLeaf
            if (!model.IsDefined(typeof(Stellar.ColdArchiveDeletedLeaf)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveDeletedLeaf), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "index");
                metaType.Add(2, "deletedKey");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveDeletedLeaf</summary>
        public static readonly Marshaller<Stellar.ColdArchiveDeletedLeaf> ColdArchiveDeletedLeafMarshaller = Marshallers.Create<Stellar.ColdArchiveDeletedLeaf>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveDeletedLeaf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
