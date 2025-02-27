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
    /// <summary>Custom marshaller for Stellar.LedgerHeaderHistoryEntry+extUnion</summary>
    public static class LedgerHeaderHistoryEntryextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerHeaderHistoryEntryextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerHeaderHistoryEntry.extUnion
            if (!model.IsDefined(typeof(Stellar.LedgerHeaderHistoryEntry.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerHeaderHistoryEntry.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LedgerHeaderHistoryEntry.extUnion.case_0));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerHeaderHistoryEntry+extUnion</summary>
        public static readonly Marshaller<Stellar.LedgerHeaderHistoryEntry.extUnion> LedgerHeaderHistoryEntry_extUnionMarshaller = Marshallers.Create<Stellar.LedgerHeaderHistoryEntry.extUnion>(
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
                        return Serializer.Deserialize<Stellar.LedgerHeaderHistoryEntry.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
