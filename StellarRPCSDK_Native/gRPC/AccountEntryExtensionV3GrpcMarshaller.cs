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
    /// <summary>Custom marshaller for Stellar.AccountEntryExtensionV3</summary>
    public static class AccountEntryExtensionV3GrpcMarshaller
    {
        // Static constructor to configure type
        static AccountEntryExtensionV3GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountEntryExtensionV3
            if (!model.IsDefined(typeof(Stellar.AccountEntryExtensionV3)))
            {
                var metaType = model.Add(typeof(Stellar.AccountEntryExtensionV3), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "seqLedger");
                metaType.Add(3, "seqTime");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AccountEntryExtensionV3</summary>
        public static readonly Marshaller<Stellar.AccountEntryExtensionV3> AccountEntryExtensionV3Marshaller = Marshallers.Create<Stellar.AccountEntryExtensionV3>(
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
                        return Serializer.Deserialize<Stellar.AccountEntryExtensionV3>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
