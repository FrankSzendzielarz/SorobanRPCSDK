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
    /// <summary>Custom marshaller for Stellar.RPC.Entries</summary>
    public static class EntriesGrpcMarshaller
    {
        // Static constructor to configure type
        static EntriesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.Entries
            if (!model.IsDefined(typeof(Stellar.RPC.Entries)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.Entries), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(100, "LedgerKey");
                metaType.Add(101, "LedgerEntryData");
                metaType.Add(1, "Key");
                metaType.Add(2, "Xdr");
                metaType.Add(3, "LastModifiedLedgerSeq");
                metaType.Add(4, "LiveUntilLedgerSeq");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Entries</summary>
        public static readonly Marshaller<Stellar.RPC.Entries> EntriesMarshaller = Marshallers.Create<Stellar.RPC.Entries>(
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
                        return Serializer.Deserialize<Stellar.RPC.Entries>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
