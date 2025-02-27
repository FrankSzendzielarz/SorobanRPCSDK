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
    /// <summary>Custom marshaller for Stellar.LedgerEntryChange+LedgerEntryUpdated</summary>
    public static class LedgerEntryChangeLedgerEntryUpdatedGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryChangeLedgerEntryUpdatedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryChange.LedgerEntryUpdated
            if (!model.IsDefined(typeof(Stellar.LedgerEntryChange.LedgerEntryUpdated)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryChange.LedgerEntryUpdated), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "updated");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntryChange+LedgerEntryUpdated</summary>
        public static readonly Marshaller<Stellar.LedgerEntryChange.LedgerEntryUpdated> LedgerEntryChange_LedgerEntryUpdatedMarshaller = Marshallers.Create<Stellar.LedgerEntryChange.LedgerEntryUpdated>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryChange.LedgerEntryUpdated>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
