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
    /// <summary>Custom marshaller for Stellar.LedgerEntryExtensionV1</summary>
    public static class LedgerEntryExtensionV1GrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryExtensionV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryExtensionV1
            if (!model.IsDefined(typeof(Stellar.LedgerEntryExtensionV1)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryExtensionV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sponsoringID");
                metaType.Add(2, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntryExtensionV1</summary>
        public static readonly Marshaller<Stellar.LedgerEntryExtensionV1> LedgerEntryExtensionV1Marshaller = Marshallers.Create<Stellar.LedgerEntryExtensionV1>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryExtensionV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
