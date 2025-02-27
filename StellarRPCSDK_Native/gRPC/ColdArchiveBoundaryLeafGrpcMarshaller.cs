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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBoundaryLeaf</summary>
    public static class ColdArchiveBoundaryLeafGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBoundaryLeafGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBoundaryLeaf
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBoundaryLeaf)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBoundaryLeaf), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "index");
                metaType.Add(2, "isLowerBound");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveBoundaryLeaf</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBoundaryLeaf> ColdArchiveBoundaryLeafMarshaller = Marshallers.Create<Stellar.ColdArchiveBoundaryLeaf>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBoundaryLeaf>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
