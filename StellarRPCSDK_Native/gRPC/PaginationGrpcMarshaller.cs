// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.Pagination</summary>
    public static class PaginationGrpcMarshaller
    {
        // Static constructor to configure type
        static PaginationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.Pagination
            if (!model.IsDefined(typeof(Stellar.RPC.Pagination)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.Pagination), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Cursor");
                metaType.Add(2, "Limit");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.Pagination</summary>
        public static readonly Marshaller<Stellar.RPC.Pagination> PaginationMarshaller = Marshallers.Create<Stellar.RPC.Pagination>(
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
                        return Serializer.Deserialize<Stellar.RPC.Pagination>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
