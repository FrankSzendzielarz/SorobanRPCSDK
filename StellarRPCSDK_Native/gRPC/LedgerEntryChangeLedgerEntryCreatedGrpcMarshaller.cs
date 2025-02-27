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
    /// <summary>Custom marshaller for Stellar.LedgerEntryChange+LedgerEntryCreated</summary>
    public static class LedgerEntryChangeLedgerEntryCreatedGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryChangeLedgerEntryCreatedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryChange.LedgerEntryCreated
            if (!model.IsDefined(typeof(Stellar.LedgerEntryChange.LedgerEntryCreated)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryChange.LedgerEntryCreated), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "created");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntryChange+LedgerEntryCreated</summary>
        public static readonly Marshaller<Stellar.LedgerEntryChange.LedgerEntryCreated> LedgerEntryChange_LedgerEntryCreatedMarshaller = Marshallers.Create<Stellar.LedgerEntryChange.LedgerEntryCreated>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryChange.LedgerEntryCreated>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
