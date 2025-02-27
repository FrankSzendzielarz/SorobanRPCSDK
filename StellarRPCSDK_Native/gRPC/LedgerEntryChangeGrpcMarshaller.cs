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
    /// <summary>Custom marshaller for Stellar.LedgerEntryChange</summary>
    public static class LedgerEntryChangeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryChangeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryChange
            if (!model.IsDefined(typeof(Stellar.LedgerEntryChange)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryChange), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LedgerEntryChange.LedgerEntryCreated));
                metaType.AddSubType(101, typeof(Stellar.LedgerEntryChange.LedgerEntryUpdated));
                metaType.AddSubType(102, typeof(Stellar.LedgerEntryChange.LedgerEntryRemoved));
                metaType.AddSubType(103, typeof(Stellar.LedgerEntryChange.LedgerEntryState));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LedgerEntryChange</summary>
        public static readonly Marshaller<Stellar.LedgerEntryChange> LedgerEntryChangeMarshaller = Marshallers.Create<Stellar.LedgerEntryChange>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryChange>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
