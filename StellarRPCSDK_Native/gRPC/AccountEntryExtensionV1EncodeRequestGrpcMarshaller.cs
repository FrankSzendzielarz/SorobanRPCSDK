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
    /// <summary>Custom marshaller for Stellar.AccountEntryExtensionV1EncodeRequest</summary>
    public static class AccountEntryExtensionV1EncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountEntryExtensionV1EncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountEntryExtensionV1EncodeRequest
            if (!model.IsDefined(typeof(Stellar.AccountEntryExtensionV1EncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.AccountEntryExtensionV1EncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AccountEntryExtensionV1EncodeRequest</summary>
        public static readonly Marshaller<Stellar.AccountEntryExtensionV1EncodeRequest> AccountEntryExtensionV1EncodeRequestMarshaller = Marshallers.Create<Stellar.AccountEntryExtensionV1EncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.AccountEntryExtensionV1EncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
