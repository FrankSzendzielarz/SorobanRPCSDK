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
    /// <summary>Custom marshaller for Stellar.ColdArchiveHashEntry</summary>
    public static class ColdArchiveHashEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveHashEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveHashEntry
            if (!model.IsDefined(typeof(Stellar.ColdArchiveHashEntry)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveHashEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "index");
                metaType.Add(2, "level");
                metaType.Add(3, "hash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ColdArchiveHashEntry</summary>
        public static readonly Marshaller<Stellar.ColdArchiveHashEntry> ColdArchiveHashEntryMarshaller = Marshallers.Create<Stellar.ColdArchiveHashEntry>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveHashEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
