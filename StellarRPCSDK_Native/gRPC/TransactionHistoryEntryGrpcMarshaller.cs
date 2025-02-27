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
    /// <summary>Custom marshaller for Stellar.TransactionHistoryEntry</summary>
    public static class TransactionHistoryEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionHistoryEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionHistoryEntry
            if (!model.IsDefined(typeof(Stellar.TransactionHistoryEntry)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionHistoryEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerSeq");
                metaType.Add(2, "txSet");
                metaType.Add(3, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionHistoryEntry</summary>
        public static readonly Marshaller<Stellar.TransactionHistoryEntry> TransactionHistoryEntryMarshaller = Marshallers.Create<Stellar.TransactionHistoryEntry>(
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
                        return Serializer.Deserialize<Stellar.TransactionHistoryEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
