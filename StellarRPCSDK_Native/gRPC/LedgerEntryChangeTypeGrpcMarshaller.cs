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
    /// <summary>Custom marshaller for Stellar.LedgerEntryChangeType</summary>
    public static class LedgerEntryChangeTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryChangeTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryChangeType
            if (!model.IsDefined(typeof(Stellar.LedgerEntryChangeType)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryChangeType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LedgerEntryChangeType</summary>
        public static readonly Marshaller<Stellar.LedgerEntryChangeType> LedgerEntryChangeTypeMarshaller = Marshallers.Create<Stellar.LedgerEntryChangeType>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryChangeType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
