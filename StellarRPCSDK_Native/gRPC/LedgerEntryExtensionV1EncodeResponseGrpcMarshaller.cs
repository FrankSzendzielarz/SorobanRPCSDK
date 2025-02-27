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
    /// <summary>Custom marshaller for Stellar.LedgerEntryExtensionV1EncodeResponse</summary>
    public static class LedgerEntryExtensionV1EncodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntryExtensionV1EncodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntryExtensionV1EncodeResponse
            if (!model.IsDefined(typeof(Stellar.LedgerEntryExtensionV1EncodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntryExtensionV1EncodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntryExtensionV1EncodeResponse</summary>
        public static readonly Marshaller<Stellar.LedgerEntryExtensionV1EncodeResponse> LedgerEntryExtensionV1EncodeResponseMarshaller = Marshallers.Create<Stellar.LedgerEntryExtensionV1EncodeResponse>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntryExtensionV1EncodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
