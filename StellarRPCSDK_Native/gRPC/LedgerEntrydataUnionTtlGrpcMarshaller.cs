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
    /// <summary>Custom marshaller for Stellar.LedgerEntry+dataUnion+Ttl</summary>
    public static class LedgerEntrydataUnionTtlGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntrydataUnionTtlGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntry.dataUnion.Ttl
            if (!model.IsDefined(typeof(Stellar.LedgerEntry.dataUnion.Ttl)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntry.dataUnion.Ttl), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(10, "ttl");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Ttl</summary>
        public static readonly Marshaller<Stellar.LedgerEntry.dataUnion.Ttl> TtlMarshaller = Marshallers.Create<Stellar.LedgerEntry.dataUnion.Ttl>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntry.dataUnion.Ttl>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
